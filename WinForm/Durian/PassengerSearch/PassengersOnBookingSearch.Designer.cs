namespace SolutionNorSolutionPort.UserInterface {

    public partial class PassengersOnBookingSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonPassengersOnBookingSearch;
        
        private PassengersOnBookingDurian durianPassengersOnBooking;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonPassengersOnBookingSearch = new System.Windows.Forms.Button();
            this.durianPassengersOnBooking = new PassengersOnBookingDurian();
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
            // buttonPassengersOnBookingSearch
            // 
            this.buttonPassengersOnBookingSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPassengersOnBookingSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonPassengersOnBookingSearch.Name = "buttonPassengersOnBookingSearch";
            this.buttonPassengersOnBookingSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonPassengersOnBookingSearch.TabIndex = 2;
            this.buttonPassengersOnBookingSearch.Text = "&Search";
            this.buttonPassengersOnBookingSearch.UseVisualStyleBackColor = true;
            this.buttonPassengersOnBookingSearch.Click += new System.EventHandler(this.buttonPassengersOnBookingSearch_Click);
            // 
            // durianPassengersOnBooking
            // 
            this.durianPassengersOnBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianPassengersOnBooking.Location = new System.Drawing.Point(12, 12);
            this.durianPassengersOnBooking.Name = "durianPassengersOnBooking";
            this.durianPassengersOnBooking.Size = new System.Drawing.Size(502, 259);
            this.durianPassengersOnBooking.TabIndex = 1;
            // 
            // InitPassengersOnBookingSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonPassengersOnBookingSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianPassengersOnBooking);
            this.Name = "PassengersOnBookingSearch";
            this.Text = "Passengers On Booking";
            this.ResumeLayout(false);

        }
    }
}
