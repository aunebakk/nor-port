namespace SolutionNorSolutionPort.UserInterface {

    public partial class GetAvailableCurrenciesSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonGetAvailableCurrenciesSearch;
        
        private GetAvailableCurrenciesDurian durianGetAvailableCurrencies;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonGetAvailableCurrenciesSearch = new System.Windows.Forms.Button();
            this.durianGetAvailableCurrencies = new GetAvailableCurrenciesDurian();
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
            // buttonGetAvailableCurrenciesSearch
            // 
            this.buttonGetAvailableCurrenciesSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetAvailableCurrenciesSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonGetAvailableCurrenciesSearch.Name = "buttonGetAvailableCurrenciesSearch";
            this.buttonGetAvailableCurrenciesSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonGetAvailableCurrenciesSearch.TabIndex = 2;
            this.buttonGetAvailableCurrenciesSearch.Text = "&Search";
            this.buttonGetAvailableCurrenciesSearch.UseVisualStyleBackColor = true;
            this.buttonGetAvailableCurrenciesSearch.Click += new System.EventHandler(this.buttonGetAvailableCurrenciesSearch_Click);
            // 
            // durianGetAvailableCurrencies
            // 
            this.durianGetAvailableCurrencies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianGetAvailableCurrencies.Location = new System.Drawing.Point(12, 12);
            this.durianGetAvailableCurrencies.Name = "durianGetAvailableCurrencies";
            this.durianGetAvailableCurrencies.Size = new System.Drawing.Size(502, 259);
            this.durianGetAvailableCurrencies.TabIndex = 1;
            // 
            // InitGetAvailableCurrenciesSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonGetAvailableCurrenciesSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianGetAvailableCurrencies);
            this.Name = "GetAvailableCurrenciesSearch";
            this.Text = "Get Available Currencies";
            this.ResumeLayout(false);

        }
    }
}
