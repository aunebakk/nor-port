namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingFlightsSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonBookingFlightsSearch;
        
        private BookingFlightsDurian durianBookingFlights;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonBookingFlightsSearch = new System.Windows.Forms.Button();
            this.durianBookingFlights = new BookingFlightsDurian();
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
            // buttonBookingFlightsSearch
            // 
            this.buttonBookingFlightsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBookingFlightsSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonBookingFlightsSearch.Name = "buttonBookingFlightsSearch";
            this.buttonBookingFlightsSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonBookingFlightsSearch.TabIndex = 2;
            this.buttonBookingFlightsSearch.Text = "&Search";
            this.buttonBookingFlightsSearch.UseVisualStyleBackColor = true;
            this.buttonBookingFlightsSearch.Click += new System.EventHandler(this.buttonBookingFlightsSearch_Click);
            // 
            // durianBookingFlights
            // 
            this.durianBookingFlights.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianBookingFlights.Location = new System.Drawing.Point(12, 12);
            this.durianBookingFlights.Name = "durianBookingFlights";
            this.durianBookingFlights.Size = new System.Drawing.Size(502, 259);
            this.durianBookingFlights.TabIndex = 1;
            // 
            // InitBookingFlightsSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonBookingFlightsSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianBookingFlights);
            this.Name = "BookingFlightsSearch";
            this.Text = "Booking Flights";
            this.ResumeLayout(false);

        }
    }
}
