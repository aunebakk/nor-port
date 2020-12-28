namespace SolutionNorSolutionPort.UserInterface {

    public partial class AircraftMaintenanceCompartmentIndexWithFilterSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonAircraftMaintenanceCompartmentIndexWithFilterSearch;
        
        private AircraftMaintenanceCompartmentIndexWithFilterDurian durianAircraftMaintenanceCompartmentIndexWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAircraftMaintenanceCompartmentIndexWithFilterSearch = new System.Windows.Forms.Button();
            this.durianAircraftMaintenanceCompartmentIndexWithFilter = new AircraftMaintenanceCompartmentIndexWithFilterDurian();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(422, 277);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonAircraftMaintenanceCompartmentIndexWithFilterSearch
            // 
            this.buttonAircraftMaintenanceCompartmentIndexWithFilterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAircraftMaintenanceCompartmentIndexWithFilterSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonAircraftMaintenanceCompartmentIndexWithFilterSearch.Name = "buttonAircraftMaintenanceCompartmentIndexWithFilterSearch";
            this.buttonAircraftMaintenanceCompartmentIndexWithFilterSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonAircraftMaintenanceCompartmentIndexWithFilterSearch.TabIndex = 2;
            this.buttonAircraftMaintenanceCompartmentIndexWithFilterSearch.Text = "&Search";
            this.buttonAircraftMaintenanceCompartmentIndexWithFilterSearch.UseVisualStyleBackColor = true;
            this.buttonAircraftMaintenanceCompartmentIndexWithFilterSearch.Click += new System.EventHandler(this.buttonAircraftMaintenanceCompartmentIndexWithFilterSearch_Click);
            // 
            // durianAircraftMaintenanceCompartmentIndexWithFilter
            // 
            this.durianAircraftMaintenanceCompartmentIndexWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianAircraftMaintenanceCompartmentIndexWithFilter.Location = new System.Drawing.Point(12, 12);
            this.durianAircraftMaintenanceCompartmentIndexWithFilter.Name = "durianAircraftMaintenanceCompartmentIndexWithFilter";
            this.durianAircraftMaintenanceCompartmentIndexWithFilter.Size = new System.Drawing.Size(502, 259);
            this.durianAircraftMaintenanceCompartmentIndexWithFilter.TabIndex = 1;
            // 
            // InitAircraftMaintenanceCompartmentIndexWithFilterSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonAircraftMaintenanceCompartmentIndexWithFilterSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianAircraftMaintenanceCompartmentIndexWithFilter);
            this.Name = "AircraftMaintenanceCompartmentIndexWithFilterSearch";
            this.Text = "Aircraft Maintenance Compartment Index With Filter";
            this.ResumeLayout(false);

        }
    }
}
