namespace SolutionNorSolutionPort.UserInterface
{


    public partial class BookingsOpenSearchLive
    {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnClose;

        private System.Windows.Forms.Button btnSearch;

        private System.Windows.Forms.DataGridView gridBookingsOpen;

        protected override void Dispose(bool disposing) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gridBookingsOpen = new System.Windows.Forms.DataGridView();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            ( ( System.ComponentModel.ISupportInitialize ) ( this.gridBookingsOpen ) ).BeginInit();
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
            // btnSearch
            // 
            this.btnSearch.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.btnSearch.Location = new System.Drawing.Point(335, 277);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 22);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gridBookingsOpen
            // 
            this.gridBookingsOpen.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
            | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.gridBookingsOpen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBookingsOpen.Location = new System.Drawing.Point(2, 3);
            this.gridBookingsOpen.Name = "gridBookingsOpen";
            this.gridBookingsOpen.Size = new System.Drawing.Size(523, 268);
            this.gridBookingsOpen.TabIndex = 0;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonEdit.Location = new System.Drawing.Point(237, 277);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "&Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonNew.Location = new System.Drawing.Point(139, 277);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(92, 22);
            this.buttonNew.TabIndex = 5;
            this.buttonNew.Text = "&New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // BookingsOpenSearchLive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gridBookingsOpen);
            this.Name = "BookingsOpenSearchLive";
            this.Text = "Bookings";
            this.Load += new System.EventHandler(this.BookingsOpenSearchLive_Load);
            ( ( System.ComponentModel.ISupportInitialize ) ( this.gridBookingsOpen ) ).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonNew;
    }
}
