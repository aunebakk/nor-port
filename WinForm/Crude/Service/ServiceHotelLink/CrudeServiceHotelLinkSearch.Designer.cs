namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeServiceHotelLinkSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeServiceHotelLinkSearch;
        
        private System.Windows.Forms.Button buttonCrudeServiceHotelLinkAdd;
        
        private System.Windows.Forms.Button buttonCrudeServiceHotelLinkEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeServiceHotelLink;
        
        private LinkTypeRefCombo linkTypeRefCombo;
        
        private System.Windows.Forms.Label labelLinkTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxLink;
        
        private System.Windows.Forms.Label labelLink;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
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
            this.buttonCrudeServiceHotelLinkAdd = new System.Windows.Forms.Button();
            this.buttonCrudeServiceHotelLinkEdit = new System.Windows.Forms.Button();
            this.buttonCrudeServiceHotelLinkSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeServiceHotelLink = new System.Windows.Forms.DataGridView();
            this.labelLinkTypeRefCombo = new System.Windows.Forms.Label();
            this.linkTypeRefCombo = new LinkTypeRefCombo();
            this.labelLink = new System.Windows.Forms.Label();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeServiceHotelLink)).BeginInit();
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
            // labelLink
            //
            this.labelLink.AutoSize = true;
            this.labelLink.Location = new System.Drawing.Point(11, 36);
            this.labelLink.Name = "labelLink";
            this.labelLink.Size = new System.Drawing.Size(71, 13);
            this.labelLink.TabIndex = 4;
            this.labelLink.Text = "Link:";
            //
            //textBoxLink
            //
            this.textBoxLink.Location = new System.Drawing.Point(140, 36);
            this.textBoxLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(250, 20);
            this.textBoxLink.TabIndex = 5;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 59);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 6;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 59);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 7;
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
            // dataGridViewCrudeServiceHotelLink
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeServiceHotelLink.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeServiceHotelLink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeServiceHotelLink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeServiceHotelLink.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeServiceHotelLink.Location = new System.Drawing.Point(12, 115);
            this.dataGridViewCrudeServiceHotelLink.Name = "dataGridViewCrudeServiceHotelLink";
            this.dataGridViewCrudeServiceHotelLink.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeServiceHotelLink.TabIndex = 0;
            this.dataGridViewCrudeServiceHotelLink.ReadOnly = true;
            this.dataGridViewCrudeServiceHotelLink.DoubleClick += new System.EventHandler(this.dataGridViewCrudeServiceHotelLink_DoubleClick);
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
            // buttonCrudeServiceHotelLinkSearch
            // 
            this.buttonCrudeServiceHotelLinkSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceHotelLinkSearch.Location = new System.Drawing.Point(198, 218);
            this.buttonCrudeServiceHotelLinkSearch.Name = "buttonCrudeServiceHotelLinkSearch";
            this.buttonCrudeServiceHotelLinkSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceHotelLinkSearch.TabIndex = 2;
            this.buttonCrudeServiceHotelLinkSearch.Text = "&Search";
            this.buttonCrudeServiceHotelLinkSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceHotelLinkSearch.Click += new System.EventHandler(this.buttonCrudeServiceHotelLinkSearch_Click);
            // 
            // buttonCrudeServiceHotelLinkAdd
            // 
            this.buttonCrudeServiceHotelLinkAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceHotelLinkAdd.Location = new System.Drawing.Point(98, 218);
            this.buttonCrudeServiceHotelLinkAdd.Name = "buttonCrudeServiceHotelLinkAdd";
            this.buttonCrudeServiceHotelLinkAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceHotelLinkAdd.TabIndex = 3;
            this.buttonCrudeServiceHotelLinkAdd.Text = "&Add";
            this.buttonCrudeServiceHotelLinkAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceHotelLinkAdd.Click += new System.EventHandler(this.buttonCrudeServiceHotelLinkAdd_Click);
            // 
            // buttonCrudeServiceHotelLinkEdit
            // 
            this.buttonCrudeServiceHotelLinkEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceHotelLinkEdit.Location = new System.Drawing.Point(-2, 218);
            this.buttonCrudeServiceHotelLinkEdit.Name = "buttonCrudeServiceHotelLinkEdit";
            this.buttonCrudeServiceHotelLinkEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceHotelLinkEdit.TabIndex = 4;
            this.buttonCrudeServiceHotelLinkEdit.Text = "&Edit";
            this.buttonCrudeServiceHotelLinkEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceHotelLinkEdit.Click += new System.EventHandler(this.buttonCrudeServiceHotelLinkEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 246);
            this.Controls.Add(this.buttonCrudeServiceHotelLinkSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeServiceHotelLinkAdd);
            this.Controls.Add(this.buttonCrudeServiceHotelLinkEdit);
            this.Controls.Add(this.dataGridViewCrudeServiceHotelLink);
            this.Name = "CrudeServiceHotelLinkSearch";
            this.Text = "Service Hotel Link Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeServiceHotelLink)).EndInit();
            this.Controls.Add(this.labelLinkTypeRefCombo);
            this.Controls.Add(this.linkTypeRefCombo);
            this.Controls.Add(this.labelLink);
            this.Controls.Add(this.textBoxLink);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
