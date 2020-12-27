namespace SolutionNorSolutionPort.UserInterface {

    public partial class FetchServiceSpecialServiceRequestWithFilterSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonFetchServiceSpecialServiceRequestWithFilterSearch;
        
        private FetchServiceSpecialServiceRequestWithFilterDurian durianFetchServiceSpecialServiceRequestWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonFetchServiceSpecialServiceRequestWithFilterSearch = new System.Windows.Forms.Button();
            this.durianFetchServiceSpecialServiceRequestWithFilter = new FetchServiceSpecialServiceRequestWithFilterDurian();
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
            // buttonFetchServiceSpecialServiceRequestWithFilterSearch
            // 
            this.buttonFetchServiceSpecialServiceRequestWithFilterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFetchServiceSpecialServiceRequestWithFilterSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonFetchServiceSpecialServiceRequestWithFilterSearch.Name = "buttonFetchServiceSpecialServiceRequestWithFilterSearch";
            this.buttonFetchServiceSpecialServiceRequestWithFilterSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonFetchServiceSpecialServiceRequestWithFilterSearch.TabIndex = 2;
            this.buttonFetchServiceSpecialServiceRequestWithFilterSearch.Text = "&Search";
            this.buttonFetchServiceSpecialServiceRequestWithFilterSearch.UseVisualStyleBackColor = true;
            this.buttonFetchServiceSpecialServiceRequestWithFilterSearch.Click += new System.EventHandler(this.buttonFetchServiceSpecialServiceRequestWithFilterSearch_Click);
            // 
            // durianFetchServiceSpecialServiceRequestWithFilter
            // 
            this.durianFetchServiceSpecialServiceRequestWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianFetchServiceSpecialServiceRequestWithFilter.Location = new System.Drawing.Point(12, 12);
            this.durianFetchServiceSpecialServiceRequestWithFilter.Name = "durianFetchServiceSpecialServiceRequestWithFilter";
            this.durianFetchServiceSpecialServiceRequestWithFilter.Size = new System.Drawing.Size(502, 259);
            this.durianFetchServiceSpecialServiceRequestWithFilter.TabIndex = 1;
            // 
            // InitFetchServiceSpecialServiceRequestWithFilterSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonFetchServiceSpecialServiceRequestWithFilterSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianFetchServiceSpecialServiceRequestWithFilter);
            this.Name = "FetchServiceSpecialServiceRequestWithFilterSearch";
            this.Text = "Fetch Service Special Service Request With Filter";
            this.ResumeLayout(false);

        }
    }
}
