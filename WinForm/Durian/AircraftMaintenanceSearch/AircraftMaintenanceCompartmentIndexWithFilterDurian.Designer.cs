namespace SolutionNorSolutionPort.UserInterface {

    public partial class AircraftMaintenanceCompartmentIndexWithFilterDurian {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.DataGridView dataGridViewAircraftMaintenanceCompartmentIndexWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewAircraftMaintenanceCompartmentIndexWithFilter = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAircraftMaintenanceCompartmentIndexWithFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAircraftMaintenanceCompartmentIndexWithFilter
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.Name = "dataGridViewAircraftMaintenanceCompartmentIndexWithFilter";
            this.dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.Size = new System.Drawing.Size(681, 368);
            this.dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.Click += new System.EventHandler(this.dataGridViewAircraftMaintenanceCompartmentIndexWithFilter_Click);
            this.dataGridViewAircraftMaintenanceCompartmentIndexWithFilter.TabIndex = 1;
            // 
            // AircraftMaintenanceCompartmentIndexWithFilterDurian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewAircraftMaintenanceCompartmentIndexWithFilter);
            this.Name = "AircraftMaintenanceCompartmentIndexWithFilterDurian";
            this.Size = new System.Drawing.Size(681, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAircraftMaintenanceCompartmentIndexWithFilter)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
