/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/2/2021 2:45:24 PM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateWithDurianGenerator.UsingWinForm
*/
using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using SolutionNorSolutionPort.BusinessLogicLayer;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//  docLink: http://sql2x.org/documentationLink/c4e2b5ff-4b03-4e33-b63a-7c9899829434
namespace SolutionNorSolutionPort.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    // links:
    //  docLink: http://sql2x.org/documentationLink/e652f7b4-5cee-4eaa-8cbf-547f51efd7c6
    public partial class AircraftIdentifierSearch : Form {
        
        // keep foreign keys as private members
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a59
        private System.Guid _aircraftId;
        
        private string _aircraftIdentifierTypeRcd;
        
        private System.Guid _userId;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/79943c87-e38f-4cb4-82f2-d55079e54b54
        public AircraftIdentifierSearch() {
            InitializeComponent();
            InitializeGridAircraftIdentifier();
            this.AcceptButton = buttonAircraftIdentifierSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/c25d8511-8577-4915-821a-4c7ec7a5b8ce
        public void Show(System.Guid aircraftId, string aircraftIdentifierTypeRcd, System.Guid userId) {
            _aircraftId = aircraftId;
            _aircraftIdentifierTypeRcd = aircraftIdentifierTypeRcd;
            _userId = userId;
            userPicker.SelectedValue = userId;
            RefreshAircraftIdentifier();
            base.Show();
        }
        
        // bring up edit form for AircraftIdentifier
        // links:
        //  docLink: http://sql2x.org/documentationLink/883480d1-2639-43f1-9096-131194b043c8
        private void buttonAircraftIdentifierEdit_Click(object sender, EventArgs e) {
            var editForm = new AircraftIdentifierEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewAircraftIdentifier.CurrentRow.Cells["AircraftIdentifierId"].Value);
        }
        
        // bring up add form for AircraftIdentifier
        // links:
        //  docLink: http://sql2x.org/documentationLink/99b0d247-c5de-47a0-a27a-a6825fb73541
        private void buttonAircraftIdentifierAdd_Click(object sender, EventArgs e) {
            var editForm = new AircraftIdentifierEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAddByRules(_userId);
        }
        
        // bring up edit form for AircraftIdentifier
        // links:
        //  docLink: http://sql2x.org/documentationLink/c7fc6d72-476a-4d4b-b327-08e419db92a5
        private void dataGridViewAircraftIdentifier_DoubleClick(object sender, EventArgs e) {
            var editForm = new AircraftIdentifierEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewAircraftIdentifier.CurrentRow.Cells["AircraftIdentifierId"].Value);
        }
        
        // search AircraftIdentifier's using values from comboboxes and edit fields
        // links:
        //  docLink: http://sql2x.org/documentationLink/3d544c02-f541-4590-ac27-775c1f57bcea
        private void buttonAircraftIdentifierSearch_Click(object sender, EventArgs e) {
            RefreshAircraftIdentifier();
        }
        
        // close the form
        // links:
        //  docLink: http://sql2x.org/documentationLink/6e648338-5d0d-4bf3-957e-07f4fe317d4b
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        // fetch AircraftIdentifier's from business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/75fb8ca9-978e-42eb-b15f-4a9f56dc6454
        public void RefreshAircraftIdentifier() {
            var aircraftIdentifier = new AircraftSearchServiceClient();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = aircraftIdentifier.AircraftIdentifierIndexWithFilter(_aircraftId);
                dataGridViewAircraftIdentifier.AutoGenerateColumns = false;
                dataGridViewAircraftIdentifier.DataSource = bindingSource;
                dataGridViewAircraftIdentifier.AutoResizeColumns();
                dataGridViewAircraftIdentifier.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                aircraftIdentifier.Close();
            }
        }
        
        // initialize grid forAircraftIdentifier's
        // links:
        //  docLink: http://sql2x.org/documentationLink/d6ea3697-5f07-488c-9680-d154a8dee287
        private void InitializeGridAircraftIdentifier() {
            dataGridViewAircraftIdentifier.Columns.Clear();
            dataGridViewAircraftIdentifier.AutoGenerateColumns = false;
            dataGridViewAircraftIdentifier.Columns.Add("AircraftName","Aircraft Name");
            dataGridViewAircraftIdentifier.Columns["AircraftName"].DataPropertyName = "AircraftName";
            dataGridViewAircraftIdentifier.Columns.Add("AircraftIdentifierTypeName","Aircraft Identifier Type Name");
            dataGridViewAircraftIdentifier.Columns["AircraftIdentifierTypeName"].DataPropertyName = "AircraftIdentifierTypeName";
            dataGridViewAircraftIdentifier.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewAircraftIdentifier.Columns["DefaultUserName"].DataPropertyName = "DefaultUserName";
            dataGridViewAircraftIdentifier.Columns.Add("EngineType","Engine Type");
            dataGridViewAircraftIdentifier.Columns["EngineType"].DataPropertyName = "EngineType";
            dataGridViewAircraftIdentifier.Columns.Add("AircraftId","Aircraft Id");
            dataGridViewAircraftIdentifier.Columns["AircraftId"].DataPropertyName = "AircraftId";
            dataGridViewAircraftIdentifier.Columns["AircraftId"].Visible = false;
            dataGridViewAircraftIdentifier.Columns.Add("AircraftIdentifierTypeRcd","Aircraft Identifier Type");
            dataGridViewAircraftIdentifier.Columns["AircraftIdentifierTypeRcd"].DataPropertyName = "AircraftIdentifierTypeRcd";
            dataGridViewAircraftIdentifier.Columns.Add("AircraftIdentifierCode","Aircraft Identifier Code");
            dataGridViewAircraftIdentifier.Columns["AircraftIdentifierCode"].DataPropertyName = "AircraftIdentifierCode";
            dataGridViewAircraftIdentifier.Columns.Add("UserId","User Id");
            dataGridViewAircraftIdentifier.Columns["UserId"].DataPropertyName = "UserId";
            dataGridViewAircraftIdentifier.Columns["UserId"].Visible = false;
            dataGridViewAircraftIdentifier.Columns.Add("DateTime","Date Time");
            dataGridViewAircraftIdentifier.Columns["DateTime"].DataPropertyName = "DateTime";
            dataGridViewAircraftIdentifier.Columns.Add("AircraftIdentifierId","Aircraft Identifier Id");
            dataGridViewAircraftIdentifier.Columns["AircraftIdentifierId"].DataPropertyName = "AircraftIdentifierId";
            dataGridViewAircraftIdentifier.Columns["AircraftIdentifierId"].Visible = false;
            dataGridViewAircraftIdentifier.Columns.Add("ExtensionData", "");
            dataGridViewAircraftIdentifier.Columns["ExtensionData"].Visible = false;

            dataGridViewAircraftIdentifier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAircraftIdentifier.AutoResizeColumns();
        }
    }
}
