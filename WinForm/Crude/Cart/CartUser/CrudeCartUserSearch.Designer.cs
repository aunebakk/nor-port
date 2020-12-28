namespace SolutionNorSolutionPort.UserInterface {

    public partial class CrudeCartUserSearch {
        
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Button buttonClose;
        
        private System.Windows.Forms.Button buttonCrudeCartUserSearch;
        
        private System.Windows.Forms.Button buttonCrudeCartUserAdd;
        
        private System.Windows.Forms.Button buttonCrudeCartUserEdit;
        
        private System.Windows.Forms.DataGridView dataGridViewCrudeCartUser;
        
        protected override void Dispose(bool disposing) {
           if (disposing && (components != null)) {
               components.Dispose();
           }
           base.Dispose(disposing);
        }
        
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCrudeCartUserAdd = new System.Windows.Forms.Button();
            this.buttonCrudeCartUserEdit = new System.Windows.Forms.Button();
            this.buttonCrudeCartUserSearch = new System.Windows.Forms.Button();
            this.dataGridViewCrudeCartUser = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeCartUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCrudeCartUser
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCrudeCartUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCrudeCartUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrudeCartUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrudeCartUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCrudeCartUser.Location = new System.Drawing.Point(12, 23);
            this.dataGridViewCrudeCartUser.Name = "dataGridViewCrudeCartUser";
            this.dataGridViewCrudeCartUser.Size = new System.Drawing.Size(378, 96);
            this.dataGridViewCrudeCartUser.TabIndex = 0;
            this.dataGridViewCrudeCartUser.ReadOnly = true;
            this.dataGridViewCrudeCartUser.DoubleClick += new System.EventHandler(this.dataGridViewCrudeCartUser_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(298, 126);
            
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCrudeCartUserSearch
            // 
            this.buttonCrudeCartUserSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeCartUserSearch.Location = new System.Drawing.Point(198, 126);
            this.buttonCrudeCartUserSearch.Name = "buttonCrudeCartUserSearch";
            this.buttonCrudeCartUserSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeCartUserSearch.TabIndex = 2;
            this.buttonCrudeCartUserSearch.Text = "&Search";
            this.buttonCrudeCartUserSearch.UseVisualStyleBackColor = true;
            this.buttonCrudeCartUserSearch.Click += new System.EventHandler(this.buttonCrudeCartUserSearch_Click);
            // 
            // buttonCrudeCartUserAdd
            // 
            this.buttonCrudeCartUserAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeCartUserAdd.Location = new System.Drawing.Point(98, 126);
            this.buttonCrudeCartUserAdd.Name = "buttonCrudeCartUserAdd";
            this.buttonCrudeCartUserAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeCartUserAdd.TabIndex = 3;
            this.buttonCrudeCartUserAdd.Text = "&Add";
            this.buttonCrudeCartUserAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeCartUserAdd.Click += new System.EventHandler(this.buttonCrudeCartUserAdd_Click);
            // 
            // buttonCrudeCartUserEdit
            // 
            this.buttonCrudeCartUserEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCrudeCartUserEdit.Location = new System.Drawing.Point(-2, 126);
            this.buttonCrudeCartUserEdit.Name = "buttonCrudeCartUserEdit";
            this.buttonCrudeCartUserEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeCartUserEdit.TabIndex = 4;
            this.buttonCrudeCartUserEdit.Text = "&Edit";
            this.buttonCrudeCartUserEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeCartUserEdit.Click += new System.EventHandler(this.buttonCrudeCartUserEdit_Click);
            // 
            // GridForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 154);
            this.Controls.Add(this.buttonCrudeCartUserSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCrudeCartUserAdd);
            this.Controls.Add(this.buttonCrudeCartUserEdit);
            this.Controls.Add(this.dataGridViewCrudeCartUser);
            this.Name = "CrudeCartUserSearch";
            this.Text = "Cart User Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrudeCartUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
