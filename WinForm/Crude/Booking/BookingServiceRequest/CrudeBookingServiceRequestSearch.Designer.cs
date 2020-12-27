namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeBookingServiceRequestSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeBookingServiceRequestSearch;
        
        private System.Windows.Forms.Button buttonCrudeBookingServiceRequestAdd;
        
        private System.Windows.Forms.Button buttonCrudeBookingServiceRequestEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeBookingServiceRequest;
        
        private ServiceTypeRefCombo serviceTypeRefCombo;
        
        private System.Windows.Forms.Label labelServiceTypeRefCombo;
        
        private ServiceRequestStatusRefCombo serviceRequestStatusRefCombo;
        
        private System.Windows.Forms.Label labelServiceRequestStatusRefCombo;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private ServiceSpecialServiceRequestPicker serviceSpecialServiceRequestPicker;
        
        private System.Windows.Forms.Label labelServiceSpecialServiceRequestPicker;
        
        private ServiceCarRentalPicker serviceCarRentalPicker;
        
        private System.Windows.Forms.Label labelServiceCarRentalPicker;
        
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
            this.buttonCrudeBookingServiceRequestAdd = new System.Windows.Forms.Button();
            this.buttonCrudeBookingServiceRequestEdit = new System.Windows.Forms.Button();
            this.buttonCrudeBookingServiceRequestSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeBookingServiceRequest = new System.Windows.Forms.DataGridView();
            this.labelServiceTypeRefCombo = new System.Windows.Forms.Label();
            this.serviceTypeRefCombo = new ServiceTypeRefCombo();
            this.labelServiceRequestStatusRefCombo = new System.Windows.Forms.Label();
            this.serviceRequestStatusRefCombo = new ServiceRequestStatusRefCombo();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelServiceSpecialServiceRequestPicker = new System.Windows.Forms.Label();
            this.serviceSpecialServiceRequestPicker = new ServiceSpecialServiceRequestPicker();
            this.labelServiceCarRentalPicker = new System.Windows.Forms.Label();
            this.serviceCarRentalPicker = new ServiceCarRentalPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeBookingServiceRequest)).BeginInit();
            this.SuspendLayout();
            //
            // labelServiceTypeRefCombo
            //
            this.labelServiceTypeRefCombo.AutoSize = true;
            this.labelServiceTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelServiceTypeRefCombo.Name = "labelServiceTypeRefCombo";
            this.labelServiceTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelServiceTypeRefCombo.TabIndex = 2;
            this.labelServiceTypeRefCombo.Text = "Service Type:";
            //
            //serviceTypeRefCombo
            //
            this.serviceTypeRefCombo.Location = new System.Drawing.Point(217, 13);
            this.serviceTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceTypeRefCombo.Name = "serviceTypeRefCombo";
            this.serviceTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.serviceTypeRefCombo.TabIndex = 3;
            //
            // labelServiceRequestStatusRefCombo
            //
            this.labelServiceRequestStatusRefCombo.AutoSize = true;
            this.labelServiceRequestStatusRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelServiceRequestStatusRefCombo.Name = "labelServiceRequestStatusRefCombo";
            this.labelServiceRequestStatusRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelServiceRequestStatusRefCombo.TabIndex = 4;
            this.labelServiceRequestStatusRefCombo.Text = "Service Request Status:";
            //
            //serviceRequestStatusRefCombo
            //
            this.serviceRequestStatusRefCombo.Location = new System.Drawing.Point(217, 36);
            this.serviceRequestStatusRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceRequestStatusRefCombo.Name = "serviceRequestStatusRefCombo";
            this.serviceRequestStatusRefCombo.Size = new System.Drawing.Size(250, 20);
            this.serviceRequestStatusRefCombo.TabIndex = 5;
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
            this.userPicker.Location = new System.Drawing.Point(217, 128);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 13;
            // 
            // dataGridViewCrudeBookingServiceRequest
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeBookingServiceRequest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeBookingServiceRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeBookingServiceRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeBookingServiceRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeBookingServiceRequest.Location = new System.Drawing.Point(12, 161);
            this.dataGridViewCrudeBookingServiceRequest.Name = "dataGridViewCrudeBookingServiceRequest";
            this.dataGridViewCrudeBookingServiceRequest.Size = new System.Drawing.Size(455, 96);
            this.dataGridViewCrudeBookingServiceRequest.TabIndex = 0;
            this.dataGridViewCrudeBookingServiceRequest.ReadOnly = true;
            this.dataGridViewCrudeBookingServiceRequest.DoubleClick += new System.EventHandler(this.dataGridViewCrudeBookingServiceRequest_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(375, 264);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeBookingServiceRequestSearch
            // 
            this.buttonCrudeBookingServiceRequestSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingServiceRequestSearch.Location = new System.Drawing.Point(275, 264);
            this.buttonCrudeBookingServiceRequestSearch.Name = "buttonCrudeBookingServiceRequestSearch";
            this.buttonCrudeBookingServiceRequestSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingServiceRequestSearch.TabIndex = 2;
            this.buttonCrudeBookingServiceRequestSearch.Text = "&Search";
            this.buttonCrudeBookingServiceRequestSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingServiceRequestSearch.Click += new System.EventHandler(this.buttonCrudeBookingServiceRequestSearch_Click);
            // 
            // buttonCrudeBookingServiceRequestAdd
            // 
            this.buttonCrudeBookingServiceRequestAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingServiceRequestAdd.Location = new System.Drawing.Point(175, 264);
            this.buttonCrudeBookingServiceRequestAdd.Name = "buttonCrudeBookingServiceRequestAdd";
            this.buttonCrudeBookingServiceRequestAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingServiceRequestAdd.TabIndex = 3;
            this.buttonCrudeBookingServiceRequestAdd.Text = "&Add";
            this.buttonCrudeBookingServiceRequestAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingServiceRequestAdd.Click += new System.EventHandler(this.buttonCrudeBookingServiceRequestAdd_Click);
            // 
            // buttonCrudeBookingServiceRequestEdit
            // 
            this.buttonCrudeBookingServiceRequestEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingServiceRequestEdit.Location = new System.Drawing.Point(75, 264);
            this.buttonCrudeBookingServiceRequestEdit.Name = "buttonCrudeBookingServiceRequestEdit";
            this.buttonCrudeBookingServiceRequestEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingServiceRequestEdit.TabIndex = 4;
            this.buttonCrudeBookingServiceRequestEdit.Text = "&Edit";
            this.buttonCrudeBookingServiceRequestEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingServiceRequestEdit.Click += new System.EventHandler(this.buttonCrudeBookingServiceRequestEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 292);
            this.Controls.Add(this.buttonCrudeBookingServiceRequestSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeBookingServiceRequestAdd);
            this.Controls.Add(this.buttonCrudeBookingServiceRequestEdit);
            this.Controls.Add(this.dataGridViewCrudeBookingServiceRequest);
            this.Name = "CrudeBookingServiceRequestSearch";
            this.Text = "Booking Service Request Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeBookingServiceRequest)).EndInit();
            this.Controls.Add(this.labelServiceTypeRefCombo);
            this.Controls.Add(this.serviceTypeRefCombo);
            this.Controls.Add(this.labelServiceRequestStatusRefCombo);
            this.Controls.Add(this.serviceRequestStatusRefCombo);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelServiceSpecialServiceRequestPicker);
            this.Controls.Add(this.serviceSpecialServiceRequestPicker);
            this.Controls.Add(this.labelServiceCarRentalPicker);
            this.Controls.Add(this.serviceCarRentalPicker);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
