namespace SolutionNorSolutionPort.UserInterface
{


    public partial class ScheduleSearch
    {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnClose;

        private System.Windows.Forms.Button buttonSearch;

        private System.Windows.Forms.DataGridView gridFlightSchedule;

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
            this.gridFlightSchedule = new System.Windows.Forms.DataGridView();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonSegments = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonMakeFlights = new System.Windows.Forms.Button();
            this.buttonMakeAll = new System.Windows.Forms.Button();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.gridFlightSchedule ) ).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.btnClose.Location = new System.Drawing.Point(618, 277);
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
            this.buttonSearch.Location = new System.Drawing.Point(520, 277);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "&Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // gridFlightSchedule
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(( ( int ) ( ( ( byte ) ( 192 ) ) ) ), ( ( int ) ( ( ( byte ) ( 192 ) ) ) ), ( ( int ) ( ( ( byte ) ( 255 ) ) ) ));
            this.gridFlightSchedule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridFlightSchedule.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
            | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.gridFlightSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFlightSchedule.Location = new System.Drawing.Point(2, 3);
            this.gridFlightSchedule.Name = "gridFlightSchedule";
            this.gridFlightSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFlightSchedule.Size = new System.Drawing.Size(708, 268);
            this.gridFlightSchedule.TabIndex = 0;
            this.gridFlightSchedule.DoubleClick += new System.EventHandler(this.gridFlightSchedule_DoubleClick);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonEdit.Location = new System.Drawing.Point(422, 277);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "&Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonSegments
            // 
            this.buttonSegments.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonSegments.Location = new System.Drawing.Point(222, 277);
            this.buttonSegments.Name = "buttonSegments";
            this.buttonSegments.Size = new System.Drawing.Size(92, 22);
            this.buttonSegments.TabIndex = 4;
            this.buttonSegments.Text = "&Segments";
            this.buttonSegments.UseVisualStyleBackColor = true;
            this.buttonSegments.Click += new System.EventHandler(this.buttonSegments_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonNew.Location = new System.Drawing.Point(320, 277);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(92, 22);
            this.buttonNew.TabIndex = 5;
            this.buttonNew.Text = "&New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonMakeFlights
            // 
            this.buttonMakeFlights.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonMakeFlights.Location = new System.Drawing.Point(124, 277);
            this.buttonMakeFlights.Name = "buttonMakeFlights";
            this.buttonMakeFlights.Size = new System.Drawing.Size(92, 22);
            this.buttonMakeFlights.TabIndex = 6;
            this.buttonMakeFlights.Text = "&Make Flights";
            this.buttonMakeFlights.UseVisualStyleBackColor = true;
            this.buttonMakeFlights.Click += new System.EventHandler(this.buttonMakeFlights_Click);
            // 
            // buttonMakeAll
            // 
            this.buttonMakeAll.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonMakeAll.Location = new System.Drawing.Point(26, 277);
            this.buttonMakeAll.Name = "buttonMakeAll";
            this.buttonMakeAll.Size = new System.Drawing.Size(92, 22);
            this.buttonMakeAll.TabIndex = 7;
            this.buttonMakeAll.Text = "&Make All";
            this.buttonMakeAll.UseVisualStyleBackColor = true;
            this.buttonMakeAll.Click += new System.EventHandler(this.buttonMakeAll_Click);
            // 
            // ScheduleSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 302);
            this.Controls.Add(this.buttonMakeAll);
            this.Controls.Add(this.buttonMakeFlights);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonSegments);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gridFlightSchedule);
            this.Name = "ScheduleSearch";
            this.Text = "Flight Schedule";
            ( ( System.ComponentModel.ISupportInitialize ) ( this.gridFlightSchedule ) ).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonSegments;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonMakeFlights;
        private System.Windows.Forms.Button buttonMakeAll;
    }
}
