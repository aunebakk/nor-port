namespace SolutionNorSolutionPort.UserInterface
{


    public partial class FlightSegmentsScheduleSearchLive
    {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnClose;

        private System.Windows.Forms.Button buttonSearch;

        private System.Windows.Forms.DataGridView gridFlightSegmentsSchedule;

        protected override void Dispose(bool disposing) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.gridFlightSegmentsSchedule = new System.Windows.Forms.DataGridView();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.gridFlightSegmentsSchedule ) ).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.btnClose.Location = new System.Drawing.Point(433, 277);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 22);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonSearch.Location = new System.Drawing.Point(335, 277);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "&Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // gridFlightSegmentsSchedule
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(( ( int ) ( ( ( byte ) ( 192 ) ) ) ), ( ( int ) ( ( ( byte ) ( 192 ) ) ) ), ( ( int ) ( ( ( byte ) ( 255 ) ) ) ));
            this.gridFlightSegmentsSchedule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridFlightSegmentsSchedule.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
            | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.gridFlightSegmentsSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFlightSegmentsSchedule.Location = new System.Drawing.Point(2, 3);
            this.gridFlightSegmentsSchedule.Name = "gridFlightSegmentsSchedule";
            this.gridFlightSegmentsSchedule.Size = new System.Drawing.Size(523, 268);
            this.gridFlightSegmentsSchedule.TabIndex = 0;
            // 
            // FlightSegmentsScheduleSearchLive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gridFlightSegmentsSchedule);
            this.Name = "FlightSegmentsScheduleSearchLive";
            this.Text = "FlightSegmentsSchedule";
            ( ( System.ComponentModel.ISupportInitialize ) ( this.gridFlightSegmentsSchedule ) ).EndInit();
            this.ResumeLayout(false);

        }
    }
}
