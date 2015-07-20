using System.Xml.Serialization;
using VersionOne.ServiceHost.ConfigurationTool.Validation;

namespace VersionOne.ServiceHost.ConfigurationTool.Entities {
    public class ClearQuestField {
        [XmlAttribute("name")]
        [NonEmptyStringValidator]
        public string Name { get; set; }

        [XmlText]
        [NonEmptyStringValidator]
        public string Value { get; set; }

        public static ClearQuestField Create(string name, string value) {
            var newField = new ClearQuestField {Value = value, Name = name};
            return newField;
        }

        public override bool Equals (object obj) {
            if(obj == null || GetType() != obj.GetType()) {
                return false;
            }

            var other = (ClearQuestField)obj;
            return string.Equals(Name, other.Name) && string.Equals(Value, other.Value);
        }

        public override int GetHashCode () {
            return base.GetHashCode();
        }
    }
}