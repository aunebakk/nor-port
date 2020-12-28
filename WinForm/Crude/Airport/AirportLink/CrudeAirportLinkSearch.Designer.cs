namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAirportLinkSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeAirportLinkSearch;
        
        private System.Windows.Forms.Button buttonCrudeAirportLinkAdd;
        
        private System.Windows.Forms.Button buttonCrudeAirportLinkEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeAirportLink;
        
        private LinkTypeRefCombo linkTypeRefCombo;
        
        private System.Windows.Forms.Label labelLinkTypeRefCombo;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private AirportPicker airportPicker;
        
        private System.Windows.Forms.Label labelAirportPicker;
        
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
            this.buttonCrudeAirportLinkAdd = new System.Windows.Forms.Button();
            this.buttonCrudeAirportLinkEdit = new System.Windows.Forms.Button();
            this.buttonCrudeAirportLinkSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeAirportLink = new System.Windows.Forms.DataGridView();
            this.labelLinkTypeRefCombo = new System.Windows.Forms.Label();
            this.linkTypeRefCombo = new LinkTypeRefCombo();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelAirportPicker = new System.Windows.Forms.Label();
            this.airportPicker = new AirportPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirportLink)).BeginInit();
            this.SuspendLayout();
            //
            // labelLinkTypeRefCombo
            //
            this.labelLinkTypeRefCombo.AutoSize = true;
            this.labelLinkTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelLinkTypeRefCombo.Name = "labelLinkTypeRefCombo";
            this.labelLinkTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelLinkTypeRefCombo.TabIndex = 2;
            this.labelLinkTypeRefCombo.Text = "Link Type:";
            //
            //linkTypeRefCombo
            //
            this.linkTypeRefCombo.Location = new System.Drawing.Point(140, 13);
            this.linkTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.linkTypeRefCombo.Name = "linkTypeRefCombo";
            this.linkTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.linkTypeRefCombo.TabIndex = 3;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 36);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 4;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 36);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 5;
            //
            // labelAirportPicker
            //
            this.labelAirportPicker.AutoSize = true;
            this.labelAirportPicker.Location = new System.Drawing.Point(11, 59);
            this.labelAirportPicker.Name = "labelAirportPicker";
            this.labelAirportPicker.Size = new System.Drawing.Size(71, 13);
            this.labelAirportPicker.TabIndex = 6;
            this.labelAirportPicker.Text = "Airport:";
            //
            //airportPicker
            //
            this.airportPicker.Location = new System.Drawing.Point(140, 59);
            this.airportPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.airportPicker.Name = "airportPicker";
            this.airportPicker.Size = new System.Drawing.Size(250, 20);
            this.airportPicker.TabIndex = 7;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 82);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 8;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(140, 82);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 9;
            // 
            // dataGridViewCrudeAirportLink
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeAirportLink.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeAirportLink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeAirportLink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeAirportLink.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeAirportLink.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeAirportLink.Name = "dataGridViewCrudeAirportLink";
            this.dataGridViewCrudeAirportLink.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeAirportLink.TabIndex = 0;
            this.dataGridViewCrudeAirportLink.ReadOnly = true;
            this.dataGridViewCrudeAirportLink.DoubleClick += new System.EventHandler(this.dataGridViewCrudeAirportLink_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 218);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeAirportLinkSearch
            // 
            this.buttonCrudeAirportLinkSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportLinkSearch.Location = new System.Drawing.Point(198, 218);
            this.buttonCrudeAirportLinkSearch.Name = "buttonCrudeAirportLinkSearch";
            this.buttonCrudeAirportLinkSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportLinkSearch.TabIndex = 2;
            this.buttonCrudeAirportLinkSearch.Text = "&Search";
            this.buttonCrudeAirportLinkSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportLinkSearch.Click += new System.EventHandler(this.buttonCrudeAirportLinkSearch_Click);
            // 
            // buttonCrudeAirportLinkAdd
            // 
            this.buttonCrudeAirportLinkAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportLinkAdd.Location = new System.Drawing.Point(98, 218);
            this.buttonCrudeAirportLinkAdd.Name = "buttonCrudeAirportLinkAdd";
            this.buttonCrudeAirportLinkAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportLinkAdd.TabIndex = 3;
            this.buttonCrudeAirportLinkAdd.Text = "&Add";
            this.buttonCrudeAirportLinkAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportLinkAdd.Click += new System.EventHandler(this.buttonCrudeAirportLinkAdd_Click);
            // 
            // buttonCrudeAirportLinkEdit
            // 
            this.buttonCrudeAirportLinkEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportLinkEdit.Location = new System.Drawing.Point(-2, 218);
            this.buttonCrudeAirportLinkEdit.Name = "buttonCrudeAirportLinkEdit";
            this.buttonCrudeAirportLinkEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportLinkEdit.TabIndex = 4;
            this.buttonCrudeAirportLinkEdit.Text = "&Edit";
            this.buttonCrudeAirportLinkEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportLinkEdit.Click += new System.EventHandler(this.buttonCrudeAirportLinkEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 246);
            this.Controls.Add(this.buttonCrudeAirportLinkSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeAirportLinkAdd);
            this.Controls.Add(this.buttonCrudeAirportLinkEdit);
            this.Controls.Add(this.dataGridViewCrudeAirportLink);
            this.Name = "CrudeAirportLinkSearch";
            this.Text = "Airport Link Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirportLink)).EndInit();
            this.Controls.Add(this.labelLinkTypeRefCombo);
            this.Controls.Add(this.linkTypeRefCombo);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelAirportPicker);
            this.Controls.Add(this.airportPicker);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
