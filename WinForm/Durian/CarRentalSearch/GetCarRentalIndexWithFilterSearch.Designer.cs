namespace SolutionNorSolutionPort.UserInterface {

    public partial class GetCarRentalIndexWithFilterSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonGetCarRentalIndexWithFilterSearch;
        
        private GetCarRentalIndexWithFilterDurian durianGetCarRentalIndexWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonGetCarRentalIndexWithFilterSearch = new System.Windows.Forms.Button();
            this.durianGetCarRentalIndexWithFilter = new GetCarRentalIndexWithFilterDurian();
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
            // buttonGetCarRentalIndexWithFilterSearch
            // 
            this.buttonGetCarRentalIndexWithFilterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetCarRentalIndexWithFilterSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonGetCarRentalIndexWithFilterSearch.Name = "buttonGetCarRentalIndexWithFilterSearch";
            this.buttonGetCarRentalIndexWithFilterSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonGetCarRentalIndexWithFilterSearch.TabIndex = 2;
            this.buttonGetCarRentalIndexWithFilterSearch.Text = "&Search";
            this.buttonGetCarRentalIndexWithFilterSearch.UseVisualStyleBackColor = true;
            this.buttonGetCarRentalIndexWithFilterSearch.Click += new System.EventHandler(this.buttonGetCarRentalIndexWithFilterSearch_Click);
            // 
            // durianGetCarRentalIndexWithFilter
            // 
            this.durianGetCarRentalIndexWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianGetCarRentalIndexWithFilter.Location = new System.Drawing.Point(12, 12);
            this.durianGetCarRentalIndexWithFilter.Name = "durianGetCarRentalIndexWithFilter";
            this.durianGetCarRentalIndexWithFilter.Size = new System.Drawing.Size(502, 259);
            this.durianGetCarRentalIndexWithFilter.TabIndex = 1;
            // 
            // InitGetCarRentalIndexWithFilterSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonGetCarRentalIndexWithFilterSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianGetCarRentalIndexWithFilter);
            this.Name = "GetCarRentalIndexWithFilterSearch";
            this.Text = "Get Car Rental Index With Filter";
            this.ResumeLayout(false);

        }
    }
}
