namespace SolutionNorSolutionPort.UserInterface {

    public partial class AircraftMaintenanceIndexWithFilterSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonAircraftMaintenanceIndexWithFilterSearch;
        
        private AircraftMaintenanceIndexWithFilterDurian durianAircraftMaintenanceIndexWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAircraftMaintenanceIndexWithFilterSearch = new System.Windows.Forms.Button();
            this.durianAircraftMaintenanceIndexWithFilter = new AircraftMaintenanceIndexWithFilterDurian();
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
            // buttonAircraftMaintenanceIndexWithFilterSearch
            // 
            this.buttonAircraftMaintenanceIndexWithFilterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAircraftMaintenanceIndexWithFilterSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonAircraftMaintenanceIndexWithFilterSearch.Name = "buttonAircraftMaintenanceIndexWithFilterSearch";
            this.buttonAircraftMaintenanceIndexWithFilterSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonAircraftMaintenanceIndexWithFilterSearch.TabIndex = 2;
            this.buttonAircraftMaintenanceIndexWithFilterSearch.Text = "&Search";
            this.buttonAircraftMaintenanceIndexWithFilterSearch.UseVisualStyleBackColor = true;
            this.buttonAircraftMaintenanceIndexWithFilterSearch.Click += new System.EventHandler(this.buttonAircraftMaintenanceIndexWithFilterSearch_Click);
            // 
            // durianAircraftMaintenanceIndexWithFilter
            // 
            this.durianAircraftMaintenanceIndexWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianAircraftMaintenanceIndexWithFilter.Location = new System.Drawing.Point(12, 12);
            this.durianAircraftMaintenanceIndexWithFilter.Name = "durianAircraftMaintenanceIndexWithFilter";
            this.durianAircraftMaintenanceIndexWithFilter.Size = new System.Drawing.Size(502, 259);
            this.durianAircraftMaintenanceIndexWithFilter.TabIndex = 1;
            // 
            // InitAircraftMaintenanceIndexWithFilterSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonAircraftMaintenanceIndexWithFilterSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianAircraftMaintenanceIndexWithFilter);
            this.Name = "AircraftMaintenanceIndexWithFilterSearch";
            this.Text = "Aircraft Maintenance Index With Filter";
            this.ResumeLayout(false);

        }
    }
}
