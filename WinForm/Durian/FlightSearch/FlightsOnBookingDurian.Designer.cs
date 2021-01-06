namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightsOnBookingDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewFlightsOnBooking;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewFlightsOnBooking = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightsOnBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFlightsOnBooking
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewFlightsOnBooking.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFlightsOnBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFlightsOnBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlightsOnBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFlightsOnBooking.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFlightsOnBooking.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewFlightsOnBooking.Name = "dataGridViewFlightsOnBooking";
            this.dataGridViewFlightsOnBooking.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewFlightsOnBooking.Click += new System.EventHandler(this.dataGridViewFlightsOnBooking_Click);
            this.dataGridViewFlightsOnBooking.TabIndex = 1;
            // 
            // FlightsOnBookingDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewFlightsOnBooking);
            this.Name = "FlightsOnBookingDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightsOnBooking)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
