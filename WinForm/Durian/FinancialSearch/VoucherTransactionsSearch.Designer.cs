namespace SolutionNorSolutionPort.UserInterface {

    public partial class VoucherTransactionsSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonVoucherTransactionsSearch;
        
        private VoucherTransactionsDurian durianVoucherTransactions;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonVoucherTransactionsSearch = new System.Windows.Forms.Button();
            this.durianVoucherTransactions = new VoucherTransactionsDurian();
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
            // buttonVoucherTransactionsSearch
            // 
            this.buttonVoucherTransactionsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVoucherTransactionsSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonVoucherTransactionsSearch.Name = "buttonVoucherTransactionsSearch";
            this.buttonVoucherTransactionsSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonVoucherTransactionsSearch.TabIndex = 2;
            this.buttonVoucherTransactionsSearch.Text = "&Search";
            this.buttonVoucherTransactionsSearch.UseVisualStyleBackColor = true;
            this.buttonVoucherTransactionsSearch.Click += new System.EventHandler(this.buttonVoucherTransactionsSearch_Click);
            // 
            // durianVoucherTransactions
            // 
            this.durianVoucherTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianVoucherTransactions.Location = new System.Drawing.Point(12, 12);
            this.durianVoucherTransactions.Name = "durianVoucherTransactions";
            this.durianVoucherTransactions.Size = new System.Drawing.Size(502, 259);
            this.durianVoucherTransactions.TabIndex = 1;
            // 
            // InitVoucherTransactionsSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonVoucherTransactionsSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianVoucherTransactions);
            this.Name = "VoucherTransactionsSearch";
            this.Text = "Voucher Transactions";
            this.ResumeLayout(false);

        }
    }
}
