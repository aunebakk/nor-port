namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingFinancialPaymentsDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewBookingFinancialPayments;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewBookingFinancialPayments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingFinancialPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBookingFinancialPayments
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewBookingFinancialPayments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBookingFinancialPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBookingFinancialPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookingFinancialPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookingFinancialPayments.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBookingFinancialPayments.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewBookingFinancialPayments.Name = "dataGridViewBookingFinancialPayments";
            this.dataGridViewBookingFinancialPayments.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewBookingFinancialPayments.Click += new System.EventHandler(this.dataGridViewBookingFinancialPayments_Click);
            this.dataGridViewBookingFinancialPayments.TabIndex = 1;
            // 
            // BookingFinancialPaymentsDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewBookingFinancialPayments);
            this.Name = "BookingFinancialPaymentsDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingFinancialPayments)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
