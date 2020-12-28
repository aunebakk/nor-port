namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAirportTerminalAirlineSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeAirportTerminalAirlineSearch;
        
        private System.Windows.Forms.Button buttonCrudeAirportTerminalAirlineAdd;
        
        private System.Windows.Forms.Button buttonCrudeAirportTerminalAirlineEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeAirportTerminalAirline;
        
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
            this.buttonCrudeAirportTerminalAirlineAdd = new System.Windows.Forms.Button();
            this.buttonCrudeAirportTerminalAirlineEdit = new System.Windows.Forms.Button();
            this.buttonCrudeAirportTerminalAirlineSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeAirportTerminalAirline = new System.Windows.Forms.DataGridView();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelAirlinePicker = new System.Windows.Forms.Label();
            this.airlinePicker = new AirlinePicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirportTerminalAirline)).BeginInit();
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
            // dataGridViewCrudeAirportTerminalAirline
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeAirportTerminalAirline.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeAirportTerminalAirline.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeAirportTerminalAirline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeAirportTerminalAirline.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeAirportTerminalAirline.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeAirportTerminalAirline.Name = "dataGridViewCrudeAirportTerminalAirline";
            this.dataGridViewCrudeAirportTerminalAirline.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeAirportTerminalAirline.TabIndex = 0;
            this.dataGridViewCrudeAirportTerminalAirline.ReadOnly = true;
            this.dataGridViewCrudeAirportTerminalAirline.DoubleClick += new System.EventHandler(this.dataGridViewCrudeAirportTerminalAirline_DoubleClick);
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
            // buttonCrudeAirportTerminalAirlineSearch
            // 
            this.buttonCrudeAirportTerminalAirlineSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportTerminalAirlineSearch.Location = new System.Drawing.Point(198, 195);
            this.buttonCrudeAirportTerminalAirlineSearch.Name = "buttonCrudeAirportTerminalAirlineSearch";
            this.buttonCrudeAirportTerminalAirlineSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportTerminalAirlineSearch.TabIndex = 2;
            this.buttonCrudeAirportTerminalAirlineSearch.Text = "&Search";
            this.buttonCrudeAirportTerminalAirlineSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportTerminalAirlineSearch.Click += new System.EventHandler(this.buttonCrudeAirportTerminalAirlineSearch_Click);
            // 
            // buttonCrudeAirportTerminalAirlineAdd
            // 
            this.buttonCrudeAirportTerminalAirlineAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportTerminalAirlineAdd.Location = new System.Drawing.Point(98, 195);
            this.buttonCrudeAirportTerminalAirlineAdd.Name = "buttonCrudeAirportTerminalAirlineAdd";
            this.buttonCrudeAirportTerminalAirlineAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportTerminalAirlineAdd.TabIndex = 3;
            this.buttonCrudeAirportTerminalAirlineAdd.Text = "&Add";
            this.buttonCrudeAirportTerminalAirlineAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportTerminalAirlineAdd.Click += new System.EventHandler(this.buttonCrudeAirportTerminalAirlineAdd_Click);
            // 
            // buttonCrudeAirportTerminalAirlineEdit
            // 
            this.buttonCrudeAirportTerminalAirlineEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportTerminalAirlineEdit.Location = new System.Drawing.Point(-2, 195);
            this.buttonCrudeAirportTerminalAirlineEdit.Name = "buttonCrudeAirportTerminalAirlineEdit";
            this.buttonCrudeAirportTerminalAirlineEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportTerminalAirlineEdit.TabIndex = 4;
            this.buttonCrudeAirportTerminalAirlineEdit.Text = "&Edit";
            this.buttonCrudeAirportTerminalAirlineEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportTerminalAirlineEdit.Click += new System.EventHandler(this.buttonCrudeAirportTerminalAirlineEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 223);
            this.Controls.Add(this.buttonCrudeAirportTerminalAirlineSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeAirportTerminalAirlineAdd);
            this.Controls.Add(this.buttonCrudeAirportTerminalAirlineEdit);
            this.Controls.Add(this.dataGridViewCrudeAirportTerminalAirline);
            this.Name = "CrudeAirportTerminalAirlineSearch";
            this.Text = "Airport Terminal Airline Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirportTerminalAirline)).EndInit();
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
