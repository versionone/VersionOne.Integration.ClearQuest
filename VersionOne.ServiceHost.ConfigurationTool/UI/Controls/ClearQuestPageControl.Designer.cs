namespace VersionOne.ServiceHost.ConfigurationTool.UI.Controls {
    public partial class ClearQuestPageControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.grpConnection = new System.Windows.Forms.GroupBox();
            this.lblConnectionValidation = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtConnectionName = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.grpMandatoryFields = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grdMandatoryFields = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSubmitedToAction = new System.Windows.Forms.TextBox();
            this.txtWaitedSubmit = new System.Windows.Forms.TextBox();
            this.lblEntityType = new System.Windows.Forms.Label();
            this.lblCloseAction = new System.Windows.Forms.Label();
            this.lblSubmitedToState = new System.Windows.Forms.Label();
            this.lblWaitedSubmitToV1State = new System.Windows.Forms.Label();
            this.lblFieldId = new System.Windows.Forms.Label();
            this.txtCloseAction = new System.Windows.Forms.TextBox();
            this.txtSubmitedToState = new System.Windows.Forms.TextBox();
            this.lblSubmitedToAction = new System.Windows.Forms.Label();
            this.txtEntityType = new System.Windows.Forms.TextBox();
            this.lblDefectTitle = new System.Windows.Forms.Label();
            this.txtUrlTitle = new System.Windows.Forms.TextBox();
            this.lblUrlTitle = new System.Windows.Forms.Label();
            this.txtUrlTemplate = new System.Windows.Forms.TextBox();
            this.lblUrlTempl = new System.Windows.Forms.Label();
            this.cboSourceFieldValue = new System.Windows.Forms.ComboBox();
            this.lblSourceFieldValue = new System.Windows.Forms.Label();
            this.chkDisable = new System.Windows.Forms.CheckBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtOwnerLogin = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtFieldId = new System.Windows.Forms.TextBox();
            this.txtDefectTitle = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblOwnerLogin = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblModifyAction = new System.Windows.Forms.Label();
            this.txtModifyAction = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.grpState = new System.Windows.Forms.GroupBox();
            this.lblPollIntervalSuffix = new System.Windows.Forms.Label();
            this.lblPollIntervalPrefix = new System.Windows.Forms.Label();
            this.numIntervalMinutes = new System.Windows.Forms.NumericUpDown();
            this.grpNativeFields = new System.Windows.Forms.GroupBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.txtPriorityField = new System.Windows.Forms.TextBox();
            this.bsMandatoryFields = new System.Windows.Forms.BindingSource(this.components);
            this.grpVersionOne = new System.Windows.Forms.GroupBox();
            this.tcData = new System.Windows.Forms.TabControl();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.ccScrollabablePanel = new System.Windows.Forms.ContainerControl();
            this.tpMappings = new System.Windows.Forms.TabPage();
            this.grpPriorityMappings = new System.Windows.Forms.GroupBox();
            this.btnDeletePriorityMapping = new System.Windows.Forms.Button();
            this.grdPriorityMappings = new System.Windows.Forms.DataGridView();
            this.colVersionOnePriority = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colClearQuestPriorityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpProjectMappings = new System.Windows.Forms.GroupBox();
            this.btnDeleteProjectMapping = new System.Windows.Forms.Button();
            this.grdProjectMappings = new System.Windows.Forms.DataGridView();
            this.colVersionOneProjectId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colClearQuestProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsProjectMappings = new System.Windows.Forms.BindingSource(this.components);
            this.bsPriorityMappings = new System.Windows.Forms.BindingSource(this.components);
            this.grpConnection.SuspendLayout();
            this.grpMandatoryFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMandatoryFields)).BeginInit();
            this.grpState.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIntervalMinutes)).BeginInit();
            this.grpNativeFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMandatoryFields)).BeginInit();
            this.grpVersionOne.SuspendLayout();
            this.tcData.SuspendLayout();
            this.tpSettings.SuspendLayout();
            this.ccScrollabablePanel.SuspendLayout();
            this.tpMappings.SuspendLayout();
            this.grpPriorityMappings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPriorityMappings)).BeginInit();
            this.grpProjectMappings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProjectMappings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjectMappings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPriorityMappings)).BeginInit();
            this.SuspendLayout();
            // 
            // grpConnection
            // 
            this.grpConnection.Controls.Add(this.lblConnectionValidation);
            this.grpConnection.Controls.Add(this.btnValidate);
            this.grpConnection.Controls.Add(this.txtPassword);
            this.grpConnection.Controls.Add(this.lblPassword);
            this.grpConnection.Controls.Add(this.txtUserName);
            this.grpConnection.Controls.Add(this.lblUserName);
            this.grpConnection.Controls.Add(this.txtConnectionName);
            this.grpConnection.Controls.Add(this.lblUrl);
            this.grpConnection.Controls.Add(this.lblDatabase);
            this.grpConnection.Controls.Add(this.txtDatabase);
            this.grpConnection.Location = new System.Drawing.Point(6, 3);
            this.grpConnection.Name = "grpConnection";
            this.grpConnection.Size = new System.Drawing.Size(495, 108);
            this.grpConnection.TabIndex = 1;
            this.grpConnection.TabStop = false;
            this.grpConnection.Text = "Connection";
            // 
            // lblConnectionValidation
            // 
            this.lblConnectionValidation.AutoSize = true;
            this.lblConnectionValidation.Location = new System.Drawing.Point(108, 80);
            this.lblConnectionValidation.Name = "lblConnectionValidation";
            this.lblConnectionValidation.Size = new System.Drawing.Size(137, 13);
            this.lblConnectionValidation.TabIndex = 8;
            this.lblConnectionValidation.Text = "Connection validation result";
            this.lblConnectionValidation.Visible = false;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(367, 73);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(87, 27);
            this.btnValidate.TabIndex = 9;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(339, 43);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(115, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(278, 46);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(111, 43);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(115, 20);
            this.txtUserName.TabIndex = 5;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(17, 46);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(55, 13);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "Username";
            // 
            // txtConnectionName
            // 
            this.txtConnectionName.Location = new System.Drawing.Point(111, 17);
            this.txtConnectionName.Name = "txtConnectionName";
            this.txtConnectionName.Size = new System.Drawing.Size(115, 20);
            this.txtConnectionName.TabIndex = 1;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(17, 20);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(92, 13);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Text = "Connection Name";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(278, 20);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(53, 13);
            this.lblDatabase.TabIndex = 2;
            this.lblDatabase.Text = "Database";
            // 
            // txtDatabase
            // 
            this.txtDatabase.AcceptsReturn = true;
            this.txtDatabase.Location = new System.Drawing.Point(339, 17);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(115, 20);
            this.txtDatabase.TabIndex = 3;
            // 
            // grpMandatoryFields
            // 
            this.grpMandatoryFields.Controls.Add(this.btnDelete);
            this.grpMandatoryFields.Controls.Add(this.grdMandatoryFields);
            this.grpMandatoryFields.Location = new System.Drawing.Point(6, 392);
            this.grpMandatoryFields.Name = "grpMandatoryFields";
            this.grpMandatoryFields.Size = new System.Drawing.Size(495, 116);
            this.grpMandatoryFields.TabIndex = 4;
            this.grpMandatoryFields.TabStop = false;
            this.grpMandatoryFields.Text = "ClearQuest Mandatory Close Fields";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(367, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 27);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // grdMandatoryFields
            // 
            this.grdMandatoryFields.AllowUserToResizeColumns = false;
            this.grdMandatoryFields.AllowUserToResizeRows = false;
            this.grdMandatoryFields.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdMandatoryFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMandatoryFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colValue});
            this.grdMandatoryFields.Location = new System.Drawing.Point(19, 19);
            this.grdMandatoryFields.MultiSelect = false;
            this.grdMandatoryFields.Name = "grdMandatoryFields";
            this.grdMandatoryFields.Size = new System.Drawing.Size(243, 91);
            this.grdMandatoryFields.TabIndex = 0;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            // 
            // colValue
            // 
            this.colValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colValue.DataPropertyName = "Value";
            this.colValue.HeaderText = "Value";
            this.colValue.Name = "colValue";
            // 
            // txtSubmitedToAction
            // 
            this.txtSubmitedToAction.Location = new System.Drawing.Point(145, 71);
            this.txtSubmitedToAction.Name = "txtSubmitedToAction";
            this.txtSubmitedToAction.Size = new System.Drawing.Size(101, 20);
            this.txtSubmitedToAction.TabIndex = 5;
            // 
            // txtWaitedSubmit
            // 
            this.txtWaitedSubmit.Location = new System.Drawing.Point(145, 19);
            this.txtWaitedSubmit.Name = "txtWaitedSubmit";
            this.txtWaitedSubmit.Size = new System.Drawing.Size(309, 20);
            this.txtWaitedSubmit.TabIndex = 1;
            // 
            // lblEntityType
            // 
            this.lblEntityType.AutoSize = true;
            this.lblEntityType.Location = new System.Drawing.Point(17, 25);
            this.lblEntityType.Name = "lblEntityType";
            this.lblEntityType.Size = new System.Drawing.Size(74, 13);
            this.lblEntityType.TabIndex = 0;
            this.lblEntityType.Text = "CQ Entity type";
            // 
            // lblCloseAction
            // 
            this.lblCloseAction.AutoSize = true;
            this.lblCloseAction.Location = new System.Drawing.Point(296, 74);
            this.lblCloseAction.Name = "lblCloseAction";
            this.lblCloseAction.Size = new System.Drawing.Size(65, 13);
            this.lblCloseAction.TabIndex = 6;
            this.lblCloseAction.Text = "Close action";
            // 
            // lblSubmitedToState
            // 
            this.lblSubmitedToState.AutoSize = true;
            this.lblSubmitedToState.Location = new System.Drawing.Point(16, 48);
            this.lblSubmitedToState.Name = "lblSubmitedToState";
            this.lblSubmitedToState.Size = new System.Drawing.Size(118, 13);
            this.lblSubmitedToState.TabIndex = 2;
            this.lblSubmitedToState.Text = "Already Submitted state";
            // 
            // lblWaitedSubmitToV1State
            // 
            this.lblWaitedSubmitToV1State.AutoSize = true;
            this.lblWaitedSubmitToV1State.Location = new System.Drawing.Point(17, 22);
            this.lblWaitedSubmitToV1State.Name = "lblWaitedSubmitToV1State";
            this.lblWaitedSubmitToV1State.Size = new System.Drawing.Size(108, 13);
            this.lblWaitedSubmitToV1State.TabIndex = 0;
            this.lblWaitedSubmitToV1State.Text = "Awaiting Submit state";
            // 
            // lblFieldId
            // 
            this.lblFieldId.AutoSize = true;
            this.lblFieldId.Location = new System.Drawing.Point(16, 51);
            this.lblFieldId.Name = "lblFieldId";
            this.lblFieldId.Size = new System.Drawing.Size(40, 13);
            this.lblFieldId.TabIndex = 2;
            this.lblFieldId.Text = "ID field";
            // 
            // txtCloseAction
            // 
            this.txtCloseAction.Location = new System.Drawing.Point(369, 71);
            this.txtCloseAction.Name = "txtCloseAction";
            this.txtCloseAction.Size = new System.Drawing.Size(85, 20);
            this.txtCloseAction.TabIndex = 7;
            // 
            // txtSubmitedToState
            // 
            this.txtSubmitedToState.AcceptsTab = true;
            this.txtSubmitedToState.Location = new System.Drawing.Point(145, 45);
            this.txtSubmitedToState.Name = "txtSubmitedToState";
            this.txtSubmitedToState.Size = new System.Drawing.Size(309, 20);
            this.txtSubmitedToState.TabIndex = 3;
            // 
            // lblSubmitedToAction
            // 
            this.lblSubmitedToAction.AutoSize = true;
            this.lblSubmitedToAction.Location = new System.Drawing.Point(17, 74);
            this.lblSubmitedToAction.Name = "lblSubmitedToAction";
            this.lblSubmitedToAction.Size = new System.Drawing.Size(71, 13);
            this.lblSubmitedToAction.TabIndex = 4;
            this.lblSubmitedToAction.Text = "Submit action";
            // 
            // txtEntityType
            // 
            this.txtEntityType.AcceptsReturn = true;
            this.txtEntityType.AcceptsTab = true;
            this.txtEntityType.Location = new System.Drawing.Point(105, 22);
            this.txtEntityType.Name = "txtEntityType";
            this.txtEntityType.Size = new System.Drawing.Size(105, 20);
            this.txtEntityType.TabIndex = 1;
            // 
            // lblDefectTitle
            // 
            this.lblDefectTitle.AutoSize = true;
            this.lblDefectTitle.Location = new System.Drawing.Point(16, 77);
            this.lblDefectTitle.Name = "lblDefectTitle";
            this.lblDefectTitle.Size = new System.Drawing.Size(84, 13);
            this.lblDefectTitle.TabIndex = 4;
            this.lblDefectTitle.Text = "Defect Title field";
            // 
            // txtUrlTitle
            // 
            this.txtUrlTitle.Location = new System.Drawing.Point(111, 72);
            this.txtUrlTitle.Name = "txtUrlTitle";
            this.txtUrlTitle.Size = new System.Drawing.Size(343, 20);
            this.txtUrlTitle.TabIndex = 5;
            // 
            // lblUrlTitle
            // 
            this.lblUrlTitle.AutoSize = true;
            this.lblUrlTitle.Location = new System.Drawing.Point(16, 75);
            this.lblUrlTitle.Name = "lblUrlTitle";
            this.lblUrlTitle.Size = new System.Drawing.Size(52, 13);
            this.lblUrlTitle.TabIndex = 4;
            this.lblUrlTitle.Text = "URL Title";
            // 
            // txtUrlTemplate
            // 
            this.txtUrlTemplate.Location = new System.Drawing.Point(111, 46);
            this.txtUrlTemplate.Name = "txtUrlTemplate";
            this.txtUrlTemplate.Size = new System.Drawing.Size(343, 20);
            this.txtUrlTemplate.TabIndex = 3;
            // 
            // lblUrlTempl
            // 
            this.lblUrlTempl.AutoSize = true;
            this.lblUrlTempl.Location = new System.Drawing.Point(16, 49);
            this.lblUrlTempl.Name = "lblUrlTempl";
            this.lblUrlTempl.Size = new System.Drawing.Size(76, 13);
            this.lblUrlTempl.TabIndex = 2;
            this.lblUrlTempl.Text = "URL Template";
            // 
            // cboSourceFieldValue
            // 
            this.cboSourceFieldValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSourceFieldValue.FormattingEnabled = true;
            this.cboSourceFieldValue.Location = new System.Drawing.Point(111, 19);
            this.cboSourceFieldValue.Name = "cboSourceFieldValue";
            this.cboSourceFieldValue.Size = new System.Drawing.Size(343, 21);
            this.cboSourceFieldValue.TabIndex = 1;
            // 
            // lblSourceFieldValue
            // 
            this.lblSourceFieldValue.AutoSize = true;
            this.lblSourceFieldValue.Location = new System.Drawing.Point(17, 22);
            this.lblSourceFieldValue.Name = "lblSourceFieldValue";
            this.lblSourceFieldValue.Size = new System.Drawing.Size(41, 13);
            this.lblSourceFieldValue.TabIndex = 0;
            this.lblSourceFieldValue.Text = "Source";
            // 
            // chkDisable
            // 
            this.chkDisable.AutoSize = true;
            this.chkDisable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDisable.Location = new System.Drawing.Point(397, 3);
            this.chkDisable.Name = "chkDisable";
            this.chkDisable.Size = new System.Drawing.Size(67, 17);
            this.chkDisable.TabIndex = 0;
            this.chkDisable.Text = "Disabled";
            this.chkDisable.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(105, 100);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(105, 20);
            this.txtDescription.TabIndex = 7;
            // 
            // txtOwnerLogin
            // 
            this.txtOwnerLogin.Location = new System.Drawing.Point(349, 48);
            this.txtOwnerLogin.Name = "txtOwnerLogin";
            this.txtOwnerLogin.Size = new System.Drawing.Size(105, 20);
            this.txtOwnerLogin.TabIndex = 11;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(349, 22);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(105, 20);
            this.txtProjectName.TabIndex = 9;
            // 
            // txtFieldId
            // 
            this.txtFieldId.AcceptsTab = true;
            this.txtFieldId.Location = new System.Drawing.Point(105, 48);
            this.txtFieldId.Name = "txtFieldId";
            this.txtFieldId.Size = new System.Drawing.Size(105, 20);
            this.txtFieldId.TabIndex = 3;
            // 
            // txtDefectTitle
            // 
            this.txtDefectTitle.Location = new System.Drawing.Point(105, 74);
            this.txtDefectTitle.Name = "txtDefectTitle";
            this.txtDefectTitle.Size = new System.Drawing.Size(105, 20);
            this.txtDefectTitle.TabIndex = 5;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(17, 103);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(82, 13);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description field";
            // 
            // lblOwnerLogin
            // 
            this.lblOwnerLogin.AutoSize = true;
            this.lblOwnerLogin.Location = new System.Drawing.Point(255, 51);
            this.lblOwnerLogin.Name = "lblOwnerLogin";
            this.lblOwnerLogin.Size = new System.Drawing.Size(89, 13);
            this.lblOwnerLogin.TabIndex = 10;
            this.lblOwnerLogin.Text = "Owner Login field";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(255, 25);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(69, 13);
            this.lblProjectName.TabIndex = 8;
            this.lblProjectName.Text = "Project name";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(255, 77);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(54, 13);
            this.lblState.TabIndex = 12;
            this.lblState.Text = "State field";
            // 
            // lblModifyAction
            // 
            this.lblModifyAction.AutoSize = true;
            this.lblModifyAction.Location = new System.Drawing.Point(17, 100);
            this.lblModifyAction.Name = "lblModifyAction";
            this.lblModifyAction.Size = new System.Drawing.Size(70, 13);
            this.lblModifyAction.TabIndex = 8;
            this.lblModifyAction.Text = "Modify action";
            // 
            // txtModifyAction
            // 
            this.txtModifyAction.Location = new System.Drawing.Point(145, 97);
            this.txtModifyAction.Name = "txtModifyAction";
            this.txtModifyAction.Size = new System.Drawing.Size(309, 20);
            this.txtModifyAction.TabIndex = 9;
            // 
            // txtState
            // 
            this.txtState.AcceptsReturn = true;
            this.txtState.Location = new System.Drawing.Point(349, 74);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(105, 20);
            this.txtState.TabIndex = 13;
            // 
            // grpState
            // 
            this.grpState.Controls.Add(this.lblWaitedSubmitToV1State);
            this.grpState.Controls.Add(this.lblPollIntervalSuffix);
            this.grpState.Controls.Add(this.lblSubmitedToState);
            this.grpState.Controls.Add(this.lblPollIntervalPrefix);
            this.grpState.Controls.Add(this.numIntervalMinutes);
            this.grpState.Controls.Add(this.lblCloseAction);
            this.grpState.Controls.Add(this.txtSubmitedToState);
            this.grpState.Controls.Add(this.lblSubmitedToAction);
            this.grpState.Controls.Add(this.txtWaitedSubmit);
            this.grpState.Controls.Add(this.txtCloseAction);
            this.grpState.Controls.Add(this.txtSubmitedToAction);
            this.grpState.Controls.Add(this.lblModifyAction);
            this.grpState.Controls.Add(this.txtModifyAction);
            this.grpState.Location = new System.Drawing.Point(6, 227);
            this.grpState.Name = "grpState";
            this.grpState.Size = new System.Drawing.Size(495, 159);
            this.grpState.TabIndex = 3;
            this.grpState.TabStop = false;
            this.grpState.Text = "ClearQuest States and Actions";
            // 
            // lblPollIntervalSuffix
            // 
            this.lblPollIntervalSuffix.AutoSize = true;
            this.lblPollIntervalSuffix.Location = new System.Drawing.Point(203, 131);
            this.lblPollIntervalSuffix.Name = "lblPollIntervalSuffix";
            this.lblPollIntervalSuffix.Size = new System.Drawing.Size(43, 13);
            this.lblPollIntervalSuffix.TabIndex = 12;
            this.lblPollIntervalSuffix.Text = "minutes";
            // 
            // lblPollIntervalPrefix
            // 
            this.lblPollIntervalPrefix.AutoSize = true;
            this.lblPollIntervalPrefix.Location = new System.Drawing.Point(17, 131);
            this.lblPollIntervalPrefix.Name = "lblPollIntervalPrefix";
            this.lblPollIntervalPrefix.Size = new System.Drawing.Size(62, 13);
            this.lblPollIntervalPrefix.TabIndex = 10;
            this.lblPollIntervalPrefix.Text = "Poll Interval";
            // 
            // numIntervalMinutes
            // 
            this.numIntervalMinutes.Location = new System.Drawing.Point(145, 129);
            this.numIntervalMinutes.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.numIntervalMinutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIntervalMinutes.Name = "numIntervalMinutes";
            this.numIntervalMinutes.Size = new System.Drawing.Size(52, 20);
            this.numIntervalMinutes.TabIndex = 11;
            this.numIntervalMinutes.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // grpNativeFields
            // 
            this.grpNativeFields.Controls.Add(this.lblPriority);
            this.grpNativeFields.Controls.Add(this.txtPriorityField);
            this.grpNativeFields.Controls.Add(this.lblState);
            this.grpNativeFields.Controls.Add(this.lblEntityType);
            this.grpNativeFields.Controls.Add(this.txtEntityType);
            this.grpNativeFields.Controls.Add(this.txtDefectTitle);
            this.grpNativeFields.Controls.Add(this.txtState);
            this.grpNativeFields.Controls.Add(this.txtFieldId);
            this.grpNativeFields.Controls.Add(this.lblProjectName);
            this.grpNativeFields.Controls.Add(this.txtProjectName);
            this.grpNativeFields.Controls.Add(this.lblOwnerLogin);
            this.grpNativeFields.Controls.Add(this.lblFieldId);
            this.grpNativeFields.Controls.Add(this.lblDescription);
            this.grpNativeFields.Controls.Add(this.lblDefectTitle);
            this.grpNativeFields.Controls.Add(this.txtDescription);
            this.grpNativeFields.Controls.Add(this.txtOwnerLogin);
            this.grpNativeFields.Location = new System.Drawing.Point(6, 514);
            this.grpNativeFields.Name = "grpNativeFields";
            this.grpNativeFields.Size = new System.Drawing.Size(495, 135);
            this.grpNativeFields.TabIndex = 5;
            this.grpNativeFields.TabStop = false;
            this.grpNativeFields.Text = "ClearQuest Entity and Attribute Names";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(255, 103);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(60, 13);
            this.lblPriority.TabIndex = 14;
            this.lblPriority.Text = "Priority field";
            // 
            // txtPriorityField
            // 
            this.txtPriorityField.Location = new System.Drawing.Point(349, 100);
            this.txtPriorityField.Name = "txtPriorityField";
            this.txtPriorityField.Size = new System.Drawing.Size(105, 20);
            this.txtPriorityField.TabIndex = 15;
            // 
            // grpVersionOne
            // 
            this.grpVersionOne.Controls.Add(this.lblUrlTempl);
            this.grpVersionOne.Controls.Add(this.txtUrlTemplate);
            this.grpVersionOne.Controls.Add(this.lblUrlTitle);
            this.grpVersionOne.Controls.Add(this.lblSourceFieldValue);
            this.grpVersionOne.Controls.Add(this.txtUrlTitle);
            this.grpVersionOne.Controls.Add(this.cboSourceFieldValue);
            this.grpVersionOne.Location = new System.Drawing.Point(6, 117);
            this.grpVersionOne.Name = "grpVersionOne";
            this.grpVersionOne.Size = new System.Drawing.Size(495, 104);
            this.grpVersionOne.TabIndex = 2;
            this.grpVersionOne.TabStop = false;
            this.grpVersionOne.Text = "VersionOne Defect Attributes";
            // 
            // tcData
            // 
            this.tcData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tcData.Controls.Add(this.tpSettings);
            this.tcData.Controls.Add(this.tpMappings);
            this.tcData.Location = new System.Drawing.Point(0, 25);
            this.tcData.Name = "tcData";
            this.tcData.SelectedIndex = 0;
            this.tcData.Size = new System.Drawing.Size(531, 688);
            this.tcData.TabIndex = 0;
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.ccScrollabablePanel);
            this.tpSettings.Location = new System.Drawing.Point(4, 22);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(523, 662);
            this.tpSettings.TabIndex = 0;
            this.tpSettings.Text = "Settings";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // ccScrollabablePanel
            // 
            this.ccScrollabablePanel.AutoScroll = true;
            this.ccScrollabablePanel.AutoScrollMinSize = new System.Drawing.Size(550, 850);
            this.ccScrollabablePanel.BackColor = System.Drawing.SystemColors.Window;
            this.ccScrollabablePanel.Controls.Add(this.grpMandatoryFields);
            this.ccScrollabablePanel.Controls.Add(this.grpConnection);
            this.ccScrollabablePanel.Controls.Add(this.grpVersionOne);
            this.ccScrollabablePanel.Controls.Add(this.grpNativeFields);
            this.ccScrollabablePanel.Controls.Add(this.grpState);
            this.ccScrollabablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ccScrollabablePanel.Location = new System.Drawing.Point(3, 3);
            this.ccScrollabablePanel.Name = "ccScrollabablePanel";
            this.ccScrollabablePanel.Size = new System.Drawing.Size(517, 656);
            this.ccScrollabablePanel.TabIndex = 10;
            // 
            // tpMappings
            // 
            this.tpMappings.Controls.Add(this.grpPriorityMappings);
            this.tpMappings.Controls.Add(this.grpProjectMappings);
            this.tpMappings.Location = new System.Drawing.Point(4, 22);
            this.tpMappings.Name = "tpMappings";
            this.tpMappings.Padding = new System.Windows.Forms.Padding(3);
            this.tpMappings.Size = new System.Drawing.Size(523, 662);
            this.tpMappings.TabIndex = 1;
            this.tpMappings.Text = "Project and Priority Mappings";
            this.tpMappings.UseVisualStyleBackColor = true;
            // 
            // grpPriorityMappings
            // 
            this.grpPriorityMappings.Controls.Add(this.btnDeletePriorityMapping);
            this.grpPriorityMappings.Controls.Add(this.grdPriorityMappings);
            this.grpPriorityMappings.Location = new System.Drawing.Point(6, 251);
            this.grpPriorityMappings.Name = "grpPriorityMappings";
            this.grpPriorityMappings.Size = new System.Drawing.Size(495, 236);
            this.grpPriorityMappings.TabIndex = 3;
            this.grpPriorityMappings.TabStop = false;
            this.grpPriorityMappings.Text = "Priority Mappings";
            // 
            // btnDeletePriorityMapping
            // 
            this.btnDeletePriorityMapping.Image = global::VersionOne.ServiceHost.ConfigurationTool.Resources.DeleteIcon;
            this.btnDeletePriorityMapping.Location = new System.Drawing.Point(322, 195);
            this.btnDeletePriorityMapping.Name = "btnDeletePriorityMapping";
            this.btnDeletePriorityMapping.Size = new System.Drawing.Size(132, 26);
            this.btnDeletePriorityMapping.TabIndex = 1;
            this.btnDeletePriorityMapping.Text = "Delete selected row";
            this.btnDeletePriorityMapping.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeletePriorityMapping.UseVisualStyleBackColor = true;
            // 
            // grdPriorityMappings
            // 
            this.grdPriorityMappings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPriorityMappings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVersionOnePriority,
            this.colClearQuestPriorityName});
            this.grdPriorityMappings.Location = new System.Drawing.Point(15, 20);
            this.grdPriorityMappings.MultiSelect = false;
            this.grdPriorityMappings.Name = "grdPriorityMappings";
            this.grdPriorityMappings.Size = new System.Drawing.Size(439, 169);
            this.grdPriorityMappings.TabIndex = 0;
            // 
            // colVersionOnePriority
            // 
            this.colVersionOnePriority.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colVersionOnePriority.DataPropertyName = "VersionOnePriorityId";
            this.colVersionOnePriority.HeaderText = "VersionOne Priority";
            this.colVersionOnePriority.MinimumWidth = 100;
            this.colVersionOnePriority.Name = "colVersionOnePriority";
            // 
            // colClearQuestPriorityName
            // 
            this.colClearQuestPriorityName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colClearQuestPriorityName.DataPropertyName = "ClearQuestPriorityName";
            this.colClearQuestPriorityName.HeaderText = "ClearQuest Priority";
            this.colClearQuestPriorityName.MinimumWidth = 100;
            this.colClearQuestPriorityName.Name = "colClearQuestPriorityName";
            // 
            // grpProjectMappings
            // 
            this.grpProjectMappings.Controls.Add(this.btnDeleteProjectMapping);
            this.grpProjectMappings.Controls.Add(this.grdProjectMappings);
            this.grpProjectMappings.Location = new System.Drawing.Point(6, 9);
            this.grpProjectMappings.Name = "grpProjectMappings";
            this.grpProjectMappings.Size = new System.Drawing.Size(495, 236);
            this.grpProjectMappings.TabIndex = 2;
            this.grpProjectMappings.TabStop = false;
            this.grpProjectMappings.Text = "Project Mappings";
            // 
            // btnDeleteProjectMapping
            // 
            this.btnDeleteProjectMapping.Image = global::VersionOne.ServiceHost.ConfigurationTool.Resources.DeleteIcon;
            this.btnDeleteProjectMapping.Location = new System.Drawing.Point(322, 195);
            this.btnDeleteProjectMapping.Name = "btnDeleteProjectMapping";
            this.btnDeleteProjectMapping.Size = new System.Drawing.Size(132, 26);
            this.btnDeleteProjectMapping.TabIndex = 1;
            this.btnDeleteProjectMapping.Text = "Delete selected row";
            this.btnDeleteProjectMapping.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteProjectMapping.UseVisualStyleBackColor = true;
            // 
            // grdProjectMappings
            // 
            this.grdProjectMappings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProjectMappings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVersionOneProjectId,
            this.colClearQuestProject});
            this.grdProjectMappings.Location = new System.Drawing.Point(15, 20);
            this.grdProjectMappings.MultiSelect = false;
            this.grdProjectMappings.Name = "grdProjectMappings";
            this.grdProjectMappings.Size = new System.Drawing.Size(439, 169);
            this.grdProjectMappings.TabIndex = 0;
            // 
            // colVersionOneProjectId
            // 
            this.colVersionOneProjectId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colVersionOneProjectId.DataPropertyName = "VersionOneProjectToken";
            this.colVersionOneProjectId.HeaderText = "VersionOne Project";
            this.colVersionOneProjectId.MinimumWidth = 100;
            this.colVersionOneProjectId.Name = "colVersionOneProjectId";
            // 
            // colClearQuestProject
            // 
            this.colClearQuestProject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colClearQuestProject.DataPropertyName = "ClearQuestProjectName";
            this.colClearQuestProject.HeaderText = "ClearQuest Project";
            this.colClearQuestProject.MinimumWidth = 100;
            this.colClearQuestProject.Name = "colClearQuestProject";
            // 
            // ClearQuestPageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.tcData);
            this.Controls.Add(this.chkDisable);
            this.Name = "ClearQuestPageControl";
            this.Size = new System.Drawing.Size(534, 716);
            this.grpConnection.ResumeLayout(false);
            this.grpConnection.PerformLayout();
            this.grpMandatoryFields.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMandatoryFields)).EndInit();
            this.grpState.ResumeLayout(false);
            this.grpState.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIntervalMinutes)).EndInit();
            this.grpNativeFields.ResumeLayout(false);
            this.grpNativeFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMandatoryFields)).EndInit();
            this.grpVersionOne.ResumeLayout(false);
            this.grpVersionOne.PerformLayout();
            this.tcData.ResumeLayout(false);
            this.tpSettings.ResumeLayout(false);
            this.ccScrollabablePanel.ResumeLayout(false);
            this.tpMappings.ResumeLayout(false);
            this.grpPriorityMappings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPriorityMappings)).EndInit();
            this.grpProjectMappings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProjectMappings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjectMappings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPriorityMappings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConnection;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtConnectionName;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.GroupBox grpMandatoryFields;
        private System.Windows.Forms.TextBox txtWaitedSubmit;
        private System.Windows.Forms.Label lblCloseAction;
        private System.Windows.Forms.Label lblSubmitedToState;
        private System.Windows.Forms.Label lblWaitedSubmitToV1State;
        private System.Windows.Forms.TextBox txtSubmitedToAction;
        private System.Windows.Forms.Label lblEntityType;
        private System.Windows.Forms.TextBox txtUrlTitle;
        private System.Windows.Forms.Label lblUrlTitle;
        private System.Windows.Forms.TextBox txtUrlTemplate;
        private System.Windows.Forms.Label lblUrlTempl;
        private System.Windows.Forms.TextBox txtSubmitedToState;
        private System.Windows.Forms.Label lblSubmitedToAction;
        private System.Windows.Forms.TextBox txtEntityType;
        private System.Windows.Forms.Label lblDefectTitle;
        private System.Windows.Forms.Label lblSourceFieldValue;
        private System.Windows.Forms.CheckBox chkDisable;
        private System.Windows.Forms.ComboBox cboSourceFieldValue;
        private System.Windows.Forms.Label lblConnectionValidation;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label lblFieldId;
        private System.Windows.Forms.TextBox txtCloseAction;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtOwnerLogin;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.TextBox txtFieldId;
        private System.Windows.Forms.TextBox txtDefectTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblOwnerLogin;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblModifyAction;
        private System.Windows.Forms.TextBox txtModifyAction;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.GroupBox grpState;
        private System.Windows.Forms.GroupBox grpNativeFields;
        private System.Windows.Forms.BindingSource bsMandatoryFields;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView grdMandatoryFields;
        private System.Windows.Forms.Label lblPollIntervalSuffix;
        private System.Windows.Forms.Label lblPollIntervalPrefix;
        private System.Windows.Forms.NumericUpDown numIntervalMinutes;
        private System.Windows.Forms.GroupBox grpVersionOne;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.TextBox txtPriorityField;
        private System.Windows.Forms.TabControl tcData;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.TabPage tpMappings;
        private System.Windows.Forms.GroupBox grpPriorityMappings;
        private System.Windows.Forms.Button btnDeletePriorityMapping;
        private System.Windows.Forms.DataGridView grdPriorityMappings;
        private System.Windows.Forms.GroupBox grpProjectMappings;
        private System.Windows.Forms.Button btnDeleteProjectMapping;
        private System.Windows.Forms.DataGridView grdProjectMappings;
        private System.Windows.Forms.BindingSource bsProjectMappings;
        private System.Windows.Forms.BindingSource bsPriorityMappings;
        private System.Windows.Forms.DataGridViewComboBoxColumn colVersionOnePriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClearQuestPriorityName;
        private System.Windows.Forms.DataGridViewComboBoxColumn colVersionOneProjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClearQuestProject;
        private System.Windows.Forms.ContainerControl ccScrollabablePanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
    }
}