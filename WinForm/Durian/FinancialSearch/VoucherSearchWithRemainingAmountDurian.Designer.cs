namespace SolutionNorSolutionPort.UserInterface {

    public partial class VoucherSearchWithRemainingAmountDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewVoucherSearchWithRemainingAmount;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewVoucherSearchWithRemainingAmount = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVoucherSearchWithRemainingAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVoucherSearchWithRemainingAmount
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewVoucherSearchWithRemainingAmount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewVoucherSearchWithRemainingAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewVoucherSearchWithRemainingAmount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVoucherSearchWithRemainingAmount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVoucherSearchWithRemainingAmount.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewVoucherSearchWithRemainingAmount.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewVoucherSearchWithRemainingAmount.Name = "dataGridViewVoucherSearchWithRemainingAmount";
            this.dataGridViewVoucherSearchWithRemainingAmount.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewVoucherSearchWithRemainingAmount.Click += new System.EventHandler(this.dataGridViewVoucherSearchWithRemainingAmount_Click);
            this.dataGridViewVoucherSearchWithRemainingAmount.TabIndex = 1;
            // 
            // VoucherSearchWithRemainingAmountDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewVoucherSearchWithRemainingAmount);
            this.Name = "VoucherSearchWithRemainingAmountDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVoucherSearchWithRemainingAmount)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
