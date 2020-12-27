namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightsWithBookingInformationSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonFlightsWithBookingInformationSearch;
        
        private FlightsWithBookingInformationDurian durianFlightsWithBookingInformation;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonFlightsWithBookingInformationSearch = new System.Windows.Forms.Button();
            this.durianFlightsWithBookingInformation = new FlightsWithBookingInformationDurian();
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
            // buttonFlightsWithBookingInformationSearch
            // 
            this.buttonFlightsWithBookingInformationSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFlightsWithBookingInformationSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonFlightsWithBookingInformationSearch.Name = "buttonFlightsWithBookingInformationSearch";
            this.buttonFlightsWithBookingInformationSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonFlightsWithBookingInformationSearch.TabIndex = 2;
            this.buttonFlightsWithBookingInformationSearch.Text = "&Search";
            this.buttonFlightsWithBookingInformationSearch.UseVisualStyleBackColor = true;
            this.buttonFlightsWithBookingInformationSearch.Click += new System.EventHandler(this.buttonFlightsWithBookingInformationSearch_Click);
            // 
            // durianFlightsWithBookingInformation
            // 
            this.durianFlightsWithBookingInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianFlightsWithBookingInformation.Location = new System.Drawing.Point(12, 12);
            this.durianFlightsWithBookingInformation.Name = "durianFlightsWithBookingInformation";
            this.durianFlightsWithBookingInformation.Size = new System.Drawing.Size(502, 259);
            this.durianFlightsWithBookingInformation.TabIndex = 1;
            // 
            // InitFlightsWithBookingInformationSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonFlightsWithBookingInformationSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianFlightsWithBookingInformation);
            this.Name = "FlightsWithBookingInformationSearch";
            this.Text = "Flights With Booking Information";
            this.ResumeLayout(false);

        }
    }
}
