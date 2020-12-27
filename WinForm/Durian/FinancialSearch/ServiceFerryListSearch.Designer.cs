﻿namespace SolutionNorSolutionPort.UserInterface {

    public partial class ServiceFerryListSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonServiceFerryListSearch;
        
        private ServiceFerryListDurian durianServiceFerryList;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonServiceFerryListSearch = new System.Windows.Forms.Button();
            this.durianServiceFerryList = new ServiceFerryListDurian();
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
            // buttonServiceFerryListSearch
            // 
            this.buttonServiceFerryListSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonServiceFerryListSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonServiceFerryListSearch.Name = "buttonServiceFerryListSearch";
            this.buttonServiceFerryListSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonServiceFerryListSearch.TabIndex = 2;
            this.buttonServiceFerryListSearch.Text = "&Search";
            this.buttonServiceFerryListSearch.UseVisualStyleBackColor = true;
            this.buttonServiceFerryListSearch.Click += new System.EventHandler(this.buttonServiceFerryListSearch_Click);
            // 
            // durianServiceFerryList
            // 
            this.durianServiceFerryList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianServiceFerryList.Location = new System.Drawing.Point(12, 12);
            this.durianServiceFerryList.Name = "durianServiceFerryList";
            this.durianServiceFerryList.Size = new System.Drawing.Size(502, 259);
            this.durianServiceFerryList.TabIndex = 1;
            // 
            // InitServiceFerryListSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonServiceFerryListSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianServiceFerryList);
            this.Name = "ServiceFerryListSearch";
            this.Text = "Service Ferry List";
            this.ResumeLayout(false);

        }
    }
}
