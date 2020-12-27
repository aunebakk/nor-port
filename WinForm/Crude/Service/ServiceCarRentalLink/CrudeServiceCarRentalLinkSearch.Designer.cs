namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeServiceCarRentalLinkSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeServiceCarRentalLinkSearch;
        
        private System.Windows.Forms.Button buttonCrudeServiceCarRentalLinkAdd;
        
        private System.Windows.Forms.Button buttonCrudeServiceCarRentalLinkEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeServiceCarRentalLink;
        
        private LinkTypeRefCombo linkTypeRefCombo;
        
        private System.Windows.Forms.Label labelLinkTypeRefCombo;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private ServiceCarRentalPicker serviceCarRentalPicker;
        
        private System.Windows.Forms.Label labelServiceCarRentalPicker;
        
        private DefaultUserPicker userPicker;
        
        private System.Windows.Forms.Label labelUserPicker;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCrudeServiceCarRentalLinkAdd = new System.Windows.Forms.Button();
            this.buttonCrudeServiceCarRentalLinkEdit = new System.Windows.Forms.Button();
            this.buttonCrudeServiceCarRentalLinkSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeServiceCarRentalLink = new System.Windows.Forms.DataGridView();
            this.labelLinkTypeRefCombo = new System.Windows.Forms.Label();
            this.linkTypeRefCombo = new LinkTypeRefCombo();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelServiceCarRentalPicker = new System.Windows.Forms.Label();
            this.serviceCarRentalPicker = new ServiceCarRentalPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeServiceCarRentalLink)).BeginInit();
            this.SuspendLayout();
            //
            // labelLinkTypeRefCombo
            //
            this.labelLinkTypeRefCombo.AutoSize = true;
            this.labelLinkTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelLinkTypeRefCombo.Name = "labelLinkTypeRefCombo";
            this.labelLinkTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelLinkTypeRefCombo.TabIndex = 2;
            this.labelLinkTypeRefCombo.Text = "Link Type:";
            //
            //linkTypeRefCombo
            //
            this.linkTypeRefCombo.Location = new System.Drawing.Point(140, 13);
            this.linkTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.linkTypeRefCombo.Name = "linkTypeRefCombo";
            this.linkTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.linkTypeRefCombo.TabIndex = 3;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 36);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 4;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 36);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 5;
            //
            // labelServiceCarRentalPicker
            //
            this.labelServiceCarRentalPicker.AutoSize = true;
            this.labelServiceCarRentalPicker.Location = new System.Drawing.Point(11, 59);
            this.labelServiceCarRentalPicker.Name = "labelServiceCarRentalPicker";
            this.labelServiceCarRentalPicker.Size = new System.Drawing.Size(71, 13);
            this.labelServiceCarRentalPicker.TabIndex = 6;
            this.labelServiceCarRentalPicker.Text = "Service Car Rental:";
            //
            //serviceCarRentalPicker
            //
            this.serviceCarRentalPicker.Location = new System.Drawing.Point(140, 59);
            this.serviceCarRentalPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceCarRentalPicker.Name = "serviceCarRentalPicker";
            this.serviceCarRentalPicker.Size = new System.Drawing.Size(250, 20);
            this.serviceCarRentalPicker.TabIndex = 7;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 82);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 8;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(140, 82);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 9;
            // 
            // dataGridViewCrudeServiceCarRentalLink
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeServiceCarRentalLink.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeServiceCarRentalLink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeServiceCarRentalLink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeServiceCarRentalLink.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeServiceCarRentalLink.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeServiceCarRentalLink.Name = "dataGridViewCrudeServiceCarRentalLink";
            this.dataGridViewCrudeServiceCarRentalLink.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeServiceCarRentalLink.TabIndex = 0;
            this.dataGridViewCrudeServiceCarRentalLink.ReadOnly = true;
            this.dataGridViewCrudeServiceCarRentalLink.DoubleClick += new System.EventHandler(this.dataGridViewCrudeServiceCarRentalLink_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 218);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeServiceCarRentalLinkSearch
            // 
            this.buttonCrudeServiceCarRentalLinkSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceCarRentalLinkSearch.Location = new System.Drawing.Point(198, 218);
            this.buttonCrudeServiceCarRentalLinkSearch.Name = "buttonCrudeServiceCarRentalLinkSearch";
            this.buttonCrudeServiceCarRentalLinkSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceCarRentalLinkSearch.TabIndex = 2;
            this.buttonCrudeServiceCarRentalLinkSearch.Text = "&Search";
            this.buttonCrudeServiceCarRentalLinkSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceCarRentalLinkSearch.Click += new System.EventHandler(this.buttonCrudeServiceCarRentalLinkSearch_Click);
            // 
            // buttonCrudeServiceCarRentalLinkAdd
            // 
            this.buttonCrudeServiceCarRentalLinkAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceCarRentalLinkAdd.Location = new System.Drawing.Point(98, 218);
            this.buttonCrudeServiceCarRentalLinkAdd.Name = "buttonCrudeServiceCarRentalLinkAdd";
            this.buttonCrudeServiceCarRentalLinkAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceCarRentalLinkAdd.TabIndex = 3;
            this.buttonCrudeServiceCarRentalLinkAdd.Text = "&Add";
            this.buttonCrudeServiceCarRentalLinkAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceCarRentalLinkAdd.Click += new System.EventHandler(this.buttonCrudeServiceCarRentalLinkAdd_Click);
            // 
            // buttonCrudeServiceCarRentalLinkEdit
            // 
            this.buttonCrudeServiceCarRentalLinkEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceCarRentalLinkEdit.Location = new System.Drawing.Point(-2, 218);
            this.buttonCrudeServiceCarRentalLinkEdit.Name = "buttonCrudeServiceCarRentalLinkEdit";
            this.buttonCrudeServiceCarRentalLinkEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceCarRentalLinkEdit.TabIndex = 4;
            this.buttonCrudeServiceCarRentalLinkEdit.Text = "&Edit";
            this.buttonCrudeServiceCarRentalLinkEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceCarRentalLinkEdit.Click += new System.EventHandler(this.buttonCrudeServiceCarRentalLinkEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 246);
            this.Controls.Add(this.buttonCrudeServiceCarRentalLinkSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeServiceCarRentalLinkAdd);
            this.Controls.Add(this.buttonCrudeServiceCarRentalLinkEdit);
            this.Controls.Add(this.dataGridViewCrudeServiceCarRentalLink);
            this.Name = "CrudeServiceCarRentalLinkSearch";
            this.Text = "Service Car Rental Link Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeServiceCarRentalLink)).EndInit();
            this.Controls.Add(this.labelLinkTypeRefCombo);
            this.Controls.Add(this.linkTypeRefCombo);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelServiceCarRentalPicker);
            this.Controls.Add(this.serviceCarRentalPicker);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
