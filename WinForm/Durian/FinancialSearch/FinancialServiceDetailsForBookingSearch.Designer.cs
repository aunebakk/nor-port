namespace SolutionNorSolutionPort.UserInterface {

    public partial class FinancialServiceDetailsForBookingSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonFinancialServiceDetailsForBookingSearch;
        
        private FinancialServiceDetailsForBookingDurian durianFinancialServiceDetailsForBooking;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonFinancialServiceDetailsForBookingSearch = new System.Windows.Forms.Button();
            this.durianFinancialServiceDetailsForBooking = new FinancialServiceDetailsForBookingDurian();
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
            // buttonFinancialServiceDetailsForBookingSearch
            // 
            this.buttonFinancialServiceDetailsForBookingSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFinancialServiceDetailsForBookingSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonFinancialServiceDetailsForBookingSearch.Name = "buttonFinancialServiceDetailsForBookingSearch";
            this.buttonFinancialServiceDetailsForBookingSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonFinancialServiceDetailsForBookingSearch.TabIndex = 2;
            this.buttonFinancialServiceDetailsForBookingSearch.Text = "&Search";
            this.buttonFinancialServiceDetailsForBookingSearch.UseVisualStyleBackColor = true;
            this.buttonFinancialServiceDetailsForBookingSearch.Click += new System.EventHandler(this.buttonFinancialServiceDetailsForBookingSearch_Click);
            // 
            // durianFinancialServiceDetailsForBooking
            // 
            this.durianFinancialServiceDetailsForBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianFinancialServiceDetailsForBooking.Location = new System.Drawing.Point(12, 12);
            this.durianFinancialServiceDetailsForBooking.Name = "durianFinancialServiceDetailsForBooking";
            this.durianFinancialServiceDetailsForBooking.Size = new System.Drawing.Size(502, 259);
            this.durianFinancialServiceDetailsForBooking.TabIndex = 1;
            // 
            // InitFinancialServiceDetailsForBookingSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonFinancialServiceDetailsForBookingSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianFinancialServiceDetailsForBooking);
            this.Name = "FinancialServiceDetailsForBookingSearch";
            this.Text = "Financial Service Details For Booking";
            this.ResumeLayout(false);

        }
    }
}
