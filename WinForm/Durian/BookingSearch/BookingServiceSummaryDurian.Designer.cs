namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingServiceSummaryDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewBookingServiceSummary;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewBookingServiceSummary = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingServiceSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBookingServiceSummary
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewBookingServiceSummary.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBookingServiceSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBookingServiceSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookingServiceSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookingServiceSummary.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBookingServiceSummary.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewBookingServiceSummary.Name = "dataGridViewBookingServiceSummary";
            this.dataGridViewBookingServiceSummary.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewBookingServiceSummary.Click += new System.EventHandler(this.dataGridViewBookingServiceSummary_Click);
            this.dataGridViewBookingServiceSummary.TabIndex = 1;
            // 
            // BookingServiceSummaryDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewBookingServiceSummary);
            this.Name = "BookingServiceSummaryDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingServiceSummary)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
