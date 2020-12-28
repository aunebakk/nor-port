namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightSegmentsDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewFlightSegments;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewFlightSegments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightSegments)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFlightSegments
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewFlightSegments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFlightSegments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFlightSegments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlightSegments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFlightSegments.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFlightSegments.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewFlightSegments.Name = "dataGridViewFlightSegments";
            this.dataGridViewFlightSegments.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewFlightSegments.Click += new System.EventHandler(this.dataGridViewFlightSegments_Click);
            this.dataGridViewFlightSegments.TabIndex = 1;
            // 
            // FlightSegmentsDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewFlightSegments);
            this.Name = "FlightSegmentsDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightSegments)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
