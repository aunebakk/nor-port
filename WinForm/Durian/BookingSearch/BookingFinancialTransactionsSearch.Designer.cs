namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingFinancialTransactionsSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonBookingFinancialTransactionsSearch;
        
        private BookingFinancialTransactionsDurian durianBookingFinancialTransactions;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonBookingFinancialTransactionsSearch = new System.Windows.Forms.Button();
            this.durianBookingFinancialTransactions = new BookingFinancialTransactionsDurian();
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
            // buttonBookingFinancialTransactionsSearch
            // 
            this.buttonBookingFinancialTransactionsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBookingFinancialTransactionsSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonBookingFinancialTransactionsSearch.Name = "buttonBookingFinancialTransactionsSearch";
            this.buttonBookingFinancialTransactionsSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonBookingFinancialTransactionsSearch.TabIndex = 2;
            this.buttonBookingFinancialTransactionsSearch.Text = "&Search";
            this.buttonBookingFinancialTransactionsSearch.UseVisualStyleBackColor = true;
            this.buttonBookingFinancialTransactionsSearch.Click += new System.EventHandler(this.buttonBookingFinancialTransactionsSearch_Click);
            // 
            // durianBookingFinancialTransactions
            // 
            this.durianBookingFinancialTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianBookingFinancialTransactions.Location = new System.Drawing.Point(12, 12);
            this.durianBookingFinancialTransactions.Name = "durianBookingFinancialTransactions";
            this.durianBookingFinancialTransactions.Size = new System.Drawing.Size(502, 259);
            this.durianBookingFinancialTransactions.TabIndex = 1;
            // 
            // InitBookingFinancialTransactionsSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonBookingFinancialTransactionsSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianBookingFinancialTransactions);
            this.Name = "BookingFinancialTransactionsSearch";
            this.Text = "Booking Financial Transactions";
            this.ResumeLayout(false);

        }
    }
}
