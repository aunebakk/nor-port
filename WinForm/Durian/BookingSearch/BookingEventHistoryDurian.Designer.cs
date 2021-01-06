namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingEventHistoryDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewBookingEventHistory;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewBookingEventHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingEventHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBookingEventHistory
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewBookingEventHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBookingEventHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBookingEventHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookingEventHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookingEventHistory.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBookingEventHistory.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewBookingEventHistory.Name = "dataGridViewBookingEventHistory";
            this.dataGridViewBookingEventHistory.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewBookingEventHistory.Click += new System.EventHandler(this.dataGridViewBookingEventHistory_Click);
            this.dataGridViewBookingEventHistory.TabIndex = 1;
            // 
            // BookingEventHistoryDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewBookingEventHistory);
            this.Name = "BookingEventHistoryDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingEventHistory)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
