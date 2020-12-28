namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightHistoryDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewFlightHistory;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewFlightHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFlightHistory
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewFlightHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFlightHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFlightHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlightHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFlightHistory.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFlightHistory.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewFlightHistory.Name = "dataGridViewFlightHistory";
            this.dataGridViewFlightHistory.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewFlightHistory.Click += new System.EventHandler(this.dataGridViewFlightHistory_Click);
            this.dataGridViewFlightHistory.TabIndex = 1;
            // 
            // FlightHistoryDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewFlightHistory);
            this.Name = "FlightHistoryDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightHistory)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
