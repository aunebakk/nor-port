namespace SolutionNorSolutionPort.UserInterface {

    public partial class GetAirportIndexWithFilterSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonGetAirportIndexWithFilterSearch;
        
        private GetAirportIndexWithFilterDurian durianGetAirportIndexWithFilter;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonGetAirportIndexWithFilterSearch = new System.Windows.Forms.Button();
            this.durianGetAirportIndexWithFilter = new GetAirportIndexWithFilterDurian();
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
            // buttonGetAirportIndexWithFilterSearch
            // 
            this.buttonGetAirportIndexWithFilterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetAirportIndexWithFilterSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonGetAirportIndexWithFilterSearch.Name = "buttonGetAirportIndexWithFilterSearch";
            this.buttonGetAirportIndexWithFilterSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonGetAirportIndexWithFilterSearch.TabIndex = 2;
            this.buttonGetAirportIndexWithFilterSearch.Text = "&Search";
            this.buttonGetAirportIndexWithFilterSearch.UseVisualStyleBackColor = true;
            this.buttonGetAirportIndexWithFilterSearch.Click += new System.EventHandler(this.buttonGetAirportIndexWithFilterSearch_Click);
            // 
            // durianGetAirportIndexWithFilter
            // 
            this.durianGetAirportIndexWithFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianGetAirportIndexWithFilter.Location = new System.Drawing.Point(12, 12);
            this.durianGetAirportIndexWithFilter.Name = "durianGetAirportIndexWithFilter";
            this.durianGetAirportIndexWithFilter.Size = new System.Drawing.Size(502, 259);
            this.durianGetAirportIndexWithFilter.TabIndex = 1;
            // 
            // InitGetAirportIndexWithFilterSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonGetAirportIndexWithFilterSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianGetAirportIndexWithFilter);
            this.Name = "GetAirportIndexWithFilterSearch";
            this.Text = "Get Airport Index With Filter";
            this.ResumeLayout(false);

        }
    }
}
