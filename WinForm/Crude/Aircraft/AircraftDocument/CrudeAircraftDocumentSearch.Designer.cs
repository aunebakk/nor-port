namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAircraftDocumentSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeAircraftDocumentSearch;
        
        private System.Windows.Forms.Button buttonCrudeAircraftDocumentAdd;
        
        private System.Windows.Forms.Button buttonCrudeAircraftDocumentEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeAircraftDocument;
        
        private System.Windows.Forms.TextBox textBoxDocumentName;
        
        private System.Windows.Forms.Label labelDocumentName;
        
        private AircraftDocumentTypeRefCombo aircraftDocumentTypeRefCombo;
        
        private System.Windows.Forms.Label labelAircraftDocumentTypeRefCombo;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerDocumentDateTime;
        
        private System.Windows.Forms.Label labelDocumentDateTime;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerExpiryDateTime;
        
        private System.Windows.Forms.Label labelExpiryDateTime;
        
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
            this.buttonCrudeAircraftDocumentAdd = new System.Windows.Forms.Button();
            this.buttonCrudeAircraftDocumentEdit = new System.Windows.Forms.Button();
            this.buttonCrudeAircraftDocumentSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeAircraftDocument = new System.Windows.Forms.DataGridView();
            this.labelDocumentName = new System.Windows.Forms.Label();
            this.textBoxDocumentName = new System.Windows.Forms.TextBox();
            this.labelAircraftDocumentTypeRefCombo = new System.Windows.Forms.Label();
            this.aircraftDocumentTypeRefCombo = new AircraftDocumentTypeRefCombo();
            this.labelDocumentDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDocumentDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelExpiryDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerExpiryDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAircraftDocument)).BeginInit();
            this.SuspendLayout();
            //
            // labelDocumentName
            //
            this.labelDocumentName.AutoSize = true;
            this.labelDocumentName.Location = new System.Drawing.Point(11, 13);
            this.labelDocumentName.Name = "labelDocumentName";
            this.labelDocumentName.Size = new System.Drawing.Size(71, 13);
            this.labelDocumentName.TabIndex = 2;
            this.labelDocumentName.Text = "Document Name:";
            //
            //textBoxDocumentName
            //
            this.textBoxDocumentName.Location = new System.Drawing.Point(154, 13);
            this.textBoxDocumentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDocumentName.Name = "textBoxDocumentName";
            this.textBoxDocumentName.Size = new System.Drawing.Size(250, 20);
            this.textBoxDocumentName.TabIndex = 3;
            //
            // labelAircraftDocumentTypeRefCombo
            //
            this.labelAircraftDocumentTypeRefCombo.AutoSize = true;
            this.labelAircraftDocumentTypeRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelAircraftDocumentTypeRefCombo.Name = "labelAircraftDocumentTypeRefCombo";
            this.labelAircraftDocumentTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelAircraftDocumentTypeRefCombo.TabIndex = 4;
            this.labelAircraftDocumentTypeRefCombo.Text = "Aircraft Document Type:";
            //
            //aircraftDocumentTypeRefCombo
            //
            this.aircraftDocumentTypeRefCombo.Location = new System.Drawing.Point(154, 36);
            this.aircraftDocumentTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.aircraftDocumentTypeRefCombo.Name = "aircraftDocumentTypeRefCombo";
            this.aircraftDocumentTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.aircraftDocumentTypeRefCombo.TabIndex = 5;
            //
            // labelDocumentDateTime
            //
            this.labelDocumentDateTime.AutoSize = true;
            this.labelDocumentDateTime.Location = new System.Drawing.Point(11, 59);
            this.labelDocumentDateTime.Name = "labelDocumentDateTime";
            this.labelDocumentDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDocumentDateTime.TabIndex = 6;
            this.labelDocumentDateTime.Text = "Document Date Time:";
            //
            //dateTimePickerDocumentDateTime
            //
            this.dateTimePickerDocumentDateTime.Location = new System.Drawing.Point(154, 59);
            this.dateTimePickerDocumentDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDocumentDateTime.Name = "dateTimePickerDocumentDateTime";
            this.dateTimePickerDocumentDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDocumentDateTime.TabIndex = 7;
            this.dateTimePickerDocumentDateTime.Checked = false;
            this.dateTimePickerDocumentDateTime.ShowCheckBox = true;
            //
            // labelExpiryDateTime
            //
            this.labelExpiryDateTime.AutoSize = true;
            this.labelExpiryDateTime.Location = new System.Drawing.Point(11, 82);
            this.labelExpiryDateTime.Name = "labelExpiryDateTime";
            this.labelExpiryDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelExpiryDateTime.TabIndex = 8;
            this.labelExpiryDateTime.Text = "Expiry Date Time:";
            //
            //dateTimePickerExpiryDateTime
            //
            this.dateTimePickerExpiryDateTime.Location = new System.Drawing.Point(154, 82);
            this.dateTimePickerExpiryDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerExpiryDateTime.Name = "dateTimePickerExpiryDateTime";
            this.dateTimePickerExpiryDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerExpiryDateTime.TabIndex = 9;
            this.dateTimePickerExpiryDateTime.Checked = false;
            this.dateTimePickerExpiryDateTime.ShowCheckBox = true;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 105);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 10;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(154, 105);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 11;
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
            this.userPicker.Location = new System.Drawing.Point(154, 128);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 13;
            // 
            // dataGridViewCrudeAircraftDocument
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeAircraftDocument.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeAircraftDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeAircraftDocument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeAircraftDocument.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeAircraftDocument.Location = new System.Drawing.Point(12, 161);
            this.dataGridViewCrudeAircraftDocument.Name = "dataGridViewCrudeAircraftDocument";
            this.dataGridViewCrudeAircraftDocument.Size = new System.Drawing.Size(392, 96);
            this.dataGridViewCrudeAircraftDocument.TabIndex = 0;
            this.dataGridViewCrudeAircraftDocument.ReadOnly = true;
            this.dataGridViewCrudeAircraftDocument.DoubleClick += new System.EventHandler(this.dataGridViewCrudeAircraftDocument_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(312, 264);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeAircraftDocumentSearch
            // 
            this.buttonCrudeAircraftDocumentSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAircraftDocumentSearch.Location = new System.Drawing.Point(212, 264);
            this.buttonCrudeAircraftDocumentSearch.Name = "buttonCrudeAircraftDocumentSearch";
            this.buttonCrudeAircraftDocumentSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAircraftDocumentSearch.TabIndex = 2;
            this.buttonCrudeAircraftDocumentSearch.Text = "&Search";
            this.buttonCrudeAircraftDocumentSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeAircraftDocumentSearch.Click += new System.EventHandler(this.buttonCrudeAircraftDocumentSearch_Click);
            // 
            // buttonCrudeAircraftDocumentAdd
            // 
            this.buttonCrudeAircraftDocumentAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAircraftDocumentAdd.Location = new System.Drawing.Point(112, 264);
            this.buttonCrudeAircraftDocumentAdd.Name = "buttonCrudeAircraftDocumentAdd";
            this.buttonCrudeAircraftDocumentAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAircraftDocumentAdd.TabIndex = 3;
            this.buttonCrudeAircraftDocumentAdd.Text = "&Add";
            this.buttonCrudeAircraftDocumentAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeAircraftDocumentAdd.Click += new System.EventHandler(this.buttonCrudeAircraftDocumentAdd_Click);
            // 
            // buttonCrudeAircraftDocumentEdit
            // 
            this.buttonCrudeAircraftDocumentEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAircraftDocumentEdit.Location = new System.Drawing.Point(12, 264);
            this.buttonCrudeAircraftDocumentEdit.Name = "buttonCrudeAircraftDocumentEdit";
            this.buttonCrudeAircraftDocumentEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAircraftDocumentEdit.TabIndex = 4;
            this.buttonCrudeAircraftDocumentEdit.Text = "&Edit";
            this.buttonCrudeAircraftDocumentEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeAircraftDocumentEdit.Click += new System.EventHandler(this.buttonCrudeAircraftDocumentEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 292);
            this.Controls.Add(this.buttonCrudeAircraftDocumentSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeAircraftDocumentAdd);
            this.Controls.Add(this.buttonCrudeAircraftDocumentEdit);
            this.Controls.Add(this.dataGridViewCrudeAircraftDocument);
            this.Name = "CrudeAircraftDocumentSearch";
            this.Text = "Aircraft Document Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAircraftDocument)).EndInit();
            this.Controls.Add(this.labelDocumentName);
            this.Controls.Add(this.textBoxDocumentName);
            this.Controls.Add(this.labelAircraftDocumentTypeRefCombo);
            this.Controls.Add(this.aircraftDocumentTypeRefCombo);
            this.Controls.Add(this.labelDocumentDateTime);
            this.Controls.Add(this.dateTimePickerDocumentDateTime);
            this.Controls.Add(this.labelExpiryDateTime);
            this.Controls.Add(this.dateTimePickerExpiryDateTime);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
