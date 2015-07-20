using IBM.ClearQuest.Interop;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using VersionOne.ServiceHost.ClearQuestServices.Exceptions;
using VersionOne.ServiceHost.Core.Configuration;
using VersionOne.ServiceHost.WorkitemServices;

namespace VersionOne.ServiceHost.ClearQuestServices {
    public class ClearQuestQuery {
        private readonly ClearQuestServiceConfiguration config;
        private readonly IClearQuestSessionBuilder sessionBuilder;

        private readonly string IdField;
		private readonly string DefectTitleField;
		private readonly string DescriptionField;
		private readonly string ProjectNameField;
		private readonly string OwnerLoginField;
		private readonly string StateField;
        private readonly string PriorityField;
        private readonly IDictionary<MappingInfo, MappingInfo> PriorityMappings;
        private readonly IDictionary<MappingInfo, MappingInfo> ProjectMappings;

		public readonly string ClearQuestEntityType;
		public readonly string ClearQuestModifyAction;

    	private readonly string[] fields;

        private IOAdSession Session 
        {
            get 
			{
                return sessionBuilder.Create(config);
            }
        }

        public ClearQuestQuery(ClearQuestServiceConfiguration config, IClearQuestSessionBuilder sessionBuilder) 
		{
            this.config = config;
            this.sessionBuilder = sessionBuilder;

			ClearQuestEntityType   = config.ClearQuestEntityType;
			IdField                = config.IdField;
			DefectTitleField       = config.DefectTitleField;
			DescriptionField       = config.DescriptionField;
			ProjectNameField       = config.ProjectNameField;
			OwnerLoginField        = config.OwnerLoginField;
			StateField             = config.StateField;
			ClearQuestModifyAction = config.ClearQuestModifyAction;
            PriorityField          = config.ClearQuestPriorityField;
            PriorityMappings        = config.PriorityMappings;
            ProjectMappings         = config.ProjectMappings;

            fields = new string[] { IdField, DefectTitleField, ProjectNameField, OwnerLoginField, DescriptionField, PriorityField };

        }

        public void ModifyEntity(string entityId, Dictionary<string, object> values, string actionName) 
		{
			IOAdEntity defect = null;
			try
			{
				defect = GetDefectById(entityId);
				Session.EditEntity(defect, actionName);

				if (values != null && values.Count > 0)
				{
					foreach (KeyValuePair<string, object> entry in values)
					{
						defect.SetFieldValue(entry.Key, entry.Value);
					}
				}

				defect.Validate();
				defect.Commit();
			}
			catch (COMException ex)
			{
				if (defect != null && defect.IsEditable())
				{
					defect.Revert();
				}
				throw new ClearQuestUpdateException("Problem with updating defect in the ClearQuest cause: " + ex.Message, ex.ErrorCode);
			}
        }

        public void ExecuteAction(string entityId, string actionName) 
		{
            ModifyEntity(entityId, null, actionName);
        }

        public string[] FieldList 
        {
            get 
            {
				return fields;
            }
        }

        public IList<Defect> SelectDefects(string filterFieldName, ComparisonOperator op, string filterValue) 
		{
			IOAdResultSet resultset;
			IList<Defect> defects;

			try
			{
				IOAdQueryDef query = CreateQuery(FieldList);
				AddQueryFilter(query, filterFieldName, op, filterValue);

				resultset = Utils.Get<IOAdResultSet>(Session.BuildResultSet(query));
				int recordCount = resultset.ExecuteAndCountRecords();

				defects = new List<Defect>(recordCount);
			}
			catch (COMException ex)
			{
				throw new ClearQuestDefectException("Problem with getting defects from the ClearQuest: " + ex.Message);
			}

            while (resultset.MoveNext() == 1) 
			{
                Dictionary<string, string> row = ExtractRow(resultset);
                Defect defect = new Defect(row[DefectTitleField], row[DescriptionField], row[ProjectNameField], row[OwnerLoginField]);
                defect.ExternalId = row[IdField];
                defect.Priority = GetVersionOnePriorityId(row[PriorityField]);
                defect.ProjectId = GetVersionOneProjectId(row[ProjectNameField]);

                if (!string.IsNullOrEmpty(config.WebUrlTemplate) && !string.IsNullOrEmpty(config.WebUrlTitle)) 
				{
                    defect.ExternalLink = new UrlToExternalSystem(config.WebUrlTemplate.Replace("#defectid#", row[IdField]), config.WebUrlTitle);
                }
                defect.ExternalSystemName = config.SourceFieldValue;

                defects.Add(defect);
            }

            return defects;
        }

        private string GetVersionOnePriorityId(string clearQuestPriorityName) {
            return GetVersionOneEntityId(clearQuestPriorityName, PriorityMappings);
        }

        private string GetVersionOneProjectId(string clearQuestProjectName) {
            return GetVersionOneEntityId(clearQuestProjectName, ProjectMappings);
        }

        private string GetVersionOneEntityId(string clearQuestItemName, IDictionary<MappingInfo, MappingInfo> itemMappings) {
            MappingInfo cqItem = new MappingInfo(null, clearQuestItemName);
            MappingInfo versionOneItem = null;
            itemMappings.TryGetValue(cqItem, out versionOneItem);

            return versionOneItem != null ? versionOneItem.Id : null;
        }


        #region Utility methods

        private IOAdQueryDef CreateQuery(params string[] includedFields) 
		{
            IOAdQueryDef query = Utils.Get<IOAdQueryDef>(Session.BuildQuery(ClearQuestEntityType));

            foreach (string field in includedFields) 
			{
                query.BuildField(field);
            }

            return query;
        }

        private static Dictionary<string, string> ExtractRow(IOAdResultSet resultset) 
		{
            if (resultset == null) return null;

            int columnCount = resultset.GetNumberOfColumns();
            Dictionary<string, string> row = new Dictionary<string, string>();

            for (int i = 1; i <= columnCount; i++) 
			{
                object value = resultset.GetColumnValue(i);
                row.Add(resultset.GetColumnLabel(i), value == null ? string.Empty : value.ToString());
            }

            return row;
        }

        private IOAdEntity GetDefectById(string entityId) 
		{
            return Utils.Get<IOAdEntity>(Session.GetEntity(ClearQuestEntityType, entityId));
        }

        private static void AddQueryFilter(IOAdQueryDef query, string fieldName, ComparisonOperator op, string filterValue) 
		{
            IOAdQueryFilterNode oper = Utils.Get<IOAdQueryFilterNode>(query.BuildFilterOperator((int)op));
            oper.BuildFilter(fieldName, (int)op, filterValue);
        }

        #endregion

		#region Presetings functions

		/// <summary>
		/// Gathers all defect with states config.WaitedSubmitToV1State
		/// </summary>
		/// <returns>All defects which waiting for submit to the VersionOne</returns>
		public IList<Defect> GetWaitingDefects()
		{
			return SelectDefects(StateField, ComparisonOperator.Equal, config.WaitedSubmitToV1State);
		}

		/// <summary>
		/// update defect with specify id to config.SubmitedToV1State state
		/// </summary>
		/// <param name="defectId">Defect Id for updating</param>
		public void UpdateStatesToSubmittedToV1(string defectId)
		{
			ExecuteAction(defectId, config.SubmittedToV1Action);
		}

		/// <summary>
		/// update defect with specify id to close state
		/// </summary>
		/// <param name="defectId">Defect Id for updating</param>
		public void UpdateStatesToClosed(string defectId)
		{
			ModifyEntity(defectId, config.MandatoryFields, config.CloseAction);
		}

		#endregion
	}

    internal static class Utils 
	{
        public static T Get<T>(object source) where T : class 
		{
            return source as T;
        }
    }
}
