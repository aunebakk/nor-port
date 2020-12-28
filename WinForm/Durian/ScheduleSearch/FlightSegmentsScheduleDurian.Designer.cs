namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightSegmentsScheduleDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewFlightSegmentsSchedule;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewFlightSegmentsSchedule = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightSegmentsSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFlightSegmentsSchedule
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewFlightSegmentsSchedule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFlightSegmentsSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFlightSegmentsSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlightSegmentsSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFlightSegmentsSchedule.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFlightSegmentsSchedule.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewFlightSegmentsSchedule.Name = "dataGridViewFlightSegmentsSchedule";
            this.dataGridViewFlightSegmentsSchedule.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewFlightSegmentsSchedule.Click += new System.EventHandler(this.dataGridViewFlightSegmentsSchedule_Click);
            this.dataGridViewFlightSegmentsSchedule.TabIndex = 1;
            // 
            // FlightSegmentsScheduleDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewFlightSegmentsSchedule);
            this.Name = "FlightSegmentsScheduleDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightSegmentsSchedule)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
