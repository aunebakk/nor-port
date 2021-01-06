namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingEventCountDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewBookingEventCount;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewBookingEventCount = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingEventCount)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBookingEventCount
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewBookingEventCount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBookingEventCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBookingEventCount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookingEventCount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookingEventCount.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBookingEventCount.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewBookingEventCount.Name = "dataGridViewBookingEventCount";
            this.dataGridViewBookingEventCount.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewBookingEventCount.Click += new System.EventHandler(this.dataGridViewBookingEventCount_Click);
            this.dataGridViewBookingEventCount.TabIndex = 1;
            // 
            // BookingEventCountDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewBookingEventCount);
            this.Name = "BookingEventCountDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingEventCount)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
