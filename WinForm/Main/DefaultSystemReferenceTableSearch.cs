using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface
{
    public partial class DefaultSystemReferenceTableSearch : Form
    {

        private Guid _userId;

        public DefaultSystemReferenceTableSearch() {
            InitializeComponent();
            InitializeGridCrudeDefaultSystemReferenceTable();
            this.AcceptButton = btnSearch;
            this.CancelButton = btnClose;
        }

        public void Show(Guid userId) {
            _userId = userId;
            btnSearch_Click(new object(), new EventArgs());
            base.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;

            string systemReferenceTableName =
                (string)dataGridViewCrudeDefaultSystemReferenceTable.
                    CurrentRow.
                        Cells["DefaultSystemReferenceTableName"].Value;

            MDIParentRefs.DisplayRefForm(
                    systemReferenceTableName, 
                    mdiParent:this.MdiParent
                    );

            Cursor.Current = Cursors.Default;
        }

        private void dataGridViewCrudeDefaultSystemReferenceTable_DoubleClick(object sender, EventArgs e) {
            btnEdit_Click(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            var crudeDefaultSystemReferenceTable = new CrudeDefaultSystemReferenceTableServiceClient();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = crudeDefaultSystemReferenceTable.FetchWithFilter(
                     Guid.Empty
                    , textBoxSystemReferenceTableName.Text
                    , textBoxSystemReferenceDisplayName.Text
                    , userPicker.SelectedValue
                    , DateTime.MinValue
                    );

                dataGridViewCrudeDefaultSystemReferenceTable.AutoGenerateColumns = false;
                dataGridViewCrudeDefaultSystemReferenceTable.DataSource = bindingSource;
                dataGridViewCrudeDefaultSystemReferenceTable.AutoResizeColumns();
                dataGridViewCrudeDefaultSystemReferenceTable.Refresh();
            } catch ( Exception ex ) {
                MessageBox.Show(ex.Message);
            } finally {
                crudeDefaultSystemReferenceTable.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void InitializeGridCrudeDefaultSystemReferenceTable() {
            dataGridViewCrudeDefaultSystemReferenceTable.Columns.Clear();
            dataGridViewCrudeDefaultSystemReferenceTable.AutoGenerateColumns = false;
            dataGridViewCrudeDefaultSystemReferenceTable.Columns.Add("DefaultSystemReferenceTableId", "System Reference Table Id");
            dataGridViewCrudeDefaultSystemReferenceTable.Columns.Add("DefaultSystemReferenceTableName", "System Reference Table Name");
            dataGridViewCrudeDefaultSystemReferenceTable.Columns.Add("DefaultSystemReferenceDisplayName", "System Reference Display Name");
            dataGridViewCrudeDefaultSystemReferenceTable.Columns["DefaultSystemReferenceDisplayName"].Width = 300;
            dataGridViewCrudeDefaultSystemReferenceTable.Columns.Add("DateTime", "Date Time");
            dataGridViewCrudeDefaultSystemReferenceTable.Columns["DateTime"].Visible = false;
            dataGridViewCrudeDefaultSystemReferenceTable.Columns.Add("DefaultUserId", "User Id");
            dataGridViewCrudeDefaultSystemReferenceTable.Columns.Add("ExtensionData", "");
            dataGridViewCrudeDefaultSystemReferenceTable.Columns["ExtensionData"].Visible = false;

            foreach ( DataGridViewColumn column in dataGridViewCrudeDefaultSystemReferenceTable.Columns ) {
                column.DataPropertyName = column.Name;
                if ( column.Name.EndsWith("Id") || column.Name.Equals("DefaultSystemReferenceTableName") )
                    column.Visible = false;
            }

            dataGridViewCrudeDefaultSystemReferenceTable.AutoResizeColumns();
            dataGridViewCrudeDefaultSystemReferenceTable.Refresh();
        }

        public void ShowByUserId(Guid userId) {
            userPicker.SelectedValue = userId;
            Show();
        }
    }
}
