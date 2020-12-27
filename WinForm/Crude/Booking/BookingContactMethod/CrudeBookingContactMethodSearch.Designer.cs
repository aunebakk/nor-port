namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeBookingContactMethodSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeBookingContactMethodSearch;
        
        private System.Windows.Forms.Button buttonCrudeBookingContactMethodAdd;
        
        private System.Windows.Forms.Button buttonCrudeBookingContactMethodEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeBookingContactMethod;
        
        private ContactMethodRefCombo contactMethodRefCombo;
        
        private System.Windows.Forms.Label labelContactMethodRefCombo;
        
        private System.Windows.Forms.TextBox textBoxContactMethodWay;
        
        private System.Windows.Forms.Label labelContactMethodWay;
        
        private System.Windows.Forms.TextBox textBoxComment;
        
        private System.Windows.Forms.Label labelComment;
        
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
            this.buttonCrudeBookingContactMethodAdd = new System.Windows.Forms.Button();
            this.buttonCrudeBookingContactMethodEdit = new System.Windows.Forms.Button();
            this.buttonCrudeBookingContactMethodSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeBookingContactMethod = new System.Windows.Forms.DataGridView();
            this.labelContactMethodRefCombo = new System.Windows.Forms.Label();
            this.contactMethodRefCombo = new ContactMethodRefCombo();
            this.labelContactMethodWay = new System.Windows.Forms.Label();
            this.textBoxContactMethodWay = new System.Windows.Forms.TextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeBookingContactMethod)).BeginInit();
            this.SuspendLayout();
            //
            // labelContactMethodRefCombo
            //
            this.labelContactMethodRefCombo.AutoSize = true;
            this.labelContactMethodRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelContactMethodRefCombo.Name = "labelContactMethodRefCombo";
            this.labelContactMethodRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelContactMethodRefCombo.TabIndex = 2;
            this.labelContactMethodRefCombo.Text = "Contact Method:";
            //
            //contactMethodRefCombo
            //
            this.contactMethodRefCombo.Location = new System.Drawing.Point(140, 13);
            this.contactMethodRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.contactMethodRefCombo.Name = "contactMethodRefCombo";
            this.contactMethodRefCombo.Size = new System.Drawing.Size(250, 20);
            this.contactMethodRefCombo.TabIndex = 3;
            //
            // labelContactMethodWay
            //
            this.labelContactMethodWay.AutoSize = true;
            this.labelContactMethodWay.Location = new System.Drawing.Point(11, 36);
            this.labelContactMethodWay.Name = "labelContactMethodWay";
            this.labelContactMethodWay.Size = new System.Drawing.Size(71, 13);
            this.labelContactMethodWay.TabIndex = 4;
            this.labelContactMethodWay.Text = "Contact Method Way:";
            //
            //textBoxContactMethodWay
            //
            this.textBoxContactMethodWay.Location = new System.Drawing.Point(140, 36);
            this.textBoxContactMethodWay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxContactMethodWay.Name = "textBoxContactMethodWay";
            this.textBoxContactMethodWay.Size = new System.Drawing.Size(250, 20);
            this.textBoxContactMethodWay.TabIndex = 5;
            //
            // labelComment
            //
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(11, 59);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(71, 13);
            this.labelComment.TabIndex = 6;
            this.labelComment.Text = "Comment:";
            //
            //textBoxComment
            //
            this.textBoxComment.Location = new System.Drawing.Point(140, 59);
            this.textBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(250, 20);
            this.textBoxComment.TabIndex = 7;
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
            // dataGridViewCrudeBookingContactMethod
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeBookingContactMethod.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeBookingContactMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeBookingContactMethod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeBookingContactMethod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeBookingContactMethod.Location = new System.Drawing.Point(12, 138);
            this.dataGridViewCrudeBookingContactMethod.Name = "dataGridViewCrudeBookingContactMethod";
            this.dataGridViewCrudeBookingContactMethod.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeBookingContactMethod.TabIndex = 0;
            this.dataGridViewCrudeBookingContactMethod.ReadOnly = true;
            this.dataGridViewCrudeBookingContactMethod.DoubleClick += new System.EventHandler(this.dataGridViewCrudeBookingContactMethod_DoubleClick);
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
            // buttonCrudeBookingContactMethodSearch
            // 
            this.buttonCrudeBookingContactMethodSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingContactMethodSearch.Location = new System.Drawing.Point(198, 241);
            this.buttonCrudeBookingContactMethodSearch.Name = "buttonCrudeBookingContactMethodSearch";
            this.buttonCrudeBookingContactMethodSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingContactMethodSearch.TabIndex = 2;
            this.buttonCrudeBookingContactMethodSearch.Text = "&Search";
            this.buttonCrudeBookingContactMethodSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingContactMethodSearch.Click += new System.EventHandler(this.buttonCrudeBookingContactMethodSearch_Click);
            // 
            // buttonCrudeBookingContactMethodAdd
            // 
            this.buttonCrudeBookingContactMethodAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingContactMethodAdd.Location = new System.Drawing.Point(98, 241);
            this.buttonCrudeBookingContactMethodAdd.Name = "buttonCrudeBookingContactMethodAdd";
            this.buttonCrudeBookingContactMethodAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingContactMethodAdd.TabIndex = 3;
            this.buttonCrudeBookingContactMethodAdd.Text = "&Add";
            this.buttonCrudeBookingContactMethodAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingContactMethodAdd.Click += new System.EventHandler(this.buttonCrudeBookingContactMethodAdd_Click);
            // 
            // buttonCrudeBookingContactMethodEdit
            // 
            this.buttonCrudeBookingContactMethodEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeBookingContactMethodEdit.Location = new System.Drawing.Point(-2, 241);
            this.buttonCrudeBookingContactMethodEdit.Name = "buttonCrudeBookingContactMethodEdit";
            this.buttonCrudeBookingContactMethodEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeBookingContactMethodEdit.TabIndex = 4;
            this.buttonCrudeBookingContactMethodEdit.Text = "&Edit";
            this.buttonCrudeBookingContactMethodEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeBookingContactMethodEdit.Click += new System.EventHandler(this.buttonCrudeBookingContactMethodEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 269);
            this.Controls.Add(this.buttonCrudeBookingContactMethodSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeBookingContactMethodAdd);
            this.Controls.Add(this.buttonCrudeBookingContactMethodEdit);
            this.Controls.Add(this.dataGridViewCrudeBookingContactMethod);
            this.Name = "CrudeBookingContactMethodSearch";
            this.Text = "Booking Contact Method Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeBookingContactMethod)).EndInit();
            this.Controls.Add(this.labelContactMethodRefCombo);
            this.Controls.Add(this.contactMethodRefCombo);
            this.Controls.Add(this.labelContactMethodWay);
            this.Controls.Add(this.textBoxContactMethodWay);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
