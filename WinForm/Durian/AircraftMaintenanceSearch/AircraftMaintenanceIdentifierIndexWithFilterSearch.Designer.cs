namespace SolutionNorSolutionPort.UserInterface {

    public partial class AircraftMaintenanceIdentifierIndexWithFilterSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonAircraftMaintenanceIdentifierIndexWithFilterSearch;
        
        private AircraftMaintenanceIdentifierIndexWithFilterDurian durianAircraftMaintenanceIdentifierIndexWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAircraftMaintenanceIdentifierIndexWithFilterSearch = new System.Windows.Forms.Button();
            this.durianAircraftMaintenanceIdentifierIndexWithFilter = new AircraftMaintenanceIdentifierIndexWithFilterDurian();
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
            // buttonAircraftMaintenanceIdentifierIndexWithFilterSearch
            // 
            this.buttonAircraftMaintenanceIdentifierIndexWithFilterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAircraftMaintenanceIdentifierIndexWithFilterSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonAircraftMaintenanceIdentifierIndexWithFilterSearch.Name = "buttonAircraftMaintenanceIdentifierIndexWithFilterSearch";
            this.buttonAircraftMaintenanceIdentifierIndexWithFilterSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonAircraftMaintenanceIdentifierIndexWithFilterSearch.TabIndex = 2;
            this.buttonAircraftMaintenanceIdentifierIndexWithFilterSearch.Text = "&Search";
            this.buttonAircraftMaintenanceIdentifierIndexWithFilterSearch.UseVisualStyleBackColor = true;
            this.buttonAircraftMaintenanceIdentifierIndexWithFilterSearch.Click += new System.EventHandler(this.buttonAircraftMaintenanceIdentifierIndexWithFilterSearch_Click);
            // 
            // durianAircraftMaintenanceIdentifierIndexWithFilter
            // 
            this.durianAircraftMaintenanceIdentifierIndexWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianAircraftMaintenanceIdentifierIndexWithFilter.Location = new System.Drawing.Point(12, 12);
            this.durianAircraftMaintenanceIdentifierIndexWithFilter.Name = "durianAircraftMaintenanceIdentifierIndexWithFilter";
            this.durianAircraftMaintenanceIdentifierIndexWithFilter.Size = new System.Drawing.Size(502, 259);
            this.durianAircraftMaintenanceIdentifierIndexWithFilter.TabIndex = 1;
            // 
            // InitAircraftMaintenanceIdentifierIndexWithFilterSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonAircraftMaintenanceIdentifierIndexWithFilterSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianAircraftMaintenanceIdentifierIndexWithFilter);
            this.Name = "AircraftMaintenanceIdentifierIndexWithFilterSearch";
            this.Text = "Aircraft Maintenance Identifier Index With Filter";
            this.ResumeLayout(false);

        }
    }
}
