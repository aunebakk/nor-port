namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAirportHotelLinkSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeAirportHotelLinkSearch;
        
        private System.Windows.Forms.Button buttonCrudeAirportHotelLinkAdd;
        
        private System.Windows.Forms.Button buttonCrudeAirportHotelLinkEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeAirportHotelLink;
        
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
            this.buttonCrudeAirportHotelLinkAdd = new System.Windows.Forms.Button();
            this.buttonCrudeAirportHotelLinkEdit = new System.Windows.Forms.Button();
            this.buttonCrudeAirportHotelLinkSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeAirportHotelLink = new System.Windows.Forms.DataGridView();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelAirportPicker = new System.Windows.Forms.Label();
            this.airportPicker = new AirportPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirportHotelLink)).BeginInit();
            this.SuspendLayout();
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 13);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 2;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 13);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 3;
            //
            // labelAirportPicker
            //
            this.labelAirportPicker.AutoSize = true;
            this.labelAirportPicker.Location = new System.Drawing.Point(11, 36);
            this.labelAirportPicker.Name = "labelAirportPicker";
            this.labelAirportPicker.Size = new System.Drawing.Size(71, 13);
            this.labelAirportPicker.TabIndex = 4;
            this.labelAirportPicker.Text = "Airport:";
            //
            //airportPicker
            //
            this.airportPicker.Location = new System.Drawing.Point(140, 36);
            this.airportPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.airportPicker.Name = "airportPicker";
            this.airportPicker.Size = new System.Drawing.Size(250, 20);
            this.airportPicker.TabIndex = 5;
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
            // dataGridViewCrudeAirportHotelLink
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeAirportHotelLink.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeAirportHotelLink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeAirportHotelLink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeAirportHotelLink.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeAirportHotelLink.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeAirportHotelLink.Name = "dataGridViewCrudeAirportHotelLink";
            this.dataGridViewCrudeAirportHotelLink.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeAirportHotelLink.TabIndex = 0;
            this.dataGridViewCrudeAirportHotelLink.ReadOnly = true;
            this.dataGridViewCrudeAirportHotelLink.DoubleClick += new System.EventHandler(this.dataGridViewCrudeAirportHotelLink_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeAirportHotelLinkSearch
            // 
            this.buttonCrudeAirportHotelLinkSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportHotelLinkSearch.Location = new System.Drawing.Point(198, 195);
            this.buttonCrudeAirportHotelLinkSearch.Name = "buttonCrudeAirportHotelLinkSearch";
            this.buttonCrudeAirportHotelLinkSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportHotelLinkSearch.TabIndex = 2;
            this.buttonCrudeAirportHotelLinkSearch.Text = "&Search";
            this.buttonCrudeAirportHotelLinkSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportHotelLinkSearch.Click += new System.EventHandler(this.buttonCrudeAirportHotelLinkSearch_Click);
            // 
            // buttonCrudeAirportHotelLinkAdd
            // 
            this.buttonCrudeAirportHotelLinkAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportHotelLinkAdd.Location = new System.Drawing.Point(98, 195);
            this.buttonCrudeAirportHotelLinkAdd.Name = "buttonCrudeAirportHotelLinkAdd";
            this.buttonCrudeAirportHotelLinkAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportHotelLinkAdd.TabIndex = 3;
            this.buttonCrudeAirportHotelLinkAdd.Text = "&Add";
            this.buttonCrudeAirportHotelLinkAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportHotelLinkAdd.Click += new System.EventHandler(this.buttonCrudeAirportHotelLinkAdd_Click);
            // 
            // buttonCrudeAirportHotelLinkEdit
            // 
            this.buttonCrudeAirportHotelLinkEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportHotelLinkEdit.Location = new System.Drawing.Point(-2, 195);
            this.buttonCrudeAirportHotelLinkEdit.Name = "buttonCrudeAirportHotelLinkEdit";
            this.buttonCrudeAirportHotelLinkEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportHotelLinkEdit.TabIndex = 4;
            this.buttonCrudeAirportHotelLinkEdit.Text = "&Edit";
            this.buttonCrudeAirportHotelLinkEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportHotelLinkEdit.Click += new System.EventHandler(this.buttonCrudeAirportHotelLinkEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 223);
            this.Controls.Add(this.buttonCrudeAirportHotelLinkSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeAirportHotelLinkAdd);
            this.Controls.Add(this.buttonCrudeAirportHotelLinkEdit);
            this.Controls.Add(this.dataGridViewCrudeAirportHotelLink);
            this.Name = "CrudeAirportHotelLinkSearch";
            this.Text = "Airport Hotel Link Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirportHotelLink)).EndInit();
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
