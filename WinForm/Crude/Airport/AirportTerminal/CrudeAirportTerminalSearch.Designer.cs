namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAirportTerminalSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeAirportTerminalSearch;
        
        private System.Windows.Forms.Button buttonCrudeAirportTerminalAdd;
        
        private System.Windows.Forms.Button buttonCrudeAirportTerminalEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeAirportTerminal;
        
        private System.Windows.Forms.TextBox textBoxAirportTerminalName;
        
        private System.Windows.Forms.Label labelAirportTerminalName;
        
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
            this.buttonCrudeAirportTerminalAdd = new System.Windows.Forms.Button();
            this.buttonCrudeAirportTerminalEdit = new System.Windows.Forms.Button();
            this.buttonCrudeAirportTerminalSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeAirportTerminal = new System.Windows.Forms.DataGridView();
            this.labelAirportTerminalName = new System.Windows.Forms.Label();
            this.textBoxAirportTerminalName = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelAirportPicker = new System.Windows.Forms.Label();
            this.airportPicker = new AirportPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirportTerminal)).BeginInit();
            this.SuspendLayout();
            //
            // labelAirportTerminalName
            //
            this.labelAirportTerminalName.AutoSize = true;
            this.labelAirportTerminalName.Location = new System.Drawing.Point(11, 13);
            this.labelAirportTerminalName.Name = "labelAirportTerminalName";
            this.labelAirportTerminalName.Size = new System.Drawing.Size(71, 13);
            this.labelAirportTerminalName.TabIndex = 2;
            this.labelAirportTerminalName.Text = "Airport Terminal Name:";
            //
            //textBoxAirportTerminalName
            //
            this.textBoxAirportTerminalName.Location = new System.Drawing.Point(147, 13);
            this.textBoxAirportTerminalName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAirportTerminalName.Name = "textBoxAirportTerminalName";
            this.textBoxAirportTerminalName.Size = new System.Drawing.Size(250, 20);
            this.textBoxAirportTerminalName.TabIndex = 3;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(147, 36);
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
            this.airportPicker.Location = new System.Drawing.Point(147, 59);
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
            this.userPicker.Location = new System.Drawing.Point(147, 82);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 9;
            // 
            // dataGridViewCrudeAirportTerminal
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeAirportTerminal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeAirportTerminal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeAirportTerminal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeAirportTerminal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeAirportTerminal.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeAirportTerminal.Name = "dataGridViewCrudeAirportTerminal";
            this.dataGridViewCrudeAirportTerminal.Size = new System.Drawing.Size(385, 96);
            this.dataGridViewCrudeAirportTerminal.TabIndex = 0;
            this.dataGridViewCrudeAirportTerminal.ReadOnly = true;
            this.dataGridViewCrudeAirportTerminal.DoubleClick += new System.EventHandler(this.dataGridViewCrudeAirportTerminal_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(305, 218);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeAirportTerminalSearch
            // 
            this.buttonCrudeAirportTerminalSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportTerminalSearch.Location = new System.Drawing.Point(205, 218);
            this.buttonCrudeAirportTerminalSearch.Name = "buttonCrudeAirportTerminalSearch";
            this.buttonCrudeAirportTerminalSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportTerminalSearch.TabIndex = 2;
            this.buttonCrudeAirportTerminalSearch.Text = "&Search";
            this.buttonCrudeAirportTerminalSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportTerminalSearch.Click += new System.EventHandler(this.buttonCrudeAirportTerminalSearch_Click);
            // 
            // buttonCrudeAirportTerminalAdd
            // 
            this.buttonCrudeAirportTerminalAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportTerminalAdd.Location = new System.Drawing.Point(105, 218);
            this.buttonCrudeAirportTerminalAdd.Name = "buttonCrudeAirportTerminalAdd";
            this.buttonCrudeAirportTerminalAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportTerminalAdd.TabIndex = 3;
            this.buttonCrudeAirportTerminalAdd.Text = "&Add";
            this.buttonCrudeAirportTerminalAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportTerminalAdd.Click += new System.EventHandler(this.buttonCrudeAirportTerminalAdd_Click);
            // 
            // buttonCrudeAirportTerminalEdit
            // 
            this.buttonCrudeAirportTerminalEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirportTerminalEdit.Location = new System.Drawing.Point(5, 218);
            this.buttonCrudeAirportTerminalEdit.Name = "buttonCrudeAirportTerminalEdit";
            this.buttonCrudeAirportTerminalEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirportTerminalEdit.TabIndex = 4;
            this.buttonCrudeAirportTerminalEdit.Text = "&Edit";
            this.buttonCrudeAirportTerminalEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeAirportTerminalEdit.Click += new System.EventHandler(this.buttonCrudeAirportTerminalEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 246);
            this.Controls.Add(this.buttonCrudeAirportTerminalSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeAirportTerminalAdd);
            this.Controls.Add(this.buttonCrudeAirportTerminalEdit);
            this.Controls.Add(this.dataGridViewCrudeAirportTerminal);
            this.Name = "CrudeAirportTerminalSearch";
            this.Text = "Airport Terminal Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirportTerminal)).EndInit();
            this.Controls.Add(this.labelAirportTerminalName);
            this.Controls.Add(this.textBoxAirportTerminalName);
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
