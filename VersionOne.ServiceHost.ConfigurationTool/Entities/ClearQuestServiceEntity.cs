using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using VersionOne.ServiceHost.ConfigurationTool.Attributes;
using VersionOne.ServiceHost.ConfigurationTool.Validation;

namespace VersionOne.ServiceHost.ConfigurationTool.Entities {
    [DependsOnVersionOne]
    [XmlRoot("ClearQuestHostedService")]
    [HasSelfValidation]
    public class ClearQuestServiceEntity : BaseServiceEntity {
        #region Property names

        public const string ConnectionNameProperty = "ConnectionName";
        public const string UserNameProperty = "UserName";
        public const string PasswordProperty = "Password";
        public const string DataBaseProperty = "DataBase";
        public const string SourceValueProperty = "SourceValue";
        public const string UrlTemplateProperty = "UrlTemplate";
        public const string UrlTitleProperty = "UrlTitle";
        public const string MandatoryFieldsProperty = "MandatoryFields";
        public const string WaitedSubmitToV1StateProperty = "WaitedSubmitToV1State";
        public const string SubmittedToV1StateProperty = "SubmittedToV1State";
        public const string SubmittedToV1ActionProperty = "SubmittedToV1Action";
        public const string CloseActionProperty = "CloseAction";
        public const string EntityTypeProperty = "EntityType";
        public const string IdFieldProperty = "IdField";
        public const string DefectTitleFieldProperty = "DefectTitleField";
        public const string DescriptionFieldProperty = "DescriptionField";
        public const string ProjectNameFieldProperty = "ProjectNameField";
        public const string OwnerLoginFieldProperty = "OwnerLoginField";
        public const string StateFieldProperty = "StateField";
        public const string PriorityFieldProperty = "PriorityField";
        public const string ModifyActionProperty = "ModifyAction";
        public const string ProjectMappingsProperty = "ProjectMappings";
        public const string PriorityMappingsProperty = "PriorityMappings";

        #endregion

        public ClearQuestServiceEntity() {
            CreateTimer(TimerEntity.DefaultTimerIntervalMinutes);
            MandatoryFields = new List<ClearQuestField>();
            ProjectMappings = new List<ClearQuestProjectMapping>();
            PriorityMappings = new List<ClearQuestPriorityMapping>();
        }

        [XmlArray("ClearQuestMandatoryFields")]
        [XmlArrayItem("Field")]
        [HelpString(HelpResourceKey = "ClearQuestMandatoryFields")]
        public List<ClearQuestField> MandatoryFields { get; set; }

        [XmlArray("ProjectMappings")]
        [XmlArrayItem("Mapping")]
        [HelpString(HelpResourceKey = "ClearQuestProjectMappings")]
        public List<ClearQuestProjectMapping> ProjectMappings { get; set; }

        [XmlArray("PriorityMappings")]
        [XmlArrayItem("Mapping")]
        [HelpString(HelpResourceKey = "ClearQuestPriorityMappings")]
        public List<ClearQuestPriorityMapping> PriorityMappings { get; set; }

        [NonEmptyStringValidator]
        [XmlElement("ClearQuestConnectionName")]
        [HelpString(HelpResourceKey = "ClearQuestConnectionName")]
        public string ConnectionName { get; set; }

        [NonEmptyStringValidator]
        [XmlElement("ClearQuestUsername")]
        [HelpString(HelpResourceKey = "ClearQuestUsername")]
        public string UserName { get; set; }

        [XmlElement("ClearQuestPassword")]
        [HelpString(HelpResourceKey = "ClearQuestPassword")]
        public string Password { get; set; }

        [NonEmptyStringValidator]
        [XmlElement("ClearQuestDatabase")]
        [HelpString(HelpResourceKey = "ClearQuestDatabase")]
        public string DataBase { get; set; }

        [NonEmptyStringValidator]
        [XmlElement("SourceFieldValue")]
        [HelpString(HelpResourceKey = "ClearQuestSourceFieldValue")]
        public string SourceValue { get; set; }

        [XmlElement("ClearQuestWebUrlTemplate")]
        [HelpString(HelpResourceKey = "ClearQuestIssueUrlTemplate")]
        public XmlCDataSection UrlTemplateCData {
            get {
                var doc = new XmlDataDocument();
                return doc.CreateCDataSection(UrlTemplate);
            }
            set { UrlTemplate = value.Value; }
        }

        [XmlIgnore]
        public string UrlTemplate { get; set; }

        [NonEmptyStringValidator]
        [XmlElement("ClearQuestWebUrlTitle")]
        public string UrlTitle { get; set; }

        [XmlElement("ClearQuestWaitedSubmitToV1State")]
        [HelpString(HelpResourceKey = "ClearQuestWaitedSubmitToV1State")]
        public string WaitedSubmitToV1State { get; set; }

        [XmlElement("ClearQuestSubmittedToV1State")]
        [HelpString(HelpResourceKey = "ClearQuestSubmittedToV1State")]
        public string SubmittedToV1State { get; set; }

        [XmlElement("ClearQuestSubmittedToV1Action")]
        [HelpString(HelpResourceKey = "ClearQuestSubmittedToV1Action")]
        public string SubmittedToV1Action { get; set; }

        [XmlElement("ClearQuestCloseAction")]
        [HelpString(HelpResourceKey = "ClearQuestCloseAction")]
        public string CloseAction { get; set; }

        [XmlElement("ClearQuestEntityType")]
        [HelpString(HelpResourceKey = "ClearQuestEntityType")]
        public string EntityType { get; set; }

        [XmlElement("ClearQuestIDField")]
        [HelpString(HelpResourceKey = "ClearQuestIdField")]
        public string IdField { get; set; }

        [XmlElement("ClearQuestDefectTitleField")]
        [HelpString(HelpResourceKey = "ClearQuestDefectTitleField")]
        public string DefectTitleField { get; set; }

        [XmlElement("ClearQuestDescriptionField")]
        [HelpString(HelpResourceKey = "ClearQuestDescriptionField")]
        public string DescriptionField { get; set; }

        [XmlElement("ClearQuestProjectNameField")]
        [HelpString(HelpResourceKey = "ClearQuestProjectNameField")]
        public string ProjectNameField { get; set; }

        [XmlElement("ClearQuestOwnerLoginField")]
        [HelpString(HelpResourceKey = "ClearQuestOwnerLoginField")]
        public string OwnerLoginField { get; set; }

        [XmlElement("ClearQuestStateField")]
        [HelpString(HelpResourceKey = "ClearQuestStateField")]
        public string StateField { get; set; }

        [XmlElement("ClearQuestPriorityField")]
        [HelpString(HelpResourceKey = "ClearQuestPriorityField")]
        public string PriorityField { get; set; }

        [XmlElement("ClearQuestModifyAction")]
        [HelpString(HelpResourceKey = "ClearQuestModifyAction")]
        public string ModifyAction { get; set; }

        [SelfValidation]
        public void CheckMandatoryFields(ValidationResults results) {
            var validator = ValidationFactory.CreateValidatorFromAttributes(typeof(ClearQuestField), string.Empty);

            foreach(ClearQuestField field in MandatoryFields) {
                var fieldResults = validator.Validate(field);
                
                if(!fieldResults.IsValid) {
                    results.AddAllResults(fieldResults);
                }
            }
        }

        [SelfValidation]
        public void CheckProjectMappings(ValidationResults results) {
            var validator = ValidationFactory.CreateValidator<ClearQuestProjectMapping>();

            foreach(ClearQuestProjectMapping mapping in ProjectMappings) {
                var mappingValidationResults = validator.Validate(mapping);

                if(!mappingValidationResults.IsValid) {
                    results.AddAllResults(mappingValidationResults);
                }
            }
        }

        [SelfValidation]
        public void CheckPriorityMappings(ValidationResults results) {
            var validator = ValidationFactory.CreateValidator<ClearQuestPriorityMapping>();

            foreach(ClearQuestPriorityMapping mapping in PriorityMappings) {
                var mappingValidationResults = validator.Validate(mapping);

                if(!mappingValidationResults.IsValid) {
                    results.AddAllResults(mappingValidationResults);
                }
            }
        }

        public override bool Equals(object obj) {
            if (obj == null || GetType() != obj.GetType()) {
                return false;
            }

            var other = (ClearQuestServiceEntity) obj;

            return string.Equals(ConnectionName, other.ConnectionName) && 
                   string.Equals(UserName, other.UserName) &&
                   string.Equals(Password, other.Password) &&
                   string.Equals(DataBase, other.DataBase) &&
                   string.Equals(SourceValue, other.SourceValue) &&
                   string.Equals(UrlTemplate, other.UrlTemplate) &&
                   string.Equals(UrlTitle, other.UrlTitle) &&
                   string.Equals(WaitedSubmitToV1State, other.WaitedSubmitToV1State) &&
                   string.Equals(SubmittedToV1State, other.SubmittedToV1State) &&
                   string.Equals(SubmittedToV1Action, other.SubmittedToV1Action) &&
                   string.Equals(CloseAction, other.CloseAction) &&
                   string.Equals(EntityType, other.EntityType) &&
                   string.Equals(IdField, other.IdField) &&
                   string.Equals(DefectTitleField, other.DefectTitleField) &&
                   string.Equals(DescriptionField, other.DescriptionField) &&
                   string.Equals(ProjectNameField, other.ProjectNameField) &&
                   string.Equals(OwnerLoginField, other.OwnerLoginField) &&
                   string.Equals(PriorityField, other.PriorityField) &&
                   string.Equals(StateField, other.StateField) &&
                   string.Equals(ModifyAction, other.ModifyAction);
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }
    }
}