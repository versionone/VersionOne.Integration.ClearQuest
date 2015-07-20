using System;
using System.Drawing;
using System.Windows.Forms;
using VersionOne.ServiceHost.ConfigurationTool.Entities;
using VersionOne.ServiceHost.ConfigurationTool.UI.Interfaces;
using VersionOne.ServiceHost.ConfigurationTool.DL;
using System.Collections.Generic;
using VersionOne.ServiceHost.ConfigurationTool.BZ;

namespace VersionOne.ServiceHost.ConfigurationTool.UI.Controls {
    partial class ClearQuestPageControl : BasePageControl<ClearQuestServiceEntity>, IClearQuestPageView {
        public event EventHandler ValidationRequested;

        public ClearQuestPageControl() {
            InitializeComponent();
            btnValidate.Click += btnValidateCQConnection_Click;
            btnDelete.Click += btnDelete_Click;
            grdMandatoryFields.CellValidating += grdMandatoryFields_CellValidating;
            
            grdMandatoryFields.UserDeletingRow += delegate(object sender, DataGridViewRowCancelEventArgs e) {
                                                      e.Cancel = !ConfirmDelete();
                                                  };
            
            grdProjectMappings.UserDeletingRow += delegate(object sender, DataGridViewRowCancelEventArgs e) {
                                                      e.Cancel = !ConfirmDelete();
                                                  };

            grdPriorityMappings.UserDeletingRow += delegate(object sender, DataGridViewRowCancelEventArgs e) {
                                                       e.Cancel = !ConfirmDelete();
                                                   };

            grdProjectMappings.DataError += grdProjectMappings_DataError;
            grdPriorityMappings.DataError += grdPriorityMappings_DataError;


            btnDeleteProjectMapping.Click += btnDeleteProjectMapping_Click;
            btnDeletePriorityMapping.Click += btnDeletePriorityMapping_Click;

            AddGridValidationProvider(typeof(ClearQuestField), grdMandatoryFields);
            AddGridValidationProvider(typeof(ClearQuestProjectMapping), grdProjectMappings);
            AddGridValidationProvider(typeof(ClearQuestPriorityMapping), grdPriorityMappings);

            AddControlValidation<ClearQuestServiceEntity>(txtConnectionName, ClearQuestServiceEntity.ConnectionNameProperty, "Text");
            AddControlValidation<ClearQuestServiceEntity>(txtUserName, ClearQuestServiceEntity.UserNameProperty, "Text");
            AddControlValidation<ClearQuestServiceEntity>(txtDatabase, ClearQuestServiceEntity.DataBaseProperty, "Text");
            AddControlValidation<ClearQuestServiceEntity>(cboSourceFieldValue, ClearQuestServiceEntity.SourceValueProperty, "Text");

            grdProjectMappings.AutoGenerateColumns = false;
            grdPriorityMappings.AutoGenerateColumns = false;

            AddTabHighlightingSupport(tcData);
        }

        public override void DataBind() {
            AddControlBinding(chkDisable, Model, BaseEntity.DisabledProperty);
            AddControlBinding(txtConnectionName, Model, ClearQuestServiceEntity.ConnectionNameProperty);
            AddControlBinding(txtPassword, Model, ClearQuestServiceEntity.PasswordProperty);
            AddControlBinding(txtUserName, Model, ClearQuestServiceEntity.UserNameProperty);
            AddControlBinding(txtDatabase, Model, ClearQuestServiceEntity.DataBaseProperty);
            AddSimpleComboboxBinding(cboSourceFieldValue, Model, ClearQuestServiceEntity.SourceValueProperty);
            AddControlBinding(txtUrlTitle, Model, ClearQuestServiceEntity.UrlTitleProperty);
            AddControlBinding(txtUrlTemplate, Model, ClearQuestServiceEntity.UrlTemplateProperty);
            AddControlBinding(txtWaitedSubmit, Model, ClearQuestServiceEntity.WaitedSubmitToV1StateProperty);
            AddControlBinding(txtSubmitedToState, Model, ClearQuestServiceEntity.SubmittedToV1StateProperty);
            AddControlBinding(txtSubmitedToAction, Model, ClearQuestServiceEntity.SubmittedToV1ActionProperty);
            AddControlBinding(txtCloseAction, Model, ClearQuestServiceEntity.CloseActionProperty);
            AddControlBinding(txtEntityType, Model, ClearQuestServiceEntity.EntityTypeProperty);
            AddControlBinding(txtFieldId, Model, ClearQuestServiceEntity.IdFieldProperty);
            AddControlBinding(txtDefectTitle, Model, ClearQuestServiceEntity.DefectTitleFieldProperty);
            AddControlBinding(txtDescription, Model, ClearQuestServiceEntity.DescriptionFieldProperty);
            AddControlBinding(txtProjectName, Model, ClearQuestServiceEntity.ProjectNameFieldProperty);
            AddControlBinding(txtOwnerLogin, Model, ClearQuestServiceEntity.OwnerLoginFieldProperty);
            AddControlBinding(txtState, Model, ClearQuestServiceEntity.StateFieldProperty);
            AddControlBinding(txtPriorityField, Model, ClearQuestServiceEntity.PriorityFieldProperty);
            AddControlBinding(txtModifyAction, Model, ClearQuestServiceEntity.ModifyActionProperty);
            AddControlBinding(numIntervalMinutes, Model.Timer, TimerEntity.TimerProperty);

            BindProjectMappingsGrid();
            BindPriorityMappingsGrid();
            BindMandatoryFiledsGrid();

            BindHelpStrings();

            FillComboBoxWithStrings(cboSourceFieldValue, SourceList);

            InvokeValidationTriggered();
        }

        private void BindPriorityMappingsGrid() {
            BindPriorityColumn();
            bsPriorityMappings.DataSource = Model.PriorityMappings;
            grdPriorityMappings.DataSource = bsPriorityMappings;
        }

        private void BindProjectMappingsGrid() {
            BindProjectColumn();
            bsProjectMappings.DataSource = Model.ProjectMappings;
            grdProjectMappings.DataSource = bsProjectMappings;
        }

        private void BindMandatoryFiledsGrid() {
            bsMandatoryFields.DataSource = Model.MandatoryFields;
            grdMandatoryFields.DataSource = bsMandatoryFields;
        }

        private void BindHelpStrings() {
            AddHelpSupport(chkDisable, Model, BaseEntity.DisabledProperty);
            AddHelpSupport(txtConnectionName, Model, ClearQuestServiceEntity.ConnectionNameProperty);
            AddHelpSupport(txtPassword, Model, ClearQuestServiceEntity.PasswordProperty);
            AddHelpSupport(txtUserName, Model, ClearQuestServiceEntity.UserNameProperty);
            AddHelpSupport(txtDatabase, Model, ClearQuestServiceEntity.DataBaseProperty);
            AddHelpSupport(cboSourceFieldValue, Model, ClearQuestServiceEntity.SourceValueProperty);
            AddHelpSupport(txtUrlTitle, Model, ClearQuestServiceEntity.UrlTitleProperty);
            AddHelpSupport(txtUrlTemplate, Model, ClearQuestServiceEntity.UrlTemplateProperty);
            AddHelpSupport(txtWaitedSubmit, Model, ClearQuestServiceEntity.WaitedSubmitToV1StateProperty);
            AddHelpSupport(txtSubmitedToState, Model, ClearQuestServiceEntity.SubmittedToV1StateProperty);
            AddHelpSupport(txtSubmitedToAction, Model, ClearQuestServiceEntity.SubmittedToV1ActionProperty);
            AddHelpSupport(txtCloseAction, Model, ClearQuestServiceEntity.CloseActionProperty);
            AddHelpSupport(txtEntityType, Model, ClearQuestServiceEntity.EntityTypeProperty);
            AddHelpSupport(txtFieldId, Model, ClearQuestServiceEntity.IdFieldProperty);
            AddHelpSupport(txtDefectTitle, Model, ClearQuestServiceEntity.DefectTitleFieldProperty);
            AddHelpSupport(txtDescription, Model, ClearQuestServiceEntity.DescriptionFieldProperty);
            AddHelpSupport(txtProjectName, Model, ClearQuestServiceEntity.ProjectNameFieldProperty);
            AddHelpSupport(txtOwnerLogin, Model, ClearQuestServiceEntity.OwnerLoginFieldProperty);
            AddHelpSupport(txtState, Model, ClearQuestServiceEntity.StateFieldProperty);
            AddHelpSupport(txtPriorityField, Model, ClearQuestServiceEntity.PriorityFieldProperty);
            AddHelpSupport(txtModifyAction, Model, ClearQuestServiceEntity.ModifyActionProperty);
            AddHelpSupport(lblPollIntervalSuffix, Model.Timer, TimerEntity.TimerProperty);
            AddHelpSupport(grdMandatoryFields, Model, ClearQuestServiceEntity.MandatoryFieldsProperty);
            AddHelpSupport(grdProjectMappings, Model, ClearQuestServiceEntity.ProjectMappingsProperty);
            AddHelpSupport(grdPriorityMappings, Model, ClearQuestServiceEntity.PriorityMappingsProperty);
        }

        private void BindProjectColumn() {
            colVersionOneProjectId.DisplayMember = "DisplayName";
            colVersionOneProjectId.ValueMember = "Token";
            colVersionOneProjectId.DataSource = VersionOneProjects;
        }

        private void BindPriorityColumn() {
            colVersionOnePriority.DisplayMember = "Name";
            colVersionOnePriority.ValueMember = "Value";
            colVersionOnePriority.DataSource = VersionOnePriorities;
        }

        #region IClearQuestPageView Members

        public string[] SourceList { get; set; }

        public IList<ProjectWrapper> VersionOneProjects { get; set; }

        public IList<ListValue> VersionOnePriorities { get; set; }

        private void btnValidateCQConnection_Click(object sender, EventArgs e) {
            if(ValidationRequested != null) {
                ValidationRequested(this, EventArgs.Empty);
            }
        }

        public void SetValidationResult(bool validationSuccessful) {
            lblConnectionValidation.Visible = true;

            if(validationSuccessful) {
                lblConnectionValidation.ForeColor = Color.Green;
                lblConnectionValidation.Text = Resources.ConnectionValidMessage;
            } else {
                lblConnectionValidation.ForeColor = Color.Red;
                lblConnectionValidation.Text = Resources.ConnectionInvalidMessage;
            }
        }

        public void SetGeneralTabValid(bool isValid) {
            TabHighlighter.SetTabPageValidationMark(tpSettings, isValid);
        }

        public void SetMappingTabValid(bool isValid) {
            TabHighlighter.SetTabPageValidationMark(tpMappings, isValid);
        }

        #endregion

        private void btnDelete_Click(object sender, EventArgs e) {
            if(grdMandatoryFields.SelectedRows.Count == 0) {
                return;
            }

            if(ConfirmDelete()) {
                bsMandatoryFields.Remove(grdMandatoryFields.SelectedRows[0].DataBoundItem);
            }
        }

        private void btnDeletePriorityMapping_Click(object sender, EventArgs e) {
            if(grdPriorityMappings.SelectedRows.Count > 0 && ConfirmDelete()) {
                bsPriorityMappings.Remove(grdPriorityMappings.SelectedRows[0].DataBoundItem);
            }
        }

        private void btnDeleteProjectMapping_Click(object sender, EventArgs e) {
            if(grdProjectMappings.SelectedRows.Count > 0 && ConfirmDelete()) {
                bsProjectMappings.Remove(grdProjectMappings.SelectedRows[0].DataBoundItem);
            }
        }

        private void grdProjectMappings_DataError(object sender, DataGridViewDataErrorEventArgs e) {
            if(VersionOneProjects != null && VersionOneProjects.Count > 0) {
                grdProjectMappings.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = VersionOneProjects[0].Token;
            }

            e.ThrowException = false;
        }

        private void grdPriorityMappings_DataError(object sender, DataGridViewDataErrorEventArgs e) {
            if(VersionOnePriorities != null && VersionOnePriorities.Count > 0) {
                grdPriorityMappings.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = VersionOnePriorities[0].Value;
            }

            e.ThrowException = false;
        }

        private void grdMandatoryFields_CellValidating(object sender, DataGridViewCellValidatingEventArgs e) {
            if(!grdMandatoryFields.IsCurrentCellDirty) {
                return;
            }

            var currentRow = grdMandatoryFields.Rows[e.RowIndex];
            currentRow.ErrorText = string.Empty;
            var nameValue = currentRow.Cells[0].EditedFormattedValue as string;

            var matchingItem =
                Model.MandatoryFields.Find(item => string.Equals(item.Name, nameValue));

            if(e.ColumnIndex == 0 && matchingItem != null) {
                e.Cancel = true;
                currentRow.ErrorText = "Values should be unique";
            }
        }
    }
}