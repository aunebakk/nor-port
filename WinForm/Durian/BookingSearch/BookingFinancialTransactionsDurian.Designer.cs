namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingFinancialTransactionsDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewBookingFinancialTransactions;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewBookingFinancialTransactions = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingFinancialTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBookingFinancialTransactions
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewBookingFinancialTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBookingFinancialTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBookingFinancialTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookingFinancialTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookingFinancialTransactions.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBookingFinancialTransactions.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewBookingFinancialTransactions.Name = "dataGridViewBookingFinancialTransactions";
            this.dataGridViewBookingFinancialTransactions.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewBookingFinancialTransactions.Click += new System.EventHandler(this.dataGridViewBookingFinancialTransactions_Click);
            this.dataGridViewBookingFinancialTransactions.TabIndex = 1;
            // 
            // BookingFinancialTransactionsDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewBookingFinancialTransactions);
            this.Name = "BookingFinancialTransactionsDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingFinancialTransactions)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
