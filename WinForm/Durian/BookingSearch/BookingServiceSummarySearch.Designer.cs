namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingServiceSummarySearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonBookingServiceSummarySearch;
        
        private BookingServiceSummaryDurian durianBookingServiceSummary;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonBookingServiceSummarySearch = new System.Windows.Forms.Button();
            this.durianBookingServiceSummary = new BookingServiceSummaryDurian();
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
            // buttonBookingServiceSummarySearch
            // 
            this.buttonBookingServiceSummarySearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBookingServiceSummarySearch.Location = new System.Drawing.Point(324, 277);
            this.buttonBookingServiceSummarySearch.Name = "buttonBookingServiceSummarySearch";
            this.buttonBookingServiceSummarySearch.Size = new System.Drawing.Size(92, 22);
            this.buttonBookingServiceSummarySearch.TabIndex = 2;
            this.buttonBookingServiceSummarySearch.Text = "&Search";
            this.buttonBookingServiceSummarySearch.UseVisualStyleBackColor = true;
            this.buttonBookingServiceSummarySearch.Click += new System.EventHandler(this.buttonBookingServiceSummarySearch_Click);
            // 
            // durianBookingServiceSummary
            // 
            this.durianBookingServiceSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianBookingServiceSummary.Location = new System.Drawing.Point(12, 12);
            this.durianBookingServiceSummary.Name = "durianBookingServiceSummary";
            this.durianBookingServiceSummary.Size = new System.Drawing.Size(502, 259);
            this.durianBookingServiceSummary.TabIndex = 1;
            // 
            // InitBookingServiceSummarySearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonBookingServiceSummarySearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianBookingServiceSummary);
            this.Name = "BookingServiceSummarySearch";
            this.Text = "Booking Service Summary";
            this.ResumeLayout(false);

        }
    }
}
