namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeServiceSpecialServiceRequestSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeServiceSpecialServiceRequestSearch;
        
        private System.Windows.Forms.Button buttonCrudeServiceSpecialServiceRequestAdd;
        
        private System.Windows.Forms.Button buttonCrudeServiceSpecialServiceRequestEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeServiceSpecialServiceRequest;
        
        private System.Windows.Forms.TextBox textBoxServiceSpecialServiceRequestName;
        
        private System.Windows.Forms.Label labelServiceSpecialServiceRequestName;
        
        private ServiceSpecialServiceRequestGroupRefCombo serviceSpecialServiceRequestGroupRefCombo;
        
        private System.Windows.Forms.Label labelServiceSpecialServiceRequestGroupRefCombo;
        
        private System.Windows.Forms.TextBox textBoxServiceSpecialServiceRequestCode;
        
        private System.Windows.Forms.Label labelServiceSpecialServiceRequestCode;
        
        private System.Windows.Forms.TextBox textBoxServiceDescription;
        
        private System.Windows.Forms.Label labelServiceDescription;
        
        private ServiceSpecialServiceRequestRequirementRefCombo requestServiceSpecialServiceRequestRequirementRefCombo;
        
        private System.Windows.Forms.Label labelRequestServiceSpecialServiceRequestRequirementRefCombo;
        
        private ServiceSpecialServiceRequestRequirementRefCombo replyServiceSpecialServiceRequestRequirementRefCombo;
        
        private System.Windows.Forms.Label labelReplyServiceSpecialServiceRequestRequirementRefCombo;
        
        private ServiceSpecialServiceRequestOperationRuleRefCombo serviceSpecialServiceRequestOperationRuleRefCombo;
        
        private System.Windows.Forms.Label labelServiceSpecialServiceRequestOperationRuleRefCombo;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAmount;
        
        private System.Windows.Forms.Label labelAmount;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private FinancialCurrencyPicker financialCurrencyPicker;
        
        private System.Windows.Forms.Label labelFinancialCurrencyPicker;
        
        private DefaultUserPicker userPicker;
        
        private System.Windows.Forms.Label labelUserPicker;
        
        private System.Windows.Forms.CheckBox checkBoxInventoryControlledFlag;
        
        private System.Windows.Forms.Label labelInventoryControlledFlag;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCrudeServiceSpecialServiceRequestAdd = new System.Windows.Forms.Button();
            this.buttonCrudeServiceSpecialServiceRequestEdit = new System.Windows.Forms.Button();
            this.buttonCrudeServiceSpecialServiceRequestSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeServiceSpecialServiceRequest = new System.Windows.Forms.DataGridView();
            this.labelServiceSpecialServiceRequestName = new System.Windows.Forms.Label();
            this.textBoxServiceSpecialServiceRequestName = new System.Windows.Forms.TextBox();
            this.labelServiceSpecialServiceRequestGroupRefCombo = new System.Windows.Forms.Label();
            this.serviceSpecialServiceRequestGroupRefCombo = new ServiceSpecialServiceRequestGroupRefCombo();
            this.labelServiceSpecialServiceRequestCode = new System.Windows.Forms.Label();
            this.textBoxServiceSpecialServiceRequestCode = new System.Windows.Forms.TextBox();
            this.labelServiceDescription = new System.Windows.Forms.Label();
            this.textBoxServiceDescription = new System.Windows.Forms.TextBox();
            this.labelRequestServiceSpecialServiceRequestRequirementRefCombo = new System.Windows.Forms.Label();
            this.requestServiceSpecialServiceRequestRequirementRefCombo = new ServiceSpecialServiceRequestRequirementRefCombo();
            this.labelReplyServiceSpecialServiceRequestRequirementRefCombo = new System.Windows.Forms.Label();
            this.replyServiceSpecialServiceRequestRequirementRefCombo = new ServiceSpecialServiceRequestRequirementRefCombo();
            this.labelServiceSpecialServiceRequestOperationRuleRefCombo = new System.Windows.Forms.Label();
            this.serviceSpecialServiceRequestOperationRuleRefCombo = new ServiceSpecialServiceRequestOperationRuleRefCombo();
            this.labelAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelFinancialCurrencyPicker = new System.Windows.Forms.Label();
            this.financialCurrencyPicker = new FinancialCurrencyPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelInventoryControlledFlag = new System.Windows.Forms.Label();
            this.checkBoxInventoryControlledFlag = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeServiceSpecialServiceRequest)).BeginInit();
            this.SuspendLayout();
            //
            // labelServiceSpecialServiceRequestName
            //
            this.labelServiceSpecialServiceRequestName.AutoSize = true;
            this.labelServiceSpecialServiceRequestName.Location = new System.Drawing.Point(11, 13);
            this.labelServiceSpecialServiceRequestName.Name = "labelServiceSpecialServiceRequestName";
            this.labelServiceSpecialServiceRequestName.Size = new System.Drawing.Size(71, 13);
            this.labelServiceSpecialServiceRequestName.TabIndex = 2;
            this.labelServiceSpecialServiceRequestName.Text = "Service Special Service Request Name:";
            //
            //textBoxServiceSpecialServiceRequestName
            //
            this.textBoxServiceSpecialServiceRequestName.Location = new System.Drawing.Point(357, 13);
            this.textBoxServiceSpecialServiceRequestName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServiceSpecialServiceRequestName.Name = "textBoxServiceSpecialServiceRequestName";
            this.textBoxServiceSpecialServiceRequestName.Size = new System.Drawing.Size(250, 20);
            this.textBoxServiceSpecialServiceRequestName.TabIndex = 3;
            //
            // labelServiceSpecialServiceRequestGroupRefCombo
            //
            this.labelServiceSpecialServiceRequestGroupRefCombo.AutoSize = true;
            this.labelServiceSpecialServiceRequestGroupRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelServiceSpecialServiceRequestGroupRefCombo.Name = "labelServiceSpecialServiceRequestGroupRefCombo";
            this.labelServiceSpecialServiceRequestGroupRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelServiceSpecialServiceRequestGroupRefCombo.TabIndex = 4;
            this.labelServiceSpecialServiceRequestGroupRefCombo.Text = "Service Special Service Request Group:";
            //
            //serviceSpecialServiceRequestGroupRefCombo
            //
            this.serviceSpecialServiceRequestGroupRefCombo.Location = new System.Drawing.Point(357, 36);
            this.serviceSpecialServiceRequestGroupRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceSpecialServiceRequestGroupRefCombo.Name = "serviceSpecialServiceRequestGroupRefCombo";
            this.serviceSpecialServiceRequestGroupRefCombo.Size = new System.Drawing.Size(250, 20);
            this.serviceSpecialServiceRequestGroupRefCombo.TabIndex = 5;
            //
            // labelServiceSpecialServiceRequestCode
            //
            this.labelServiceSpecialServiceRequestCode.AutoSize = true;
            this.labelServiceSpecialServiceRequestCode.Location = new System.Drawing.Point(11, 59);
            this.labelServiceSpecialServiceRequestCode.Name = "labelServiceSpecialServiceRequestCode";
            this.labelServiceSpecialServiceRequestCode.Size = new System.Drawing.Size(71, 13);
            this.labelServiceSpecialServiceRequestCode.TabIndex = 6;
            this.labelServiceSpecialServiceRequestCode.Text = "Service Special Service Request Code:";
            //
            //textBoxServiceSpecialServiceRequestCode
            //
            this.textBoxServiceSpecialServiceRequestCode.Location = new System.Drawing.Point(357, 59);
            this.textBoxServiceSpecialServiceRequestCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServiceSpecialServiceRequestCode.Name = "textBoxServiceSpecialServiceRequestCode";
            this.textBoxServiceSpecialServiceRequestCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxServiceSpecialServiceRequestCode.TabIndex = 7;
            //
            // labelServiceDescription
            //
            this.labelServiceDescription.AutoSize = true;
            this.labelServiceDescription.Location = new System.Drawing.Point(11, 82);
            this.labelServiceDescription.Name = "labelServiceDescription";
            this.labelServiceDescription.Size = new System.Drawing.Size(71, 13);
            this.labelServiceDescription.TabIndex = 8;
            this.labelServiceDescription.Text = "Service Description:";
            //
            //textBoxServiceDescription
            //
            this.textBoxServiceDescription.Location = new System.Drawing.Point(357, 82);
            this.textBoxServiceDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServiceDescription.Name = "textBoxServiceDescription";
            this.textBoxServiceDescription.Size = new System.Drawing.Size(250, 20);
            this.textBoxServiceDescription.TabIndex = 9;
            //
            // labelRequestServiceSpecialServiceRequestRequirementRefCombo
            //
            this.labelRequestServiceSpecialServiceRequestRequirementRefCombo.AutoSize = true;
            this.labelRequestServiceSpecialServiceRequestRequirementRefCombo.Location = new System.Drawing.Point(11, 105);
            this.labelRequestServiceSpecialServiceRequestRequirementRefCombo.Name = "labelRequestServiceSpecialServiceRequestRequirementRefCombo";
            this.labelRequestServiceSpecialServiceRequestRequirementRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelRequestServiceSpecialServiceRequestRequirementRefCombo.TabIndex = 10;
            this.labelRequestServiceSpecialServiceRequestRequirementRefCombo.Text = "Request Service Special Service Request Requirement:";
            //
            //requestServiceSpecialServiceRequestRequirementRefCombo
            //
            this.requestServiceSpecialServiceRequestRequirementRefCombo.Location = new System.Drawing.Point(357, 105);
            this.requestServiceSpecialServiceRequestRequirementRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.requestServiceSpecialServiceRequestRequirementRefCombo.Name = "requestServiceSpecialServiceRequestRequirementRefCombo";
            this.requestServiceSpecialServiceRequestRequirementRefCombo.Size = new System.Drawing.Size(250, 20);
            this.requestServiceSpecialServiceRequestRequirementRefCombo.TabIndex = 11;
            //
            // labelReplyServiceSpecialServiceRequestRequirementRefCombo
            //
            this.labelReplyServiceSpecialServiceRequestRequirementRefCombo.AutoSize = true;
            this.labelReplyServiceSpecialServiceRequestRequirementRefCombo.Location = new System.Drawing.Point(11, 128);
            this.labelReplyServiceSpecialServiceRequestRequirementRefCombo.Name = "labelReplyServiceSpecialServiceRequestRequirementRefCombo";
            this.labelReplyServiceSpecialServiceRequestRequirementRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelReplyServiceSpecialServiceRequestRequirementRefCombo.TabIndex = 12;
            this.labelReplyServiceSpecialServiceRequestRequirementRefCombo.Text = "Reply Service Special Service Request Requirement:";
            //
            //replyServiceSpecialServiceRequestRequirementRefCombo
            //
            this.replyServiceSpecialServiceRequestRequirementRefCombo.Location = new System.Drawing.Point(357, 128);
            this.replyServiceSpecialServiceRequestRequirementRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.replyServiceSpecialServiceRequestRequirementRefCombo.Name = "replyServiceSpecialServiceRequestRequirementRefCombo";
            this.replyServiceSpecialServiceRequestRequirementRefCombo.Size = new System.Drawing.Size(250, 20);
            this.replyServiceSpecialServiceRequestRequirementRefCombo.TabIndex = 13;
            //
            // labelServiceSpecialServiceRequestOperationRuleRefCombo
            //
            this.labelServiceSpecialServiceRequestOperationRuleRefCombo.AutoSize = true;
            this.labelServiceSpecialServiceRequestOperationRuleRefCombo.Location = new System.Drawing.Point(11, 151);
            this.labelServiceSpecialServiceRequestOperationRuleRefCombo.Name = "labelServiceSpecialServiceRequestOperationRuleRefCombo";
            this.labelServiceSpecialServiceRequestOperationRuleRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelServiceSpecialServiceRequestOperationRuleRefCombo.TabIndex = 14;
            this.labelServiceSpecialServiceRequestOperationRuleRefCombo.Text = "Service Special Service Request Operation Rule:";
            //
            //serviceSpecialServiceRequestOperationRuleRefCombo
            //
            this.serviceSpecialServiceRequestOperationRuleRefCombo.Location = new System.Drawing.Point(357, 151);
            this.serviceSpecialServiceRequestOperationRuleRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceSpecialServiceRequestOperationRuleRefCombo.Name = "serviceSpecialServiceRequestOperationRuleRefCombo";
            this.serviceSpecialServiceRequestOperationRuleRefCombo.Size = new System.Drawing.Size(250, 20);
            this.serviceSpecialServiceRequestOperationRuleRefCombo.TabIndex = 15;
            //
            // labelAmount
            //
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(11, 174);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(71, 13);
            this.labelAmount.TabIndex = 16;
            this.labelAmount.Text = "Amount:";
            //
            //maskedTextBoxAmount
            //
            this.maskedTextBoxAmount.Location = new System.Drawing.Point(357, 174);
            this.maskedTextBoxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxAmount.Name = "maskedTextBoxAmount";
            this.maskedTextBoxAmount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxAmount.TabIndex = 17;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 197);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 18;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(357, 197);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 19;
            //
            // labelFinancialCurrencyPicker
            //
            this.labelFinancialCurrencyPicker.AutoSize = true;
            this.labelFinancialCurrencyPicker.Location = new System.Drawing.Point(11, 220);
            this.labelFinancialCurrencyPicker.Name = "labelFinancialCurrencyPicker";
            this.labelFinancialCurrencyPicker.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCurrencyPicker.TabIndex = 20;
            this.labelFinancialCurrencyPicker.Text = "Financial Currency:";
            //
            //financialCurrencyPicker
            //
            this.financialCurrencyPicker.Location = new System.Drawing.Point(357, 220);
            this.financialCurrencyPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialCurrencyPicker.Name = "financialCurrencyPicker";
            this.financialCurrencyPicker.Size = new System.Drawing.Size(250, 20);
            this.financialCurrencyPicker.TabIndex = 21;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 243);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 22;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(357, 243);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 23;
            //
            // labelInventoryControlledFlag
            //
            this.labelInventoryControlledFlag.AutoSize = true;
            this.labelInventoryControlledFlag.Location = new System.Drawing.Point(11, 266);
            this.labelInventoryControlledFlag.Name = "labelInventoryControlledFlag";
            this.labelInventoryControlledFlag.Size = new System.Drawing.Size(71, 13);
            this.labelInventoryControlledFlag.TabIndex = 24;
            this.labelInventoryControlledFlag.Text = "Inventory Controlled Flag:";
            //
            //checkBoxInventoryControlledFlag
            //
            this.checkBoxInventoryControlledFlag.Location = new System.Drawing.Point(357, 266);
            this.checkBoxInventoryControlledFlag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxInventoryControlledFlag.Name = "checkBoxInventoryControlledFlag";
            this.checkBoxInventoryControlledFlag.Size = new System.Drawing.Size(250, 20);
            this.checkBoxInventoryControlledFlag.TabIndex = 25;
            // 
            // dataGridViewCrudeServiceSpecialServiceRequest
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeServiceSpecialServiceRequest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeServiceSpecialServiceRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeServiceSpecialServiceRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeServiceSpecialServiceRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeServiceSpecialServiceRequest.Location = new System.Drawing.Point(12, 299);
            this.dataGridViewCrudeServiceSpecialServiceRequest.Name = "dataGridViewCrudeServiceSpecialServiceRequest";
            this.dataGridViewCrudeServiceSpecialServiceRequest.Size = new System.Drawing.Size(595, 96);
            this.dataGridViewCrudeServiceSpecialServiceRequest.TabIndex = 0;
            this.dataGridViewCrudeServiceSpecialServiceRequest.ReadOnly = true;
            this.dataGridViewCrudeServiceSpecialServiceRequest.DoubleClick += new System.EventHandler(this.dataGridViewCrudeServiceSpecialServiceRequest_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(515, 402);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeServiceSpecialServiceRequestSearch
            // 
            this.buttonCrudeServiceSpecialServiceRequestSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceSpecialServiceRequestSearch.Location = new System.Drawing.Point(415, 402);
            this.buttonCrudeServiceSpecialServiceRequestSearch.Name = "buttonCrudeServiceSpecialServiceRequestSearch";
            this.buttonCrudeServiceSpecialServiceRequestSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceSpecialServiceRequestSearch.TabIndex = 2;
            this.buttonCrudeServiceSpecialServiceRequestSearch.Text = "&Search";
            this.buttonCrudeServiceSpecialServiceRequestSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceSpecialServiceRequestSearch.Click += new System.EventHandler(this.buttonCrudeServiceSpecialServiceRequestSearch_Click);
            // 
            // buttonCrudeServiceSpecialServiceRequestAdd
            // 
            this.buttonCrudeServiceSpecialServiceRequestAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceSpecialServiceRequestAdd.Location = new System.Drawing.Point(315, 402);
            this.buttonCrudeServiceSpecialServiceRequestAdd.Name = "buttonCrudeServiceSpecialServiceRequestAdd";
            this.buttonCrudeServiceSpecialServiceRequestAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceSpecialServiceRequestAdd.TabIndex = 3;
            this.buttonCrudeServiceSpecialServiceRequestAdd.Text = "&Add";
            this.buttonCrudeServiceSpecialServiceRequestAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceSpecialServiceRequestAdd.Click += new System.EventHandler(this.buttonCrudeServiceSpecialServiceRequestAdd_Click);
            // 
            // buttonCrudeServiceSpecialServiceRequestEdit
            // 
            this.buttonCrudeServiceSpecialServiceRequestEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceSpecialServiceRequestEdit.Location = new System.Drawing.Point(215, 402);
            this.buttonCrudeServiceSpecialServiceRequestEdit.Name = "buttonCrudeServiceSpecialServiceRequestEdit";
            this.buttonCrudeServiceSpecialServiceRequestEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceSpecialServiceRequestEdit.TabIndex = 4;
            this.buttonCrudeServiceSpecialServiceRequestEdit.Text = "&Edit";
            this.buttonCrudeServiceSpecialServiceRequestEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceSpecialServiceRequestEdit.Click += new System.EventHandler(this.buttonCrudeServiceSpecialServiceRequestEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 430);
            this.Controls.Add(this.buttonCrudeServiceSpecialServiceRequestSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeServiceSpecialServiceRequestAdd);
            this.Controls.Add(this.buttonCrudeServiceSpecialServiceRequestEdit);
            this.Controls.Add(this.dataGridViewCrudeServiceSpecialServiceRequest);
            this.Name = "CrudeServiceSpecialServiceRequestSearch";
            this.Text = "Service Special Service Request Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeServiceSpecialServiceRequest)).EndInit();
            this.Controls.Add(this.labelServiceSpecialServiceRequestName);
            this.Controls.Add(this.textBoxServiceSpecialServiceRequestName);
            this.Controls.Add(this.labelServiceSpecialServiceRequestGroupRefCombo);
            this.Controls.Add(this.serviceSpecialServiceRequestGroupRefCombo);
            this.Controls.Add(this.labelServiceSpecialServiceRequestCode);
            this.Controls.Add(this.textBoxServiceSpecialServiceRequestCode);
            this.Controls.Add(this.labelServiceDescription);
            this.Controls.Add(this.textBoxServiceDescription);
            this.Controls.Add(this.labelRequestServiceSpecialServiceRequestRequirementRefCombo);
            this.Controls.Add(this.requestServiceSpecialServiceRequestRequirementRefCombo);
            this.Controls.Add(this.labelReplyServiceSpecialServiceRequestRequirementRefCombo);
            this.Controls.Add(this.replyServiceSpecialServiceRequestRequirementRefCombo);
            this.Controls.Add(this.labelServiceSpecialServiceRequestOperationRuleRefCombo);
            this.Controls.Add(this.serviceSpecialServiceRequestOperationRuleRefCombo);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.maskedTextBoxAmount);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelFinancialCurrencyPicker);
            this.Controls.Add(this.financialCurrencyPicker);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelInventoryControlledFlag);
            this.Controls.Add(this.checkBoxInventoryControlledFlag);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
