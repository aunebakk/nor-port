namespace SolutionNorSolutionPort.UserInterface {

    public partial class PassengersOnBookingDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewPassengersOnBooking;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewPassengersOnBooking = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPassengersOnBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPassengersOnBooking
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewPassengersOnBooking.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPassengersOnBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPassengersOnBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPassengersOnBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPassengersOnBooking.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPassengersOnBooking.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewPassengersOnBooking.Name = "dataGridViewPassengersOnBooking";
            this.dataGridViewPassengersOnBooking.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewPassengersOnBooking.Click += new System.EventHandler(this.dataGridViewPassengersOnBooking_Click);
            this.dataGridViewPassengersOnBooking.TabIndex = 1;
            // 
            // PassengersOnBookingDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewPassengersOnBooking);
            this.Name = "PassengersOnBookingDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPassengersOnBooking)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
