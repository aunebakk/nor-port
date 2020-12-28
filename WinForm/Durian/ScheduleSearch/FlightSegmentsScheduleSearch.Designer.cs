namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightSegmentsScheduleSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonFlightSegmentsScheduleSearch;
        
        private FlightSegmentsScheduleDurian durianFlightSegmentsSchedule;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonFlightSegmentsScheduleSearch = new System.Windows.Forms.Button();
            this.durianFlightSegmentsSchedule = new FlightSegmentsScheduleDurian();
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
            // buttonFlightSegmentsScheduleSearch
            // 
            this.buttonFlightSegmentsScheduleSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFlightSegmentsScheduleSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonFlightSegmentsScheduleSearch.Name = "buttonFlightSegmentsScheduleSearch";
            this.buttonFlightSegmentsScheduleSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonFlightSegmentsScheduleSearch.TabIndex = 2;
            this.buttonFlightSegmentsScheduleSearch.Text = "&Search";
            this.buttonFlightSegmentsScheduleSearch.UseVisualStyleBackColor = true;
            this.buttonFlightSegmentsScheduleSearch.Click += new System.EventHandler(this.buttonFlightSegmentsScheduleSearch_Click);
            // 
            // durianFlightSegmentsSchedule
            // 
            this.durianFlightSegmentsSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianFlightSegmentsSchedule.Location = new System.Drawing.Point(12, 12);
            this.durianFlightSegmentsSchedule.Name = "durianFlightSegmentsSchedule";
            this.durianFlightSegmentsSchedule.Size = new System.Drawing.Size(502, 259);
            this.durianFlightSegmentsSchedule.TabIndex = 1;
            // 
            // InitFlightSegmentsScheduleSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonFlightSegmentsScheduleSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianFlightSegmentsSchedule);
            this.Name = "FlightSegmentsScheduleSearch";
            this.Text = "Flight Segments Schedule";
            this.ResumeLayout(false);

        }
    }
}
