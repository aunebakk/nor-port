namespace SolutionNorSolutionPort.UserInterface {

    public partial class GetFerryIndexWithFilterSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonGetFerryIndexWithFilterSearch;
        
        private GetFerryIndexWithFilterDurian durianGetFerryIndexWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonGetFerryIndexWithFilterSearch = new System.Windows.Forms.Button();
            this.durianGetFerryIndexWithFilter = new GetFerryIndexWithFilterDurian();
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
            // buttonGetFerryIndexWithFilterSearch
            // 
            this.buttonGetFerryIndexWithFilterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetFerryIndexWithFilterSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonGetFerryIndexWithFilterSearch.Name = "buttonGetFerryIndexWithFilterSearch";
            this.buttonGetFerryIndexWithFilterSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonGetFerryIndexWithFilterSearch.TabIndex = 2;
            this.buttonGetFerryIndexWithFilterSearch.Text = "&Search";
            this.buttonGetFerryIndexWithFilterSearch.UseVisualStyleBackColor = true;
            this.buttonGetFerryIndexWithFilterSearch.Click += new System.EventHandler(this.buttonGetFerryIndexWithFilterSearch_Click);
            // 
            // durianGetFerryIndexWithFilter
            // 
            this.durianGetFerryIndexWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianGetFerryIndexWithFilter.Location = new System.Drawing.Point(12, 12);
            this.durianGetFerryIndexWithFilter.Name = "durianGetFerryIndexWithFilter";
            this.durianGetFerryIndexWithFilter.Size = new System.Drawing.Size(502, 259);
            this.durianGetFerryIndexWithFilter.TabIndex = 1;
            // 
            // InitGetFerryIndexWithFilterSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonGetFerryIndexWithFilterSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianGetFerryIndexWithFilter);
            this.Name = "GetFerryIndexWithFilterSearch";
            this.Text = "Get Ferry Index With Filter";
            this.ResumeLayout(false);

        }
    }
}
