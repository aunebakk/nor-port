namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightsOpenForCheckinWithDescriptionSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonFlightsOpenForCheckinWithDescriptionSearch;
        
        private FlightsOpenForCheckinWithDescriptionDurian durianFlightsOpenForCheckinWithDescription;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonFlightsOpenForCheckinWithDescriptionSearch = new System.Windows.Forms.Button();
            this.durianFlightsOpenForCheckinWithDescription = new FlightsOpenForCheckinWithDescriptionDurian();
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
            // buttonFlightsOpenForCheckinWithDescriptionSearch
            // 
            this.buttonFlightsOpenForCheckinWithDescriptionSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFlightsOpenForCheckinWithDescriptionSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonFlightsOpenForCheckinWithDescriptionSearch.Name = "buttonFlightsOpenForCheckinWithDescriptionSearch";
            this.buttonFlightsOpenForCheckinWithDescriptionSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonFlightsOpenForCheckinWithDescriptionSearch.TabIndex = 2;
            this.buttonFlightsOpenForCheckinWithDescriptionSearch.Text = "&Search";
            this.buttonFlightsOpenForCheckinWithDescriptionSearch.UseVisualStyleBackColor = true;
            this.buttonFlightsOpenForCheckinWithDescriptionSearch.Click += new System.EventHandler(this.buttonFlightsOpenForCheckinWithDescriptionSearch_Click);
            // 
            // durianFlightsOpenForCheckinWithDescription
            // 
            this.durianFlightsOpenForCheckinWithDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianFlightsOpenForCheckinWithDescription.Location = new System.Drawing.Point(12, 12);
            this.durianFlightsOpenForCheckinWithDescription.Name = "durianFlightsOpenForCheckinWithDescription";
            this.durianFlightsOpenForCheckinWithDescription.Size = new System.Drawing.Size(502, 259);
            this.durianFlightsOpenForCheckinWithDescription.TabIndex = 1;
            // 
            // InitFlightsOpenForCheckinWithDescriptionSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonFlightsOpenForCheckinWithDescriptionSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianFlightsOpenForCheckinWithDescription);
            this.Name = "FlightsOpenForCheckinWithDescriptionSearch";
            this.Text = "Flights Open For Checkin With Description";
            this.ResumeLayout(false);

        }
    }
}
