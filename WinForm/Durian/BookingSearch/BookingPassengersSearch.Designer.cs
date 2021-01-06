namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingPassengersSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonBookingPassengersSearch;
        
        private BookingPassengersDurian durianBookingPassengers;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonBookingPassengersSearch = new System.Windows.Forms.Button();
            this.durianBookingPassengers = new BookingPassengersDurian();
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
            // buttonBookingPassengersSearch
            // 
            this.buttonBookingPassengersSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBookingPassengersSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonBookingPassengersSearch.Name = "buttonBookingPassengersSearch";
            this.buttonBookingPassengersSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonBookingPassengersSearch.TabIndex = 2;
            this.buttonBookingPassengersSearch.Text = "&Search";
            this.buttonBookingPassengersSearch.UseVisualStyleBackColor = true;
            this.buttonBookingPassengersSearch.Click += new System.EventHandler(this.buttonBookingPassengersSearch_Click);
            // 
            // durianBookingPassengers
            // 
            this.durianBookingPassengers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianBookingPassengers.Location = new System.Drawing.Point(12, 12);
            this.durianBookingPassengers.Name = "durianBookingPassengers";
            this.durianBookingPassengers.Size = new System.Drawing.Size(502, 259);
            this.durianBookingPassengers.TabIndex = 1;
            // 
            // InitBookingPassengersSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonBookingPassengersSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianBookingPassengers);
            this.Name = "BookingPassengersSearch";
            this.Text = "Booking Passengers";
            this.ResumeLayout(false);

        }
    }
}
