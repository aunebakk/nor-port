namespace SolutionNorSolutionPort.UserInterface {

    public partial class AircraftMaintenanceDocumentIndexWithFilterSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonAircraftMaintenanceDocumentIndexWithFilterSearch;
        
        private AircraftMaintenanceDocumentIndexWithFilterDurian durianAircraftMaintenanceDocumentIndexWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAircraftMaintenanceDocumentIndexWithFilterSearch = new System.Windows.Forms.Button();
            this.durianAircraftMaintenanceDocumentIndexWithFilter = new AircraftMaintenanceDocumentIndexWithFilterDurian();
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
            // buttonAircraftMaintenanceDocumentIndexWithFilterSearch
            // 
            this.buttonAircraftMaintenanceDocumentIndexWithFilterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAircraftMaintenanceDocumentIndexWithFilterSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonAircraftMaintenanceDocumentIndexWithFilterSearch.Name = "buttonAircraftMaintenanceDocumentIndexWithFilterSearch";
            this.buttonAircraftMaintenanceDocumentIndexWithFilterSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonAircraftMaintenanceDocumentIndexWithFilterSearch.TabIndex = 2;
            this.buttonAircraftMaintenanceDocumentIndexWithFilterSearch.Text = "&Search";
            this.buttonAircraftMaintenanceDocumentIndexWithFilterSearch.UseVisualStyleBackColor = true;
            this.buttonAircraftMaintenanceDocumentIndexWithFilterSearch.Click += new System.EventHandler(this.buttonAircraftMaintenanceDocumentIndexWithFilterSearch_Click);
            // 
            // durianAircraftMaintenanceDocumentIndexWithFilter
            // 
            this.durianAircraftMaintenanceDocumentIndexWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianAircraftMaintenanceDocumentIndexWithFilter.Location = new System.Drawing.Point(12, 12);
            this.durianAircraftMaintenanceDocumentIndexWithFilter.Name = "durianAircraftMaintenanceDocumentIndexWithFilter";
            this.durianAircraftMaintenanceDocumentIndexWithFilter.Size = new System.Drawing.Size(502, 259);
            this.durianAircraftMaintenanceDocumentIndexWithFilter.TabIndex = 1;
            // 
            // InitAircraftMaintenanceDocumentIndexWithFilterSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonAircraftMaintenanceDocumentIndexWithFilterSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianAircraftMaintenanceDocumentIndexWithFilter);
            this.Name = "AircraftMaintenanceDocumentIndexWithFilterSearch";
            this.Text = "Aircraft Maintenance Document Index With Filter";
            this.ResumeLayout(false);

        }
    }
}
