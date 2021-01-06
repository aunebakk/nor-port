namespace SolutionNorSolutionPort.UserInterface {

    public partial class TransactionsCreditDebitBalanceSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonTransactionsCreditDebitBalanceSearch;
        
        private TransactionsCreditDebitBalanceDurian durianTransactionsCreditDebitBalance;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonTransactionsCreditDebitBalanceSearch = new System.Windows.Forms.Button();
            this.durianTransactionsCreditDebitBalance = new TransactionsCreditDebitBalanceDurian();
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
            // buttonTransactionsCreditDebitBalanceSearch
            // 
            this.buttonTransactionsCreditDebitBalanceSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTransactionsCreditDebitBalanceSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonTransactionsCreditDebitBalanceSearch.Name = "buttonTransactionsCreditDebitBalanceSearch";
            this.buttonTransactionsCreditDebitBalanceSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonTransactionsCreditDebitBalanceSearch.TabIndex = 2;
            this.buttonTransactionsCreditDebitBalanceSearch.Text = "&Search";
            this.buttonTransactionsCreditDebitBalanceSearch.UseVisualStyleBackColor = true;
            this.buttonTransactionsCreditDebitBalanceSearch.Click += new System.EventHandler(this.buttonTransactionsCreditDebitBalanceSearch_Click);
            // 
            // durianTransactionsCreditDebitBalance
            // 
            this.durianTransactionsCreditDebitBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianTransactionsCreditDebitBalance.Location = new System.Drawing.Point(12, 12);
            this.durianTransactionsCreditDebitBalance.Name = "durianTransactionsCreditDebitBalance";
            this.durianTransactionsCreditDebitBalance.Size = new System.Drawing.Size(502, 259);
            this.durianTransactionsCreditDebitBalance.TabIndex = 1;
            // 
            // InitTransactionsCreditDebitBalanceSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonTransactionsCreditDebitBalanceSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianTransactionsCreditDebitBalance);
            this.Name = "TransactionsCreditDebitBalanceSearch";
            this.Text = "Transactions Credit Debit Balance";
            this.ResumeLayout(false);

        }
    }
}
