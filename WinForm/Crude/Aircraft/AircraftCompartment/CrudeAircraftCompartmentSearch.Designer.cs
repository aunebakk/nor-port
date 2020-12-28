namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAircraftCompartmentSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeAircraftCompartmentSearch;
        
        private System.Windows.Forms.Button buttonCrudeAircraftCompartmentAdd;
        
        private System.Windows.Forms.Button buttonCrudeAircraftCompartmentEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeAircraftCompartment;
        
        private System.Windows.Forms.TextBox textBoxAircraftCompartmentName;
        
        private System.Windows.Forms.Label labelAircraftCompartmentName;
        
        private AircraftCompartmentTypeRefCombo aircraftCompartmentTypeRefCombo;
        
        private System.Windows.Forms.Label labelAircraftCompartmentTypeRefCombo;
        
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
            this.buttonCrudeAircraftCompartmentAdd = new System.Windows.Forms.Button();
            this.buttonCrudeAircraftCompartmentEdit = new System.Windows.Forms.Button();
            this.buttonCrudeAircraftCompartmentSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeAircraftCompartment = new System.Windows.Forms.DataGridView();
            this.labelAircraftCompartmentName = new System.Windows.Forms.Label();
            this.textBoxAircraftCompartmentName = new System.Windows.Forms.TextBox();
            this.labelAircraftCompartmentTypeRefCombo = new System.Windows.Forms.Label();
            this.aircraftCompartmentTypeRefCombo = new AircraftCompartmentTypeRefCombo();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAircraftCompartment)).BeginInit();
            this.SuspendLayout();
            //
            // labelAircraftCompartmentName
            //
            this.labelAircraftCompartmentName.AutoSize = true;
            this.labelAircraftCompartmentName.Location = new System.Drawing.Point(11, 13);
            this.labelAircraftCompartmentName.Name = "labelAircraftCompartmentName";
            this.labelAircraftCompartmentName.Size = new System.Drawing.Size(71, 13);
            this.labelAircraftCompartmentName.TabIndex = 2;
            this.labelAircraftCompartmentName.Text = "Aircraft Compartment Name:";
            //
            //textBoxAircraftCompartmentName
            //
            this.textBoxAircraftCompartmentName.Location = new System.Drawing.Point(224, 13);
            this.textBoxAircraftCompartmentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAircraftCompartmentName.Name = "textBoxAircraftCompartmentName";
            this.textBoxAircraftCompartmentName.Size = new System.Drawing.Size(250, 20);
            this.textBoxAircraftCompartmentName.TabIndex = 3;
            //
            // labelAircraftCompartmentTypeRefCombo
            //
            this.labelAircraftCompartmentTypeRefCombo.AutoSize = true;
            this.labelAircraftCompartmentTypeRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelAircraftCompartmentTypeRefCombo.Name = "labelAircraftCompartmentTypeRefCombo";
            this.labelAircraftCompartmentTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelAircraftCompartmentTypeRefCombo.TabIndex = 4;
            this.labelAircraftCompartmentTypeRefCombo.Text = "Aircraft Compartment Type:";
            //
            //aircraftCompartmentTypeRefCombo
            //
            this.aircraftCompartmentTypeRefCombo.Location = new System.Drawing.Point(224, 36);
            this.aircraftCompartmentTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.aircraftCompartmentTypeRefCombo.Name = "aircraftCompartmentTypeRefCombo";
            this.aircraftCompartmentTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.aircraftCompartmentTypeRefCombo.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(224, 59);
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
            this.userPicker.Location = new System.Drawing.Point(224, 82);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 9;
            // 
            // dataGridViewCrudeAircraftCompartment
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeAircraftCompartment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeAircraftCompartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeAircraftCompartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeAircraftCompartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeAircraftCompartment.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeAircraftCompartment.Name = "dataGridViewCrudeAircraftCompartment";
            this.dataGridViewCrudeAircraftCompartment.Size = new System.Drawing.Size(462, 96);
            this.dataGridViewCrudeAircraftCompartment.TabIndex = 0;
            this.dataGridViewCrudeAircraftCompartment.ReadOnly = true;
            this.dataGridViewCrudeAircraftCompartment.DoubleClick += new System.EventHandler(this.dataGridViewCrudeAircraftCompartment_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(382, 218);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeAircraftCompartmentSearch
            // 
            this.buttonCrudeAircraftCompartmentSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAircraftCompartmentSearch.Location = new System.Drawing.Point(282, 218);
            this.buttonCrudeAircraftCompartmentSearch.Name = "buttonCrudeAircraftCompartmentSearch";
            this.buttonCrudeAircraftCompartmentSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAircraftCompartmentSearch.TabIndex = 2;
            this.buttonCrudeAircraftCompartmentSearch.Text = "&Search";
            this.buttonCrudeAircraftCompartmentSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeAircraftCompartmentSearch.Click += new System.EventHandler(this.buttonCrudeAircraftCompartmentSearch_Click);
            // 
            // buttonCrudeAircraftCompartmentAdd
            // 
            this.buttonCrudeAircraftCompartmentAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAircraftCompartmentAdd.Location = new System.Drawing.Point(182, 218);
            this.buttonCrudeAircraftCompartmentAdd.Name = "buttonCrudeAircraftCompartmentAdd";
            this.buttonCrudeAircraftCompartmentAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAircraftCompartmentAdd.TabIndex = 3;
            this.buttonCrudeAircraftCompartmentAdd.Text = "&Add";
            this.buttonCrudeAircraftCompartmentAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeAircraftCompartmentAdd.Click += new System.EventHandler(this.buttonCrudeAircraftCompartmentAdd_Click);
            // 
            // buttonCrudeAircraftCompartmentEdit
            // 
            this.buttonCrudeAircraftCompartmentEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAircraftCompartmentEdit.Location = new System.Drawing.Point(82, 218);
            this.buttonCrudeAircraftCompartmentEdit.Name = "buttonCrudeAircraftCompartmentEdit";
            this.buttonCrudeAircraftCompartmentEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAircraftCompartmentEdit.TabIndex = 4;
            this.buttonCrudeAircraftCompartmentEdit.Text = "&Edit";
            this.buttonCrudeAircraftCompartmentEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeAircraftCompartmentEdit.Click += new System.EventHandler(this.buttonCrudeAircraftCompartmentEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 246);
            this.Controls.Add(this.buttonCrudeAircraftCompartmentSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeAircraftCompartmentAdd);
            this.Controls.Add(this.buttonCrudeAircraftCompartmentEdit);
            this.Controls.Add(this.dataGridViewCrudeAircraftCompartment);
            this.Name = "CrudeAircraftCompartmentSearch";
            this.Text = "Aircraft Compartment Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAircraftCompartment)).EndInit();
            this.Controls.Add(this.labelAircraftCompartmentName);
            this.Controls.Add(this.textBoxAircraftCompartmentName);
            this.Controls.Add(this.labelAircraftCompartmentTypeRefCombo);
            this.Controls.Add(this.aircraftCompartmentTypeRefCombo);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
