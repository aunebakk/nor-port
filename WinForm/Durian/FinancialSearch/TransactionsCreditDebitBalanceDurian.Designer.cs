namespace SolutionNorSolutionPort.UserInterface {

    public partial class TransactionsCreditDebitBalanceDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewTransactionsCreditDebitBalance;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewTransactionsCreditDebitBalance = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactionsCreditDebitBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTransactionsCreditDebitBalance
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewTransactionsCreditDebitBalance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTransactionsCreditDebitBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTransactionsCreditDebitBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransactionsCreditDebitBalance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTransactionsCreditDebitBalance.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTransactionsCreditDebitBalance.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewTransactionsCreditDebitBalance.Name = "dataGridViewTransactionsCreditDebitBalance";
            this.dataGridViewTransactionsCreditDebitBalance.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewTransactionsCreditDebitBalance.Click += new System.EventHandler(this.dataGridViewTransactionsCreditDebitBalance_Click);
            this.dataGridViewTransactionsCreditDebitBalance.TabIndex = 1;
            // 
            // TransactionsCreditDebitBalanceDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewTransactionsCreditDebitBalance);
            this.Name = "TransactionsCreditDebitBalanceDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactionsCreditDebitBalance)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
