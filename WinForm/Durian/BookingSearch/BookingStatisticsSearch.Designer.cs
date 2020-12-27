namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingStatisticsSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonBookingStatisticsSearch;
        
        private BookingStatisticsDurian durianBookingStatistics;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonBookingStatisticsSearch = new System.Windows.Forms.Button();
            this.durianBookingStatistics = new BookingStatisticsDurian();
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
            // buttonBookingStatisticsSearch
            // 
            this.buttonBookingStatisticsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBookingStatisticsSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonBookingStatisticsSearch.Name = "buttonBookingStatisticsSearch";
            this.buttonBookingStatisticsSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonBookingStatisticsSearch.TabIndex = 2;
            this.buttonBookingStatisticsSearch.Text = "&Search";
            this.buttonBookingStatisticsSearch.UseVisualStyleBackColor = true;
            this.buttonBookingStatisticsSearch.Click += new System.EventHandler(this.buttonBookingStatisticsSearch_Click);
            // 
            // durianBookingStatistics
            // 
            this.durianBookingStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianBookingStatistics.Location = new System.Drawing.Point(12, 12);
            this.durianBookingStatistics.Name = "durianBookingStatistics";
            this.durianBookingStatistics.Size = new System.Drawing.Size(502, 259);
            this.durianBookingStatistics.TabIndex = 1;
            // 
            // InitBookingStatisticsSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonBookingStatisticsSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianBookingStatistics);
            this.Name = "BookingStatisticsSearch";
            this.Text = "Booking Statistics";
            this.ResumeLayout(false);

        }
    }
}
