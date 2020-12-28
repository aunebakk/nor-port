namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightsForPeriodSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonFlightsForPeriodSearch;
        
        private FlightsForPeriodDurian durianFlightsForPeriod;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonFlightsForPeriodSearch = new System.Windows.Forms.Button();
            this.durianFlightsForPeriod = new FlightsForPeriodDurian();
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
            // buttonFlightsForPeriodSearch
            // 
            this.buttonFlightsForPeriodSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFlightsForPeriodSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonFlightsForPeriodSearch.Name = "buttonFlightsForPeriodSearch";
            this.buttonFlightsForPeriodSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonFlightsForPeriodSearch.TabIndex = 2;
            this.buttonFlightsForPeriodSearch.Text = "&Search";
            this.buttonFlightsForPeriodSearch.UseVisualStyleBackColor = true;
            this.buttonFlightsForPeriodSearch.Click += new System.EventHandler(this.buttonFlightsForPeriodSearch_Click);
            // 
            // durianFlightsForPeriod
            // 
            this.durianFlightsForPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianFlightsForPeriod.Location = new System.Drawing.Point(12, 12);
            this.durianFlightsForPeriod.Name = "durianFlightsForPeriod";
            this.durianFlightsForPeriod.Size = new System.Drawing.Size(502, 259);
            this.durianFlightsForPeriod.TabIndex = 1;
            // 
            // InitFlightsForPeriodSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonFlightsForPeriodSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianFlightsForPeriod);
            this.Name = "FlightsForPeriodSearch";
            this.Text = "Flights For Period";
            this.ResumeLayout(false);

        }
    }
}
