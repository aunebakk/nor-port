namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingPassengersDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewBookingPassengers;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewBookingPassengers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingPassengers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBookingPassengers
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewBookingPassengers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBookingPassengers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBookingPassengers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookingPassengers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookingPassengers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBookingPassengers.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewBookingPassengers.Name = "dataGridViewBookingPassengers";
            this.dataGridViewBookingPassengers.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewBookingPassengers.Click += new System.EventHandler(this.dataGridViewBookingPassengers_Click);
            this.dataGridViewBookingPassengers.TabIndex = 1;
            // 
            // BookingPassengersDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewBookingPassengers);
            this.Name = "BookingPassengersDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingPassengers)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
