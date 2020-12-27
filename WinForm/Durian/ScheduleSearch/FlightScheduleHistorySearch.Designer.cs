namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightScheduleHistorySearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonFlightScheduleHistorySearch;
        
        private FlightScheduleHistoryDurian durianFlightScheduleHistory;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonFlightScheduleHistorySearch = new System.Windows.Forms.Button();
            this.durianFlightScheduleHistory = new FlightScheduleHistoryDurian();
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
            // buttonFlightScheduleHistorySearch
            // 
            this.buttonFlightScheduleHistorySearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFlightScheduleHistorySearch.Location = new System.Drawing.Point(324, 277);
            this.buttonFlightScheduleHistorySearch.Name = "buttonFlightScheduleHistorySearch";
            this.buttonFlightScheduleHistorySearch.Size = new System.Drawing.Size(92, 22);
            this.buttonFlightScheduleHistorySearch.TabIndex = 2;
            this.buttonFlightScheduleHistorySearch.Text = "&Search";
            this.buttonFlightScheduleHistorySearch.UseVisualStyleBackColor = true;
            this.buttonFlightScheduleHistorySearch.Click += new System.EventHandler(this.buttonFlightScheduleHistorySearch_Click);
            // 
            // durianFlightScheduleHistory
            // 
            this.durianFlightScheduleHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianFlightScheduleHistory.Location = new System.Drawing.Point(12, 12);
            this.durianFlightScheduleHistory.Name = "durianFlightScheduleHistory";
            this.durianFlightScheduleHistory.Size = new System.Drawing.Size(502, 259);
            this.durianFlightScheduleHistory.TabIndex = 1;
            // 
            // InitFlightScheduleHistorySearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonFlightScheduleHistorySearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianFlightScheduleHistory);
            this.Name = "FlightScheduleHistorySearch";
            this.Text = "Flight Schedule History";
            this.ResumeLayout(false);

        }
    }
}
