namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeServiceHotelImageSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeServiceHotelImageSearch;
        
        private System.Windows.Forms.Button buttonCrudeServiceHotelImageAdd;
        
        private System.Windows.Forms.Button buttonCrudeServiceHotelImageEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeServiceHotelImage;
        
        private System.Windows.Forms.TextBox textBoxImageFileName;
        
        private System.Windows.Forms.Label labelImageFileName;
        
        private ServiceImageTypeRefCombo serviceImageTypeRefCombo;
        
        private System.Windows.Forms.Label labelServiceImageTypeRefCombo;
        
        private System.Windows.Forms.PictureBox pictureBoxImage;
        
        private System.Windows.Forms.Label labelImage;
        
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
            this.buttonCrudeServiceHotelImageAdd = new System.Windows.Forms.Button();
            this.buttonCrudeServiceHotelImageEdit = new System.Windows.Forms.Button();
            this.buttonCrudeServiceHotelImageSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeServiceHotelImage = new System.Windows.Forms.DataGridView();
            this.labelImageFileName = new System.Windows.Forms.Label();
            this.textBoxImageFileName = new System.Windows.Forms.TextBox();
            this.labelServiceImageTypeRefCombo = new System.Windows.Forms.Label();
            this.serviceImageTypeRefCombo = new ServiceImageTypeRefCombo();
            this.labelImage = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeServiceHotelImage)).BeginInit();
            this.SuspendLayout();
            //
            // labelImageFileName
            //
            this.labelImageFileName.AutoSize = true;
            this.labelImageFileName.Location = new System.Drawing.Point(11, 13);
            this.labelImageFileName.Name = "labelImageFileName";
            this.labelImageFileName.Size = new System.Drawing.Size(71, 13);
            this.labelImageFileName.TabIndex = 2;
            this.labelImageFileName.Text = "Image File Name:";
            //
            //textBoxImageFileName
            //
            this.textBoxImageFileName.Location = new System.Drawing.Point(140, 13);
            this.textBoxImageFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxImageFileName.Name = "textBoxImageFileName";
            this.textBoxImageFileName.Size = new System.Drawing.Size(250, 20);
            this.textBoxImageFileName.TabIndex = 3;
            //
            // labelServiceImageTypeRefCombo
            //
            this.labelServiceImageTypeRefCombo.AutoSize = true;
            this.labelServiceImageTypeRefCombo.Location = new System.Drawing.Point(11, 36);
            this.labelServiceImageTypeRefCombo.Name = "labelServiceImageTypeRefCombo";
            this.labelServiceImageTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelServiceImageTypeRefCombo.TabIndex = 4;
            this.labelServiceImageTypeRefCombo.Text = "Service Image Type:";
            //
            //serviceImageTypeRefCombo
            //
            this.serviceImageTypeRefCombo.Location = new System.Drawing.Point(140, 36);
            this.serviceImageTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceImageTypeRefCombo.Name = "serviceImageTypeRefCombo";
            this.serviceImageTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.serviceImageTypeRefCombo.TabIndex = 5;
            //
            // labelImage
            //
            this.labelImage.AutoSize = true;
            this.labelImage.Location = new System.Drawing.Point(11, 59);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(71, 13);
            this.labelImage.TabIndex = 6;
            this.labelImage.Text = "Image:";
            //
            //pictureBoxImage
            //
            this.pictureBoxImage.Location = new System.Drawing.Point(140, 59);
            this.pictureBoxImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(250, 20);
            this.pictureBoxImage.TabIndex = 7;
            //
            // labelDateTime
            //
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(11, 82);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(71, 13);
            this.labelDateTime.TabIndex = 8;
            this.labelDateTime.Text = "Date Time:";
            //
            //dateTimePickerDateTime
            //
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(140, 82);
            this.dateTimePickerDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateTime.Name = "dateTimePickerDateTime";
            this.dateTimePickerDateTime.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerDateTime.TabIndex = 9;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 105);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 10;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(140, 105);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 11;
            // 
            // dataGridViewCrudeServiceHotelImage
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeServiceHotelImage.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeServiceHotelImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeServiceHotelImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeServiceHotelImage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeServiceHotelImage.Location = new System.Drawing.Point(12, 138);
            this.dataGridViewCrudeServiceHotelImage.Name = "dataGridViewCrudeServiceHotelImage";
            this.dataGridViewCrudeServiceHotelImage.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeServiceHotelImage.TabIndex = 0;
            this.dataGridViewCrudeServiceHotelImage.ReadOnly = true;
            this.dataGridViewCrudeServiceHotelImage.DoubleClick += new System.EventHandler(this.dataGridViewCrudeServiceHotelImage_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 241);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeServiceHotelImageSearch
            // 
            this.buttonCrudeServiceHotelImageSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceHotelImageSearch.Location = new System.Drawing.Point(198, 241);
            this.buttonCrudeServiceHotelImageSearch.Name = "buttonCrudeServiceHotelImageSearch";
            this.buttonCrudeServiceHotelImageSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceHotelImageSearch.TabIndex = 2;
            this.buttonCrudeServiceHotelImageSearch.Text = "&Search";
            this.buttonCrudeServiceHotelImageSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceHotelImageSearch.Click += new System.EventHandler(this.buttonCrudeServiceHotelImageSearch_Click);
            // 
            // buttonCrudeServiceHotelImageAdd
            // 
            this.buttonCrudeServiceHotelImageAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceHotelImageAdd.Location = new System.Drawing.Point(98, 241);
            this.buttonCrudeServiceHotelImageAdd.Name = "buttonCrudeServiceHotelImageAdd";
            this.buttonCrudeServiceHotelImageAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceHotelImageAdd.TabIndex = 3;
            this.buttonCrudeServiceHotelImageAdd.Text = "&Add";
            this.buttonCrudeServiceHotelImageAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceHotelImageAdd.Click += new System.EventHandler(this.buttonCrudeServiceHotelImageAdd_Click);
            // 
            // buttonCrudeServiceHotelImageEdit
            // 
            this.buttonCrudeServiceHotelImageEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeServiceHotelImageEdit.Location = new System.Drawing.Point(-2, 241);
            this.buttonCrudeServiceHotelImageEdit.Name = "buttonCrudeServiceHotelImageEdit";
            this.buttonCrudeServiceHotelImageEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeServiceHotelImageEdit.TabIndex = 4;
            this.buttonCrudeServiceHotelImageEdit.Text = "&Edit";
            this.buttonCrudeServiceHotelImageEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeServiceHotelImageEdit.Click += new System.EventHandler(this.buttonCrudeServiceHotelImageEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 269);
            this.Controls.Add(this.buttonCrudeServiceHotelImageSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeServiceHotelImageAdd);
            this.Controls.Add(this.buttonCrudeServiceHotelImageEdit);
            this.Controls.Add(this.dataGridViewCrudeServiceHotelImage);
            this.Name = "CrudeServiceHotelImageSearch";
            this.Text = "Service Hotel Image Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeServiceHotelImage)).EndInit();
            this.Controls.Add(this.labelImageFileName);
            this.Controls.Add(this.textBoxImageFileName);
            this.Controls.Add(this.labelServiceImageTypeRefCombo);
            this.Controls.Add(this.serviceImageTypeRefCombo);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
