namespace SolutionNorSolutionPort.UserInterface {

    public partial class AircraftDetailsSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonAircraftDetailsSearch;
        
        private AircraftDetailsDurian durianAircraftDetails;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAircraftDetailsSearch = new System.Windows.Forms.Button();
            this.durianAircraftDetails = new AircraftDetailsDurian();
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
            // buttonAircraftDetailsSearch
            // 
            this.buttonAircraftDetailsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAircraftDetailsSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonAircraftDetailsSearch.Name = "buttonAircraftDetailsSearch";
            this.buttonAircraftDetailsSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonAircraftDetailsSearch.TabIndex = 2;
            this.buttonAircraftDetailsSearch.Text = "&Search";
            this.buttonAircraftDetailsSearch.UseVisualStyleBackColor = true;
            this.buttonAircraftDetailsSearch.Click += new System.EventHandler(this.buttonAircraftDetailsSearch_Click);
            // 
            // durianAircraftDetails
            // 
            this.durianAircraftDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianAircraftDetails.Location = new System.Drawing.Point(12, 12);
            this.durianAircraftDetails.Name = "durianAircraftDetails";
            this.durianAircraftDetails.Size = new System.Drawing.Size(502, 259);
            this.durianAircraftDetails.TabIndex = 1;
            // 
            // InitAircraftDetailsSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonAircraftDetailsSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianAircraftDetails);
            this.Name = "AircraftDetailsSearch";
            this.Text = "Aircraft Details";
            this.ResumeLayout(false);

        }
    }
}
