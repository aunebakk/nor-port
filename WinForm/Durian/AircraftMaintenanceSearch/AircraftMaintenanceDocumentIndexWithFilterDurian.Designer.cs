namespace SolutionNorSolutionPort.UserInterface {

    public partial class AircraftMaintenanceDocumentIndexWithFilterDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewAircraftMaintenanceDocumentIndexWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewAircraftMaintenanceDocumentIndexWithFilter = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAircraftMaintenanceDocumentIndexWithFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAircraftMaintenanceDocumentIndexWithFilter
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewAircraftMaintenanceDocumentIndexWithFilter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAircraftMaintenanceDocumentIndexWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAircraftMaintenanceDocumentIndexWithFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAircraftMaintenanceDocumentIndexWithFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAircraftMaintenanceDocumentIndexWithFilter.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAircraftMaintenanceDocumentIndexWithFilter.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewAircraftMaintenanceDocumentIndexWithFilter.Name = "dataGridViewAircraftMaintenanceDocumentIndexWithFilter";
            this.dataGridViewAircraftMaintenanceDocumentIndexWithFilter.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewAircraftMaintenanceDocumentIndexWithFilter.Click += new System.EventHandler(this.dataGridViewAircraftMaintenanceDocumentIndexWithFilter_Click);
            this.dataGridViewAircraftMaintenanceDocumentIndexWithFilter.TabIndex = 1;
            // 
            // AircraftMaintenanceDocumentIndexWithFilterDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewAircraftMaintenanceDocumentIndexWithFilter);
            this.Name = "AircraftMaintenanceDocumentIndexWithFilterDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAircraftMaintenanceDocumentIndexWithFilter)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
