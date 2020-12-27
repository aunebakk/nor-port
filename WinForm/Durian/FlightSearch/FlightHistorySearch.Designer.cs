namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightHistorySearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonFlightHistorySearch;
        
        private FlightHistoryDurian durianFlightHistory;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonFlightHistorySearch = new System.Windows.Forms.Button();
            this.durianFlightHistory = new FlightHistoryDurian();
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
            // buttonFlightHistorySearch
            // 
            this.buttonFlightHistorySearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFlightHistorySearch.Location = new System.Drawing.Point(324, 277);
            this.buttonFlightHistorySearch.Name = "buttonFlightHistorySearch";
            this.buttonFlightHistorySearch.Size = new System.Drawing.Size(92, 22);
            this.buttonFlightHistorySearch.TabIndex = 2;
            this.buttonFlightHistorySearch.Text = "&Search";
            this.buttonFlightHistorySearch.UseVisualStyleBackColor = true;
            this.buttonFlightHistorySearch.Click += new System.EventHandler(this.buttonFlightHistorySearch_Click);
            // 
            // durianFlightHistory
            // 
            this.durianFlightHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianFlightHistory.Location = new System.Drawing.Point(12, 12);
            this.durianFlightHistory.Name = "durianFlightHistory";
            this.durianFlightHistory.Size = new System.Drawing.Size(502, 259);
            this.durianFlightHistory.TabIndex = 1;
            // 
            // InitFlightHistorySearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonFlightHistorySearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianFlightHistory);
            this.Name = "FlightHistorySearch";
            this.Text = "Flight History";
            this.ResumeLayout(false);

        }
    }
}
