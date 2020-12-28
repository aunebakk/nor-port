namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeAirlineContactMethodSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeAirlineContactMethodSearch;
        
        private System.Windows.Forms.Button buttonCrudeAirlineContactMethodAdd;
        
        private System.Windows.Forms.Button buttonCrudeAirlineContactMethodEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeAirlineContactMethod;
        
        private ContactMethodRefCombo contactMethodRefCombo;
        
        private System.Windows.Forms.Label labelContactMethodRefCombo;
        
        private System.Windows.Forms.TextBox textBoxContactMethodWay;
        
        private System.Windows.Forms.Label labelContactMethodWay;
        
        private System.Windows.Forms.TextBox textBoxComment;
        
        private System.Windows.Forms.Label labelComment;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        private AirlinePicker airlinePicker;
        
        private System.Windows.Forms.Label labelAirlinePicker;
        
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
            this.buttonCrudeAirlineContactMethodAdd = new System.Windows.Forms.Button();
            this.buttonCrudeAirlineContactMethodEdit = new System.Windows.Forms.Button();
            this.buttonCrudeAirlineContactMethodSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeAirlineContactMethod = new System.Windows.Forms.DataGridView();
            this.labelContactMethodRefCombo = new System.Windows.Forms.Label();
            this.contactMethodRefCombo = new ContactMethodRefCombo();
            this.labelContactMethodWay = new System.Windows.Forms.Label();
            this.textBoxContactMethodWay = new System.Windows.Forms.TextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelAirlinePicker = new System.Windows.Forms.Label();
            this.airlinePicker = new AirlinePicker();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirlineContactMethod)).BeginInit();
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
            // labelAirlinePicker
            //
            this.labelAirlinePicker.AutoSize = true;
            this.labelAirlinePicker.Location = new System.Drawing.Point(11, 105);
            this.labelAirlinePicker.Name = "labelAirlinePicker";
            this.labelAirlinePicker.Size = new System.Drawing.Size(71, 13);
            this.labelAirlinePicker.TabIndex = 10;
            this.labelAirlinePicker.Text = "Airline:";
            //
            //airlinePicker
            //
            this.airlinePicker.Location = new System.Drawing.Point(140, 105);
            this.airlinePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.airlinePicker.Name = "airlinePicker";
            this.airlinePicker.Size = new System.Drawing.Size(250, 20);
            this.airlinePicker.TabIndex = 11;
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
            // dataGridViewCrudeAirlineContactMethod
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeAirlineContactMethod.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeAirlineContactMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeAirlineContactMethod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeAirlineContactMethod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeAirlineContactMethod.Location = new System.Drawing.Point(12, 161);
            this.dataGridViewCrudeAirlineContactMethod.Name = "dataGridViewCrudeAirlineContactMethod";
            this.dataGridViewCrudeAirlineContactMethod.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeAirlineContactMethod.TabIndex = 0;
            this.dataGridViewCrudeAirlineContactMethod.ReadOnly = true;
            this.dataGridViewCrudeAirlineContactMethod.DoubleClick += new System.EventHandler(this.dataGridViewCrudeAirlineContactMethod_DoubleClick);
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
            // buttonCrudeAirlineContactMethodSearch
            // 
            this.buttonCrudeAirlineContactMethodSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirlineContactMethodSearch.Location = new System.Drawing.Point(198, 264);
            this.buttonCrudeAirlineContactMethodSearch.Name = "buttonCrudeAirlineContactMethodSearch";
            this.buttonCrudeAirlineContactMethodSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirlineContactMethodSearch.TabIndex = 2;
            this.buttonCrudeAirlineContactMethodSearch.Text = "&Search";
            this.buttonCrudeAirlineContactMethodSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeAirlineContactMethodSearch.Click += new System.EventHandler(this.buttonCrudeAirlineContactMethodSearch_Click);
            // 
            // buttonCrudeAirlineContactMethodAdd
            // 
            this.buttonCrudeAirlineContactMethodAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirlineContactMethodAdd.Location = new System.Drawing.Point(98, 264);
            this.buttonCrudeAirlineContactMethodAdd.Name = "buttonCrudeAirlineContactMethodAdd";
            this.buttonCrudeAirlineContactMethodAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirlineContactMethodAdd.TabIndex = 3;
            this.buttonCrudeAirlineContactMethodAdd.Text = "&Add";
            this.buttonCrudeAirlineContactMethodAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeAirlineContactMethodAdd.Click += new System.EventHandler(this.buttonCrudeAirlineContactMethodAdd_Click);
            // 
            // buttonCrudeAirlineContactMethodEdit
            // 
            this.buttonCrudeAirlineContactMethodEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeAirlineContactMethodEdit.Location = new System.Drawing.Point(-2, 264);
            this.buttonCrudeAirlineContactMethodEdit.Name = "buttonCrudeAirlineContactMethodEdit";
            this.buttonCrudeAirlineContactMethodEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeAirlineContactMethodEdit.TabIndex = 4;
            this.buttonCrudeAirlineContactMethodEdit.Text = "&Edit";
            this.buttonCrudeAirlineContactMethodEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeAirlineContactMethodEdit.Click += new System.EventHandler(this.buttonCrudeAirlineContactMethodEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 292);
            this.Controls.Add(this.buttonCrudeAirlineContactMethodSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeAirlineContactMethodAdd);
            this.Controls.Add(this.buttonCrudeAirlineContactMethodEdit);
            this.Controls.Add(this.dataGridViewCrudeAirlineContactMethod);
            this.Name = "CrudeAirlineContactMethodSearch";
            this.Text = "Airline Contact Method Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeAirlineContactMethod)).EndInit();
            this.Controls.Add(this.labelContactMethodRefCombo);
            this.Controls.Add(this.contactMethodRefCombo);
            this.Controls.Add(this.labelContactMethodWay);
            this.Controls.Add(this.textBoxContactMethodWay);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelAirlinePicker);
            this.Controls.Add(this.airlinePicker);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
