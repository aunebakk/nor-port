namespace SolutionNorSolutionPort.UserInterface
{


    public partial class ClientSearch
    {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonClose;

        private System.Windows.Forms.Button buttonGetClientWithFilterSearch;

        private GetClientWithFilterDurian durianGetClientWithFilter;

        protected override void Dispose(bool disposing) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonGetClientWithFilterSearch = new System.Windows.Forms.Button();
            this.durianGetClientWithFilter = new SolutionNorSolutionPort.UserInterface.GetClientWithFilterDurian();
            this.buttonCrudeClientAdd = new System.Windows.Forms.Button();
            this.buttonCrudeClientEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonClose.Location = new System.Drawing.Point(422, 277);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonGetClientWithFilterSearch
            // 
            this.buttonGetClientWithFilterSearch.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonGetClientWithFilterSearch.Location = new System.Drawing.Point(324, 277);
            this.buttonGetClientWithFilterSearch.Name = "buttonGetClientWithFilterSearch";
            this.buttonGetClientWithFilterSearch.Size = new System.Drawing.Size(92, 22);
            this.buttonGetClientWithFilterSearch.TabIndex = 2;
            this.buttonGetClientWithFilterSearch.Text = "&Search";
            this.buttonGetClientWithFilterSearch.UseVisualStyleBackColor = true;
            this.buttonGetClientWithFilterSearch.Click += new System.EventHandler(this.buttonGetClientWithFilterSearch_Click);
            // 
            // durianGetClientWithFilter
            // 
            this.durianGetClientWithFilter.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
            | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.durianGetClientWithFilter.Location = new System.Drawing.Point(12, 12);
            this.durianGetClientWithFilter.Name = "durianGetClientWithFilter";
            this.durianGetClientWithFilter.Size = new System.Drawing.Size(502, 259);
            this.durianGetClientWithFilter.TabIndex = 1;
            this.durianGetClientWithFilter.DoubleClick += new System.EventHandler(this.durianGetClientWithFilter_DoubleClick);
            // 
            // buttonCrudeClientAdd
            // 
            this.buttonCrudeClientAdd.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonCrudeClientAdd.Location = new System.Drawing.Point(226, 277);
            this.buttonCrudeClientAdd.Name = "buttonCrudeClientAdd";
            this.buttonCrudeClientAdd.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientAdd.TabIndex = 5;
            this.buttonCrudeClientAdd.Text = "&Add";
            this.buttonCrudeClientAdd.UseVisualStyleBackColor = true;
            this.buttonCrudeClientAdd.Click += new System.EventHandler(this.buttonCrudeClientAdd_Click);
            // 
            // buttonCrudeClientEdit
            // 
            this.buttonCrudeClientEdit.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.buttonCrudeClientEdit.Location = new System.Drawing.Point(126, 277);
            this.buttonCrudeClientEdit.Name = "buttonCrudeClientEdit";
            this.buttonCrudeClientEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonCrudeClientEdit.TabIndex = 6;
            this.buttonCrudeClientEdit.Text = "&Edit";
            this.buttonCrudeClientEdit.UseVisualStyleBackColor = true;
            this.buttonCrudeClientEdit.Click += new System.EventHandler(this.buttonCrudeClientEdit_Click);
            // 
            // ClientSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.buttonCrudeClientAdd);
            this.Controls.Add(this.buttonCrudeClientEdit);
            this.Controls.Add(this.buttonGetClientWithFilterSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.durianGetClientWithFilter);
            this.Name = "ClientSearch";
            this.Text = "Get Client With Filter";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button buttonCrudeClientAdd;
        private System.Windows.Forms.Button buttonCrudeClientEdit;
    }
}
