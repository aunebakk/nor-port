namespace SolutionNorSolutionPort.UserInterface {

    public partial class AircraftPIMDetailsSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonAircraftPIMDetailsSearch;
        
        private AircraftPIMDetailsDurian durianAircraftPIMDetails;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAircraftPIMDetailsSearch = new System.Windows.Forms.Button();
            this.durianAircraftPIMDetails = new AircraftPIMDetailsDurian();
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
            // buttonAircraftPIMDetailsSearch
            // 
            this.buttonAircraftPIMDetailsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAircraftPIMDetailsSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonAircraftPIMDetailsSearch.Name = "buttonAircraftPIMDetailsSearch";
            this.buttonAircraftPIMDetailsSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonAircraftPIMDetailsSearch.TabIndex = 2;
            this.buttonAircraftPIMDetailsSearch.Text = "&Search";
            this.buttonAircraftPIMDetailsSearch.UseVisualStyleBackColor = true;
            this.buttonAircraftPIMDetailsSearch.Click += new System.EventHandler(this.buttonAircraftPIMDetailsSearch_Click);
            // 
            // durianAircraftPIMDetails
            // 
            this.durianAircraftPIMDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianAircraftPIMDetails.Location = new System.Drawing.Point(12, 12);
            this.durianAircraftPIMDetails.Name = "durianAircraftPIMDetails";
            this.durianAircraftPIMDetails.Size = new System.Drawing.Size(502, 259);
            this.durianAircraftPIMDetails.TabIndex = 1;
            // 
            // InitAircraftPIMDetailsSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonAircraftPIMDetailsSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianAircraftPIMDetails);
            this.Name = "AircraftPIMDetailsSearch";
            this.Text = "Aircraft PIMD etails";
            this.ResumeLayout(false);

        }
    }
}
