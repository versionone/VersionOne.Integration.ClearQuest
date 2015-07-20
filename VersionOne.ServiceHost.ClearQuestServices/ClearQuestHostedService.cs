using System;
using System.Collections.Generic;
using System.Xml;
using Ninject;
using VersionOne.Profile;
using VersionOne.ServiceHost.ClearQuestServices.Exceptions;
using VersionOne.ServiceHost.Core.Logging;
using VersionOne.ServiceHost.Core.Services;
using VersionOne.ServiceHost.Core.Utility;
using VersionOne.ServiceHost.Eventing;
using VersionOne.ServiceHost.WorkitemServices;

namespace VersionOne.ServiceHost.ClearQuestServices {
    public class ClearQuestHostedService : IHostedService {
        // code of error appearing at try to close already closed defect in the ClearQuest
        private const int CannotChangeStateCodeError = 14053;
        // code of error appearing at try to close defect with incorrect begin of ID.  
        // (ExternalId field in code, Reference in VersionOne defect)
        // ClearQurest ID have to start with name of datebase name
        private const int InvalidStartExternalId = 13637;
        // code of error appearing at try to close defect with incorrect id or not defect object. 
        private const int InvalidExternalId = 18028;
        // code of error appearing at try to close defect without filling all mandatory fields. 
        private const int NotValidConditionForChangeState = 18020;

        private const string PriorityMappingsNode = "PriorityMappings";
        private const string ClearQuestPriorityNode = "ClearQuestPriority";
        private const string VersionOnePriorityNode = "VersionOnePriority";
        private const string ProjectMappingsNode = "ProjectMappings";
        private const string ClearQuestProjectNode = "ClearQuestProject";
        private const string VersionOneProjectNode = "VersionOneProject";

        private readonly ClearQuestServiceConfiguration clearQuestConfig = new ClearQuestServiceConfiguration();
        private IClearQuestReader clearQuestReader;
        private IClearQuestUpdater clearQuestUpdater;

        private IEventManager eventManager;
        private ILogger logger;
        private IProfile profile;
        private string sourceFieldValue;

        public void Initialize(XmlElement config, IEventManager eventManager, IProfile profile) {
            this.profile = profile;
            this.eventManager = eventManager;
            logger = new Logger(eventManager);

            ConfigurationReader.ReadConfigurationValues(clearQuestConfig, config);
            sourceFieldValue = clearQuestConfig.SourceFieldValue;
            ProcessMandatoryFieldsSettings(config["ClearQuestMandatoryFields"], clearQuestConfig);
            ConfigurationReader.ProcessMappingSettings(clearQuestConfig.PriorityMappings, config[PriorityMappingsNode], ClearQuestPriorityNode, VersionOnePriorityNode);
            ConfigurationReader.ProcessMappingSettings(clearQuestConfig.ProjectMappings, config[ProjectMappingsNode], ClearQuestProjectNode, VersionOneProjectNode);

            var clearQuestQuery = new ClearQuestQuery(clearQuestConfig, new ClearQuestSession());

            var readerUpdater = new ClearQuestReaderUpdater(clearQuestQuery, clearQuestConfig, logger);
            clearQuestReader = readerUpdater;
            clearQuestUpdater = readerUpdater;

            eventManager.Subscribe(typeof(IntervalSync), OnInterval);
            eventManager.Subscribe(typeof(WorkitemCreationResult), OnDefectCreated);
            eventManager.Subscribe(typeof(WorkitemStateChangeCollection), OnDefectStateChanged);
        }

        public void Start() {
            // TODO move subscriptions to timer events, etc. here
        }

        private void OnInterval(object pubobj) {
            IList<Defect> bugs;

            try {
                // Get defects from ClearQuest
                bugs = clearQuestReader.GetDefects();
            } catch(Exception ex) {
                logger.Log(LogMessage.SeverityType.Error, "Error getting Defects from ClearQuest:");
                logger.Log(LogMessage.SeverityType.Error, ex.ToString());
                return;
            }

            if(bugs.Count > 0) {
                logger.Log(string.Format("Found {0} issues in ClearQuest to create in VersionOne.", bugs.Count));
            }

            // Create Defects in V1 
            foreach(var bug in bugs) {
                eventManager.Publish(bug);
            }

            // Query VersionOne for Closed defects with a ClearQuest Source Id
            var source = new ClosedWorkitemsSource(clearQuestConfig.SourceFieldValue);
            eventManager.Publish(source);
        }

        /// <summary>
        ///   A Defect was created in V1 that corresponds to an Defect in ClearQuest. We update the defect in 
        ///   ClearQuest to reflect that.
        /// </summary>
        /// <param name = "pubobj">DefectCreationResult of created defect.</param>
        private void OnDefectCreated(object pubobj) {
            var workitemCreationResult = pubobj as WorkitemCreationResult;

            if(workitemCreationResult != null) {
                clearQuestUpdater.OnDefectCreated(workitemCreationResult);
            }
        }

        public void ProcessMandatoryFieldsSettings(XmlElement config, ClearQuestServiceConfiguration clearQuestConfig) {
            XmlNodeList nodeList = config.SelectNodes("Field");

            for(int i = 0; i < nodeList.Count; i++) {
                XmlNode node = nodeList.Item(i);
                clearQuestConfig.MandatoryFields.Add(node.Attributes.GetNamedItem("name").Value, node.InnerText);
            }
        }

        private void OnDefectStateChanged(object pubobj) {
            var workitemStateChangeCollection = pubobj as WorkitemStateChangeCollection;

            logger.Log(string.Format("Found {0} closed defects in the VersionOne.", workitemStateChangeCollection.Count));

            if(workitemStateChangeCollection != null) {
                bool success = true;
                foreach(var defectStateChangeResult in workitemStateChangeCollection) {
                    if(string.IsNullOrEmpty(defectStateChangeResult.ExternalId)) {
                        logger.Log(string.Format("Defect '{0}' was not closed in the ClearQuest becouse of the 'Reference' field is empty.",
                            defectStateChangeResult.WorkitemId));
                        continue;
                    }

                    try {
                        clearQuestUpdater.OnDefectStateChange(defectStateChangeResult);
                    } catch(ClearQuestUpdateException ex) {
                        string message = ex.Message;
                        logger.Log(string.Format("Problem with closing {0} defect in the ClearQuest ({1}).", defectStateChangeResult.ExternalId, ex.CodeError));
                        if(ex.CodeError == CannotChangeStateCodeError) {
                            message = "This defect has already closed or has wrong state.";
                        } else if(ex.CodeError == InvalidStartExternalId || ex.CodeError == InvalidExternalId) {
                            message = string.Format("The VersionOne defect({0}) has incorrect reference.", defectStateChangeResult.WorkitemId);
                            success = false;
                        } else if(ex.CodeError == NotValidConditionForChangeState) {
                            message = "Some of mandatory fields can't be filled. Please verify the VersionOne.ServiceHost.exe.config file.";
                            success = false;
                        } else {
                            success = false;
                        }
                        logger.Log(message);
                    }
                }
                workitemStateChangeCollection.ChangesProcessed = success;
            }
        }

        public class IntervalSync { }
    }
}