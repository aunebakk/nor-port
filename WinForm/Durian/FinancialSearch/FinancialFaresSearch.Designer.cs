namespace SolutionNorSolutionPort.UserInterface {

    public partial class FinancialFaresSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonFinancialFaresSearch;
        
        private FinancialFaresDurian durianFinancialFares;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonFinancialFaresSearch = new System.Windows.Forms.Button();
            this.durianFinancialFares = new FinancialFaresDurian();
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
            // buttonFinancialFaresSearch
            // 
            this.buttonFinancialFaresSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFinancialFaresSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonFinancialFaresSearch.Name = "buttonFinancialFaresSearch";
            this.buttonFinancialFaresSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonFinancialFaresSearch.TabIndex = 2;
            this.buttonFinancialFaresSearch.Text = "&Search";
            this.buttonFinancialFaresSearch.UseVisualStyleBackColor = true;
            this.buttonFinancialFaresSearch.Click += new System.EventHandler(this.buttonFinancialFaresSearch_Click);
            // 
            // durianFinancialFares
            // 
            this.durianFinancialFares.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianFinancialFares.Location = new System.Drawing.Point(12, 12);
            this.durianFinancialFares.Name = "durianFinancialFares";
            this.durianFinancialFares.Size = new System.Drawing.Size(502, 259);
            this.durianFinancialFares.TabIndex = 1;
            // 
            // InitFinancialFaresSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonFinancialFaresSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianFinancialFares);
            this.Name = "FinancialFaresSearch";
            this.Text = "Financial Fares";
            this.ResumeLayout(false);

        }
    }
}
