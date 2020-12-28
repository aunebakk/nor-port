namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingsOpenSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonBookingsOpenSearch;
        
        private BookingsOpenDurian durianBookingsOpen;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonBookingsOpenSearch = new System.Windows.Forms.Button();
            this.durianBookingsOpen = new BookingsOpenDurian();
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
            // buttonBookingsOpenSearch
            // 
            this.buttonBookingsOpenSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBookingsOpenSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonBookingsOpenSearch.Name = "buttonBookingsOpenSearch";
            this.buttonBookingsOpenSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonBookingsOpenSearch.TabIndex = 2;
            this.buttonBookingsOpenSearch.Text = "&Search";
            this.buttonBookingsOpenSearch.UseVisualStyleBackColor = true;
            this.buttonBookingsOpenSearch.Click += new System.EventHandler(this.buttonBookingsOpenSearch_Click);
            // 
            // durianBookingsOpen
            // 
            this.durianBookingsOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianBookingsOpen.Location = new System.Drawing.Point(12, 12);
            this.durianBookingsOpen.Name = "durianBookingsOpen";
            this.durianBookingsOpen.Size = new System.Drawing.Size(502, 259);
            this.durianBookingsOpen.TabIndex = 1;
            // 
            // InitBookingsOpenSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonBookingsOpenSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianBookingsOpen);
            this.Name = "BookingsOpenSearch";
            this.Text = "Bookings Open";
            this.ResumeLayout(false);

        }
    }
}
