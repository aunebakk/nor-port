namespace SolutionNorSolutionPort.UserInterface {

    public partial class VoucherTransactionsDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewVoucherTransactions;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewVoucherTransactions = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVoucherTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVoucherTransactions
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewVoucherTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewVoucherTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewVoucherTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVoucherTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVoucherTransactions.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewVoucherTransactions.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewVoucherTransactions.Name = "dataGridViewVoucherTransactions";
            this.dataGridViewVoucherTransactions.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewVoucherTransactions.Click += new System.EventHandler(this.dataGridViewVoucherTransactions_Click);
            this.dataGridViewVoucherTransactions.TabIndex = 1;
            // 
            // VoucherTransactionsDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewVoucherTransactions);
            this.Name = "VoucherTransactionsDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVoucherTransactions)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
