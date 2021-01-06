namespace SolutionNorSolutionPort.UserInterface
{


    public partial class SpecialServiceRequestListLiveSearch
    {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonSpecialServiceRequestListSearch;

        private SpecialServiceRequestListDurian durianSpecialServiceRequestList;

        protected override void Dispose(bool disposing) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSpecialServiceRequestListSearch = new System.Windows.Forms.Button();
            this.durianSpecialServiceRequestList = new SolutionNorSolutionPort.UserInterface.SpecialServiceRequestListDurian();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonClose.Location = new System.Drawing.Point(422, 277);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Cancel";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSpecialServiceRequestListSearch
            // 
            this.buttonSpecialServiceRequestListSearch.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonSpecialServiceRequestListSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonSpecialServiceRequestListSearch.Name = "buttonSpecialServiceRequestListSearch";
            this.buttonSpecialServiceRequestListSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonSpecialServiceRequestListSearch.TabIndex = 2;
            this.buttonSpecialServiceRequestListSearch.Text = "&Search";
            this.buttonSpecialServiceRequestListSearch.UseVisualStyleBackColor = true;
            this.buttonSpecialServiceRequestListSearch.Click += new System.EventHandler(this.buttonSpecialServiceRequestListSearch_Click);
            // 
            // durianSpecialServiceRequestList
            // 
            this.durianSpecialServiceRequestList.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
            | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.durianSpecialServiceRequestList.Location = new System.Drawing.Point(12, 12);
            this.durianSpecialServiceRequestList.Name = "durianSpecialServiceRequestList";
            this.durianSpecialServiceRequestList.Size = new System.Drawing.Size(502, 259);
            this.durianSpecialServiceRequestList.TabIndex = 1;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonSelect.Location = new System.Drawing.Point(226, 277);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(92, 22);
            this.buttonSelect.TabIndex = 3;
            this.buttonSelect.Text = "&OK";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // SpecialServiceRequestListLiveSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonSpecialServiceRequestListSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianSpecialServiceRequestList);
            this.Name = "SpecialServiceRequestListLiveSearch";
            this.Text = "Special Service Request List";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button buttonSelect;
    }
}
