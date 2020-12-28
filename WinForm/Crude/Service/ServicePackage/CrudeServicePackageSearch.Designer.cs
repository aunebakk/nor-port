namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeServicePackageSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeServicePackageSearch;
        
        private System.Windows.Forms.Button buttonCrudeServicePackageAdd;
        
        private System.Windows.Forms.Button buttonCrudeServicePackageEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeServicePackage;
        
        private System.Windows.Forms.TextBox textBoxServicePackageName;
        
        private System.Windows.Forms.Label labelServicePackageName;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxStayDurationDays;
        
        private System.Windows.Forms.Label labelStayDurationDays;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private ServiceSpecialServiceRequestPicker serviceSpecialServiceRequestPicker;
        
        private System.Windows.Forms.Label labelServiceSpecialServiceRequestPicker;
        
        private ServiceCarRentalPicker serviceCarRentalPicker;
        
        private System.Windows.Forms.Label labelServiceCarRentalPicker;
        
        private AirportPicker departureAirportPicker;
        
        private System.Windows.Forms.Label labelDepartureAirportPicker;
        
        private AirportPicker arrivalAirportPicker;
        
        private System.Windows.Forms.Label labelArrivalAirportPicker;
        
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
            this.buttonCrudeServicePackageAdd = new System.Windows.Forms.Button();
            this.buttonCrudeServicePackageEdit = new System.Windows.Forms.Button();
            this.buttonCrudeServicePackageSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeServicePackage = new System.Windows.Forms.DataGridView();
            this.labelServicePackageName = new System.Windows.Forms.Label();
            this.textBoxServicePackageName = new System.Windows.Forms.TextBox();
            this.labelStayDurationDays = new System.Windows.Forms.Label();
            this.maskedTextBoxStayDurationDays = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelServiceSpecialServiceRequestPicker = new System.Windows.Forms.Label();
            this.serviceSpecialServiceRequestPicker = new ServiceSpecialServiceRequestPicker();
            this.labelServiceCarRentalPicker = new System.Windows.Forms.Label();
            this.serviceCarRentalPicker = new ServiceCarRentalPicker();
            this.labelDepartureAirportPicker = new System.Windows.Forms.Label();
            this.departureAirportPicker = new AirportPicker();
            this.labelArrivalAirportPicker = new System.Windows.Forms.Label();
            this.arrivalAirportPicker = new AirportPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeServicePackage)).BeginInit();
            this.SuspendLayout();
            //
            // labelServicePackageName
            //
            this.labelServicePackageName.AutoSize = true;
            this.labelServicePackageName.Location = new System.Drawing.Point(11, 13);
            this.labelServicePackageName.Name = "labelServicePackageName";
            this.labelServicePackageName.Size = new System.Drawing.Size(71, 13);
            this.labelServicePackageName.TabIndex = 2;
            this.labelServicePackageName.Text = "Service Package Name:";
            //
            //textBoxServicePackageName
            //
            this.textBoxServicePackageName.Location = new System.Drawing.Point(217, 13);
            this.textBoxServicePackageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServicePackageName.Name = "textBoxServicePackageName";
            this.textBoxServicePackageName.Size = new System.Drawing.Size(250, 20);
            this.textBoxServicePackageName.TabIndex = 3;
            //
            // labelStayDurationDays
            //
            this.labelStayDurationDays.AutoSize = true;
            this.labelStayDurationDays.Location = new System.Drawing.Point(11, 36);
            this.labelStayDurationDays.Name = "labelStayDurationDays";
            this.labelStayDurationDays.Size = new System.Drawing.Size(71, 13);
            this.labelStayDurationDays.TabIndex = 4;
            this.labelStayDurationDays.Text = "Stay Duration Days:";
            //
            //maskedTextBoxStayDurationDays
            //
            this.maskedTextBoxStayDurationDays.Location = new System.Drawing.Point(217, 36);
            this.maskedTextBoxStayDurationDays.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxStayDurationDays.Name = "maskedTextBoxStayDurationDays";
            this.maskedTextBoxStayDurationDays.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxStayDurationDays.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(217, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            //
            // labelServiceSpecialServiceRequestPicker
            //
            this.labelServiceSpecialServiceRequestPicker.AutoSize = true;
            this.labelServiceSpecialServiceRequestPicker.Location = new System.Drawing.Point(11, 82);
            this.labelServiceSpecialServiceRequestPicker.Name = "labelServiceSpecialServiceRequestPicker";
            this.labelServiceSpecialServiceRequestPicker.Size = new System.Drawing.Size(71, 13);
            this.labelServiceSpecialServiceRequestPicker.TabIndex = 8;
            this.labelServiceSpecialServiceRequestPicker.Text = "Service Special Service Request:";
            //
            //serviceSpecialServiceRequestPicker
            //
            this.serviceSpecialServiceRequestPicker.Location = new System.Drawing.Point(217, 82);
            this.serviceSpecialServiceRequestPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceSpecialServiceRequestPicker.Name = "serviceSpecialServiceRequestPicker";
            this.serviceSpecialServiceRequestPicker.Size = new System.Drawing.Size(250, 20);
            this.serviceSpecialServiceRequestPicker.TabIndex = 9;
            //
            // labelServiceCarRentalPicker
            //
            this.labelServiceCarRentalPicker.AutoSize = true;
            this.labelServiceCarRentalPicker.Location = new System.Drawing.Point(11, 105);
            this.labelServiceCarRentalPicker.Name = "labelServiceCarRentalPicker";
            this.labelServiceCarRentalPicker.Size = new System.Drawing.Size(71, 13);
            this.labelServiceCarRentalPicker.TabIndex = 10;
            this.labelServiceCarRentalPicker.Text = "Service Car Rental:";
            //
            //serviceCarRentalPicker
            //
            this.serviceCarRentalPicker.Location = new System.Drawing.Point(217, 105);
            this.serviceCarRentalPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceCarRentalPicker.Name = "serviceCarRentalPicker";
            this.serviceCarRentalPicker.Size = new System.Drawing.Size(250, 20);
            this.serviceCarRentalPicker.TabIndex = 11;
            //
            // labelDepartureAirportPicker
            //
            this.labelDepartureAirportPicker.AutoSize = true;
            this.labelDepartureAirportPicker.Location = new System.Drawing.Point(11, 128);
            this.labelDepartureAirportPicker.Name = "labelDepartureAirportPicker";
            this.labelDepartureAirportPicker.Size = new System.Drawing.Size(71, 13);
            this.labelDepartureAirportPicker.TabIndex = 12;
            this.labelDepartureAirportPicker.Text = "Departure Airport:";
            //
            //departureAirportPicker
            //
            this.departureAirportPicker.Location = new System.Drawing.Point(217, 128);
            this.departureAirportPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.departureAirportPicker.Name = "departureAirportPicker";
            this.departureAirportPicker.Size = new System.Drawing.Size(250, 20);
            this.departureAirportPicker.TabIndex = 13;
            //
            // labelArrivalAirportPicker
            //
            this.labelArrivalAirportPicker.AutoSize = true;
            this.labelArrivalAirportPicker.Location = new System.Drawing.Point(11, 151);
            this.labelArrivalAirportPicker.Name = "labelArrivalAirportPicker";
            this.labelArrivalAirportPicker.Size = new System.Drawing.Size(71, 13);
            this.labelArrivalAirportPicker.TabIndex = 14;
            this.labelArrivalAirportPicker.Text = "Arrival Airport:";
            //
            //arrivalAirportPicker
            //
            this.arrivalAirportPicker.Location = new System.Drawing.Point(217, 151);
            this.arrivalAirportPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.arrivalAirportPicker.Name = "arrivalAirportPicker";
            this.arrivalAirportPicker.Size = new System.Drawing.Size(250, 20);
            this.arrivalAirportPicker.TabIndex = 15;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 174);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 16;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(217, 174);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 17;
            // 
            // dataGridViewCrudeServicePackage
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeServicePackage.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeServicePackage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeServicePackage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeServicePackage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeServicePackage.Location = new System.Drawing.Point(12, 207);
            this.dataGridViewCrudeServicePackage.Name = "dataGridViewCrudeServicePackage";
            this.dataGridViewCrudeServicePackage.Size = new System.Drawing.Size(455, 96);
            this.dataGridViewCrudeServicePackage.TabIndex = 0;
            this.dataGridViewCrudeServicePackage.ReadOnly = true;
            this.dataGridViewCrudeServicePackage.DoubleClick += new System.EventHandler(this.dataGridViewCrudeServicePackage_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(375, 310);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeServicePackageSearch
            // 
            this.buttonCrudeServicePackageSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServicePackageSearch.Location = new System.Drawing.Point(275, 310);
            this.buttonCrudeServicePackageSearch.Name = "buttonCrudeServicePackageSearch";
            this.buttonCrudeServicePackageSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServicePackageSearch.TabIndex = 2;
            this.buttonCrudeServicePackageSearch.Text = "&Search";
            this.buttonCrudeServicePackageSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeServicePackageSearch.Click += new System.EventHandler(this.buttonCrudeServicePackageSearch_Click);
            // 
            // buttonCrudeServicePackageAdd
            // 
            this.buttonCrudeServicePackageAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServicePackageAdd.Location = new System.Drawing.Point(175, 310);
            this.buttonCrudeServicePackageAdd.Name = "buttonCrudeServicePackageAdd";
            this.buttonCrudeServicePackageAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServicePackageAdd.TabIndex = 3;
            this.buttonCrudeServicePackageAdd.Text = "&Add";
            this.buttonCrudeServicePackageAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeServicePackageAdd.Click += new System.EventHandler(this.buttonCrudeServicePackageAdd_Click);
            // 
            // buttonCrudeServicePackageEdit
            // 
            this.buttonCrudeServicePackageEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServicePackageEdit.Location = new System.Drawing.Point(75, 310);
            this.buttonCrudeServicePackageEdit.Name = "buttonCrudeServicePackageEdit";
            this.buttonCrudeServicePackageEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServicePackageEdit.TabIndex = 4;
            this.buttonCrudeServicePackageEdit.Text = "&Edit";
            this.buttonCrudeServicePackageEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeServicePackageEdit.Click += new System.EventHandler(this.buttonCrudeServicePackageEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 338);
            this.Controls.Add(this.buttonCrudeServicePackageSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeServicePackageAdd);
            this.Controls.Add(this.buttonCrudeServicePackageEdit);
            this.Controls.Add(this.dataGridViewCrudeServicePackage);
            this.Name = "CrudeServicePackageSearch";
            this.Text = "Service Package Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeServicePackage)).EndInit();
            this.Controls.Add(this.labelServicePackageName);
            this.Controls.Add(this.textBoxServicePackageName);
            this.Controls.Add(this.labelStayDurationDays);
            this.Controls.Add(this.maskedTextBoxStayDurationDays);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelServiceSpecialServiceRequestPicker);
            this.Controls.Add(this.serviceSpecialServiceRequestPicker);
            this.Controls.Add(this.labelServiceCarRentalPicker);
            this.Controls.Add(this.serviceCarRentalPicker);
            this.Controls.Add(this.labelDepartureAirportPicker);
            this.Controls.Add(this.departureAirportPicker);
            this.Controls.Add(this.labelArrivalAirportPicker);
            this.Controls.Add(this.arrivalAirportPicker);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
