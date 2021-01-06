namespace SolutionNorSolutionPort.UserInterface {

    public partial class ServiceCarRentalListSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonServiceCarRentalListSearch;
        
        private ServiceCarRentalListDurian durianServiceCarRentalList;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonServiceCarRentalListSearch = new System.Windows.Forms.Button();
            this.durianServiceCarRentalList = new ServiceCarRentalListDurian();
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
            // buttonServiceCarRentalListSearch
            // 
            this.buttonServiceCarRentalListSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonServiceCarRentalListSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonServiceCarRentalListSearch.Name = "buttonServiceCarRentalListSearch";
            this.buttonServiceCarRentalListSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonServiceCarRentalListSearch.TabIndex = 2;
            this.buttonServiceCarRentalListSearch.Text = "&Search";
            this.buttonServiceCarRentalListSearch.UseVisualStyleBackColor = true;
            this.buttonServiceCarRentalListSearch.Click += new System.EventHandler(this.buttonServiceCarRentalListSearch_Click);
            // 
            // durianServiceCarRentalList
            // 
            this.durianServiceCarRentalList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianServiceCarRentalList.Location = new System.Drawing.Point(12, 12);
            this.durianServiceCarRentalList.Name = "durianServiceCarRentalList";
            this.durianServiceCarRentalList.Size = new System.Drawing.Size(502, 259);
            this.durianServiceCarRentalList.TabIndex = 1;
            // 
            // InitServiceCarRentalListSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonServiceCarRentalListSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianServiceCarRentalList);
            this.Name = "ServiceCarRentalListSearch";
            this.Text = "Service Car Rental List";
            this.ResumeLayout(false);

        }
    }
}
