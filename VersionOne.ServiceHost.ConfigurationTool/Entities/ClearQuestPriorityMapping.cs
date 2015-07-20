using System.Xml.Serialization;
using VersionOne.ServiceHost.ConfigurationTool.Validation;

namespace VersionOne.ServiceHost.ConfigurationTool.Entities {
    public class ClearQuestPriorityMapping {
        public const string VersionOnePriorityIdProperty = "VersionOnePriorityId";
        public const string ClearQuestPriorityNameProperty = "ClearQuestPriorityName";

        public ClearQuestPriorityMapping() {
            ClearQuestPriority = new Mapping();
            VersionOnePriority = new Mapping();
        }

        public Mapping ClearQuestPriority { get; set; }
        public Mapping VersionOnePriority { get; set; }

        [XmlIgnore]
        [NonEmptyStringValidator]
        public string VersionOnePriorityId {
            get { return VersionOnePriority.Id; }
            set { VersionOnePriority.Id = value; }
        }

        [XmlIgnore]
        [NonEmptyStringValidator]
        public string ClearQuestPriorityName {
            get { return ClearQuestPriority.Name; }
            set { ClearQuestPriority.Name = value; }
        }
    }
}