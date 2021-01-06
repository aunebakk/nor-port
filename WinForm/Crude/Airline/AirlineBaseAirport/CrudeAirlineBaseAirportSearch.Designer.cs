namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAirlineBaseAirportSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeAirlineBaseAirportSearch;
        
        private System.Windows.Forms.Button buttonCrudeAirlineBaseAirportAdd;
        
        private System.Windows.Forms.Button buttonCrudeAirlineBaseAirportEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeAirlineBaseAirport;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private AirlinePicker airlinePicker;
        
        private System.Windows.Forms.Label labelAirlinePicker;
        
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
            this.buttonCrudeAirlineBaseAirportAdd = new System.Windows.Forms.Button();
            this.buttonCrudeAirlineBaseAirportEdit = new System.Windows.Forms.Button();
            this.buttonCrudeAirlineBaseAirportSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeAirlineBaseAirport = new System.Windows.Forms.DataGridView();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelAirlinePicker = new System.Windows.Forms.Label();
            this.airlinePicker = new AirlinePicker();
            this.labelAirportPicker = new System.Windows.Forms.Label();
            this.airportPicker = new AirportPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirlineBaseAirport)).BeginInit();
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
            // labelAirlinePicker
            //
            this.labelAirlinePicker.AutoSize = true;
            this.labelAirlinePicker.Location = new System.Drawing.Point(11, 36);
            this.labelAirlinePicker.Name = "labelAirlinePicker";
            this.labelAirlinePicker.Size = new System.Drawing.Size(71, 13);
            this.labelAirlinePicker.TabIndex = 4;
            this.labelAirlinePicker.Text = "Airline:";
            //
            //airlinePicker
            //
            this.airlinePicker.Location = new System.Drawing.Point(140, 36);
            this.airlinePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.airlinePicker.Name = "airlinePicker";
            this.airlinePicker.Size = new System.Drawing.Size(250, 20);
            this.airlinePicker.TabIndex = 5;
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
            // dataGridViewCrudeAirlineBaseAirport
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeAirlineBaseAirport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeAirlineBaseAirport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeAirlineBaseAirport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeAirlineBaseAirport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeAirlineBaseAirport.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeAirlineBaseAirport.Name = "dataGridViewCrudeAirlineBaseAirport";
            this.dataGridViewCrudeAirlineBaseAirport.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeAirlineBaseAirport.TabIndex = 0;
            this.dataGridViewCrudeAirlineBaseAirport.ReadOnly = true;
            this.dataGridViewCrudeAirlineBaseAirport.DoubleClick += new System.EventHandler(this.dataGridViewCrudeAirlineBaseAirport_DoubleClick);
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
            // buttonCrudeAirlineBaseAirportSearch
            // 
            this.buttonCrudeAirlineBaseAirportSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirlineBaseAirportSearch.Location = new System.Drawing.Point(198, 218);
            this.buttonCrudeAirlineBaseAirportSearch.Name = "buttonCrudeAirlineBaseAirportSearch";
            this.buttonCrudeAirlineBaseAirportSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirlineBaseAirportSearch.TabIndex = 2;
            this.buttonCrudeAirlineBaseAirportSearch.Text = "&Search";
            this.buttonCrudeAirlineBaseAirportSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeAirlineBaseAirportSearch.Click += new System.EventHandler(this.buttonCrudeAirlineBaseAirportSearch_Click);
            // 
            // buttonCrudeAirlineBaseAirportAdd
            // 
            this.buttonCrudeAirlineBaseAirportAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirlineBaseAirportAdd.Location = new System.Drawing.Point(98, 218);
            this.buttonCrudeAirlineBaseAirportAdd.Name = "buttonCrudeAirlineBaseAirportAdd";
            this.buttonCrudeAirlineBaseAirportAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirlineBaseAirportAdd.TabIndex = 3;
            this.buttonCrudeAirlineBaseAirportAdd.Text = "&Add";
            this.buttonCrudeAirlineBaseAirportAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeAirlineBaseAirportAdd.Click += new System.EventHandler(this.buttonCrudeAirlineBaseAirportAdd_Click);
            // 
            // buttonCrudeAirlineBaseAirportEdit
            // 
            this.buttonCrudeAirlineBaseAirportEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirlineBaseAirportEdit.Location = new System.Drawing.Point(-2, 218);
            this.buttonCrudeAirlineBaseAirportEdit.Name = "buttonCrudeAirlineBaseAirportEdit";
            this.buttonCrudeAirlineBaseAirportEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirlineBaseAirportEdit.TabIndex = 4;
            this.buttonCrudeAirlineBaseAirportEdit.Text = "&Edit";
            this.buttonCrudeAirlineBaseAirportEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeAirlineBaseAirportEdit.Click += new System.EventHandler(this.buttonCrudeAirlineBaseAirportEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 246);
            this.Controls.Add(this.buttonCrudeAirlineBaseAirportSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeAirlineBaseAirportAdd);
            this.Controls.Add(this.buttonCrudeAirlineBaseAirportEdit);
            this.Controls.Add(this.dataGridViewCrudeAirlineBaseAirport);
            this.Name = "CrudeAirlineBaseAirportSearch";
            this.Text = "Airline Base Airport Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirlineBaseAirport)).EndInit();
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelAirlinePicker);
            this.Controls.Add(this.airlinePicker);
            this.Controls.Add(this.labelAirportPicker);
            this.Controls.Add(this.airportPicker);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
