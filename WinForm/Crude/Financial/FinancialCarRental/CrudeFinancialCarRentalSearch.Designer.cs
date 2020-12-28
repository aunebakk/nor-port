﻿namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFinancialCarRentalSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialCarRentalSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialCarRentalAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialCarRentalEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialCarRental;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAmount;
        
        private System.Windows.Forms.Label labelAmount;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDateTime;
        
        private System.Windows.Forms.Label labelFromDateTime;
        
        private System.Windows.Forms.DateTimePicker dateTimePickerUntilDateTime;
        
        private System.Windows.Forms.Label labelUntilDateTime;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private ServiceCarRentalPicker serviceCarRentalPicker;
        
        private System.Windows.Forms.Label labelServiceCarRentalPicker;
        
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
            this.buttonCrudeFinancialCarRentalAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialCarRentalEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialCarRentalSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialCarRental = new System.Windows.Forms.DataGridView();
            this.labelAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelFromDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerFromDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelUntilDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerUntilDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelServiceCarRentalPicker = new System.Windows.Forms.Label();
            this.serviceCarRentalPicker = new ServiceCarRentalPicker();
            this.labelFinancialCurrencyPicker = new System.Windows.Forms.Label();
            this.financialCurrencyPicker = new FinancialCurrencyPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialCarRental)).BeginInit();
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
            this.serviceCarRentalPicker.Location = new System.Drawing.Point(140, 105);
            this.serviceCarRentalPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceCarRentalPicker.Name = "serviceCarRentalPicker";
            this.serviceCarRentalPicker.Size = new System.Drawing.Size(250, 20);
            this.serviceCarRentalPicker.TabIndex = 11;
            //
            // labelFinancialCurrencyPicker
            //
            this.labelFinancialCurrencyPicker.AutoSize = true;
            this.labelFinancialCurrencyPicker.Location = new System.Drawing.Point(11, 128);
            this.labelFinancialCurrencyPicker.Name = "labelFinancialCurrencyPicker";
            this.labelFinancialCurrencyPicker.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCurrencyPicker.TabIndex = 12;
            this.labelFinancialCurrencyPicker.Text = "Financial Currency:";
            //
            //financialCurrencyPicker
            //
            this.financialCurrencyPicker.Location = new System.Drawing.Point(140, 128);
            this.financialCurrencyPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialCurrencyPicker.Name = "financialCurrencyPicker";
            this.financialCurrencyPicker.Size = new System.Drawing.Size(250, 20);
            this.financialCurrencyPicker.TabIndex = 13;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 151);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 14;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(140, 151);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 15;
            // 
            // dataGridViewCrudeFinancialCarRental
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialCarRental.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialCarRental.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialCarRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialCarRental.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialCarRental.Location = new System.Drawing.Point(12, 184);
            this.dataGridViewCrudeFinancialCarRental.Name = "dataGridViewCrudeFinancialCarRental";
            this.dataGridViewCrudeFinancialCarRental.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeFinancialCarRental.TabIndex = 0;
            this.dataGridViewCrudeFinancialCarRental.ReadOnly = true;
            this.dataGridViewCrudeFinancialCarRental.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialCarRental_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 287);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialCarRentalSearch
            // 
            this.buttonCrudeFinancialCarRentalSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialCarRentalSearch.Location = new System.Drawing.Point(198, 287);
            this.buttonCrudeFinancialCarRentalSearch.Name = "buttonCrudeFinancialCarRentalSearch";
            this.buttonCrudeFinancialCarRentalSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialCarRentalSearch.TabIndex = 2;
            this.buttonCrudeFinancialCarRentalSearch.Text = "&Search";
            this.buttonCrudeFinancialCarRentalSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialCarRentalSearch.Click += new System.EventHandler(this.buttonCrudeFinancialCarRentalSearch_Click);
            // 
            // buttonCrudeFinancialCarRentalAdd
            // 
            this.buttonCrudeFinancialCarRentalAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialCarRentalAdd.Location = new System.Drawing.Point(98, 287);
            this.buttonCrudeFinancialCarRentalAdd.Name = "buttonCrudeFinancialCarRentalAdd";
            this.buttonCrudeFinancialCarRentalAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialCarRentalAdd.TabIndex = 3;
            this.buttonCrudeFinancialCarRentalAdd.Text = "&Add";
            this.buttonCrudeFinancialCarRentalAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialCarRentalAdd.Click += new System.EventHandler(this.buttonCrudeFinancialCarRentalAdd_Click);
            // 
            // buttonCrudeFinancialCarRentalEdit
            // 
            this.buttonCrudeFinancialCarRentalEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialCarRentalEdit.Location = new System.Drawing.Point(-2, 287);
            this.buttonCrudeFinancialCarRentalEdit.Name = "buttonCrudeFinancialCarRentalEdit";
            this.buttonCrudeFinancialCarRentalEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialCarRentalEdit.TabIndex = 4;
            this.buttonCrudeFinancialCarRentalEdit.Text = "&Edit";
            this.buttonCrudeFinancialCarRentalEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialCarRentalEdit.Click += new System.EventHandler(this.buttonCrudeFinancialCarRentalEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 315);
            this.Controls.Add(this.buttonCrudeFinancialCarRentalSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialCarRentalAdd);
            this.Controls.Add(this.buttonCrudeFinancialCarRentalEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialCarRental);
            this.Name = "CrudeFinancialCarRentalSearch";
            this.Text = "Financial Car Rental Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialCarRental)).EndInit();
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.maskedTextBoxAmount);
            this.Controls.Add(this.labelFromDateTime);
            this.Controls.Add(this.dateTimePickerFromDateTime);
            this.Controls.Add(this.labelUntilDateTime);
            this.Controls.Add(this.dateTimePickerUntilDateTime);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelServiceCarRentalPicker);
            this.Controls.Add(this.serviceCarRentalPicker);
            this.Controls.Add(this.labelFinancialCurrencyPicker);
            this.Controls.Add(this.financialCurrencyPicker);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
