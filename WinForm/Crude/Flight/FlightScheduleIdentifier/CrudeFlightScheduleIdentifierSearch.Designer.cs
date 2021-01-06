namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFlightScheduleIdentifierSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFlightScheduleIdentifierSearch;
        
        private System.Windows.Forms.Button buttonCrudeFlightScheduleIdentifierAdd;
        
        private System.Windows.Forms.Button buttonCrudeFlightScheduleIdentifierEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFlightScheduleIdentifier;
        
        private FlightIdentifierTypeRefCombo flightIdentifierTypeRefCombo;
        
        private System.Windows.Forms.Label labelFlightIdentifierTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxFlightIdentifierCode;
        
        private System.Windows.Forms.Label labelFlightIdentifierCode;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
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
            this.buttonCrudeFlightScheduleIdentifierAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFlightScheduleIdentifierEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFlightScheduleIdentifierSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFlightScheduleIdentifier = new System.Windows.Forms.DataGridView();
            this.labelFlightIdentifierTypeRefCombo = new System.Windows.Forms.Label();
            this.flightIdentifierTypeRefCombo = new FlightIdentifierTypeRefCombo();
            this.labelFlightIdentifierCode = new System.Windows.Forms.Label();
            this.textBoxFlightIdentifierCode = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFlightScheduleIdentifier)).BeginInit();
            this.SuspendLayout();
            //
            // labelFlightIdentifierTypeRefCombo
            //
            this.labelFlightIdentifierTypeRefCombo.AutoSize = true;
            this.labelFlightIdentifierTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelFlightIdentifierTypeRefCombo.Name = "labelFlightIdentifierTypeRefCombo";
            this.labelFlightIdentifierTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelFlightIdentifierTypeRefCombo.TabIndex = 2;
            this.labelFlightIdentifierTypeRefCombo.Text = "Flight Identifier Type:";
            //
            //flightIdentifierTypeRefCombo
            //
            this.flightIdentifierTypeRefCombo.Location = new System.Drawing.Point(154, 13);
            this.flightIdentifierTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.flightIdentifierTypeRefCombo.Name = "flightIdentifierTypeRefCombo";
            this.flightIdentifierTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.flightIdentifierTypeRefCombo.TabIndex = 3;
            //
            // labelFlightIdentifierCode
            //
            this.labelFlightIdentifierCode.AutoSize = true;
            this.labelFlightIdentifierCode.Location = new System.Drawing.Point(11, 36);
            this.labelFlightIdentifierCode.Name = "labelFlightIdentifierCode";
            this.labelFlightIdentifierCode.Size = new System.Drawing.Size(71, 13);
            this.labelFlightIdentifierCode.TabIndex = 4;
            this.labelFlightIdentifierCode.Text = "Flight Identifier Code:";
            //
            //textBoxFlightIdentifierCode
            //
            this.textBoxFlightIdentifierCode.Location = new System.Drawing.Point(154, 36);
            this.textBoxFlightIdentifierCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFlightIdentifierCode.Name = "textBoxFlightIdentifierCode";
            this.textBoxFlightIdentifierCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxFlightIdentifierCode.TabIndex = 5;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 59);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 6;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(154, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
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
            this.userPicker.Location = new System.Drawing.Point(154, 82);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 9;
            // 
            // dataGridViewCrudeFlightScheduleIdentifier
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFlightScheduleIdentifier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFlightScheduleIdentifier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFlightScheduleIdentifier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFlightScheduleIdentifier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFlightScheduleIdentifier.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeFlightScheduleIdentifier.Name = "dataGridViewCrudeFlightScheduleIdentifier";
            this.dataGridViewCrudeFlightScheduleIdentifier.Size = new System.Drawing.Size(392, 96);
            this.dataGridViewCrudeFlightScheduleIdentifier.TabIndex = 0;
            this.dataGridViewCrudeFlightScheduleIdentifier.ReadOnly = true;
            this.dataGridViewCrudeFlightScheduleIdentifier.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFlightScheduleIdentifier_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(312, 218);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFlightScheduleIdentifierSearch
            // 
            this.buttonCrudeFlightScheduleIdentifierSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFlightScheduleIdentifierSearch.Location = new System.Drawing.Point(212, 218);
            this.buttonCrudeFlightScheduleIdentifierSearch.Name = "buttonCrudeFlightScheduleIdentifierSearch";
            this.buttonCrudeFlightScheduleIdentifierSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFlightScheduleIdentifierSearch.TabIndex = 2;
            this.buttonCrudeFlightScheduleIdentifierSearch.Text = "&Search";
            this.buttonCrudeFlightScheduleIdentifierSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFlightScheduleIdentifierSearch.Click += new System.EventHandler(this.buttonCrudeFlightScheduleIdentifierSearch_Click);
            // 
            // buttonCrudeFlightScheduleIdentifierAdd
            // 
            this.buttonCrudeFlightScheduleIdentifierAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFlightScheduleIdentifierAdd.Location = new System.Drawing.Point(112, 218);
            this.buttonCrudeFlightScheduleIdentifierAdd.Name = "buttonCrudeFlightScheduleIdentifierAdd";
            this.buttonCrudeFlightScheduleIdentifierAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFlightScheduleIdentifierAdd.TabIndex = 3;
            this.buttonCrudeFlightScheduleIdentifierAdd.Text = "&Add";
            this.buttonCrudeFlightScheduleIdentifierAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFlightScheduleIdentifierAdd.Click += new System.EventHandler(this.buttonCrudeFlightScheduleIdentifierAdd_Click);
            // 
            // buttonCrudeFlightScheduleIdentifierEdit
            // 
            this.buttonCrudeFlightScheduleIdentifierEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFlightScheduleIdentifierEdit.Location = new System.Drawing.Point(12, 218);
            this.buttonCrudeFlightScheduleIdentifierEdit.Name = "buttonCrudeFlightScheduleIdentifierEdit";
            this.buttonCrudeFlightScheduleIdentifierEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFlightScheduleIdentifierEdit.TabIndex = 4;
            this.buttonCrudeFlightScheduleIdentifierEdit.Text = "&Edit";
            this.buttonCrudeFlightScheduleIdentifierEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFlightScheduleIdentifierEdit.Click += new System.EventHandler(this.buttonCrudeFlightScheduleIdentifierEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 246);
            this.Controls.Add(this.buttonCrudeFlightScheduleIdentifierSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFlightScheduleIdentifierAdd);
            this.Controls.Add(this.buttonCrudeFlightScheduleIdentifierEdit);
            this.Controls.Add(this.dataGridViewCrudeFlightScheduleIdentifier);
            this.Name = "CrudeFlightScheduleIdentifierSearch";
            this.Text = "Flight Schedule Identifier Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFlightScheduleIdentifier)).EndInit();
            this.Controls.Add(this.labelFlightIdentifierTypeRefCombo);
            this.Controls.Add(this.flightIdentifierTypeRefCombo);
            this.Controls.Add(this.labelFlightIdentifierCode);
            this.Controls.Add(this.textBoxFlightIdentifierCode);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
