namespace SolutionNorSolutionPort.UserInterface {

    public partial class ServicePackagePromotionWithFilterSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonServicePackagePromotionWithFilterSearch;
        
        private ServicePackagePromotionWithFilterDurian durianServicePackagePromotionWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonServicePackagePromotionWithFilterSearch = new System.Windows.Forms.Button();
            this.durianServicePackagePromotionWithFilter = new ServicePackagePromotionWithFilterDurian();
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
            // buttonServicePackagePromotionWithFilterSearch
            // 
            this.buttonServicePackagePromotionWithFilterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonServicePackagePromotionWithFilterSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonServicePackagePromotionWithFilterSearch.Name = "buttonServicePackagePromotionWithFilterSearch";
            this.buttonServicePackagePromotionWithFilterSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonServicePackagePromotionWithFilterSearch.TabIndex = 2;
            this.buttonServicePackagePromotionWithFilterSearch.Text = "&Search";
            this.buttonServicePackagePromotionWithFilterSearch.UseVisualStyleBackColor = true;
            this.buttonServicePackagePromotionWithFilterSearch.Click += new System.EventHandler(this.buttonServicePackagePromotionWithFilterSearch_Click);
            // 
            // durianServicePackagePromotionWithFilter
            // 
            this.durianServicePackagePromotionWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianServicePackagePromotionWithFilter.Location = new System.Drawing.Point(12, 12);
            this.durianServicePackagePromotionWithFilter.Name = "durianServicePackagePromotionWithFilter";
            this.durianServicePackagePromotionWithFilter.Size = new System.Drawing.Size(502, 259);
            this.durianServicePackagePromotionWithFilter.TabIndex = 1;
            // 
            // InitServicePackagePromotionWithFilterSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonServicePackagePromotionWithFilterSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianServicePackagePromotionWithFilter);
            this.Name = "ServicePackagePromotionWithFilterSearch";
            this.Text = "Service Package Promotion With Filter";
            this.ResumeLayout(false);

        }
    }
}
