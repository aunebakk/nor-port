namespace SolutionNorSolutionPort.UserInterface {

    public partial class ServiceHotelListSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonServiceHotelListSearch;
        
        private ServiceHotelListDurian durianServiceHotelList;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonServiceHotelListSearch = new System.Windows.Forms.Button();
            this.durianServiceHotelList = new ServiceHotelListDurian();
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
            // buttonServiceHotelListSearch
            // 
            this.buttonServiceHotelListSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonServiceHotelListSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonServiceHotelListSearch.Name = "buttonServiceHotelListSearch";
            this.buttonServiceHotelListSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonServiceHotelListSearch.TabIndex = 2;
            this.buttonServiceHotelListSearch.Text = "&Search";
            this.buttonServiceHotelListSearch.UseVisualStyleBackColor = true;
            this.buttonServiceHotelListSearch.Click += new System.EventHandler(this.buttonServiceHotelListSearch_Click);
            // 
            // durianServiceHotelList
            // 
            this.durianServiceHotelList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianServiceHotelList.Location = new System.Drawing.Point(12, 12);
            this.durianServiceHotelList.Name = "durianServiceHotelList";
            this.durianServiceHotelList.Size = new System.Drawing.Size(502, 259);
            this.durianServiceHotelList.TabIndex = 1;
            // 
            // InitServiceHotelListSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonServiceHotelListSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianServiceHotelList);
            this.Name = "ServiceHotelListSearch";
            this.Text = "Service Hotel List";
            this.ResumeLayout(false);

        }
    }
}
