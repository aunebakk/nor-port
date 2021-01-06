namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeClientContactMethodSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeClientContactMethodSearch;
        
        private System.Windows.Forms.Button buttonCrudeClientContactMethodAdd;
        
        private System.Windows.Forms.Button buttonCrudeClientContactMethodEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeClientContactMethod;
        
        private ContactMethodRefCombo contactMethodRefCombo;
        
        private System.Windows.Forms.Label labelContactMethodRefCombo;
        
        private System.Windows.Forms.TextBox textBoxContactMethodWay;
        
        private System.Windows.Forms.Label labelContactMethodWay;
        
        private System.Windows.Forms.TextBox textBoxComment;
        
        private System.Windows.Forms.Label labelComment;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private ClientPicker clientPicker;
        
        private System.Windows.Forms.Label labelClientPicker;
        
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
            this.buttonCrudeClientContactMethodAdd = new System.Windows.Forms.Button();
            this.buttonCrudeClientContactMethodEdit = new System.Windows.Forms.Button();
            this.buttonCrudeClientContactMethodSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeClientContactMethod = new System.Windows.Forms.DataGridView();
            this.labelContactMethodRefCombo = new System.Windows.Forms.Label();
            this.contactMethodRefCombo = new ContactMethodRefCombo();
            this.labelContactMethodWay = new System.Windows.Forms.Label();
            this.textBoxContactMethodWay = new System.Windows.Forms.TextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelClientPicker = new System.Windows.Forms.Label();
            this.clientPicker = new ClientPicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClientContactMethod)).BeginInit();
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
            // labelClientPicker
            //
            this.labelClientPicker.AutoSize = true;
            this.labelClientPicker.Location = new System.Drawing.Point(11, 105);
            this.labelClientPicker.Name = "labelClientPicker";
            this.labelClientPicker.Size = new System.Drawing.Size(71, 13);
            this.labelClientPicker.TabIndex = 10;
            this.labelClientPicker.Text = "Client:";
            //
            //clientPicker
            //
            this.clientPicker.Location = new System.Drawing.Point(140, 105);
            this.clientPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.clientPicker.Name = "clientPicker";
            this.clientPicker.Size = new System.Drawing.Size(250, 20);
            this.clientPicker.TabIndex = 11;
            //
            // labelUserPicker
            //
            this.labelUserPicker.AutoSize = true;
            this.labelUserPicker.Location = new System.Drawing.Point(11, 128);
            this.labelUserPicker.Name = "labelUserPicker";
            this.labelUserPicker.Size = new System.Drawing.Size(71, 13);
            this.labelUserPicker.TabIndex = 12;
            this.labelUserPicker.Text = "User:";
            //
            //userPicker
            //
            this.userPicker.Location = new System.Drawing.Point(140, 128);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 13;
            // 
            // dataGridViewCrudeClientContactMethod
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeClientContactMethod.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeClientContactMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeClientContactMethod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeClientContactMethod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeClientContactMethod.Location = new System.Drawing.Point(12, 161);
            this.dataGridViewCrudeClientContactMethod.Name = "dataGridViewCrudeClientContactMethod";
            this.dataGridViewCrudeClientContactMethod.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeClientContactMethod.TabIndex = 0;
            this.dataGridViewCrudeClientContactMethod.ReadOnly = true;
            this.dataGridViewCrudeClientContactMethod.DoubleClick += new System.EventHandler(this.dataGridViewCrudeClientContactMethod_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 264);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeClientContactMethodSearch
            // 
            this.buttonCrudeClientContactMethodSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientContactMethodSearch.Location = new System.Drawing.Point(198, 264);
            this.buttonCrudeClientContactMethodSearch.Name = "buttonCrudeClientContactMethodSearch";
            this.buttonCrudeClientContactMethodSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientContactMethodSearch.TabIndex = 2;
            this.buttonCrudeClientContactMethodSearch.Text = "&Search";
            this.buttonCrudeClientContactMethodSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeClientContactMethodSearch.Click += new System.EventHandler(this.buttonCrudeClientContactMethodSearch_Click);
            // 
            // buttonCrudeClientContactMethodAdd
            // 
            this.buttonCrudeClientContactMethodAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientContactMethodAdd.Location = new System.Drawing.Point(98, 264);
            this.buttonCrudeClientContactMethodAdd.Name = "buttonCrudeClientContactMethodAdd";
            this.buttonCrudeClientContactMethodAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientContactMethodAdd.TabIndex = 3;
            this.buttonCrudeClientContactMethodAdd.Text = "&Add";
            this.buttonCrudeClientContactMethodAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeClientContactMethodAdd.Click += new System.EventHandler(this.buttonCrudeClientContactMethodAdd_Click);
            // 
            // buttonCrudeClientContactMethodEdit
            // 
            this.buttonCrudeClientContactMethodEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeClientContactMethodEdit.Location = new System.Drawing.Point(-2, 264);
            this.buttonCrudeClientContactMethodEdit.Name = "buttonCrudeClientContactMethodEdit";
            this.buttonCrudeClientContactMethodEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientContactMethodEdit.TabIndex = 4;
            this.buttonCrudeClientContactMethodEdit.Text = "&Edit";
            this.buttonCrudeClientContactMethodEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeClientContactMethodEdit.Click += new System.EventHandler(this.buttonCrudeClientContactMethodEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 292);
            this.Controls.Add(this.buttonCrudeClientContactMethodSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeClientContactMethodAdd);
            this.Controls.Add(this.buttonCrudeClientContactMethodEdit);
            this.Controls.Add(this.dataGridViewCrudeClientContactMethod);
            this.Name = "CrudeClientContactMethodSearch";
            this.Text = "Client Contact Method Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeClientContactMethod)).EndInit();
            this.Controls.Add(this.labelContactMethodRefCombo);
            this.Controls.Add(this.contactMethodRefCombo);
            this.Controls.Add(this.labelContactMethodWay);
            this.Controls.Add(this.textBoxContactMethodWay);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelClientPicker);
            this.Controls.Add(this.clientPicker);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
