namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightsForPeriodDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewFlightsForPeriod;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewFlightsForPeriod = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightsForPeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFlightsForPeriod
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewFlightsForPeriod.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFlightsForPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFlightsForPeriod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlightsForPeriod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFlightsForPeriod.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFlightsForPeriod.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewFlightsForPeriod.Name = "dataGridViewFlightsForPeriod";
            this.dataGridViewFlightsForPeriod.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewFlightsForPeriod.Click += new System.EventHandler(this.dataGridViewFlightsForPeriod_Click);
            this.dataGridViewFlightsForPeriod.TabIndex = 1;
            // 
            // FlightsForPeriodDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewFlightsForPeriod);
            this.Name = "FlightsForPeriodDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightsForPeriod)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
