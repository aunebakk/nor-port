namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightScheduleHistoryDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewFlightScheduleHistory;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewFlightScheduleHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightScheduleHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFlightScheduleHistory
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewFlightScheduleHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFlightScheduleHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFlightScheduleHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlightScheduleHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFlightScheduleHistory.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFlightScheduleHistory.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewFlightScheduleHistory.Name = "dataGridViewFlightScheduleHistory";
            this.dataGridViewFlightScheduleHistory.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewFlightScheduleHistory.Click += new System.EventHandler(this.dataGridViewFlightScheduleHistory_Click);
            this.dataGridViewFlightScheduleHistory.TabIndex = 1;
            // 
            // FlightScheduleHistoryDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewFlightScheduleHistory);
            this.Name = "FlightScheduleHistoryDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightScheduleHistory)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
