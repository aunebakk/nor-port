namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightsOnBookingSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonFlightsOnBookingSearch;
        
        private FlightsOnBookingDurian durianFlightsOnBooking;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonFlightsOnBookingSearch = new System.Windows.Forms.Button();
            this.durianFlightsOnBooking = new FlightsOnBookingDurian();
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
            // buttonFlightsOnBookingSearch
            // 
            this.buttonFlightsOnBookingSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFlightsOnBookingSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonFlightsOnBookingSearch.Name = "buttonFlightsOnBookingSearch";
            this.buttonFlightsOnBookingSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonFlightsOnBookingSearch.TabIndex = 2;
            this.buttonFlightsOnBookingSearch.Text = "&Search";
            this.buttonFlightsOnBookingSearch.UseVisualStyleBackColor = true;
            this.buttonFlightsOnBookingSearch.Click += new System.EventHandler(this.buttonFlightsOnBookingSearch_Click);
            // 
            // durianFlightsOnBooking
            // 
            this.durianFlightsOnBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianFlightsOnBooking.Location = new System.Drawing.Point(12, 12);
            this.durianFlightsOnBooking.Name = "durianFlightsOnBooking";
            this.durianFlightsOnBooking.Size = new System.Drawing.Size(502, 259);
            this.durianFlightsOnBooking.TabIndex = 1;
            // 
            // InitFlightsOnBookingSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonFlightsOnBookingSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianFlightsOnBooking);
            this.Name = "FlightsOnBookingSearch";
            this.Text = "Flights On Booking";
            this.ResumeLayout(false);

        }
    }
}
