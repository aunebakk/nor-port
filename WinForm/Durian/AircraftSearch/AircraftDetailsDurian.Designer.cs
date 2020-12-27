namespace SolutionNorSolutionPort.UserInterface {

    public partial class AircraftDetailsDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewAircraftDetails;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewAircraftDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAircraftDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAircraftDetails
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewAircraftDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAircraftDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAircraftDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAircraftDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAircraftDetails.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAircraftDetails.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewAircraftDetails.Name = "dataGridViewAircraftDetails";
            this.dataGridViewAircraftDetails.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewAircraftDetails.Click += new System.EventHandler(this.dataGridViewAircraftDetails_Click);
            this.dataGridViewAircraftDetails.TabIndex = 1;
            // 
            // AircraftDetailsDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewAircraftDetails);
            this.Name = "AircraftDetailsDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAircraftDetails)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
