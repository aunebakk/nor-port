namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightsWithCheckinInformationDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewFlightsWithCheckinInformation;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewFlightsWithCheckinInformation = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightsWithCheckinInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFlightsWithCheckinInformation
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewFlightsWithCheckinInformation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFlightsWithCheckinInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFlightsWithCheckinInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlightsWithCheckinInformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFlightsWithCheckinInformation.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFlightsWithCheckinInformation.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewFlightsWithCheckinInformation.Name = "dataGridViewFlightsWithCheckinInformation";
            this.dataGridViewFlightsWithCheckinInformation.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewFlightsWithCheckinInformation.Click += new System.EventHandler(this.dataGridViewFlightsWithCheckinInformation_Click);
            this.dataGridViewFlightsWithCheckinInformation.TabIndex = 1;
            // 
            // FlightsWithCheckinInformationDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewFlightsWithCheckinInformation);
            this.Name = "FlightsWithCheckinInformationDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightsWithCheckinInformation)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
