namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAirlineLinkSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeAirlineLinkSearch;
        
        private System.Windows.Forms.Button buttonCrudeAirlineLinkAdd;
        
        private System.Windows.Forms.Button buttonCrudeAirlineLinkEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeAirlineLink;
        
        private System.Windows.Forms.TextBox textBoxLinkName;
        
        private System.Windows.Forms.Label labelLinkName;
        
        private LinkTypeRefCombo linkTypeRefCombo;
        
        private System.Windows.Forms.Label labelLinkTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxLink;
        
        private System.Windows.Forms.Label labelLink;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private AirlinePicker airlinePicker;
        
        private System.Windows.Forms.Label labelAirlinePicker;
        
        private DefaultUserPicker userPicker;
        
        private System.Windows.Forms.Label labelUserPicker;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCrudeAirlineLinkAdd = new System.Windows.Forms.Button();
            this.buttonCrudeAirlineLinkEdit = new System.Windows.Forms.Button();
            this.buttonCrudeAirlineLinkSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeAirlineLink = new System.Windows.Forms.DataGridView();
            this.labelLinkName = new System.Windows.Forms.Label();
            this.textBoxLinkName = new System.Windows.Forms.TextBox();
            this.labelLinkTypeRefCombo = new System.Windows.Forms.Label();
            this.linkTypeRefCombo = new LinkTypeRefCombo();
            this.labelLink = new System.Windows.Forms.Label();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelAirlinePicker = new System.Windows.Forms.Label();
            this.airlinePicker = new AirlinePicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirlineLink)).BeginInit();
            this.SuspendLayout();
            //
            // labelLinkName
            //
            this.labelLinkName.AutoSize = true;
            this.labelLinkName.Location = new System.Drawing.Point(11, 13);
            this.labelLinkName.Name = "labelLinkName";
            this.labelLinkName.Size = new System.Drawing.Size(71, 13);
            this.labelLinkName.TabIndex = 2;
            this.labelLinkName.Text = "Link Name:";
            //
            //textBoxLinkName
            //
            this.textBoxLinkName.Location = new System.Drawing.Point(140, 13);
            this.textBoxLinkName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLinkName.Name = "textBoxLinkName";
            this.textBoxLinkName.Size = new System.Drawing.Size(250, 20);
            this.textBoxLinkName.TabIndex = 3;
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
            // labelLink
            //
            this.labelLink.AutoSize = true;
            this.labelLink.Location = new System.Drawing.Point(11, 59);
            this.labelLink.Name = "labelLink";
            this.labelLink.Size = new System.Drawing.Size(71, 13);
            this.labelLink.TabIndex = 6;
            this.labelLink.Text = "Link:";
            //
            //textBoxLink
            //
            this.textBoxLink.Location = new System.Drawing.Point(140, 59);
            this.textBoxLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(250, 20);
            this.textBoxLink.TabIndex = 7;
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
            // labelAirlinePicker
            //
            this.labelAirlinePicker.AutoSize = true;
            this.labelAirlinePicker.Location = new System.Drawing.Point(11, 105);
            this.labelAirlinePicker.Name = "labelAirlinePicker";
            this.labelAirlinePicker.Size = new System.Drawing.Size(71, 13);
            this.labelAirlinePicker.TabIndex = 10;
            this.labelAirlinePicker.Text = "Airline:";
            //
            //airlinePicker
            //
            this.airlinePicker.Location = new System.Drawing.Point(140, 105);
            this.airlinePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.airlinePicker.Name = "airlinePicker";
            this.airlinePicker.Size = new System.Drawing.Size(250, 20);
            this.airlinePicker.TabIndex = 11;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 128);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 12;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(140, 128);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 13;
            // 
            // dataGridViewCrudeAirlineLink
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeAirlineLink.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeAirlineLink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeAirlineLink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeAirlineLink.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeAirlineLink.Location = new System.Drawing.Point(12, 161);
            this.dataGridViewCrudeAirlineLink.Name = "dataGridViewCrudeAirlineLink";
            this.dataGridViewCrudeAirlineLink.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeAirlineLink.TabIndex = 0;
            this.dataGridViewCrudeAirlineLink.ReadOnly = true;
            this.dataGridViewCrudeAirlineLink.DoubleClick += new System.EventHandler(this.dataGridViewCrudeAirlineLink_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 264);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeAirlineLinkSearch
            // 
            this.buttonCrudeAirlineLinkSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirlineLinkSearch.Location = new System.Drawing.Point(198, 264);
            this.buttonCrudeAirlineLinkSearch.Name = "buttonCrudeAirlineLinkSearch";
            this.buttonCrudeAirlineLinkSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirlineLinkSearch.TabIndex = 2;
            this.buttonCrudeAirlineLinkSearch.Text = "&Search";
            this.buttonCrudeAirlineLinkSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeAirlineLinkSearch.Click += new System.EventHandler(this.buttonCrudeAirlineLinkSearch_Click);
            // 
            // buttonCrudeAirlineLinkAdd
            // 
            this.buttonCrudeAirlineLinkAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirlineLinkAdd.Location = new System.Drawing.Point(98, 264);
            this.buttonCrudeAirlineLinkAdd.Name = "buttonCrudeAirlineLinkAdd";
            this.buttonCrudeAirlineLinkAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirlineLinkAdd.TabIndex = 3;
            this.buttonCrudeAirlineLinkAdd.Text = "&Add";
            this.buttonCrudeAirlineLinkAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeAirlineLinkAdd.Click += new System.EventHandler(this.buttonCrudeAirlineLinkAdd_Click);
            // 
            // buttonCrudeAirlineLinkEdit
            // 
            this.buttonCrudeAirlineLinkEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirlineLinkEdit.Location = new System.Drawing.Point(-2, 264);
            this.buttonCrudeAirlineLinkEdit.Name = "buttonCrudeAirlineLinkEdit";
            this.buttonCrudeAirlineLinkEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirlineLinkEdit.TabIndex = 4;
            this.buttonCrudeAirlineLinkEdit.Text = "&Edit";
            this.buttonCrudeAirlineLinkEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeAirlineLinkEdit.Click += new System.EventHandler(this.buttonCrudeAirlineLinkEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 292);
            this.Controls.Add(this.buttonCrudeAirlineLinkSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeAirlineLinkAdd);
            this.Controls.Add(this.buttonCrudeAirlineLinkEdit);
            this.Controls.Add(this.dataGridViewCrudeAirlineLink);
            this.Name = "CrudeAirlineLinkSearch";
            this.Text = "Airline Link Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirlineLink)).EndInit();
            this.Controls.Add(this.labelLinkName);
            this.Controls.Add(this.textBoxLinkName);
            this.Controls.Add(this.labelLinkTypeRefCombo);
            this.Controls.Add(this.linkTypeRefCombo);
            this.Controls.Add(this.labelLink);
            this.Controls.Add(this.textBoxLink);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelAirlinePicker);
            this.Controls.Add(this.airlinePicker);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
