/*(c) Copyright 2009, VersionOne, Inc. All rights reserved. (c)*/
using System;
using System.Collections.Generic;
using System.Text;
using VersionOne.ServiceHost.Core.Utility;
using VersionOne.ServiceHost.Core.Configuration;

namespace VersionOne.ServiceHost.ClearQuestServices
{
	public class ClearQuestServiceConfiguration
	{

		[ConfigFileValue("ClearQuestConnectionName")]
		public string ConnectionName;

		[ConfigFileValue("SourceFieldValue")]
		public string SourceFieldValue;		

		[ConfigFileValue("ClearQuestUsername")]
		public string Username;

		[ConfigFileValue("ClearQuestPassword")]
		public string Password;

		[ConfigFileValue("ClearQuestDatabase")]
		public string Database;

		[ConfigFileValue("ClearQuestWebUrlTemplate")]
		public string WebUrlTemplate;

		[ConfigFileValue("ClearQuestWebUrlTitle")]
		public string WebUrlTitle;		

		[ConfigFileValue("ClearQuestSubmittedToV1Action")]
		public string SubmittedToV1Action;

		[ConfigFileValue("ClearQuestCloseAction")]
		public string CloseAction;

        [ConfigFileValue("ClearQuestWaitedSubmitToV1State")]
		public string WaitedSubmitToV1State;

		[ConfigFileValue("ClearQuestSubmittedToV1State")]
		public string SubmittedToV1State;

		#region ClearQuest Configuration Values

		[ConfigFileValue("ClearQuestIDField")] 
		public string IdField;

		[ConfigFileValue("ClearQuestDefectTitleField")]
		public string DefectTitleField;

		[ConfigFileValue("ClearQuestDescriptionField")]
		public string DescriptionField;

		[ConfigFileValue("ClearQuestProjectNameField")]
		public string ProjectNameField;

		[ConfigFileValue("ClearQuestOwnerLoginField")]
		public string OwnerLoginField;

		[ConfigFileValue("ClearQuestStateField")]
		public string StateField;

		[ConfigFileValue("ClearQuestEntityType")]
		public string ClearQuestEntityType;

		[ConfigFileValue("ClearQuestModifyAction")]
		public string ClearQuestModifyAction;

        [ConfigFileValue("ClearQuestPriorityField")]
        public string ClearQuestPriorityField;

		#endregion

		private readonly Dictionary<string, object> MandatoryFieldsValues = new Dictionary<string, object>();
        private readonly IDictionary<MappingInfo, MappingInfo> priorityMappings = new Dictionary<MappingInfo, MappingInfo>();
        private readonly IDictionary<MappingInfo, MappingInfo> projectMappings = new Dictionary<MappingInfo, MappingInfo>();

		public Dictionary<string, object> MandatoryFields
		{
			get { return MandatoryFieldsValues; }
		}

        public IDictionary<MappingInfo, MappingInfo> PriorityMappings {
            get { return priorityMappings; }
        }

        public IDictionary<MappingInfo, MappingInfo> ProjectMappings {
            get { return projectMappings; }
        }
	}
}
