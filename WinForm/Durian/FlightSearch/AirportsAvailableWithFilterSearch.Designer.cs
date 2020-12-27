namespace SolutionNorSolutionPort.UserInterface {

    public partial class AirportsAvailableWithFilterSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonAirportsAvailableWithFilterSearch;
        
        private AirportsAvailableWithFilterDurian durianAirportsAvailableWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAirportsAvailableWithFilterSearch = new System.Windows.Forms.Button();
            this.durianAirportsAvailableWithFilter = new AirportsAvailableWithFilterDurian();
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
            // buttonAirportsAvailableWithFilterSearch
            // 
            this.buttonAirportsAvailableWithFilterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAirportsAvailableWithFilterSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonAirportsAvailableWithFilterSearch.Name = "buttonAirportsAvailableWithFilterSearch";
            this.buttonAirportsAvailableWithFilterSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonAirportsAvailableWithFilterSearch.TabIndex = 2;
            this.buttonAirportsAvailableWithFilterSearch.Text = "&Search";
            this.buttonAirportsAvailableWithFilterSearch.UseVisualStyleBackColor = true;
            this.buttonAirportsAvailableWithFilterSearch.Click += new System.EventHandler(this.buttonAirportsAvailableWithFilterSearch_Click);
            // 
            // durianAirportsAvailableWithFilter
            // 
            this.durianAirportsAvailableWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianAirportsAvailableWithFilter.Location = new System.Drawing.Point(12, 12);
            this.durianAirportsAvailableWithFilter.Name = "durianAirportsAvailableWithFilter";
            this.durianAirportsAvailableWithFilter.Size = new System.Drawing.Size(502, 259);
            this.durianAirportsAvailableWithFilter.TabIndex = 1;
            // 
            // InitAirportsAvailableWithFilterSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonAirportsAvailableWithFilterSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianAirportsAvailableWithFilter);
            this.Name = "AirportsAvailableWithFilterSearch";
            this.Text = "Airports Available With Filter";
            this.ResumeLayout(false);

        }
    }
}
