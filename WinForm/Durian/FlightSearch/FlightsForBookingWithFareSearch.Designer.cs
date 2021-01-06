namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightsForBookingWithFareSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonFlightsForBookingWithFareSearch;
        
        private FlightsForBookingWithFareDurian durianFlightsForBookingWithFare;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonFlightsForBookingWithFareSearch = new System.Windows.Forms.Button();
            this.durianFlightsForBookingWithFare = new FlightsForBookingWithFareDurian();
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
            // buttonFlightsForBookingWithFareSearch
            // 
            this.buttonFlightsForBookingWithFareSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFlightsForBookingWithFareSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonFlightsForBookingWithFareSearch.Name = "buttonFlightsForBookingWithFareSearch";
            this.buttonFlightsForBookingWithFareSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonFlightsForBookingWithFareSearch.TabIndex = 2;
            this.buttonFlightsForBookingWithFareSearch.Text = "&Search";
            this.buttonFlightsForBookingWithFareSearch.UseVisualStyleBackColor = true;
            this.buttonFlightsForBookingWithFareSearch.Click += new System.EventHandler(this.buttonFlightsForBookingWithFareSearch_Click);
            // 
            // durianFlightsForBookingWithFare
            // 
            this.durianFlightsForBookingWithFare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianFlightsForBookingWithFare.Location = new System.Drawing.Point(12, 12);
            this.durianFlightsForBookingWithFare.Name = "durianFlightsForBookingWithFare";
            this.durianFlightsForBookingWithFare.Size = new System.Drawing.Size(502, 259);
            this.durianFlightsForBookingWithFare.TabIndex = 1;
            // 
            // InitFlightsForBookingWithFareSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonFlightsForBookingWithFareSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianFlightsForBookingWithFare);
            this.Name = "FlightsForBookingWithFareSearch";
            this.Text = "Flights For Booking With Fare";
            this.ResumeLayout(false);

        }
    }
}
