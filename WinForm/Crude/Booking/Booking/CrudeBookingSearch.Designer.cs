namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeBookingSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeBookingSearch;
        
        private System.Windows.Forms.Button buttonCrudeBookingAdd;
        
        private System.Windows.Forms.Button buttonCrudeBookingEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeBooking;
        
        private System.Windows.Forms.TextBox textBoxReceivedFrom;
        
        private System.Windows.Forms.Label labelReceivedFrom;
        
        private BookingSourceRefCombo bookingSourceRefCombo;
        
        private System.Windows.Forms.Label labelBookingSourceRefCombo;
        
        private System.Windows.Forms.TextBox textBoxComment;
        
        private System.Windows.Forms.Label labelComment;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private ExternalSystemPicker externalSystemPicker;
        
        private System.Windows.Forms.Label labelExternalSystemPicker;
        
        private AgencyPicker agencyPicker;
        
        private System.Windows.Forms.Label labelAgencyPicker;
        
        private FinancialCurrencyPicker financialCurrencyPicker;
        
        private System.Windows.Forms.Label labelFinancialCurrencyPicker;
        
        private FinancialCostcentrePicker financialCostcentrePicker;
        
        private System.Windows.Forms.Label labelFinancialCostcentrePicker;
        
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
            this.buttonCrudeBookingAdd = new System.Windows.Forms.Button();
            this.buttonCrudeBookingEdit = new System.Windows.Forms.Button();
            this.buttonCrudeBookingSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeBooking = new System.Windows.Forms.DataGridView();
            this.labelReceivedFrom = new System.Windows.Forms.Label();
            this.textBoxReceivedFrom = new System.Windows.Forms.TextBox();
            this.labelBookingSourceRefCombo = new System.Windows.Forms.Label();
            this.bookingSourceRefCombo = new BookingSourceRefCombo();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelExternalSystemPicker = new System.Windows.Forms.Label();
            this.externalSystemPicker = new ExternalSystemPicker();
            this.labelAgencyPicker = new System.Windows.Forms.Label();
            this.agencyPicker = new AgencyPicker();
            this.labelFinancialCurrencyPicker = new System.Windows.Forms.Label();
            this.financialCurrencyPicker = new FinancialCurrencyPicker();
            this.labelFinancialCostcentrePicker = new System.Windows.Forms.Label();
            this.financialCostcentrePicker = new FinancialCostcentrePicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeBooking)).BeginInit();
            this.SuspendLayout();
            //
            // labelReceivedFrom
            //
            this.labelReceivedFrom.AutoSize = true;
            this.labelReceivedFrom.Location = new System.Drawing.Point(11, 13);
            this.labelReceivedFrom.Name = "labelReceivedFrom";
            this.labelReceivedFrom.Size = new System.Drawing.Size(71, 13);
            this.labelReceivedFrom.TabIndex = 2;
            this.labelReceivedFrom.Text = "Received From:";
            //
            //textBoxReceivedFrom
            //
            this.textBoxReceivedFrom.Location = new System.Drawing.Point(140, 13);
            this.textBoxReceivedFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReceivedFrom.Name = "textBoxReceivedFrom";
            this.textBoxReceivedFrom.Size = new System.Drawing.Size(250, 20);
            this.textBoxReceivedFrom.TabIndex = 3;
            //
            // labelBookingSourceRefCombo
            //
            this.labelBookingSourceRefCombo.AutoSize = true;
            this.labelBookingSourceRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelBookingSourceRefCombo.Name = "labelBookingSourceRefCombo";
            this.labelBookingSourceRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelBookingSourceRefCombo.TabIndex = 4;
            this.labelBookingSourceRefCombo.Text = "Booking Source:";
            //
            //bookingSourceRefCombo
            //
            this.bookingSourceRefCombo.Location = new System.Drawing.Point(140, 36);
            this.bookingSourceRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.bookingSourceRefCombo.Name = "bookingSourceRefCombo";
            this.bookingSourceRefCombo.Size = new System.Drawing.Size(250, 20);
            this.bookingSourceRefCombo.TabIndex = 5;
            //
            // labelComment
            //
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(11, 59);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(71, 13);
            this.labelComment.TabIndex = 6;
            this.labelComment.Text = "Comment:";
            //
            //textBoxComment
            //
            this.textBoxComment.Location = new System.Drawing.Point(140, 59);
            this.textBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(250, 20);
            this.textBoxComment.TabIndex = 7;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 82);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            //
            // labelExternalSystemPicker
            //
            this.labelExternalSystemPicker.AutoSize = true;
            this.labelExternalSystemPicker.Location = new System.Drawing.Point(11, 105);
            this.labelExternalSystemPicker.Name = "labelExternalSystemPicker";
            this.labelExternalSystemPicker.Size = new System.Drawing.Size(71, 13);
            this.labelExternalSystemPicker.TabIndex = 10;
            this.labelExternalSystemPicker.Text = "External System:";
            //
            //externalSystemPicker
            //
            this.externalSystemPicker.Location = new System.Drawing.Point(140, 105);
            this.externalSystemPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.externalSystemPicker.Name = "externalSystemPicker";
            this.externalSystemPicker.Size = new System.Drawing.Size(250, 20);
            this.externalSystemPicker.TabIndex = 11;
            //
            // labelAgencyPicker
            //
            this.labelAgencyPicker.AutoSize = true;
            this.labelAgencyPicker.Location = new System.Drawing.Point(11, 128);
            this.labelAgencyPicker.Name = "labelAgencyPicker";
            this.labelAgencyPicker.Size = new System.Drawing.Size(71, 13);
            this.labelAgencyPicker.TabIndex = 12;
            this.labelAgencyPicker.Text = "Agency:";
            //
            //agencyPicker
            //
            this.agencyPicker.Location = new System.Drawing.Point(140, 128);
            this.agencyPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.agencyPicker.Name = "agencyPicker";
            this.agencyPicker.Size = new System.Drawing.Size(250, 20);
            this.agencyPicker.TabIndex = 13;
            //
            // labelFinancialCurrencyPicker
            //
            this.labelFinancialCurrencyPicker.AutoSize = true;
            this.labelFinancialCurrencyPicker.Location = new System.Drawing.Point(11, 151);
            this.labelFinancialCurrencyPicker.Name = "labelFinancialCurrencyPicker";
            this.labelFinancialCurrencyPicker.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCurrencyPicker.TabIndex = 14;
            this.labelFinancialCurrencyPicker.Text = "Financial Currency:";
            //
            //financialCurrencyPicker
            //
            this.financialCurrencyPicker.Location = new System.Drawing.Point(140, 151);
            this.financialCurrencyPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialCurrencyPicker.Name = "financialCurrencyPicker";
            this.financialCurrencyPicker.Size = new System.Drawing.Size(250, 20);
            this.financialCurrencyPicker.TabIndex = 15;
            //
            // labelFinancialCostcentrePicker
            //
            this.labelFinancialCostcentrePicker.AutoSize = true;
            this.labelFinancialCostcentrePicker.Location = new System.Drawing.Point(11, 174);
            this.labelFinancialCostcentrePicker.Name = "labelFinancialCostcentrePicker";
            this.labelFinancialCostcentrePicker.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCostcentrePicker.TabIndex = 16;
            this.labelFinancialCostcentrePicker.Text = "Financial Costcentre:";
            //
            //financialCostcentrePicker
            //
            this.financialCostcentrePicker.Location = new System.Drawing.Point(140, 174);
            this.financialCostcentrePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialCostcentrePicker.Name = "financialCostcentrePicker";
            this.financialCostcentrePicker.Size = new System.Drawing.Size(250, 20);
            this.financialCostcentrePicker.TabIndex = 17;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 197);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 18;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(140, 197);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 19;
            // 
            // dataGridViewCrudeBooking
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeBooking.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeBooking.Location = new System.Drawing.Point(12, 230);
            this.dataGridViewCrudeBooking.Name = "dataGridViewCrudeBooking";
            this.dataGridViewCrudeBooking.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeBooking.TabIndex = 0;
            this.dataGridViewCrudeBooking.ReadOnly = true;
            this.dataGridViewCrudeBooking.DoubleClick += new System.EventHandler(this.dataGridViewCrudeBooking_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 333);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeBookingSearch
            // 
            this.buttonCrudeBookingSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingSearch.Location = new System.Drawing.Point(198, 333);
            this.buttonCrudeBookingSearch.Name = "buttonCrudeBookingSearch";
            this.buttonCrudeBookingSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingSearch.TabIndex = 2;
            this.buttonCrudeBookingSearch.Text = "&Search";
            this.buttonCrudeBookingSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingSearch.Click += new System.EventHandler(this.buttonCrudeBookingSearch_Click);
            // 
            // buttonCrudeBookingAdd
            // 
            this.buttonCrudeBookingAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingAdd.Location = new System.Drawing.Point(98, 333);
            this.buttonCrudeBookingAdd.Name = "buttonCrudeBookingAdd";
            this.buttonCrudeBookingAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingAdd.TabIndex = 3;
            this.buttonCrudeBookingAdd.Text = "&Add";
            this.buttonCrudeBookingAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingAdd.Click += new System.EventHandler(this.buttonCrudeBookingAdd_Click);
            // 
            // buttonCrudeBookingEdit
            // 
            this.buttonCrudeBookingEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingEdit.Location = new System.Drawing.Point(-2, 333);
            this.buttonCrudeBookingEdit.Name = "buttonCrudeBookingEdit";
            this.buttonCrudeBookingEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingEdit.TabIndex = 4;
            this.buttonCrudeBookingEdit.Text = "&Edit";
            this.buttonCrudeBookingEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingEdit.Click += new System.EventHandler(this.buttonCrudeBookingEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 361);
            this.Controls.Add(this.buttonCrudeBookingSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeBookingAdd);
            this.Controls.Add(this.buttonCrudeBookingEdit);
            this.Controls.Add(this.dataGridViewCrudeBooking);
            this.Name = "CrudeBookingSearch";
            this.Text = "Booking Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeBooking)).EndInit();
            this.Controls.Add(this.labelReceivedFrom);
            this.Controls.Add(this.textBoxReceivedFrom);
            this.Controls.Add(this.labelBookingSourceRefCombo);
            this.Controls.Add(this.bookingSourceRefCombo);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelExternalSystemPicker);
            this.Controls.Add(this.externalSystemPicker);
            this.Controls.Add(this.labelAgencyPicker);
            this.Controls.Add(this.agencyPicker);
            this.Controls.Add(this.labelFinancialCurrencyPicker);
            this.Controls.Add(this.financialCurrencyPicker);
            this.Controls.Add(this.labelFinancialCostcentrePicker);
            this.Controls.Add(this.financialCostcentrePicker);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
