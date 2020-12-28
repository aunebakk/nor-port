namespace SolutionNorSolutionPort.UserInterface {

    public partial class AircraftPIMDetailsDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewAircraftPIMDetails;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewAircraftPIMDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAircraftPIMDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAircraftPIMDetails
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewAircraftPIMDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAircraftPIMDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAircraftPIMDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAircraftPIMDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAircraftPIMDetails.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAircraftPIMDetails.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewAircraftPIMDetails.Name = "dataGridViewAircraftPIMDetails";
            this.dataGridViewAircraftPIMDetails.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewAircraftPIMDetails.Click += new System.EventHandler(this.dataGridViewAircraftPIMDetails_Click);
            this.dataGridViewAircraftPIMDetails.TabIndex = 1;
            // 
            // AircraftPIMDetailsDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewAircraftPIMDetails);
            this.Name = "AircraftPIMDetailsDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAircraftPIMDetails)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
