namespace SolutionNorSolutionPort.UserInterface
{


    public partial class ServiceHotelListLiveSearch
    {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonCancel;

        private System.Windows.Forms.Button buttonServiceHotelListSearch;

        private ServiceHotelListDurian durianServiceHotelList;

        protected override void Dispose(bool disposing) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonServiceHotelListSearch = new System.Windows.Forms.Button();
            this.durianServiceHotelList = new SolutionNorSolutionPort.UserInterface.ServiceHotelListDurian();
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
            // buttonServiceHotelListSearch
            // 
            this.buttonServiceHotelListSearch.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonServiceHotelListSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonServiceHotelListSearch.Name = "buttonServiceHotelListSearch";
            this.buttonServiceHotelListSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonServiceHotelListSearch.TabIndex = 2;
            this.buttonServiceHotelListSearch.Text = "&Search";
            this.buttonServiceHotelListSearch.UseVisualStyleBackColor = true;
            this.buttonServiceHotelListSearch.Click += new System.EventHandler(this.buttonServiceHotelListSearch_Click);
            // 
            // durianServiceHotelList
            // 
            this.durianServiceHotelList.Location = new System.Drawing.Point(12, 12);
            this.durianServiceHotelList.Name = "durianServiceHotelList";
            this.durianServiceHotelList.Size = new System.Drawing.Size(502, 259);
            this.durianServiceHotelList.TabIndex = 1;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonSelect.Location = new System.Drawing.Point(226, 277);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(92, 22);
            this.buttonSelect.TabIndex = 4;
            this.buttonSelect.Text = "&Ok";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // ServiceHotelListLiveSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonServiceHotelListSearch);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.durianServiceHotelList);
            this.Name = "ServiceHotelListLiveSearch";
            this.Text = "Service Hotel List";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button buttonSelect;
    }
}
