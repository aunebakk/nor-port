namespace SolutionNorSolutionPort.UserInterface {

    public partial class VoucherSearchWithRemainingAmountSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonVoucherSearchWithRemainingAmountSearch;
        
        private VoucherSearchWithRemainingAmountDurian durianVoucherSearchWithRemainingAmount;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonVoucherSearchWithRemainingAmountSearch = new System.Windows.Forms.Button();
            this.durianVoucherSearchWithRemainingAmount = new VoucherSearchWithRemainingAmountDurian();
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
            // buttonVoucherSearchWithRemainingAmountSearch
            // 
            this.buttonVoucherSearchWithRemainingAmountSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVoucherSearchWithRemainingAmountSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonVoucherSearchWithRemainingAmountSearch.Name = "buttonVoucherSearchWithRemainingAmountSearch";
            this.buttonVoucherSearchWithRemainingAmountSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonVoucherSearchWithRemainingAmountSearch.TabIndex = 2;
            this.buttonVoucherSearchWithRemainingAmountSearch.Text = "&Search";
            this.buttonVoucherSearchWithRemainingAmountSearch.UseVisualStyleBackColor = true;
            this.buttonVoucherSearchWithRemainingAmountSearch.Click += new System.EventHandler(this.buttonVoucherSearchWithRemainingAmountSearch_Click);
            // 
            // durianVoucherSearchWithRemainingAmount
            // 
            this.durianVoucherSearchWithRemainingAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianVoucherSearchWithRemainingAmount.Location = new System.Drawing.Point(12, 12);
            this.durianVoucherSearchWithRemainingAmount.Name = "durianVoucherSearchWithRemainingAmount";
            this.durianVoucherSearchWithRemainingAmount.Size = new System.Drawing.Size(502, 259);
            this.durianVoucherSearchWithRemainingAmount.TabIndex = 1;
            // 
            // InitVoucherSearchWithRemainingAmountSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonVoucherSearchWithRemainingAmountSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianVoucherSearchWithRemainingAmount);
            this.Name = "VoucherSearchWithRemainingAmountSearch";
            this.Text = "Voucher Search With Remaining Amount";
            this.ResumeLayout(false);

        }
    }
}
