namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingFinancialPaymentsSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonBookingFinancialPaymentsSearch;
        
        private BookingFinancialPaymentsDurian durianBookingFinancialPayments;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonBookingFinancialPaymentsSearch = new System.Windows.Forms.Button();
            this.durianBookingFinancialPayments = new BookingFinancialPaymentsDurian();
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
            // buttonBookingFinancialPaymentsSearch
            // 
            this.buttonBookingFinancialPaymentsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBookingFinancialPaymentsSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonBookingFinancialPaymentsSearch.Name = "buttonBookingFinancialPaymentsSearch";
            this.buttonBookingFinancialPaymentsSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonBookingFinancialPaymentsSearch.TabIndex = 2;
            this.buttonBookingFinancialPaymentsSearch.Text = "&Search";
            this.buttonBookingFinancialPaymentsSearch.UseVisualStyleBackColor = true;
            this.buttonBookingFinancialPaymentsSearch.Click += new System.EventHandler(this.buttonBookingFinancialPaymentsSearch_Click);
            // 
            // durianBookingFinancialPayments
            // 
            this.durianBookingFinancialPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianBookingFinancialPayments.Location = new System.Drawing.Point(12, 12);
            this.durianBookingFinancialPayments.Name = "durianBookingFinancialPayments";
            this.durianBookingFinancialPayments.Size = new System.Drawing.Size(502, 259);
            this.durianBookingFinancialPayments.TabIndex = 1;
            // 
            // InitBookingFinancialPaymentsSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonBookingFinancialPaymentsSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianBookingFinancialPayments);
            this.Name = "BookingFinancialPaymentsSearch";
            this.Text = "Booking Financial Payments";
            this.ResumeLayout(false);

        }
    }
}
