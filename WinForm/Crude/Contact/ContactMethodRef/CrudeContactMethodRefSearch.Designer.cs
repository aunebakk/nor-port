namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeContactMethodRefSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeContactMethodRefSearch;
        
        private System.Windows.Forms.Button buttonCrudeContactMethodRefAdd;
        
        private System.Windows.Forms.Button buttonCrudeContactMethodRefEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeContactMethodRef;
        
        private System.Windows.Forms.TextBox textBoxContactMethodName;
        
        private System.Windows.Forms.Label labelContactMethodName;
        
        private System.Windows.Forms.TextBox textBoxContactMethod;
        
        private System.Windows.Forms.Label labelContactMethod;
        
        private System.Windows.Forms.TextBox dateTimePickerDateTime;
        
        private System.Windows.Forms.Label labelDateTime;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCrudeContactMethodRefAdd = new System.Windows.Forms.Button();
            this.buttonCrudeContactMethodRefEdit = new System.Windows.Forms.Button();
            this.buttonCrudeContactMethodRefSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeContactMethodRef = new System.Windows.Forms.DataGridView();
            this.labelContactMethodName = new System.Windows.Forms.Label();
            this.textBoxContactMethodName = new System.Windows.Forms.TextBox();
            this.labelContactMethod = new System.Windows.Forms.Label();
            this.textBoxContactMethod = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeContactMethodRef)).BeginInit();
            this.SuspendLayout();
            //
            // labelContactMethodName
            //
            this.labelContactMethodName.AutoSize = true;
            this.labelContactMethodName.Location = new System.Drawing.Point(11, 13);
            this.labelContactMethodName.Name = "labelContactMethodName";
            this.labelContactMethodName.Size = new System.Drawing.Size(71, 13);
            this.labelContactMethodName.TabIndex = 2;
            this.labelContactMethodName.Text = "Contact Method Name:";
            //
            //textBoxContactMethodName
            //
            this.textBoxContactMethodName.Location = new System.Drawing.Point(140, 13);
            this.textBoxContactMethodName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxContactMethodName.Name = "textBoxContactMethodName";
            this.textBoxContactMethodName.Size = new System.Drawing.Size(250, 20);
            this.textBoxContactMethodName.TabIndex = 3;
            //
            // labelContactMethod
            //
            this.labelContactMethod.AutoSize = true;
            this.labelContactMethod.Location = new System.Drawing.Point(11, 36);
            this.labelContactMethod.Name = "labelContactMethod";
            this.labelContactMethod.Size = new System.Drawing.Size(71, 13);
            this.labelContactMethod.TabIndex = 4;
            this.labelContactMethod.Text = "Contact Method:";
            //
            //textBoxContactMethod
            //
            this.textBoxContactMethod.Location = new System.Drawing.Point(140, 36);
            this.textBoxContactMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxContactMethod.Name = "textBoxContactMethod";
            this.textBoxContactMethod.Size = new System.Drawing.Size(250, 20);
            this.textBoxContactMethod.TabIndex = 5;
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
            // dataGridViewCrudeContactMethodRef
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeContactMethodRef.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeContactMethodRef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeContactMethodRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeContactMethodRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeContactMethodRef.Location = new System.Drawing.Point(12, 92);
            this.dataGridViewCrudeContactMethodRef.Name = "dataGridViewCrudeContactMethodRef";
            this.dataGridViewCrudeContactMethodRef.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeContactMethodRef.TabIndex = 0;
            this.dataGridViewCrudeContactMethodRef.ReadOnly = true;
            this.dataGridViewCrudeContactMethodRef.DoubleClick += new System.EventHandler(this.dataGridViewCrudeContactMethodRef_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 195);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeContactMethodRefSearch
            // 
            this.buttonCrudeContactMethodRefSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeContactMethodRefSearch.Location = new System.Drawing.Point(198, 195);
            this.buttonCrudeContactMethodRefSearch.Name = "buttonCrudeContactMethodRefSearch";
            this.buttonCrudeContactMethodRefSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeContactMethodRefSearch.TabIndex = 2;
            this.buttonCrudeContactMethodRefSearch.Text = "&Search";
            this.buttonCrudeContactMethodRefSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeContactMethodRefSearch.Click += new System.EventHandler(this.buttonCrudeContactMethodRefSearch_Click);
            // 
            // buttonCrudeContactMethodRefAdd
            // 
            this.buttonCrudeContactMethodRefAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeContactMethodRefAdd.Location = new System.Drawing.Point(98, 195);
            this.buttonCrudeContactMethodRefAdd.Name = "buttonCrudeContactMethodRefAdd";
            this.buttonCrudeContactMethodRefAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeContactMethodRefAdd.TabIndex = 3;
            this.buttonCrudeContactMethodRefAdd.Text = "&Add";
            this.buttonCrudeContactMethodRefAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeContactMethodRefAdd.Click += new System.EventHandler(this.buttonCrudeContactMethodRefAdd_Click);
            // 
            // buttonCrudeContactMethodRefEdit
            // 
            this.buttonCrudeContactMethodRefEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeContactMethodRefEdit.Location = new System.Drawing.Point(-2, 195);
            this.buttonCrudeContactMethodRefEdit.Name = "buttonCrudeContactMethodRefEdit";
            this.buttonCrudeContactMethodRefEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeContactMethodRefEdit.TabIndex = 4;
            this.buttonCrudeContactMethodRefEdit.Text = "&Edit";
            this.buttonCrudeContactMethodRefEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeContactMethodRefEdit.Click += new System.EventHandler(this.buttonCrudeContactMethodRefEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 223);
            this.Controls.Add(this.buttonCrudeContactMethodRefSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeContactMethodRefAdd);
            this.Controls.Add(this.buttonCrudeContactMethodRefEdit);
            this.Controls.Add(this.dataGridViewCrudeContactMethodRef);
            this.Name = "CrudeContactMethodRefSearch";
            this.Text = "Contact Method Ref Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeContactMethodRef)).EndInit();
            this.Controls.Add(this.labelContactMethodName);
            this.Controls.Add(this.textBoxContactMethodName);
            this.Controls.Add(this.labelContactMethod);
            this.Controls.Add(this.textBoxContactMethod);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
