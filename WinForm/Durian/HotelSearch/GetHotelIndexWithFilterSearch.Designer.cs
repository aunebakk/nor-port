namespace SolutionNorSolutionPort.UserInterface {

    public partial class GetHotelIndexWithFilterSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonGetHotelIndexWithFilterSearch;
        
        private GetHotelIndexWithFilterDurian durianGetHotelIndexWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonGetHotelIndexWithFilterSearch = new System.Windows.Forms.Button();
            this.durianGetHotelIndexWithFilter = new GetHotelIndexWithFilterDurian();
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
            // buttonGetHotelIndexWithFilterSearch
            // 
            this.buttonGetHotelIndexWithFilterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetHotelIndexWithFilterSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonGetHotelIndexWithFilterSearch.Name = "buttonGetHotelIndexWithFilterSearch";
            this.buttonGetHotelIndexWithFilterSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonGetHotelIndexWithFilterSearch.TabIndex = 2;
            this.buttonGetHotelIndexWithFilterSearch.Text = "&Search";
            this.buttonGetHotelIndexWithFilterSearch.UseVisualStyleBackColor = true;
            this.buttonGetHotelIndexWithFilterSearch.Click += new System.EventHandler(this.buttonGetHotelIndexWithFilterSearch_Click);
            // 
            // durianGetHotelIndexWithFilter
            // 
            this.durianGetHotelIndexWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianGetHotelIndexWithFilter.Location = new System.Drawing.Point(12, 12);
            this.durianGetHotelIndexWithFilter.Name = "durianGetHotelIndexWithFilter";
            this.durianGetHotelIndexWithFilter.Size = new System.Drawing.Size(502, 259);
            this.durianGetHotelIndexWithFilter.TabIndex = 1;
            // 
            // InitGetHotelIndexWithFilterSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonGetHotelIndexWithFilterSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianGetHotelIndexWithFilter);
            this.Name = "GetHotelIndexWithFilterSearch";
            this.Text = "Get Hotel Index With Filter";
            this.ResumeLayout(false);

        }
    }
}
