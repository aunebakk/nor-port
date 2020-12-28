namespace SolutionNorSolutionPort.UserInterface {

    public partial class AircraftMaintenanceIndexWithFilterDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewAircraftMaintenanceIndexWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewAircraftMaintenanceIndexWithFilter = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAircraftMaintenanceIndexWithFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAircraftMaintenanceIndexWithFilter
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewAircraftMaintenanceIndexWithFilter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAircraftMaintenanceIndexWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAircraftMaintenanceIndexWithFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAircraftMaintenanceIndexWithFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAircraftMaintenanceIndexWithFilter.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAircraftMaintenanceIndexWithFilter.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewAircraftMaintenanceIndexWithFilter.Name = "dataGridViewAircraftMaintenanceIndexWithFilter";
            this.dataGridViewAircraftMaintenanceIndexWithFilter.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewAircraftMaintenanceIndexWithFilter.Click += new System.EventHandler(this.dataGridViewAircraftMaintenanceIndexWithFilter_Click);
            this.dataGridViewAircraftMaintenanceIndexWithFilter.TabIndex = 1;
            // 
            // AircraftMaintenanceIndexWithFilterDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewAircraftMaintenanceIndexWithFilter);
            this.Name = "AircraftMaintenanceIndexWithFilterDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAircraftMaintenanceIndexWithFilter)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
