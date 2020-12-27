namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingPassengerWithExtraDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewBookingPassengerWithExtra;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewBookingPassengerWithExtra = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingPassengerWithExtra)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBookingPassengerWithExtra
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewBookingPassengerWithExtra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBookingPassengerWithExtra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBookingPassengerWithExtra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookingPassengerWithExtra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBookingPassengerWithExtra.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBookingPassengerWithExtra.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewBookingPassengerWithExtra.Name = "dataGridViewBookingPassengerWithExtra";
            this.dataGridViewBookingPassengerWithExtra.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewBookingPassengerWithExtra.Click += new System.EventHandler(this.dataGridViewBookingPassengerWithExtra_Click);
            this.dataGridViewBookingPassengerWithExtra.TabIndex = 1;
            // 
            // BookingPassengerWithExtraDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewBookingPassengerWithExtra);
            this.Name = "BookingPassengerWithExtraDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookingPassengerWithExtra)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
