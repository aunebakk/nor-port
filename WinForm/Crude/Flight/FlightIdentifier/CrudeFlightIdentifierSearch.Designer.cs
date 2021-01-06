namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFlightIdentifierSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFlightIdentifierSearch;
        
        private System.Windows.Forms.Button buttonCrudeFlightIdentifierAdd;
        
        private System.Windows.Forms.Button buttonCrudeFlightIdentifierEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFlightIdentifier;
        
        private System.Windows.Forms.TextBox textBoxFlightIdentifierCode;
        
        private System.Windows.Forms.Label labelFlightIdentifierCode;
        
        private FlightIdentifierTypeRefCombo flightIdentifierTypeRefCombo;
        
        private System.Windows.Forms.Label labelFlightIdentifierTypeRefCombo;
        
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
            this.buttonCrudeFlightIdentifierAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFlightIdentifierEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFlightIdentifierSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFlightIdentifier = new System.Windows.Forms.DataGridView();
            this.labelFlightIdentifierCode = new System.Windows.Forms.Label();
            this.textBoxFlightIdentifierCode = new System.Windows.Forms.TextBox();
            this.labelFlightIdentifierTypeRefCombo = new System.Windows.Forms.Label();
            this.flightIdentifierTypeRefCombo = new FlightIdentifierTypeRefCombo();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFlightIdentifier)).BeginInit();
            this.SuspendLayout();
            //
            // labelFlightIdentifierCode
            //
            this.labelFlightIdentifierCode.AutoSize = true;
            this.labelFlightIdentifierCode.Location = new System.Drawing.Point(11, 13);
            this.labelFlightIdentifierCode.Name = "labelFlightIdentifierCode";
            this.labelFlightIdentifierCode.Size = new System.Drawing.Size(71, 13);
            this.labelFlightIdentifierCode.TabIndex = 2;
            this.labelFlightIdentifierCode.Text = "Flight Identifier Code:";
            //
            //textBoxFlightIdentifierCode
            //
            this.textBoxFlightIdentifierCode.Location = new System.Drawing.Point(154, 13);
            this.textBoxFlightIdentifierCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFlightIdentifierCode.Name = "textBoxFlightIdentifierCode";
            this.textBoxFlightIdentifierCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxFlightIdentifierCode.TabIndex = 3;
            //
            // labelFlightIdentifierTypeRefCombo
            //
            this.labelFlightIdentifierTypeRefCombo.AutoSize = true;
            this.labelFlightIdentifierTypeRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelFlightIdentifierTypeRefCombo.Name = "labelFlightIdentifierTypeRefCombo";
            this.labelFlightIdentifierTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelFlightIdentifierTypeRefCombo.TabIndex = 4;
            this.labelFlightIdentifierTypeRefCombo.Text = "Flight Identifier Type:";
            //
            //flightIdentifierTypeRefCombo
            //
            this.flightIdentifierTypeRefCombo.Location = new System.Drawing.Point(154, 36);
            this.flightIdentifierTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.flightIdentifierTypeRefCombo.Name = "flightIdentifierTypeRefCombo";
            this.flightIdentifierTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.flightIdentifierTypeRefCombo.TabIndex = 5;
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
            // dataGridViewCrudeFlightIdentifier
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFlightIdentifier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFlightIdentifier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFlightIdentifier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFlightIdentifier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFlightIdentifier.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeFlightIdentifier.Name = "dataGridViewCrudeFlightIdentifier";
            this.dataGridViewCrudeFlightIdentifier.Size = new System.Drawing.Size(392, 96);
            this.dataGridViewCrudeFlightIdentifier.TabIndex = 0;
            this.dataGridViewCrudeFlightIdentifier.ReadOnly = true;
            this.dataGridViewCrudeFlightIdentifier.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFlightIdentifier_DoubleClick);
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
            // buttonCrudeFlightIdentifierSearch
            // 
            this.buttonCrudeFlightIdentifierSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFlightIdentifierSearch.Location = new System.Drawing.Point(212, 218);
            this.buttonCrudeFlightIdentifierSearch.Name = "buttonCrudeFlightIdentifierSearch";
            this.buttonCrudeFlightIdentifierSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFlightIdentifierSearch.TabIndex = 2;
            this.buttonCrudeFlightIdentifierSearch.Text = "&Search";
            this.buttonCrudeFlightIdentifierSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFlightIdentifierSearch.Click += new System.EventHandler(this.buttonCrudeFlightIdentifierSearch_Click);
            // 
            // buttonCrudeFlightIdentifierAdd
            // 
            this.buttonCrudeFlightIdentifierAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFlightIdentifierAdd.Location = new System.Drawing.Point(112, 218);
            this.buttonCrudeFlightIdentifierAdd.Name = "buttonCrudeFlightIdentifierAdd";
            this.buttonCrudeFlightIdentifierAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFlightIdentifierAdd.TabIndex = 3;
            this.buttonCrudeFlightIdentifierAdd.Text = "&Add";
            this.buttonCrudeFlightIdentifierAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFlightIdentifierAdd.Click += new System.EventHandler(this.buttonCrudeFlightIdentifierAdd_Click);
            // 
            // buttonCrudeFlightIdentifierEdit
            // 
            this.buttonCrudeFlightIdentifierEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFlightIdentifierEdit.Location = new System.Drawing.Point(12, 218);
            this.buttonCrudeFlightIdentifierEdit.Name = "buttonCrudeFlightIdentifierEdit";
            this.buttonCrudeFlightIdentifierEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFlightIdentifierEdit.TabIndex = 4;
            this.buttonCrudeFlightIdentifierEdit.Text = "&Edit";
            this.buttonCrudeFlightIdentifierEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFlightIdentifierEdit.Click += new System.EventHandler(this.buttonCrudeFlightIdentifierEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 246);
            this.Controls.Add(this.buttonCrudeFlightIdentifierSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFlightIdentifierAdd);
            this.Controls.Add(this.buttonCrudeFlightIdentifierEdit);
            this.Controls.Add(this.dataGridViewCrudeFlightIdentifier);
            this.Name = "CrudeFlightIdentifierSearch";
            this.Text = "Flight Identifier Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFlightIdentifier)).EndInit();
            this.Controls.Add(this.labelFlightIdentifierCode);
            this.Controls.Add(this.textBoxFlightIdentifierCode);
            this.Controls.Add(this.labelFlightIdentifierTypeRefCombo);
            this.Controls.Add(this.flightIdentifierTypeRefCombo);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
