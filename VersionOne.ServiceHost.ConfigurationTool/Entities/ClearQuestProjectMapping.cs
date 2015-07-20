using System.Xml.Serialization;
using VersionOne.ServiceHost.ConfigurationTool.Validation;

namespace VersionOne.ServiceHost.ConfigurationTool.Entities {
    public class ClearQuestProjectMapping {
        public const string VersionOneProjectTokenProperty = "VersionOneProjectToken";
        public const string ClearQuestProjectNameProperty = "ClearQuestProjectName";

        public ClearQuestProjectMapping() {
            ClearQuestProject = new Mapping();
            VersionOneProject = new Mapping();
        }

        public Mapping ClearQuestProject { get; set; }
        public Mapping VersionOneProject { get; set; }

        [XmlIgnore]
        [NonEmptyStringValidator]
        public string VersionOneProjectToken {
            get { return VersionOneProject.Id; }
            set { VersionOneProject.Id = value; }
        }

        [XmlIgnore]
        [NonEmptyStringValidator]
        public string ClearQuestProjectName {
            get { return ClearQuestProject.Name; }
            set { ClearQuestProject.Name = value; }
        }
    }
}