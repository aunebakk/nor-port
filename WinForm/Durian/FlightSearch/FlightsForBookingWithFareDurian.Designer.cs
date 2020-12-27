namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightsForBookingWithFareDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewFlightsForBookingWithFare;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewFlightsForBookingWithFare = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightsForBookingWithFare)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFlightsForBookingWithFare
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewFlightsForBookingWithFare.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFlightsForBookingWithFare.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFlightsForBookingWithFare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlightsForBookingWithFare.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFlightsForBookingWithFare.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFlightsForBookingWithFare.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewFlightsForBookingWithFare.Name = "dataGridViewFlightsForBookingWithFare";
            this.dataGridViewFlightsForBookingWithFare.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewFlightsForBookingWithFare.Click += new System.EventHandler(this.dataGridViewFlightsForBookingWithFare_Click);
            this.dataGridViewFlightsForBookingWithFare.TabIndex = 1;
            // 
            // FlightsForBookingWithFareDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewFlightsForBookingWithFare);
            this.Name = "FlightsForBookingWithFareDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightsForBookingWithFare)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
