﻿namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFinancialBookingTransactionSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFinancialBookingTransactionSearch;
        
        private System.Windows.Forms.Button buttonCrudeFinancialBookingTransactionAdd;
        
        private System.Windows.Forms.Button buttonCrudeFinancialBookingTransactionEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFinancialBookingTransaction;
        
        private FinancialBookingTransactionTypeRefCombo financialBookingTransactionTypeRefCombo;
        
        private System.Windows.Forms.Label labelFinancialBookingTransactionTypeRefCombo;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTransactionNumber;
        
        private System.Windows.Forms.Label labelTransactionNumber;
        
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAmount;
        
        private System.Windows.Forms.Label labelAmount;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
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
            this.buttonCrudeFinancialBookingTransactionAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialBookingTransactionEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFinancialBookingTransactionSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFinancialBookingTransaction = new System.Windows.Forms.DataGridView();
            this.labelFinancialBookingTransactionTypeRefCombo = new System.Windows.Forms.Label();
            this.financialBookingTransactionTypeRefCombo = new FinancialBookingTransactionTypeRefCombo();
            this.labelTransactionNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxTransactionNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.maskedTextBoxAmount = new System.Windows.Forms.MaskedTextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelFinancialCurrencyPicker = new System.Windows.Forms.Label();
            this.financialCurrencyPicker = new FinancialCurrencyPicker();
            this.labelFinancialCostcentrePicker = new System.Windows.Forms.Label();
            this.financialCostcentrePicker = new FinancialCostcentrePicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialBookingTransaction)).BeginInit();
            this.SuspendLayout();
            //
            // labelFinancialBookingTransactionTypeRefCombo
            //
            this.labelFinancialBookingTransactionTypeRefCombo.AutoSize = true;
            this.labelFinancialBookingTransactionTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelFinancialBookingTransactionTypeRefCombo.Name = "labelFinancialBookingTransactionTypeRefCombo";
            this.labelFinancialBookingTransactionTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialBookingTransactionTypeRefCombo.TabIndex = 2;
            this.labelFinancialBookingTransactionTypeRefCombo.Text = "Financial Booking Transaction Type:";
            //
            //financialBookingTransactionTypeRefCombo
            //
            this.financialBookingTransactionTypeRefCombo.Location = new System.Drawing.Point(238, 13);
            this.financialBookingTransactionTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialBookingTransactionTypeRefCombo.Name = "financialBookingTransactionTypeRefCombo";
            this.financialBookingTransactionTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.financialBookingTransactionTypeRefCombo.TabIndex = 3;
            //
            // labelTransactionNumber
            //
            this.labelTransactionNumber.AutoSize = true;
            this.labelTransactionNumber.Location = new System.Drawing.Point(11, 36);
            this.labelTransactionNumber.Name = "labelTransactionNumber";
            this.labelTransactionNumber.Size = new System.Drawing.Size(71, 13);
            this.labelTransactionNumber.TabIndex = 4;
            this.labelTransactionNumber.Text = "Transaction Number:";
            //
            //maskedTextBoxTransactionNumber
            //
            this.maskedTextBoxTransactionNumber.Location = new System.Drawing.Point(238, 36);
            this.maskedTextBoxTransactionNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxTransactionNumber.Name = "maskedTextBoxTransactionNumber";
            this.maskedTextBoxTransactionNumber.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxTransactionNumber.TabIndex = 5;
            //
            // labelAmount
            //
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(11, 59);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(71, 13);
            this.labelAmount.TabIndex = 6;
            this.labelAmount.Text = "Amount:";
            //
            //maskedTextBoxAmount
            //
            this.maskedTextBoxAmount.Location = new System.Drawing.Point(238, 59);
            this.maskedTextBoxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxAmount.Name = "maskedTextBoxAmount";
            this.maskedTextBoxAmount.Size = new System.Drawing.Size(250, 20);
            this.maskedTextBoxAmount.TabIndex = 7;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(238, 82);
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
            this.financialCurrencyPicker.Location = new System.Drawing.Point(238, 105);
            this.financialCurrencyPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialCurrencyPicker.Name = "financialCurrencyPicker";
            this.financialCurrencyPicker.Size = new System.Drawing.Size(250, 20);
            this.financialCurrencyPicker.TabIndex = 11;
            //
            // labelFinancialCostcentrePicker
            //
            this.labelFinancialCostcentrePicker.AutoSize = true;
            this.labelFinancialCostcentrePicker.Location = new System.Drawing.Point(11, 128);
            this.labelFinancialCostcentrePicker.Name = "labelFinancialCostcentrePicker";
            this.labelFinancialCostcentrePicker.Size = new System.Drawing.Size(71, 13);
            this.labelFinancialCostcentrePicker.TabIndex = 12;
            this.labelFinancialCostcentrePicker.Text = "Financial Costcentre:";
            //
            //financialCostcentrePicker
            //
            this.financialCostcentrePicker.Location = new System.Drawing.Point(238, 128);
            this.financialCostcentrePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.financialCostcentrePicker.Name = "financialCostcentrePicker";
            this.financialCostcentrePicker.Size = new System.Drawing.Size(250, 20);
            this.financialCostcentrePicker.TabIndex = 13;
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
            this.userPicker.Location = new System.Drawing.Point(238, 151);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 15;
            // 
            // dataGridViewCrudeFinancialBookingTransaction
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFinancialBookingTransaction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFinancialBookingTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFinancialBookingTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFinancialBookingTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFinancialBookingTransaction.Location = new System.Drawing.Point(12, 184);
            this.dataGridViewCrudeFinancialBookingTransaction.Name = "dataGridViewCrudeFinancialBookingTransaction";
            this.dataGridViewCrudeFinancialBookingTransaction.Size = new System.Drawing.Size(476, 96);
            this.dataGridViewCrudeFinancialBookingTransaction.TabIndex = 0;
            this.dataGridViewCrudeFinancialBookingTransaction.ReadOnly = true;
            this.dataGridViewCrudeFinancialBookingTransaction.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFinancialBookingTransaction_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(396, 287);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFinancialBookingTransactionSearch
            // 
            this.buttonCrudeFinancialBookingTransactionSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialBookingTransactionSearch.Location = new System.Drawing.Point(296, 287);
            this.buttonCrudeFinancialBookingTransactionSearch.Name = "buttonCrudeFinancialBookingTransactionSearch";
            this.buttonCrudeFinancialBookingTransactionSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialBookingTransactionSearch.TabIndex = 2;
            this.buttonCrudeFinancialBookingTransactionSearch.Text = "&Search";
            this.buttonCrudeFinancialBookingTransactionSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialBookingTransactionSearch.Click += new System.EventHandler(this.buttonCrudeFinancialBookingTransactionSearch_Click);
            // 
            // buttonCrudeFinancialBookingTransactionAdd
            // 
            this.buttonCrudeFinancialBookingTransactionAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialBookingTransactionAdd.Location = new System.Drawing.Point(196, 287);
            this.buttonCrudeFinancialBookingTransactionAdd.Name = "buttonCrudeFinancialBookingTransactionAdd";
            this.buttonCrudeFinancialBookingTransactionAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialBookingTransactionAdd.TabIndex = 3;
            this.buttonCrudeFinancialBookingTransactionAdd.Text = "&Add";
            this.buttonCrudeFinancialBookingTransactionAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialBookingTransactionAdd.Click += new System.EventHandler(this.buttonCrudeFinancialBookingTransactionAdd_Click);
            // 
            // buttonCrudeFinancialBookingTransactionEdit
            // 
            this.buttonCrudeFinancialBookingTransactionEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFinancialBookingTransactionEdit.Location = new System.Drawing.Point(96, 287);
            this.buttonCrudeFinancialBookingTransactionEdit.Name = "buttonCrudeFinancialBookingTransactionEdit";
            this.buttonCrudeFinancialBookingTransactionEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFinancialBookingTransactionEdit.TabIndex = 4;
            this.buttonCrudeFinancialBookingTransactionEdit.Text = "&Edit";
            this.buttonCrudeFinancialBookingTransactionEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFinancialBookingTransactionEdit.Click += new System.EventHandler(this.buttonCrudeFinancialBookingTransactionEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 315);
            this.Controls.Add(this.buttonCrudeFinancialBookingTransactionSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFinancialBookingTransactionAdd);
            this.Controls.Add(this.buttonCrudeFinancialBookingTransactionEdit);
            this.Controls.Add(this.dataGridViewCrudeFinancialBookingTransaction);
            this.Name = "CrudeFinancialBookingTransactionSearch";
            this.Text = "Financial Booking Transaction Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFinancialBookingTransaction)).EndInit();
            this.Controls.Add(this.labelFinancialBookingTransactionTypeRefCombo);
            this.Controls.Add(this.financialBookingTransactionTypeRefCombo);
            this.Controls.Add(this.labelTransactionNumber);
            this.Controls.Add(this.maskedTextBoxTransactionNumber);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.maskedTextBoxAmount);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
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
