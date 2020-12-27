namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeFerryIdentifierSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeFerryIdentifierSearch;
        
        private System.Windows.Forms.Button buttonCrudeFerryIdentifierAdd;
        
        private System.Windows.Forms.Button buttonCrudeFerryIdentifierEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeFerryIdentifier;
        
        private FerryIdentifierTypeRefCombo ferryIdentifierTypeRefCombo;
        
        private System.Windows.Forms.Label labelFerryIdentifierTypeRefCombo;
        
        private System.Windows.Forms.TextBox textBoxFerryIdentifierCode;
        
        private System.Windows.Forms.Label labelFerryIdentifierCode;
        
        private System.Windows.Forms.TextBox textBoxState;
        
        private System.Windows.Forms.Label labelState;
        
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
            this.buttonCrudeFerryIdentifierAdd = new System.Windows.Forms.Button();
            this.buttonCrudeFerryIdentifierEdit = new System.Windows.Forms.Button();
            this.buttonCrudeFerryIdentifierSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeFerryIdentifier = new System.Windows.Forms.DataGridView();
            this.labelFerryIdentifierTypeRefCombo = new System.Windows.Forms.Label();
            this.ferryIdentifierTypeRefCombo = new FerryIdentifierTypeRefCombo();
            this.labelFerryIdentifierCode = new System.Windows.Forms.Label();
            this.textBoxFerryIdentifierCode = new System.Windows.Forms.TextBox();
            this.labelState = new System.Windows.Forms.Label();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimePickerDateTime = new System.Windows.Forms.TextBox();
            this.labelUserPicker = new System.Windows.Forms.Label();
            this.userPicker = new DefaultUserPicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFerryIdentifier)).BeginInit();
            this.SuspendLayout();
            //
            // labelFerryIdentifierTypeRefCombo
            //
            this.labelFerryIdentifierTypeRefCombo.AutoSize = true;
            this.labelFerryIdentifierTypeRefCombo.Location = new System.Drawing.Point(11, 13);
            this.labelFerryIdentifierTypeRefCombo.Name = "labelFerryIdentifierTypeRefCombo";
            this.labelFerryIdentifierTypeRefCombo.Size = new System.Drawing.Size(71, 13);
            this.labelFerryIdentifierTypeRefCombo.TabIndex = 2;
            this.labelFerryIdentifierTypeRefCombo.Text = "Ferry Identifier Type:";
            //
            //ferryIdentifierTypeRefCombo
            //
            this.ferryIdentifierTypeRefCombo.Location = new System.Drawing.Point(147, 13);
            this.ferryIdentifierTypeRefCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.ferryIdentifierTypeRefCombo.Name = "ferryIdentifierTypeRefCombo";
            this.ferryIdentifierTypeRefCombo.Size = new System.Drawing.Size(250, 20);
            this.ferryIdentifierTypeRefCombo.TabIndex = 3;
            //
            // labelFerryIdentifierCode
            //
            this.labelFerryIdentifierCode.AutoSize = true;
            this.labelFerryIdentifierCode.Location = new System.Drawing.Point(11, 36);
            this.labelFerryIdentifierCode.Name = "labelFerryIdentifierCode";
            this.labelFerryIdentifierCode.Size = new System.Drawing.Size(71, 13);
            this.labelFerryIdentifierCode.TabIndex = 4;
            this.labelFerryIdentifierCode.Text = "Ferry Identifier Code:";
            //
            //textBoxFerryIdentifierCode
            //
            this.textBoxFerryIdentifierCode.Location = new System.Drawing.Point(147, 36);
            this.textBoxFerryIdentifierCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFerryIdentifierCode.Name = "textBoxFerryIdentifierCode";
            this.textBoxFerryIdentifierCode.Size = new System.Drawing.Size(250, 20);
            this.textBoxFerryIdentifierCode.TabIndex = 5;
            //
            // labelState
            //
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(11, 59);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(71, 13);
            this.labelState.TabIndex = 6;
            this.labelState.Text = "State:";
            //
            //textBoxState
            //
            this.textBoxState.Location = new System.Drawing.Point(147, 59);
            this.textBoxState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(250, 20);
            this.textBoxState.TabIndex = 7;
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
            this.dateTimePickerDateTime.Location = new System.Drawing.Point(147, 82);
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
            this.userPicker.Location = new System.Drawing.Point(147, 105);
            this.userPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userPicker.Name = "userPicker";
            this.userPicker.Size = new System.Drawing.Size(250, 20);
            this.userPicker.TabIndex = 11;
            // 
            // dataGridViewCrudeFerryIdentifier
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeFerryIdentifier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeFerryIdentifier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeFerryIdentifier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeFerryIdentifier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeFerryIdentifier.Location = new System.Drawing.Point(12, 138);
            this.dataGridViewCrudeFerryIdentifier.Name = "dataGridViewCrudeFerryIdentifier";
            this.dataGridViewCrudeFerryIdentifier.Size = new System.Drawing.Size(385, 96);
            this.dataGridViewCrudeFerryIdentifier.TabIndex = 0;
            this.dataGridViewCrudeFerryIdentifier.ReadOnly = true;
            this.dataGridViewCrudeFerryIdentifier.DoubleClick += new System.EventHandler(this.dataGridViewCrudeFerryIdentifier_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(305, 241);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeFerryIdentifierSearch
            // 
            this.buttonCrudeFerryIdentifierSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFerryIdentifierSearch.Location = new System.Drawing.Point(205, 241);
            this.buttonCrudeFerryIdentifierSearch.Name = "buttonCrudeFerryIdentifierSearch";
            this.buttonCrudeFerryIdentifierSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFerryIdentifierSearch.TabIndex = 2;
            this.buttonCrudeFerryIdentifierSearch.Text = "&Search";
            this.buttonCrudeFerryIdentifierSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeFerryIdentifierSearch.Click += new System.EventHandler(this.buttonCrudeFerryIdentifierSearch_Click);
            // 
            // buttonCrudeFerryIdentifierAdd
            // 
            this.buttonCrudeFerryIdentifierAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFerryIdentifierAdd.Location = new System.Drawing.Point(105, 241);
            this.buttonCrudeFerryIdentifierAdd.Name = "buttonCrudeFerryIdentifierAdd";
            this.buttonCrudeFerryIdentifierAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFerryIdentifierAdd.TabIndex = 3;
            this.buttonCrudeFerryIdentifierAdd.Text = "&Add";
            this.buttonCrudeFerryIdentifierAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeFerryIdentifierAdd.Click += new System.EventHandler(this.buttonCrudeFerryIdentifierAdd_Click);
            // 
            // buttonCrudeFerryIdentifierEdit
            // 
            this.buttonCrudeFerryIdentifierEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeFerryIdentifierEdit.Location = new System.Drawing.Point(5, 241);
            this.buttonCrudeFerryIdentifierEdit.Name = "buttonCrudeFerryIdentifierEdit";
            this.buttonCrudeFerryIdentifierEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeFerryIdentifierEdit.TabIndex = 4;
            this.buttonCrudeFerryIdentifierEdit.Text = "&Edit";
            this.buttonCrudeFerryIdentifierEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeFerryIdentifierEdit.Click += new System.EventHandler(this.buttonCrudeFerryIdentifierEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 269);
            this.Controls.Add(this.buttonCrudeFerryIdentifierSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeFerryIdentifierAdd);
            this.Controls.Add(this.buttonCrudeFerryIdentifierEdit);
            this.Controls.Add(this.dataGridViewCrudeFerryIdentifier);
            this.Name = "CrudeFerryIdentifierSearch";
            this.Text = "Ferry Identifier Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeFerryIdentifier)).EndInit();
            this.Controls.Add(this.labelFerryIdentifierTypeRefCombo);
            this.Controls.Add(this.ferryIdentifierTypeRefCombo);
            this.Controls.Add(this.labelFerryIdentifierCode);
            this.Controls.Add(this.textBoxFerryIdentifierCode);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.dateTimePickerDateTime);
            this.Controls.Add(this.labelUserPicker);
            this.Controls.Add(this.userPicker);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
