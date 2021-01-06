namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFinancialFareSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialFareSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialFareAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialFareEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialFare;
        
        private FinancialFareTypeRefCombo financialFareTypeRefCombo;
        
        private System.Windows.Forms.Label labelFinancialFareTypeRefCombo;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAmount;
        
        private System.Windows.Forms.Label labelAmount;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerValidFromFlightDateTime;
        
        private System.Windows.Forms.Label labelValidFromFlightDateTime;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerValidUntilFlightDateTime;
        
        private System.Windows.Forms.Label labelValidUntilFlightDateTime;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private AirportPicker departureAirportPicker;
        
        private System.Windows.Forms.Label labelDepartureAirportPicker;
        
        private AirportPicker arrivalAirportPicker;
        
        private System.Windows.Forms.Label labelArrivalAirportPicker;
        
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
            this.buttonCrudeFinancialFareAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialFareEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialFareSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialFare = new System.Windows.Forms.DataGridView();
            this.labelFinancialFareTypeRefCombo = new System.Windows.Forms.Label();
            this.financialFareTypeRefCombo = new FinancialFareTypeRefCombo();
            this.labelAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelValidFromFlightDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerValidFromFlightDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelValidUntilFlightDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerValidUntilFlightDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelDepartureAirportPicker = new System.Windows.Forms.Label();
            this.departureAirportPicker = new AirportPicker();
            this.labelArrivalAirportPicker = new System.Windows.Forms.Label();
            this.arrivalAirportPicker = new AirportPicker();
            this.labelFinancialCurrencyPicker = new System.Windows.Forms.Label();
            this.financialCurrencyPicker = new FinancialCurrencyPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialFare)).BeginInit();
            this.SuspendLayout();
            //
            // labelFinancialFareTypeRefCombo
            //
            this.labelFinancialFareTypeRefCombo.AutoSize = true;
            this.labelFinancialFareTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialFareTypeRefCombo.Name = "labelFinancialFareTypeRefCombo";
            this.labelFinancialFareTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialFareTypeRefCombo.TabIndex = 2;
            this.labelFinancialFareTypeRefCombo.Text = "Financial Fare Type:";
            //
            //financialFareTypeRefCombo
            //
            this.financialFareTypeRefCombo.Location = new System.Drawing.Point(196, 13);
            this.financialFareTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialFareTypeRefCombo.Name = "financialFareTypeRefCombo";
            this.financialFareTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.financialFareTypeRefCombo.TabIndex = 3;
            //
            // labelAmount
            //
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(11, 36);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(71, 13);
            this.labelAmount.TabIndex = 4;
            this.labelAmount.Text = "Amount:";
            //
            //maskedTextBoxAmount
            //
            this.maskedTextBoxAmount.Location = new System.Drawing.Point(196, 36);
            this.maskedTextBoxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxAmount.Name = "maskedTextBoxAmount";
            this.maskedTextBoxAmount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxAmount.TabIndex = 5;
            //
            // labelValidFromFlightDateTime
            //
            this.labelValidFromFlightDateTime.AutoSize = true;
            this.labelValidFromFlightDateTime.Location = new System.Drawing.Point(11, 59);
            this.labelValidFromFlightDateTime.Name = "labelValidFromFlightDateTime";
            this.labelValidFromFlightDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelValidFromFlightDateTime.TabIndex = 6;
            this.labelValidFromFlightDateTime.Text = "Valid From Flight Date Time:";
            //
            //dateTimePickerValidFromFlightDateTime
            //
            this.dateTimePickerValidFromFlightDateTime.Location = new System.Drawing.Point(196, 59);
            this.dateTimePickerValidFromFlightDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerValidFromFlightDateTime.Name = "dateTimePickerValidFromFlightDateTime";
            this.dateTimePickerValidFromFlightDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerValidFromFlightDateTime.TabIndex = 7;
            this.dateTimePickerValidFromFlightDateTime.Checked = false;
            this.dateTimePickerValidFromFlightDateTime.ShowCheckBox = true;
            //
            // labelValidUntilFlightDateTime
            //
            this.labelValidUntilFlightDateTime.AutoSize = true;
            this.labelValidUntilFlightDateTime.Location = new System.Drawing.Point(11, 82);
            this.labelValidUntilFlightDateTime.Name = "labelValidUntilFlightDateTime";
            this.labelValidUntilFlightDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelValidUntilFlightDateTime.TabIndex = 8;
            this.labelValidUntilFlightDateTime.Text = "Valid Until Flight Date Time:";
            //
            //dateTimePickerValidUntilFlightDateTime
            //
            this.dateTimePickerValidUntilFlightDateTime.Location = new System.Drawing.Point(196, 82);
            this.dateTimePickerValidUntilFlightDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerValidUntilFlightDateTime.Name = "dateTimePickerValidUntilFlightDateTime";
            this.dateTimePickerValidUntilFlightDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerValidUntilFlightDateTime.TabIndex = 9;
            this.dateTimePickerValidUntilFlightDateTime.Checked = false;
            this.dateTimePickerValidUntilFlightDateTime.ShowCheckBox = true;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(196, 105);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 11;
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
            this.departureAirportPicker.Location = new System.Drawing.Point(196, 128);
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
            this.arrivalAirportPicker.Location = new System.Drawing.Point(196, 151);
            this.arrivalAirportPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.arrivalAirportPicker.Name = "arrivalAirportPicker";
            this.arrivalAirportPicker.Size = new System.Drawing.Size(250, 20);
            this.arrivalAirportPicker.TabIndex = 15;
            //
            // labelFinancialCurrencyPicker
            //
            this.labelFinancialCurrencyPicker.AutoSize = true;
            this.labelFinancialCurrencyPicker.Location = new System.Drawing.Point(11, 174);
            this.labelFinancialCurrencyPicker.Name = "labelFinancialCurrencyPicker";
            this.labelFinancialCurrencyPicker.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCurrencyPicker.TabIndex = 16;
            this.labelFinancialCurrencyPicker.Text = "Financial Currency:";
            //
            //financialCurrencyPicker
            //
            this.financialCurrencyPicker.Location = new System.Drawing.Point(196, 174);
            this.financialCurrencyPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialCurrencyPicker.Name = "financialCurrencyPicker";
            this.financialCurrencyPicker.Size = new System.Drawing.Size(250, 20);
            this.financialCurrencyPicker.TabIndex = 17;
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
            this.userPicker.Location = new System.Drawing.Point(196, 197);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 19;
            // 
            // dataGridViewCrudeFinancialFare
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialFare.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialFare.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialFare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialFare.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialFare.Location = new System.Drawing.Point(12, 230);
            this.dataGridViewCrudeFinancialFare.Name = "dataGridViewCrudeFinancialFare";
            this.dataGridViewCrudeFinancialFare.Size = new System.Drawing.Size(434, 96);
            this.dataGridViewCrudeFinancialFare.TabIndex = 0;
            this.dataGridViewCrudeFinancialFare.ReadOnly = true;
            this.dataGridViewCrudeFinancialFare.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialFare_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(354, 333);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialFareSearch
            // 
            this.buttonCrudeFinancialFareSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialFareSearch.Location = new System.Drawing.Point(254, 333);
            this.buttonCrudeFinancialFareSearch.Name = "buttonCrudeFinancialFareSearch";
            this.buttonCrudeFinancialFareSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialFareSearch.TabIndex = 2;
            this.buttonCrudeFinancialFareSearch.Text = "&Search";
            this.buttonCrudeFinancialFareSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialFareSearch.Click += new System.EventHandler(this.buttonCrudeFinancialFareSearch_Click);
            // 
            // buttonCrudeFinancialFareAdd
            // 
            this.buttonCrudeFinancialFareAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialFareAdd.Location = new System.Drawing.Point(154, 333);
            this.buttonCrudeFinancialFareAdd.Name = "buttonCrudeFinancialFareAdd";
            this.buttonCrudeFinancialFareAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialFareAdd.TabIndex = 3;
            this.buttonCrudeFinancialFareAdd.Text = "&Add";
            this.buttonCrudeFinancialFareAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialFareAdd.Click += new System.EventHandler(this.buttonCrudeFinancialFareAdd_Click);
            // 
            // buttonCrudeFinancialFareEdit
            // 
            this.buttonCrudeFinancialFareEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialFareEdit.Location = new System.Drawing.Point(54, 333);
            this.buttonCrudeFinancialFareEdit.Name = "buttonCrudeFinancialFareEdit";
            this.buttonCrudeFinancialFareEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialFareEdit.TabIndex = 4;
            this.buttonCrudeFinancialFareEdit.Text = "&Edit";
            this.buttonCrudeFinancialFareEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialFareEdit.Click += new System.EventHandler(this.buttonCrudeFinancialFareEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 361);
            this.Controls.Add(this.buttonCrudeFinancialFareSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialFareAdd);
            this.Controls.Add(this.buttonCrudeFinancialFareEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialFare);
            this.Name = "CrudeFinancialFareSearch";
            this.Text = "Financial Fare Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialFare)).EndInit();
            this.Controls.Add(this.labelFinancialFareTypeRefCombo);
            this.Controls.Add(this.financialFareTypeRefCombo);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.maskedTextBoxAmount);
            this.Controls.Add(this.labelValidFromFlightDateTime);
            this.Controls.Add(this.dateTimePickerValidFromFlightDateTime);
            this.Controls.Add(this.labelValidUntilFlightDateTime);
            this.Controls.Add(this.dateTimePickerValidUntilFlightDateTime);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelDepartureAirportPicker);
            this.Controls.Add(this.departureAirportPicker);
            this.Controls.Add(this.labelArrivalAirportPicker);
            this.Controls.Add(this.arrivalAirportPicker);
            this.Controls.Add(this.labelFinancialCurrencyPicker);
            this.Controls.Add(this.financialCurrencyPicker);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
