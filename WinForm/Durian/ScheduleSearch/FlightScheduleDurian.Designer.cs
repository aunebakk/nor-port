namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightScheduleDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewFlightSchedule;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewFlightSchedule = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFlightSchedule
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewFlightSchedule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFlightSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFlightSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlightSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFlightSchedule.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFlightSchedule.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewFlightSchedule.Name = "dataGridViewFlightSchedule";
            this.dataGridViewFlightSchedule.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewFlightSchedule.Click += new System.EventHandler(this.dataGridViewFlightSchedule_Click);
            this.dataGridViewFlightSchedule.TabIndex = 1;
            // 
            // FlightScheduleDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewFlightSchedule);
            this.Name = "FlightScheduleDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightSchedule)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
