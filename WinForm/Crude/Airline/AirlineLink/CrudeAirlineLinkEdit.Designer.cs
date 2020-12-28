namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAirlineLinkEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private AirlinePicker airlinePicker;
        
        private System.Windows.Forms.Label labelAirlinePicker;
        
        private LinkTypeRefCombo linkTypeRefCombo;
        
        private System.Windows.Forms.Label labelLinkTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxLinkName;
        
        private System.Windows.Forms.Label labelLinkName;
        
        private System.Windows.Forms.TextBox textBoxLink;
        
        private System.Windows.Forms.Label labelLink;
        
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
            this.labelAirlinePicker = new System.Windows.Forms.Label();
            this.airlinePicker = new AirlinePicker();
            this.labelLinkTypeRefCombo = new System.Windows.Forms.Label();
            this.linkTypeRefCombo = new LinkTypeRefCombo();
            this.labelLinkName = new System.Windows.Forms.Label();
            this.textBoxLinkName = new System.Windows.Forms.TextBox();
            this.labelLink = new System.Windows.Forms.Label();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            //
            // labelAirlinePicker
            //
            this.labelAirlinePicker.AutoSize = true;
            this.labelAirlinePicker.Location = new System.Drawing.Point(11, 13);
            this.labelAirlinePicker.Name = "labelAirlinePicker";
            this.labelAirlinePicker.Size = new System.Drawing.Size(71, 13);
            this.labelAirlinePicker.TabIndex = 2;
            this.labelAirlinePicker.Text = "Airline:";
            //
            //airlinePicker
            //
            this.airlinePicker.Location = new System.Drawing.Point(140, 13);
            this.airlinePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.airlinePicker.Name = "airlinePicker";
            this.airlinePicker.Size = new System.Drawing.Size(250, 20);
            this.airlinePicker.TabIndex = 3;
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
            // labelLinkName
            //
            this.labelLinkName.AutoSize = true;
            this.labelLinkName.Location = new System.Drawing.Point(11, 59);
            this.labelLinkName.Name = "labelLinkName";
            this.labelLinkName.Size = new System.Drawing.Size(71, 13);
            this.labelLinkName.TabIndex = 6;
            this.labelLinkName.Text = "Link Name:";
            //
            //textBoxLinkName
            //
            this.textBoxLinkName.Location = new System.Drawing.Point(140, 59);
            this.textBoxLinkName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLinkName.Name = "textBoxLinkName";
            this.textBoxLinkName.Size = new System.Drawing.Size(250, 20);
            this.textBoxLinkName.TabIndex = 7;
            //
            // labelLink
            //
            this.labelLink.AutoSize = true;
            this.labelLink.Location = new System.Drawing.Point(11, 82);
            this.labelLink.Name = "labelLink";
            this.labelLink.Size = new System.Drawing.Size(71, 13);
            this.labelLink.TabIndex = 8;
            this.labelLink.Text = "Link:";
            //
            //textBoxLink
            //
            this.textBoxLink.Location = new System.Drawing.Point(140, 82);
            this.textBoxLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(250, 20);
            this.textBoxLink.TabIndex = 9;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 105);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 10;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(140, 105);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 11;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 128);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 12;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 128);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 13;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 151);
            
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
            this.buttonSave.Location = new System.Drawing.Point(198, 151);
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
            this.ClientSize = new System.Drawing.Size(402, 179);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Name = "CrudeAirlineLinkEdit";
            this.Text = "Airline Link Edit";
            this.Controls.Add(this.labelAirlinePicker);
            this.Controls.Add(this.airlinePicker);
            this.Controls.Add(this.labelLinkTypeRefCombo);
            this.Controls.Add(this.linkTypeRefCombo);
            this.Controls.Add(this.labelLinkName);
            this.Controls.Add(this.textBoxLinkName);
            this.Controls.Add(this.labelLink);
            this.Controls.Add(this.textBoxLink);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
