namespace SolutionNorSolutionPort.UserInterface {

    public partial class FinancialServiceDetailsForBookingDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewFinancialServiceDetailsForBooking;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewFinancialServiceDetailsForBooking = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinancialServiceDetailsForBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFinancialServiceDetailsForBooking
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewFinancialServiceDetailsForBooking.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFinancialServiceDetailsForBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFinancialServiceDetailsForBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFinancialServiceDetailsForBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFinancialServiceDetailsForBooking.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFinancialServiceDetailsForBooking.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewFinancialServiceDetailsForBooking.Name = "dataGridViewFinancialServiceDetailsForBooking";
            this.dataGridViewFinancialServiceDetailsForBooking.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewFinancialServiceDetailsForBooking.Click += new System.EventHandler(this.dataGridViewFinancialServiceDetailsForBooking_Click);
            this.dataGridViewFinancialServiceDetailsForBooking.TabIndex = 1;
            // 
            // FinancialServiceDetailsForBookingDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewFinancialServiceDetailsForBooking);
            this.Name = "FinancialServiceDetailsForBookingDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinancialServiceDetailsForBooking)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
