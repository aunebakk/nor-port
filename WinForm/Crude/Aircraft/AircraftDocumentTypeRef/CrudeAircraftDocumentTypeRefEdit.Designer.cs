namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAircraftDocumentTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxAircraftDocumentType;
        
        private System.Windows.Forms.Label labelAircraftDocumentType;
        
        private System.Windows.Forms.TextBox textBoxAircraftDocumentTypeName;
        
        private System.Windows.Forms.Label labelAircraftDocumentTypeName;
        
        private System.Windows.Forms.CheckBox checkBoxActiveFlag;
        
        private System.Windows.Forms.Label labelActiveFlag;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSortOrder;
        
        private System.Windows.Forms.Label labelSortOrder;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelAircraftDocumentType = new System.Windows.Forms.Label();
            this.textBoxAircraftDocumentType = new System.Windows.Forms.TextBox();
            this.labelAircraftDocumentTypeName = new System.Windows.Forms.Label();
            this.textBoxAircraftDocumentTypeName = new System.Windows.Forms.TextBox();
            this.labelActiveFlag = new System.Windows.Forms.Label();
            this.checkBoxActiveFlag = new System.Windows.Forms.CheckBox();
            this.labelSortOrder = new System.Windows.Forms.Label();
            this.maskedTextBoxSortOrder = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelAircraftDocumentType
            //
            this.labelAircraftDocumentType.AutoSize = true;
            this.labelAircraftDocumentType.Location = new System.Drawing.Point(11, 13);
            this.labelAircraftDocumentType.Name = "labelAircraftDocumentType";
            this.labelAircraftDocumentType.Size = new System.Drawing.Size(71, 13);
            this.labelAircraftDocumentType.TabIndex = 2;
            this.labelAircraftDocumentType.Text = "Aircraft Document Type:";
            //
            //textBoxAircraftDocumentType
            //
            this.textBoxAircraftDocumentType.Location = new System.Drawing.Point(189, 13);
            this.textBoxAircraftDocumentType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAircraftDocumentType.Name = "textBoxAircraftDocumentType";
            this.textBoxAircraftDocumentType.Size = new System.Drawing.Size(250, 20);
            this.textBoxAircraftDocumentType.TabIndex = 3;
            //
            // labelAircraftDocumentTypeName
            //
            this.labelAircraftDocumentTypeName.AutoSize = true;
            this.labelAircraftDocumentTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelAircraftDocumentTypeName.Name = "labelAircraftDocumentTypeName";
            this.labelAircraftDocumentTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelAircraftDocumentTypeName.TabIndex = 4;
            this.labelAircraftDocumentTypeName.Text = "Aircraft Document Type Name:";
            //
            //textBoxAircraftDocumentTypeName
            //
            this.textBoxAircraftDocumentTypeName.Location = new System.Drawing.Point(189, 36);
            this.textBoxAircraftDocumentTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAircraftDocumentTypeName.Name = "textBoxAircraftDocumentTypeName";
            this.textBoxAircraftDocumentTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxAircraftDocumentTypeName.TabIndex = 5;
            //
            // labelActiveFlag
            //
            this.labelActiveFlag.AutoSize = true;
            this.labelActiveFlag.Location = new System.Drawing.Point(11, 59);
            this.labelActiveFlag.Name = "labelActiveFlag";
            this.labelActiveFlag.Size = new System.Drawing.Size(71, 13);
            this.labelActiveFlag.TabIndex = 6;
            this.labelActiveFlag.Text = "Active Flag:";
            //
            //checkBoxActiveFlag
            //
            this.checkBoxActiveFlag.Location = new System.Drawing.Point(189, 59);
            this.checkBoxActiveFlag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxActiveFlag.Name = "checkBoxActiveFlag";
            this.checkBoxActiveFlag.Size = new System.Drawing.Size(250, 20);
            this.checkBoxActiveFlag.TabIndex = 7;
            //
            // labelSortOrder
            //
            this.labelSortOrder.AutoSize = true;
            this.labelSortOrder.Location = new System.Drawing.Point(11, 82);
            this.labelSortOrder.Name = "labelSortOrder";
            this.labelSortOrder.Size = new System.Drawing.Size(71, 13);
            this.labelSortOrder.TabIndex = 8;
            this.labelSortOrder.Text = "Sort Order:";
            //
            //maskedTextBoxSortOrder
            //
            this.maskedTextBoxSortOrder.Location = new System.Drawing.Point(189, 82);
            this.maskedTextBoxSortOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxSortOrder.Name = "maskedTextBoxSortOrder";
            this.maskedTextBoxSortOrder.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxSortOrder.TabIndex = 9;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 105);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 10;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(189, 105);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 11;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(347, 128);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(247, 128);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(92, 22);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // EditForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 156);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeAircraftDocumentTypeRefEdit";
            this.Text = "Aircraft Document Type Ref Edit";
            this.Controls.Add(this.labelAircraftDocumentType);
            this.Controls.Add(this.textBoxAircraftDocumentType);
            this.Controls.Add(this.labelAircraftDocumentTypeName);
            this.Controls.Add(this.textBoxAircraftDocumentTypeName);
            this.Controls.Add(this.labelActiveFlag);
            this.Controls.Add(this.checkBoxActiveFlag);
            this.Controls.Add(this.labelSortOrder);
            this.Controls.Add(this.maskedTextBoxSortOrder);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
