namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingEventCountSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonBookingEventCountSearch;
        
        private BookingEventCountDurian durianBookingEventCount;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonBookingEventCountSearch = new System.Windows.Forms.Button();
            this.durianBookingEventCount = new BookingEventCountDurian();
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
            // buttonBookingEventCountSearch
            // 
            this.buttonBookingEventCountSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBookingEventCountSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonBookingEventCountSearch.Name = "buttonBookingEventCountSearch";
            this.buttonBookingEventCountSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonBookingEventCountSearch.TabIndex = 2;
            this.buttonBookingEventCountSearch.Text = "&Search";
            this.buttonBookingEventCountSearch.UseVisualStyleBackColor = true;
            this.buttonBookingEventCountSearch.Click += new System.EventHandler(this.buttonBookingEventCountSearch_Click);
            // 
            // durianBookingEventCount
            // 
            this.durianBookingEventCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianBookingEventCount.Location = new System.Drawing.Point(12, 12);
            this.durianBookingEventCount.Name = "durianBookingEventCount";
            this.durianBookingEventCount.Size = new System.Drawing.Size(502, 259);
            this.durianBookingEventCount.TabIndex = 1;
            // 
            // InitBookingEventCountSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonBookingEventCountSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianBookingEventCount);
            this.Name = "BookingEventCountSearch";
            this.Text = "Booking Event Count";
            this.ResumeLayout(false);

        }
    }
}
