namespace SolutionNorSolutionPort.UserInterface {

    public partial class AircraftCompartmentEdit {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonSave;
        
        private AircraftCompartmentTypeRefCombo aircraftCompartmentTypeRefCombo;
        
        private System.Windows.Forms.Label labelAircraftCompartmentTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxAircraftCompartmentName;
        
        private System.Windows.Forms.Label labelAircraftCompartmentName;
        
        private DefaultUserPicker userPicker;
        
        private System.Windows.Forms.Label labelUserPicker;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private System.Windows.Forms.Button buttonAircraftCompartmentSearch;
        
        private System.Windows.Forms.Button buttonAircraftCompartmentAdd;
        
        private System.Windows.Forms.Button buttonAircraftCompartmentEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewAircraftCompartment;
        
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonAircraftCompartmentAdd = new System.Windows.Forms.Button();
            this.buttonAircraftCompartmentEdit = new System.Windows.Forms.Button();
            this.buttonAircraftCompartmentSearch = new System.Windows.Forms.Button();
            this.dataGridViewAircraftCompartment = new System.Windows.Forms.DataGridView();
            this.labelAircraftCompartmentTypeRefCombo = new System.Windows.Forms.Label();
            this.aircraftCompartmentTypeRefCombo = new AircraftCompartmentTypeRefCombo();
            this.labelAircraftCompartmentName = new System.Windows.Forms.Label();
            this.textBoxAircraftCompartmentName = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAircraftCompartment)).BeginInit();
            this.SuspendLayout();
            //
            // labelAircraftCompartmentTypeRefCombo
            //
            this.labelAircraftCompartmentTypeRefCombo.AutoSize = true;
            this.labelAircraftCompartmentTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelAircraftCompartmentTypeRefCombo.Name = "labelAircraftCompartmentTypeRefCombo";
            this.labelAircraftCompartmentTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelAircraftCompartmentTypeRefCombo.TabIndex = 2;
            this.labelAircraftCompartmentTypeRefCombo.Text = "Aircraft Compartment Type:";
            //
            //aircraftCompartmentTypeRefCombo
            //
            this.aircraftCompartmentTypeRefCombo.Location = new System.Drawing.Point(224, 13);
            this.aircraftCompartmentTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.aircraftCompartmentTypeRefCombo.Name = "aircraftCompartmentTypeRefCombo";
            this.aircraftCompartmentTypeRefCombo.Size = new System.Drawing.Size(350, 20);
            this.aircraftCompartmentTypeRefCombo.TabIndex = 3;
            //
            // labelAircraftCompartmentName
            //
            this.labelAircraftCompartmentName.AutoSize = true;
            this.labelAircraftCompartmentName.Location = new System.Drawing.Point(11, 36);
            this.labelAircraftCompartmentName.Name = "labelAircraftCompartmentName";
            this.labelAircraftCompartmentName.Size = new System.Drawing.Size(71, 13);
            this.labelAircraftCompartmentName.TabIndex = 4;
            this.labelAircraftCompartmentName.Text = "Aircraft Compartment Name:";
            //
            //textBoxAircraftCompartmentName
            //
            this.textBoxAircraftCompartmentName.Location = new System.Drawing.Point(224, 36);
            this.textBoxAircraftCompartmentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAircraftCompartmentName.Name = "textBoxAircraftCompartmentName";
            this.textBoxAircraftCompartmentName.Size = new System.Drawing.Size(350, 20);
            this.textBoxAircraftCompartmentName.TabIndex = 5;
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
            this.userPicker.Location = new System.Drawing.Point(224, 59);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(350, 20);
            this.userPicker.TabIndex = 7;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(224, 82);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(350, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            // 
            // dataGridViewAircraftCompartment
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewAircraftCompartment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAircraftCompartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAircraftCompartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAircraftCompartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAircraftCompartment.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewAircraftCompartment.Name = "dataGridViewAircraftCompartment";
            this.dataGridViewAircraftCompartment.Size = new System.Drawing.Size(562, 96);
            this.dataGridViewAircraftCompartment.TabIndex = 0;
            this.dataGridViewAircraftCompartment.DoubleClick += new System.EventHandler(this.dataGridViewAircraftCompartment_DoubleClick);
            // 
            // buttonAircraftCompartmentSearch
            // 
            this.buttonAircraftCompartmentSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAircraftCompartmentSearch.Location = new System.Drawing.Point(282, 218);
            this.buttonAircraftCompartmentSearch.Name = "buttonAircraftCompartmentSearch";
            this.buttonAircraftCompartmentSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonAircraftCompartmentSearch.TabIndex = 2;
            this.buttonAircraftCompartmentSearch.Text = "&Search";
            this.buttonAircraftCompartmentSearch.UseVisualStyleBackColor = true;
            this.buttonAircraftCompartmentSearch.Click += new System.EventHandler(this.buttonAircraftCompartmentSearch_Click);
            // 
            // buttonAircraftCompartmentAdd
            // 
            this.buttonAircraftCompartmentAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAircraftCompartmentAdd.Location = new System.Drawing.Point(182, 218);
            this.buttonAircraftCompartmentAdd.Name = "buttonAircraftCompartmentAdd";
            this.buttonAircraftCompartmentAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonAircraftCompartmentAdd.TabIndex = 3;
            this.buttonAircraftCompartmentAdd.Text = "&Add";
            this.buttonAircraftCompartmentAdd.UseVisualStyleBackColor = true;
            this.buttonAircraftCompartmentAdd.Click += new System.EventHandler(this.buttonAircraftCompartmentAdd_Click);
            // 
            // buttonAircraftCompartmentEdit
            // 
            this.buttonAircraftCompartmentEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAircraftCompartmentEdit.Location = new System.Drawing.Point(82, 218);
            this.buttonAircraftCompartmentEdit.Name = "buttonAircraftCompartmentEdit";
            this.buttonAircraftCompartmentEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonAircraftCompartmentEdit.TabIndex = 4;
            this.buttonAircraftCompartmentEdit.Text = "&Edit";
            this.buttonAircraftCompartmentEdit.UseVisualStyleBackColor = true;
            this.buttonAircraftCompartmentEdit.Click += new System.EventHandler(this.buttonAircraftCompartmentEdit_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(482, 218);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(382, 218);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(92, 22);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // EditForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 246);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonAircraftCompartmentSearch);
            this.Controls.Add(this.buttonAircraftCompartmentAdd);
            this.Controls.Add(this.buttonAircraftCompartmentEdit);
            this.Controls.Add(this.dataGridViewAircraftCompartment);
            this.Name = "AircraftCompartmentEdit";
            this.Text = "Aircraft Compartment Edit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAircraftCompartment)).EndInit();
            this.Controls.Add(this.labelAircraftCompartmentTypeRefCombo);
            this.Controls.Add(this.aircraftCompartmentTypeRefCombo);
            this.Controls.Add(this.labelAircraftCompartmentName);
            this.Controls.Add(this.textBoxAircraftCompartmentName);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
