namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeServiceCarRentalSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeServiceCarRentalSearch;
        
        private System.Windows.Forms.Button buttonCrudeServiceCarRentalAdd;
        
        private System.Windows.Forms.Button buttonCrudeServiceCarRentalEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeServiceCarRental;
        
        private System.Windows.Forms.TextBox textBoxCarName;
        
        private System.Windows.Forms.Label labelCarName;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDayPriceAmount;
        
        private System.Windows.Forms.Label labelDayPriceAmount;
        
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
            this.buttonCrudeServiceCarRentalAdd = new System.Windows.Forms.Button();
            this.buttonCrudeServiceCarRentalEdit = new System.Windows.Forms.Button();
            this.buttonCrudeServiceCarRentalSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeServiceCarRental = new System.Windows.Forms.DataGridView();
            this.labelCarName = new System.Windows.Forms.Label();
            this.textBoxCarName = new System.Windows.Forms.TextBox();
            this.labelDayPriceAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxDayPriceAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelFinancialCurrencyPicker = new System.Windows.Forms.Label();
            this.financialCurrencyPicker = new FinancialCurrencyPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeServiceCarRental)).BeginInit();
            this.SuspendLayout();
            //
            // labelCarName
            //
            this.labelCarName.AutoSize = true;
            this.labelCarName.Location = new System.Drawing.Point(11, 13);
            this.labelCarName.Name = "labelCarName";
            this.labelCarName.Size = new System.Drawing.Size(71, 13);
            this.labelCarName.TabIndex = 2;
            this.labelCarName.Text = "Car Name:";
            //
            //textBoxCarName
            //
            this.textBoxCarName.Location = new System.Drawing.Point(140, 13);
            this.textBoxCarName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCarName.Name = "textBoxCarName";
            this.textBoxCarName.Size = new System.Drawing.Size(250, 20);
            this.textBoxCarName.TabIndex = 3;
            //
            // labelDayPriceAmount
            //
            this.labelDayPriceAmount.AutoSize = true;
            this.labelDayPriceAmount.Location = new System.Drawing.Point(11, 36);
            this.labelDayPriceAmount.Name = "labelDayPriceAmount";
            this.labelDayPriceAmount.Size = new System.Drawing.Size(71, 13);
            this.labelDayPriceAmount.TabIndex = 4;
            this.labelDayPriceAmount.Text = "Day Price Amount:";
            //
            //maskedTextBoxDayPriceAmount
            //
            this.maskedTextBoxDayPriceAmount.Location = new System.Drawing.Point(140, 36);
            this.maskedTextBoxDayPriceAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxDayPriceAmount.Name = "maskedTextBoxDayPriceAmount";
            this.maskedTextBoxDayPriceAmount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxDayPriceAmount.TabIndex = 5;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
            //
            // labelFinancialCurrencyPicker
            //
            this.labelFinancialCurrencyPicker.AutoSize = true;
            this.labelFinancialCurrencyPicker.Location = new System.Drawing.Point(11, 82);
            this.labelFinancialCurrencyPicker.Name = "labelFinancialCurrencyPicker";
            this.labelFinancialCurrencyPicker.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCurrencyPicker.TabIndex = 8;
            this.labelFinancialCurrencyPicker.Text = "Financial Currency:";
            //
            //financialCurrencyPicker
            //
            this.financialCurrencyPicker.Location = new System.Drawing.Point(140, 82);
            this.financialCurrencyPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialCurrencyPicker.Name = "financialCurrencyPicker";
            this.financialCurrencyPicker.Size = new System.Drawing.Size(250, 20);
            this.financialCurrencyPicker.TabIndex = 9;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 105);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 10;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(140, 105);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 11;
            // 
            // dataGridViewCrudeServiceCarRental
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeServiceCarRental.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeServiceCarRental.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeServiceCarRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeServiceCarRental.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeServiceCarRental.Location = new System.Drawing.Point(12, 138);
            this.dataGridViewCrudeServiceCarRental.Name = "dataGridViewCrudeServiceCarRental";
            this.dataGridViewCrudeServiceCarRental.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeServiceCarRental.TabIndex = 0;
            this.dataGridViewCrudeServiceCarRental.ReadOnly = true;
            this.dataGridViewCrudeServiceCarRental.DoubleClick += new System.EventHandler(this.dataGridViewCrudeServiceCarRental_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 241);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeServiceCarRentalSearch
            // 
            this.buttonCrudeServiceCarRentalSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceCarRentalSearch.Location = new System.Drawing.Point(198, 241);
            this.buttonCrudeServiceCarRentalSearch.Name = "buttonCrudeServiceCarRentalSearch";
            this.buttonCrudeServiceCarRentalSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceCarRentalSearch.TabIndex = 2;
            this.buttonCrudeServiceCarRentalSearch.Text = "&Search";
            this.buttonCrudeServiceCarRentalSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceCarRentalSearch.Click += new System.EventHandler(this.buttonCrudeServiceCarRentalSearch_Click);
            // 
            // buttonCrudeServiceCarRentalAdd
            // 
            this.buttonCrudeServiceCarRentalAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceCarRentalAdd.Location = new System.Drawing.Point(98, 241);
            this.buttonCrudeServiceCarRentalAdd.Name = "buttonCrudeServiceCarRentalAdd";
            this.buttonCrudeServiceCarRentalAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceCarRentalAdd.TabIndex = 3;
            this.buttonCrudeServiceCarRentalAdd.Text = "&Add";
            this.buttonCrudeServiceCarRentalAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceCarRentalAdd.Click += new System.EventHandler(this.buttonCrudeServiceCarRentalAdd_Click);
            // 
            // buttonCrudeServiceCarRentalEdit
            // 
            this.buttonCrudeServiceCarRentalEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceCarRentalEdit.Location = new System.Drawing.Point(-2, 241);
            this.buttonCrudeServiceCarRentalEdit.Name = "buttonCrudeServiceCarRentalEdit";
            this.buttonCrudeServiceCarRentalEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceCarRentalEdit.TabIndex = 4;
            this.buttonCrudeServiceCarRentalEdit.Text = "&Edit";
            this.buttonCrudeServiceCarRentalEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceCarRentalEdit.Click += new System.EventHandler(this.buttonCrudeServiceCarRentalEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 269);
            this.Controls.Add(this.buttonCrudeServiceCarRentalSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeServiceCarRentalAdd);
            this.Controls.Add(this.buttonCrudeServiceCarRentalEdit);
            this.Controls.Add(this.dataGridViewCrudeServiceCarRental);
            this.Name = "CrudeServiceCarRentalSearch";
            this.Text = "Service Car Rental Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeServiceCarRental)).EndInit();
            this.Controls.Add(this.labelCarName);
            this.Controls.Add(this.textBoxCarName);
            this.Controls.Add(this.labelDayPriceAmount);
            this.Controls.Add(this.maskedTextBoxDayPriceAmount);
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
