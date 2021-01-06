namespace SolutionNorSolutionPort.UserInterface
{


    public partial class ServicePackagePromotion
    {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonServicePackagePromotionWithFilterSearch;

        private ServicePackagePromotionWithFilterDurian durianServicePackagePromotionWithFilter;

        protected override void Dispose(bool disposing) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonServicePackagePromotionWithFilterSearch = new System.Windows.Forms.Button();
            this.durianServicePackagePromotionWithFilter = new SolutionNorSolutionPort.UserInterface.ServicePackagePromotionWithFilterDurian();
            this.buttonCrudeServicePackagePromotionAdd = new System.Windows.Forms.Button();
            this.buttonCrudeServicePackagePromotionEdit = new System.Windows.Forms.Button();
            this.buttonPromotionSend = new System.Windows.Forms.Button();
            this.buttonMakeBooking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonClose.Location = new System.Drawing.Point(651, 277);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonServicePackagePromotionWithFilterSearch
            // 
            this.buttonServicePackagePromotionWithFilterSearch.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonServicePackagePromotionWithFilterSearch.Location = new System.Drawing.Point(553, 277);
            this.buttonServicePackagePromotionWithFilterSearch.Name = "buttonServicePackagePromotionWithFilterSearch";
            this.buttonServicePackagePromotionWithFilterSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonServicePackagePromotionWithFilterSearch.TabIndex = 2;
            this.buttonServicePackagePromotionWithFilterSearch.Text = "&Search";
            this.buttonServicePackagePromotionWithFilterSearch.UseVisualStyleBackColor = true;
            this.buttonServicePackagePromotionWithFilterSearch.Click += new System.EventHandler(this.buttonServicePackagePromotionWithFilterSearch_Click);
            // 
            // durianServicePackagePromotionWithFilter
            // 
            this.durianServicePackagePromotionWithFilter.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
            | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.durianServicePackagePromotionWithFilter.Location = new System.Drawing.Point(12, 12);
            this.durianServicePackagePromotionWithFilter.Name = "durianServicePackagePromotionWithFilter";
            this.durianServicePackagePromotionWithFilter.Size = new System.Drawing.Size(731, 259);
            this.durianServicePackagePromotionWithFilter.TabIndex = 1;
            // 
            // buttonCrudeServicePackagePromotionAdd
            // 
            this.buttonCrudeServicePackagePromotionAdd.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonCrudeServicePackagePromotionAdd.Location = new System.Drawing.Point(455, 277);
            this.buttonCrudeServicePackagePromotionAdd.Name = "buttonCrudeServicePackagePromotionAdd";
            this.buttonCrudeServicePackagePromotionAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServicePackagePromotionAdd.TabIndex = 5;
            this.buttonCrudeServicePackagePromotionAdd.Text = "&Add";
            this.buttonCrudeServicePackagePromotionAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeServicePackagePromotionAdd.Click += new System.EventHandler(this.buttonCrudeServicePackagePromotionAdd_Click);
            // 
            // buttonCrudeServicePackagePromotionEdit
            // 
            this.buttonCrudeServicePackagePromotionEdit.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonCrudeServicePackagePromotionEdit.Location = new System.Drawing.Point(355, 277);
            this.buttonCrudeServicePackagePromotionEdit.Name = "buttonCrudeServicePackagePromotionEdit";
            this.buttonCrudeServicePackagePromotionEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServicePackagePromotionEdit.TabIndex = 6;
            this.buttonCrudeServicePackagePromotionEdit.Text = "&Edit";
            this.buttonCrudeServicePackagePromotionEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeServicePackagePromotionEdit.Click += new System.EventHandler(this.buttonCrudeServicePackagePromotionEdit_Click);
            // 
            // buttonPromotionSend
            // 
            this.buttonPromotionSend.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonPromotionSend.Location = new System.Drawing.Point(257, 277);
            this.buttonPromotionSend.Name = "buttonPromotionSend";
            this.buttonPromotionSend.Size = new System.Drawing.Size(92, 22);
            this.buttonPromotionSend.TabIndex = 7;
            this.buttonPromotionSend.Text = "&Send Promotion";
            this.buttonPromotionSend.UseVisualStyleBackColor = true;
            this.buttonPromotionSend.Click += new System.EventHandler(this.buttonPromotionSend_Click);
            // 
            // buttonMakeBooking
            // 
            this.buttonMakeBooking.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonMakeBooking.Location = new System.Drawing.Point(159, 277);
            this.buttonMakeBooking.Name = "buttonMakeBooking";
            this.buttonMakeBooking.Size = new System.Drawing.Size(92, 22);
            this.buttonMakeBooking.TabIndex = 8;
            this.buttonMakeBooking.Text = "&Make Booking";
            this.buttonMakeBooking.UseVisualStyleBackColor = true;
            this.buttonMakeBooking.Click += new System.EventHandler(this.buttonMakeBooking_Click);
            // 
            // ServicePackagePromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 302);
            this.Controls.Add(this.buttonMakeBooking);
            this.Controls.Add(this.buttonPromotionSend);
            this.Controls.Add(this.buttonCrudeServicePackagePromotionAdd);
            this.Controls.Add(this.buttonCrudeServicePackagePromotionEdit);
            this.Controls.Add(this.buttonServicePackagePromotionWithFilterSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianServicePackagePromotionWithFilter);
            this.Name = "ServicePackagePromotion";
            this.Text = "Package Promotion";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button buttonCrudeServicePackagePromotionAdd;
        private System.Windows.Forms.Button buttonCrudeServicePackagePromotionEdit;
        private System.Windows.Forms.Button buttonPromotionSend;
        private System.Windows.Forms.Button buttonMakeBooking;
    }
}
