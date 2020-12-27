namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeServiceCarRentalLinkEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private ServiceCarRentalPicker serviceCarRentalPicker;
        
        private System.Windows.Forms.Label labelServiceCarRentalPicker;
        
        private LinkTypeRefCombo linkTypeRefCombo;
        
        private System.Windows.Forms.Label labelLinkTypeRefCombo;
        
        private DefaultUserPicker userPicker;
        
        private System.Windows.Forms.Label labelUserPicker;
        
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
            this.labelServiceCarRentalPicker = new System.Windows.Forms.Label();
            this.serviceCarRentalPicker = new ServiceCarRentalPicker();
            this.labelLinkTypeRefCombo = new System.Windows.Forms.Label();
            this.linkTypeRefCombo = new LinkTypeRefCombo();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelServiceCarRentalPicker
            //
            this.labelServiceCarRentalPicker.AutoSize = true;
            this.labelServiceCarRentalPicker.Location = new System.Drawing.Point(11, 13);
            this.labelServiceCarRentalPicker.Name = "labelServiceCarRentalPicker";
            this.labelServiceCarRentalPicker.Size = new System.Drawing.Size(71, 13);
            this.labelServiceCarRentalPicker.TabIndex = 2;
            this.labelServiceCarRentalPicker.Text = "Service Car Rental:";
            //
            //serviceCarRentalPicker
            //
            this.serviceCarRentalPicker.Location = new System.Drawing.Point(140, 13);
            this.serviceCarRentalPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceCarRentalPicker.Name = "serviceCarRentalPicker";
            this.serviceCarRentalPicker.Size = new System.Drawing.Size(250, 20);
            this.serviceCarRentalPicker.TabIndex = 3;
            //
            // labelLinkTypeRefCombo
            //
            this.labelLinkTypeRefCombo.AutoSize = true;
            this.labelLinkTypeRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelLinkTypeRefCombo.Name = "labelLinkTypeRefCombo";
            this.labelLinkTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelLinkTypeRefCombo.TabIndex = 4;
            this.labelLinkTypeRefCombo.Text = "Link Type:";
            //
            //linkTypeRefCombo
            //
            this.linkTypeRefCombo.Location = new System.Drawing.Point(140, 36);
            this.linkTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.linkTypeRefCombo.Name = "linkTypeRefCombo";
            this.linkTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.linkTypeRefCombo.TabIndex = 5;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 59);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 6;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(140, 59);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 7;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 82);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 8;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 82);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 105);
            
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
            this.buttonSave.Location = new System.Drawing.Point(198, 105);
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
            this.ClientSize = new System.Drawing.Size(402, 133);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeServiceCarRentalLinkEdit";
            this.Text = "Service Car Rental Link Edit";
            this.Controls.Add(this.labelServiceCarRentalPicker);
            this.Controls.Add(this.serviceCarRentalPicker);
            this.Controls.Add(this.labelLinkTypeRefCombo);
            this.Controls.Add(this.linkTypeRefCombo);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
