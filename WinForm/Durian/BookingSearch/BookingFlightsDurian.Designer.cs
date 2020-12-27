namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingFlightsDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewBookingFlights;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewBookingFlights = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBookingFlights
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewBookingFlights.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBookingFlights.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBookingFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookingFlights.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookingFlights.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBookingFlights.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewBookingFlights.Name = "dataGridViewBookingFlights";
            this.dataGridViewBookingFlights.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewBookingFlights.Click += new System.EventHandler(this.dataGridViewBookingFlights_Click);
            this.dataGridViewBookingFlights.TabIndex = 1;
            // 
            // BookingFlightsDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewBookingFlights);
            this.Name = "BookingFlightsDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingFlights)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
