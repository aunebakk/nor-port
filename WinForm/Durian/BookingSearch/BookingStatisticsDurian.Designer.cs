namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingStatisticsDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewBookingStatistics;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewBookingStatistics = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBookingStatistics
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewBookingStatistics.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBookingStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBookingStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookingStatistics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookingStatistics.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBookingStatistics.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewBookingStatistics.Name = "dataGridViewBookingStatistics";
            this.dataGridViewBookingStatistics.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewBookingStatistics.Click += new System.EventHandler(this.dataGridViewBookingStatistics_Click);
            this.dataGridViewBookingStatistics.TabIndex = 1;
            // 
            // BookingStatisticsDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewBookingStatistics);
            this.Name = "BookingStatisticsDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingStatistics)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
