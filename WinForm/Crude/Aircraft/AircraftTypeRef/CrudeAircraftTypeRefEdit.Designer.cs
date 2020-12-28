namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAircraftTypeRefEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private System.Windows.Forms.TextBox textBoxAircraftType;
        
        private System.Windows.Forms.Label labelAircraftType;
        
        private System.Windows.Forms.TextBox textBoxAircraftTypeName;
        
        private System.Windows.Forms.Label labelAircraftTypeName;
        
        private System.Windows.Forms.TextBox textBoxDescription;
        
        private System.Windows.Forms.Label labelDescription;
        
        private System.Windows.Forms.PictureBox pictureBoxAircraftFamilyImage;
        
        private System.Windows.Forms.Label labelAircraftFamilyImage;
        
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
            this.labelAircraftType = new System.Windows.Forms.Label();
            this.textBoxAircraftType = new System.Windows.Forms.TextBox();
            this.labelAircraftTypeName = new System.Windows.Forms.Label();
            this.textBoxAircraftTypeName = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelAircraftFamilyImage = new System.Windows.Forms.Label();
            this.pictureBoxAircraftFamilyImage = new System.Windows.Forms.PictureBox();
            this.labelActiveFlag = new System.Windows.Forms.Label();
            this.checkBoxActiveFlag = new System.Windows.Forms.CheckBox();
            this.labelSortOrder = new System.Windows.Forms.Label();
            this.maskedTextBoxSortOrder = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelAircraftType
            //
            this.labelAircraftType.AutoSize = true;
            this.labelAircraftType.Location = new System.Drawing.Point(11, 13);
            this.labelAircraftType.Name = "labelAircraftType";
            this.labelAircraftType.Size = new System.Drawing.Size(71, 13);
            this.labelAircraftType.TabIndex = 2;
            this.labelAircraftType.Text = "Aircraft Type:";
            //
            //textBoxAircraftType
            //
            this.textBoxAircraftType.Location = new System.Drawing.Point(147, 13);
            this.textBoxAircraftType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAircraftType.Name = "textBoxAircraftType";
            this.textBoxAircraftType.Size = new System.Drawing.Size(250, 20);
            this.textBoxAircraftType.TabIndex = 3;
            //
            // labelAircraftTypeName
            //
            this.labelAircraftTypeName.AutoSize = true;
            this.labelAircraftTypeName.Location = new System.Drawing.Point(11, 36);
            this.labelAircraftTypeName.Name = "labelAircraftTypeName";
            this.labelAircraftTypeName.Size = new System.Drawing.Size(71, 13);
            this.labelAircraftTypeName.TabIndex = 4;
            this.labelAircraftTypeName.Text = "Aircraft Type Name:";
            //
            //textBoxAircraftTypeName
            //
            this.textBoxAircraftTypeName.Location = new System.Drawing.Point(147, 36);
            this.textBoxAircraftTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAircraftTypeName.Name = "textBoxAircraftTypeName";
            this.textBoxAircraftTypeName.Size = new System.Drawing.Size(250, 20);
            this.textBoxAircraftTypeName.TabIndex = 5;
            //
            // labelDescription
            //
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(11, 59);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(71, 13);
            this.labelDescription.TabIndex = 6;
            this.labelDescription.Text = "Description:";
            //
            //textBoxDescription
            //
            this.textBoxDescription.Location = new System.Drawing.Point(147, 59);
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(250, 20);
            this.textBoxDescription.TabIndex = 7;
            //
            // labelAircraftFamilyImage
            //
            this.labelAircraftFamilyImage.AutoSize = true;
            this.labelAircraftFamilyImage.Location = new System.Drawing.Point(11, 82);
            this.labelAircraftFamilyImage.Name = "labelAircraftFamilyImage";
            this.labelAircraftFamilyImage.Size = new System.Drawing.Size(71, 13);
            this.labelAircraftFamilyImage.TabIndex = 8;
            this.labelAircraftFamilyImage.Text = "Aircraft Family Image:";
            //
            //pictureBoxAircraftFamilyImage
            //
            this.pictureBoxAircraftFamilyImage.Location = new System.Drawing.Point(147, 82);
            this.pictureBoxAircraftFamilyImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxAircraftFamilyImage.Name = "pictureBoxAircraftFamilyImage";
            this.pictureBoxAircraftFamilyImage.Size = new System.Drawing.Size(250, 20);
            this.pictureBoxAircraftFamilyImage.TabIndex = 9;
            //
            // labelActiveFlag
            //
            this.labelActiveFlag.AutoSize = true;
            this.labelActiveFlag.Location = new System.Drawing.Point(11, 105);
            this.labelActiveFlag.Name = "labelActiveFlag";
            this.labelActiveFlag.Size = new System.Drawing.Size(71, 13);
            this.labelActiveFlag.TabIndex = 10;
            this.labelActiveFlag.Text = "Active Flag:";
            //
            //checkBoxActiveFlag
            //
            this.checkBoxActiveFlag.Location = new System.Drawing.Point(147, 105);
            this.checkBoxActiveFlag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxActiveFlag.Name = "checkBoxActiveFlag";
            this.checkBoxActiveFlag.Size = new System.Drawing.Size(250, 20);
            this.checkBoxActiveFlag.TabIndex = 11;
            //
            // labelSortOrder
            //
            this.labelSortOrder.AutoSize = true;
            this.labelSortOrder.Location = new System.Drawing.Point(11, 128);
            this.labelSortOrder.Name = "labelSortOrder";
            this.labelSortOrder.Size = new System.Drawing.Size(71, 13);
            this.labelSortOrder.TabIndex = 12;
            this.labelSortOrder.Text = "Sort Order:";
            //
            //maskedTextBoxSortOrder
            //
            this.maskedTextBoxSortOrder.Location = new System.Drawing.Point(147, 128);
            this.maskedTextBoxSortOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxSortOrder.Name = "maskedTextBoxSortOrder";
            this.maskedTextBoxSortOrder.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxSortOrder.TabIndex = 13;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 151);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 14;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(147, 151);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 15;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(305, 174);
            
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
            this.buttonSave.Location = new System.Drawing.Point(205, 174);
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
            this.ClientSize = new System.Drawing.Size(409, 202);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeAircraftTypeRefEdit";
            this.Text = "Aircraft Type Ref Edit";
            this.Controls.Add(this.labelAircraftType);
            this.Controls.Add(this.textBoxAircraftType);
            this.Controls.Add(this.labelAircraftTypeName);
            this.Controls.Add(this.textBoxAircraftTypeName);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelAircraftFamilyImage);
            this.Controls.Add(this.pictureBoxAircraftFamilyImage);
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
