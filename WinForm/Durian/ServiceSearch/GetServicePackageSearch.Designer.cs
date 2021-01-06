namespace SolutionNorSolutionPort.UserInterface {

    public partial class GetServicePackageSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonGetServicePackageSearch;
        
        private GetServicePackageDurian durianGetServicePackage;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonGetServicePackageSearch = new System.Windows.Forms.Button();
            this.durianGetServicePackage = new GetServicePackageDurian();
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
            // buttonGetServicePackageSearch
            // 
            this.buttonGetServicePackageSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetServicePackageSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonGetServicePackageSearch.Name = "buttonGetServicePackageSearch";
            this.buttonGetServicePackageSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonGetServicePackageSearch.TabIndex = 2;
            this.buttonGetServicePackageSearch.Text = "&Search";
            this.buttonGetServicePackageSearch.UseVisualStyleBackColor = true;
            this.buttonGetServicePackageSearch.Click += new System.EventHandler(this.buttonGetServicePackageSearch_Click);
            // 
            // durianGetServicePackage
            // 
            this.durianGetServicePackage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianGetServicePackage.Location = new System.Drawing.Point(12, 12);
            this.durianGetServicePackage.Name = "durianGetServicePackage";
            this.durianGetServicePackage.Size = new System.Drawing.Size(502, 259);
            this.durianGetServicePackage.TabIndex = 1;
            // 
            // InitGetServicePackageSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonGetServicePackageSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianGetServicePackage);
            this.Name = "GetServicePackageSearch";
            this.Text = "Get Service Package";
            this.ResumeLayout(false);

        }
    }
}
