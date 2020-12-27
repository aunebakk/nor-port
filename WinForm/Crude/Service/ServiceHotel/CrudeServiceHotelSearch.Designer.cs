namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeServiceHotelSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeServiceHotelSearch;
        
        private System.Windows.Forms.Button buttonCrudeServiceHotelAdd;
        
        private System.Windows.Forms.Button buttonCrudeServiceHotelEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeServiceHotel;
        
        private System.Windows.Forms.TextBox textBoxHotelName;
        
        private System.Windows.Forms.Label labelHotelName;
        
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
            this.buttonCrudeServiceHotelAdd = new System.Windows.Forms.Button();
            this.buttonCrudeServiceHotelEdit = new System.Windows.Forms.Button();
            this.buttonCrudeServiceHotelSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeServiceHotel = new System.Windows.Forms.DataGridView();
            this.labelHotelName = new System.Windows.Forms.Label();
            this.textBoxHotelName = new System.Windows.Forms.TextBox();
            this.labelDayPriceAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxDayPriceAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelFinancialCurrencyPicker = new System.Windows.Forms.Label();
            this.financialCurrencyPicker = new FinancialCurrencyPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeServiceHotel)).BeginInit();
            this.SuspendLayout();
            //
            // labelHotelName
            //
            this.labelHotelName.AutoSize = true;
            this.labelHotelName.Location = new System.Drawing.Point(11, 13);
            this.labelHotelName.Name = "labelHotelName";
            this.labelHotelName.Size = new System.Drawing.Size(71, 13);
            this.labelHotelName.TabIndex = 2;
            this.labelHotelName.Text = "Hotel Name:";
            //
            //textBoxHotelName
            //
            this.textBoxHotelName.Location = new System.Drawing.Point(140, 13);
            this.textBoxHotelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHotelName.Name = "textBoxHotelName";
            this.textBoxHotelName.Size = new System.Drawing.Size(250, 20);
            this.textBoxHotelName.TabIndex = 3;
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
            // dataGridViewCrudeServiceHotel
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeServiceHotel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeServiceHotel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeServiceHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeServiceHotel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeServiceHotel.Location = new System.Drawing.Point(12, 138);
            this.dataGridViewCrudeServiceHotel.Name = "dataGridViewCrudeServiceHotel";
            this.dataGridViewCrudeServiceHotel.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeServiceHotel.TabIndex = 0;
            this.dataGridViewCrudeServiceHotel.ReadOnly = true;
            this.dataGridViewCrudeServiceHotel.DoubleClick += new System.EventHandler(this.dataGridViewCrudeServiceHotel_DoubleClick);
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
            // buttonCrudeServiceHotelSearch
            // 
            this.buttonCrudeServiceHotelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceHotelSearch.Location = new System.Drawing.Point(198, 241);
            this.buttonCrudeServiceHotelSearch.Name = "buttonCrudeServiceHotelSearch";
            this.buttonCrudeServiceHotelSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceHotelSearch.TabIndex = 2;
            this.buttonCrudeServiceHotelSearch.Text = "&Search";
            this.buttonCrudeServiceHotelSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceHotelSearch.Click += new System.EventHandler(this.buttonCrudeServiceHotelSearch_Click);
            // 
            // buttonCrudeServiceHotelAdd
            // 
            this.buttonCrudeServiceHotelAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceHotelAdd.Location = new System.Drawing.Point(98, 241);
            this.buttonCrudeServiceHotelAdd.Name = "buttonCrudeServiceHotelAdd";
            this.buttonCrudeServiceHotelAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceHotelAdd.TabIndex = 3;
            this.buttonCrudeServiceHotelAdd.Text = "&Add";
            this.buttonCrudeServiceHotelAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceHotelAdd.Click += new System.EventHandler(this.buttonCrudeServiceHotelAdd_Click);
            // 
            // buttonCrudeServiceHotelEdit
            // 
            this.buttonCrudeServiceHotelEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceHotelEdit.Location = new System.Drawing.Point(-2, 241);
            this.buttonCrudeServiceHotelEdit.Name = "buttonCrudeServiceHotelEdit";
            this.buttonCrudeServiceHotelEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceHotelEdit.TabIndex = 4;
            this.buttonCrudeServiceHotelEdit.Text = "&Edit";
            this.buttonCrudeServiceHotelEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceHotelEdit.Click += new System.EventHandler(this.buttonCrudeServiceHotelEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 269);
            this.Controls.Add(this.buttonCrudeServiceHotelSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeServiceHotelAdd);
            this.Controls.Add(this.buttonCrudeServiceHotelEdit);
            this.Controls.Add(this.dataGridViewCrudeServiceHotel);
            this.Name = "CrudeServiceHotelSearch";
            this.Text = "Service Hotel Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeServiceHotel)).EndInit();
            this.Controls.Add(this.labelHotelName);
            this.Controls.Add(this.textBoxHotelName);
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
