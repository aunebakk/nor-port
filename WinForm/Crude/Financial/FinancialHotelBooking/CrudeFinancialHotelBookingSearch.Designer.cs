namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFinancialHotelBookingSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialHotelBookingSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialHotelBookingAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialHotelBookingEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialHotelBooking;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAmount;
        
        private System.Windows.Forms.Label labelAmount;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDateTime;
        
        private System.Windows.Forms.Label labelFromDateTime;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerUntilDateTime;
        
        private System.Windows.Forms.Label labelUntilDateTime;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private FinancialCurrencyPicker financialCurrencyPicker;
        
        private System.Windows.Forms.Label labelFinancialCurrencyPicker;
        
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
            this.buttonCrudeFinancialHotelBookingAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialHotelBookingEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialHotelBookingSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialHotelBooking = new System.Windows.Forms.DataGridView();
            this.labelAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelFromDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerFromDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelUntilDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerUntilDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelFinancialCurrencyPicker = new System.Windows.Forms.Label();
            this.financialCurrencyPicker = new FinancialCurrencyPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialHotelBooking)).BeginInit();
            this.SuspendLayout();
            //
            // labelAmount
            //
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(11, 13);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(71, 13);
            this.labelAmount.TabIndex = 2;
            this.labelAmount.Text = "Amount:";
            //
            //maskedTextBoxAmount
            //
            this.maskedTextBoxAmount.Location = new System.Drawing.Point(140, 13);
            this.maskedTextBoxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxAmount.Name = "maskedTextBoxAmount";
            this.maskedTextBoxAmount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxAmount.TabIndex = 3;
            //
            // labelFromDateTime
            //
            this.labelFromDateTime.AutoSize = true;
            this.labelFromDateTime.Location = new System.Drawing.Point(11, 36);
            this.labelFromDateTime.Name = "labelFromDateTime";
            this.labelFromDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelFromDateTime.TabIndex = 4;
            this.labelFromDateTime.Text = "From Date Time:";
            //
            //dateTimePickerFromDateTime
            //
            this.dateTimePickerFromDateTime.Location = new System.Drawing.Point(140, 36);
            this.dateTimePickerFromDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFromDateTime.Name = "dateTimePickerFromDateTime";
            this.dateTimePickerFromDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerFromDateTime.TabIndex = 5;
            this.dateTimePickerFromDateTime.Checked = false;
            this.dateTimePickerFromDateTime.ShowCheckBox = true;
            //
            // labelUntilDateTime
            //
            this.labelUntilDateTime.AutoSize = true;
            this.labelUntilDateTime.Location = new System.Drawing.Point(11, 59);
            this.labelUntilDateTime.Name = "labelUntilDateTime";
            this.labelUntilDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelUntilDateTime.TabIndex = 6;
            this.labelUntilDateTime.Text = "Until Date Time:";
            //
            //dateTimePickerUntilDateTime
            //
            this.dateTimePickerUntilDateTime.Location = new System.Drawing.Point(140, 59);
            this.dateTimePickerUntilDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerUntilDateTime.Name = "dateTimePickerUntilDateTime";
            this.dateTimePickerUntilDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerUntilDateTime.TabIndex = 7;
            this.dateTimePickerUntilDateTime.Checked = false;
            this.dateTimePickerUntilDateTime.ShowCheckBox = true;
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
            // labelFinancialCurrencyPicker
            //
            this.labelFinancialCurrencyPicker.AutoSize = true;
            this.labelFinancialCurrencyPicker.Location = new System.Drawing.Point(11, 105);
            this.labelFinancialCurrencyPicker.Name = "labelFinancialCurrencyPicker";
            this.labelFinancialCurrencyPicker.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCurrencyPicker.TabIndex = 10;
            this.labelFinancialCurrencyPicker.Text = "Financial Currency:";
            //
            //financialCurrencyPicker
            //
            this.financialCurrencyPicker.Location = new System.Drawing.Point(140, 105);
            this.financialCurrencyPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialCurrencyPicker.Name = "financialCurrencyPicker";
            this.financialCurrencyPicker.Size = new System.Drawing.Size(250, 20);
            this.financialCurrencyPicker.TabIndex = 11;
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
            this.userPicker.Location = new System.Drawing.Point(140, 128);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 13;
            // 
            // dataGridViewCrudeFinancialHotelBooking
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialHotelBooking.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialHotelBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialHotelBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialHotelBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialHotelBooking.Location = new System.Drawing.Point(12, 161);
            this.dataGridViewCrudeFinancialHotelBooking.Name = "dataGridViewCrudeFinancialHotelBooking";
            this.dataGridViewCrudeFinancialHotelBooking.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeFinancialHotelBooking.TabIndex = 0;
            this.dataGridViewCrudeFinancialHotelBooking.ReadOnly = true;
            this.dataGridViewCrudeFinancialHotelBooking.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialHotelBooking_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 264);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialHotelBookingSearch
            // 
            this.buttonCrudeFinancialHotelBookingSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialHotelBookingSearch.Location = new System.Drawing.Point(198, 264);
            this.buttonCrudeFinancialHotelBookingSearch.Name = "buttonCrudeFinancialHotelBookingSearch";
            this.buttonCrudeFinancialHotelBookingSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialHotelBookingSearch.TabIndex = 2;
            this.buttonCrudeFinancialHotelBookingSearch.Text = "&Search";
            this.buttonCrudeFinancialHotelBookingSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialHotelBookingSearch.Click += new System.EventHandler(this.buttonCrudeFinancialHotelBookingSearch_Click);
            // 
            // buttonCrudeFinancialHotelBookingAdd
            // 
            this.buttonCrudeFinancialHotelBookingAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialHotelBookingAdd.Location = new System.Drawing.Point(98, 264);
            this.buttonCrudeFinancialHotelBookingAdd.Name = "buttonCrudeFinancialHotelBookingAdd";
            this.buttonCrudeFinancialHotelBookingAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialHotelBookingAdd.TabIndex = 3;
            this.buttonCrudeFinancialHotelBookingAdd.Text = "&Add";
            this.buttonCrudeFinancialHotelBookingAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialHotelBookingAdd.Click += new System.EventHandler(this.buttonCrudeFinancialHotelBookingAdd_Click);
            // 
            // buttonCrudeFinancialHotelBookingEdit
            // 
            this.buttonCrudeFinancialHotelBookingEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialHotelBookingEdit.Location = new System.Drawing.Point(-2, 264);
            this.buttonCrudeFinancialHotelBookingEdit.Name = "buttonCrudeFinancialHotelBookingEdit";
            this.buttonCrudeFinancialHotelBookingEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialHotelBookingEdit.TabIndex = 4;
            this.buttonCrudeFinancialHotelBookingEdit.Text = "&Edit";
            this.buttonCrudeFinancialHotelBookingEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialHotelBookingEdit.Click += new System.EventHandler(this.buttonCrudeFinancialHotelBookingEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 292);
            this.Controls.Add(this.buttonCrudeFinancialHotelBookingSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialHotelBookingAdd);
            this.Controls.Add(this.buttonCrudeFinancialHotelBookingEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialHotelBooking);
            this.Name = "CrudeFinancialHotelBookingSearch";
            this.Text = "Financial Hotel Booking Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialHotelBooking)).EndInit();
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.maskedTextBoxAmount);
            this.Controls.Add(this.labelFromDateTime);
            this.Controls.Add(this.dateTimePickerFromDateTime);
            this.Controls.Add(this.labelUntilDateTime);
            this.Controls.Add(this.dateTimePickerUntilDateTime);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelFinancialCurrencyPicker);
            this.Controls.Add(this.financialCurrencyPicker);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
