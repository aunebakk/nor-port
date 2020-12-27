namespace SolutionNorSolutionPort.UserInterface
{


    public partial class ServiceCarRentalListLiveSearch
    {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonCancel;

        private System.Windows.Forms.Button buttonServiceCarRentalListSearch;

        private ServiceCarRentalListDurian durianServiceCarRentalList;

        protected override void Dispose(bool disposing) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonServiceCarRentalListSearch = new System.Windows.Forms.Button();
            this.durianServiceCarRentalList = new SolutionNorSolutionPort.UserInterface.ServiceCarRentalListDurian();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonCancel.Location = new System.Drawing.Point(422, 277);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(92, 22);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonServiceCarRentalListSearch
            // 
            this.buttonServiceCarRentalListSearch.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonServiceCarRentalListSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonServiceCarRentalListSearch.Name = "buttonServiceCarRentalListSearch";
            this.buttonServiceCarRentalListSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonServiceCarRentalListSearch.TabIndex = 2;
            this.buttonServiceCarRentalListSearch.Text = "&Search";
            this.buttonServiceCarRentalListSearch.UseVisualStyleBackColor = true;
            this.buttonServiceCarRentalListSearch.Click += new System.EventHandler(this.buttonServiceCarRentalListSearch_Click);
            // 
            // durianServiceCarRentalList
            // 
            this.durianServiceCarRentalList.Location = new System.Drawing.Point(12, 12);
            this.durianServiceCarRentalList.Name = "durianServiceCarRentalList";
            this.durianServiceCarRentalList.Size = new System.Drawing.Size(502, 259);
            this.durianServiceCarRentalList.TabIndex = 1;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonSelect.Location = new System.Drawing.Point(226, 277);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(92, 22);
            this.buttonSelect.TabIndex = 5;
            this.buttonSelect.Text = "&Ok";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // ServiceCarRentalListLiveSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonServiceCarRentalListSearch);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.durianServiceCarRentalList);
            this.Name = "ServiceCarRentalListLiveSearch";
            this.Text = "Service Car Rental List";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button buttonSelect;
    }
}
