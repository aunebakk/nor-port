namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightSegmentsSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonFlightSegmentsSearch;
        
        private FlightSegmentsDurian durianFlightSegments;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonFlightSegmentsSearch = new System.Windows.Forms.Button();
            this.durianFlightSegments = new FlightSegmentsDurian();
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
            // buttonFlightSegmentsSearch
            // 
            this.buttonFlightSegmentsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFlightSegmentsSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonFlightSegmentsSearch.Name = "buttonFlightSegmentsSearch";
            this.buttonFlightSegmentsSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonFlightSegmentsSearch.TabIndex = 2;
            this.buttonFlightSegmentsSearch.Text = "&Search";
            this.buttonFlightSegmentsSearch.UseVisualStyleBackColor = true;
            this.buttonFlightSegmentsSearch.Click += new System.EventHandler(this.buttonFlightSegmentsSearch_Click);
            // 
            // durianFlightSegments
            // 
            this.durianFlightSegments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianFlightSegments.Location = new System.Drawing.Point(12, 12);
            this.durianFlightSegments.Name = "durianFlightSegments";
            this.durianFlightSegments.Size = new System.Drawing.Size(502, 259);
            this.durianFlightSegments.TabIndex = 1;
            // 
            // InitFlightSegmentsSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonFlightSegmentsSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianFlightSegments);
            this.Name = "FlightSegmentsSearch";
            this.Text = "Flight Segments";
            this.ResumeLayout(false);

        }
    }
}
