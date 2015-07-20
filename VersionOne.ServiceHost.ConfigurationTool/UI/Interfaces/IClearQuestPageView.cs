using System;
using VersionOne.ServiceHost.ConfigurationTool.Entities;
using System.Collections.Generic;
using VersionOne.ServiceHost.ConfigurationTool.DL;
using VersionOne.ServiceHost.ConfigurationTool.BZ;

namespace VersionOne.ServiceHost.ConfigurationTool.UI.Interfaces {
    public interface IClearQuestPageView : IPageView<ClearQuestServiceEntity> {
        event EventHandler ValidationRequested;
        
        string[] SourceList { get; set; }
        IList<ProjectWrapper> VersionOneProjects { get; set; }
        IList<ListValue> VersionOnePriorities { get; set; }
        
        void SetValidationResult(bool validationSuccessful);

        void SetGeneralTabValid(bool isValid);
        void SetMappingTabValid(bool isValid);
    }
}