namespace SolutionNorSolutionPort.UserInterface {

    public partial class AircraftMaintenanceIdentifierIndexWithFilterDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewAircraftMaintenanceIdentifierIndexWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewAircraftMaintenanceIdentifierIndexWithFilter = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAircraftMaintenanceIdentifierIndexWithFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAircraftMaintenanceIdentifierIndexWithFilter
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.Name = "dataGridViewAircraftMaintenanceIdentifierIndexWithFilter";
            this.dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.Click += new System.EventHandler(this.dataGridViewAircraftMaintenanceIdentifierIndexWithFilter_Click);
            this.dataGridViewAircraftMaintenanceIdentifierIndexWithFilter.TabIndex = 1;
            // 
            // AircraftMaintenanceIdentifierIndexWithFilterDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewAircraftMaintenanceIdentifierIndexWithFilter);
            this.Name = "AircraftMaintenanceIdentifierIndexWithFilterDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAircraftMaintenanceIdentifierIndexWithFilter)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
