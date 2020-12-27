namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingPassengerWithExtraSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonBookingPassengerWithExtraSearch;
        
        private BookingPassengerWithExtraDurian durianBookingPassengerWithExtra;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonBookingPassengerWithExtraSearch = new System.Windows.Forms.Button();
            this.durianBookingPassengerWithExtra = new BookingPassengerWithExtraDurian();
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
            // buttonBookingPassengerWithExtraSearch
            // 
            this.buttonBookingPassengerWithExtraSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBookingPassengerWithExtraSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonBookingPassengerWithExtraSearch.Name = "buttonBookingPassengerWithExtraSearch";
            this.buttonBookingPassengerWithExtraSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonBookingPassengerWithExtraSearch.TabIndex = 2;
            this.buttonBookingPassengerWithExtraSearch.Text = "&Search";
            this.buttonBookingPassengerWithExtraSearch.UseVisualStyleBackColor = true;
            this.buttonBookingPassengerWithExtraSearch.Click += new System.EventHandler(this.buttonBookingPassengerWithExtraSearch_Click);
            // 
            // durianBookingPassengerWithExtra
            // 
            this.durianBookingPassengerWithExtra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianBookingPassengerWithExtra.Location = new System.Drawing.Point(12, 12);
            this.durianBookingPassengerWithExtra.Name = "durianBookingPassengerWithExtra";
            this.durianBookingPassengerWithExtra.Size = new System.Drawing.Size(502, 259);
            this.durianBookingPassengerWithExtra.TabIndex = 1;
            // 
            // InitBookingPassengerWithExtraSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonBookingPassengerWithExtraSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianBookingPassengerWithExtra);
            this.Name = "BookingPassengerWithExtraSearch";
            this.Text = "Booking Passenger With Extra";
            this.ResumeLayout(false);

        }
    }
}
