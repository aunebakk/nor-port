namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingEventHistorySearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonBookingEventHistorySearch;
        
        private BookingEventHistoryDurian durianBookingEventHistory;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonBookingEventHistorySearch = new System.Windows.Forms.Button();
            this.durianBookingEventHistory = new BookingEventHistoryDurian();
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
            // buttonBookingEventHistorySearch
            // 
            this.buttonBookingEventHistorySearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBookingEventHistorySearch.Location = new System.Drawing.Point(324, 277);
            this.buttonBookingEventHistorySearch.Name = "buttonBookingEventHistorySearch";
            this.buttonBookingEventHistorySearch.Size = new System.Drawing.Size(92, 22);
            this.buttonBookingEventHistorySearch.TabIndex = 2;
            this.buttonBookingEventHistorySearch.Text = "&Search";
            this.buttonBookingEventHistorySearch.UseVisualStyleBackColor = true;
            this.buttonBookingEventHistorySearch.Click += new System.EventHandler(this.buttonBookingEventHistorySearch_Click);
            // 
            // durianBookingEventHistory
            // 
            this.durianBookingEventHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianBookingEventHistory.Location = new System.Drawing.Point(12, 12);
            this.durianBookingEventHistory.Name = "durianBookingEventHistory";
            this.durianBookingEventHistory.Size = new System.Drawing.Size(502, 259);
            this.durianBookingEventHistory.TabIndex = 1;
            // 
            // InitBookingEventHistorySearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonBookingEventHistorySearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianBookingEventHistory);
            this.Name = "BookingEventHistorySearch";
            this.Text = "Booking Event History";
            this.ResumeLayout(false);

        }
    }
}
