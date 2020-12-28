namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAirportSupplierLinkSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeAirportSupplierLinkSearch;
        
        private System.Windows.Forms.Button buttonCrudeAirportSupplierLinkAdd;
        
        private System.Windows.Forms.Button buttonCrudeAirportSupplierLinkEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeAirportSupplierLink;
        
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
            this.buttonCrudeAirportSupplierLinkAdd = new System.Windows.Forms.Button();
            this.buttonCrudeAirportSupplierLinkEdit = new System.Windows.Forms.Button();
            this.buttonCrudeAirportSupplierLinkSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeAirportSupplierLink = new System.Windows.Forms.DataGridView();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelAirportPicker = new System.Windows.Forms.Label();
            this.airportPicker = new AirportPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirportSupplierLink)).BeginInit();
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
            // dataGridViewCrudeAirportSupplierLink
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeAirportSupplierLink.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeAirportSupplierLink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeAirportSupplierLink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeAirportSupplierLink.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeAirportSupplierLink.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeAirportSupplierLink.Name = "dataGridViewCrudeAirportSupplierLink";
            this.dataGridViewCrudeAirportSupplierLink.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeAirportSupplierLink.TabIndex = 0;
            this.dataGridViewCrudeAirportSupplierLink.ReadOnly = true;
            this.dataGridViewCrudeAirportSupplierLink.DoubleClick += new System.EventHandler(this.dataGridViewCrudeAirportSupplierLink_DoubleClick);
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
            // buttonCrudeAirportSupplierLinkSearch
            // 
            this.buttonCrudeAirportSupplierLinkSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportSupplierLinkSearch.Location = new System.Drawing.Point(198, 195);
            this.buttonCrudeAirportSupplierLinkSearch.Name = "buttonCrudeAirportSupplierLinkSearch";
            this.buttonCrudeAirportSupplierLinkSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportSupplierLinkSearch.TabIndex = 2;
            this.buttonCrudeAirportSupplierLinkSearch.Text = "&Search";
            this.buttonCrudeAirportSupplierLinkSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportSupplierLinkSearch.Click += new System.EventHandler(this.buttonCrudeAirportSupplierLinkSearch_Click);
            // 
            // buttonCrudeAirportSupplierLinkAdd
            // 
            this.buttonCrudeAirportSupplierLinkAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportSupplierLinkAdd.Location = new System.Drawing.Point(98, 195);
            this.buttonCrudeAirportSupplierLinkAdd.Name = "buttonCrudeAirportSupplierLinkAdd";
            this.buttonCrudeAirportSupplierLinkAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportSupplierLinkAdd.TabIndex = 3;
            this.buttonCrudeAirportSupplierLinkAdd.Text = "&Add";
            this.buttonCrudeAirportSupplierLinkAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportSupplierLinkAdd.Click += new System.EventHandler(this.buttonCrudeAirportSupplierLinkAdd_Click);
            // 
            // buttonCrudeAirportSupplierLinkEdit
            // 
            this.buttonCrudeAirportSupplierLinkEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportSupplierLinkEdit.Location = new System.Drawing.Point(-2, 195);
            this.buttonCrudeAirportSupplierLinkEdit.Name = "buttonCrudeAirportSupplierLinkEdit";
            this.buttonCrudeAirportSupplierLinkEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportSupplierLinkEdit.TabIndex = 4;
            this.buttonCrudeAirportSupplierLinkEdit.Text = "&Edit";
            this.buttonCrudeAirportSupplierLinkEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportSupplierLinkEdit.Click += new System.EventHandler(this.buttonCrudeAirportSupplierLinkEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 223);
            this.Controls.Add(this.buttonCrudeAirportSupplierLinkSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeAirportSupplierLinkAdd);
            this.Controls.Add(this.buttonCrudeAirportSupplierLinkEdit);
            this.Controls.Add(this.dataGridViewCrudeAirportSupplierLink);
            this.Name = "CrudeAirportSupplierLinkSearch";
            this.Text = "Airport Supplier Link Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirportSupplierLink)).EndInit();
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
