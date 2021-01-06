namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightScheduleSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonFlightScheduleSearch;
        
        private FlightScheduleDurian durianFlightSchedule;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonFlightScheduleSearch = new System.Windows.Forms.Button();
            this.durianFlightSchedule = new FlightScheduleDurian();
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
            // buttonFlightScheduleSearch
            // 
            this.buttonFlightScheduleSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFlightScheduleSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonFlightScheduleSearch.Name = "buttonFlightScheduleSearch";
            this.buttonFlightScheduleSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonFlightScheduleSearch.TabIndex = 2;
            this.buttonFlightScheduleSearch.Text = "&Search";
            this.buttonFlightScheduleSearch.UseVisualStyleBackColor = true;
            this.buttonFlightScheduleSearch.Click += new System.EventHandler(this.buttonFlightScheduleSearch_Click);
            // 
            // durianFlightSchedule
            // 
            this.durianFlightSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.durianFlightSchedule.Location = new System.Drawing.Point(12, 12);
            this.durianFlightSchedule.Name = "durianFlightSchedule";
            this.durianFlightSchedule.Size = new System.Drawing.Size(502, 259);
            this.durianFlightSchedule.TabIndex = 1;
            // 
            // InitFlightScheduleSearch
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonFlightScheduleSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianFlightSchedule);
            this.Name = "FlightScheduleSearch";
            this.Text = "Flight Schedule";
            this.ResumeLayout(false);

        }
    }
}
