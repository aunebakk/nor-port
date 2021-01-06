/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/6/2021 4:52:05 PM
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
    public partial class AirportIdentifierSearch : Form {
        
        // keep foreign keys as private members
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a59
        private System.Guid _airportId;
        
        private string _airportIdentifierTypeRcd;
        
        private System.Guid _userId;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/79943c87-e38f-4cb4-82f2-d55079e54b54
        public AirportIdentifierSearch() {
            InitializeComponent();
            InitializeGridAirportIdentifier();
            this.AcceptButton = buttonAirportIdentifierSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/c25d8511-8577-4915-821a-4c7ec7a5b8ce
        public void Show(System.Guid airportId, string airportIdentifierTypeRcd, System.Guid userId) {
            _airportId = airportId;
            _airportIdentifierTypeRcd = airportIdentifierTypeRcd;
            _userId = userId;
            userPicker.SelectedValue = userId;
            RefreshAirportIdentifier();
            base.Show();
        }
        
        // bring up edit form for AirportIdentifier
        // links:
        //  docLink: http://sql2x.org/documentationLink/883480d1-2639-43f1-9096-131194b043c8
        private void buttonAirportIdentifierEdit_Click(object sender, EventArgs e) {
            var editForm = new AirportIdentifierEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewAirportIdentifier.CurrentRow.Cells["AirportIdentifierId"].Value);
        }
        
        // bring up add form for AirportIdentifier
        // links:
        //  docLink: http://sql2x.org/documentationLink/99b0d247-c5de-47a0-a27a-a6825fb73541
        private void buttonAirportIdentifierAdd_Click(object sender, EventArgs e) {
            var editForm = new AirportIdentifierEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAddByRules(_userId);
        }
        
        // bring up edit form for AirportIdentifier
        // links:
        //  docLink: http://sql2x.org/documentationLink/c7fc6d72-476a-4d4b-b327-08e419db92a5
        private void dataGridViewAirportIdentifier_DoubleClick(object sender, EventArgs e) {
            var editForm = new AirportIdentifierEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewAirportIdentifier.CurrentRow.Cells["AirportIdentifierId"].Value);
        }
        
        // search AirportIdentifier's using values from comboboxes and edit fields
        // links:
        //  docLink: http://sql2x.org/documentationLink/3d544c02-f541-4590-ac27-775c1f57bcea
        private void buttonAirportIdentifierSearch_Click(object sender, EventArgs e) {
            RefreshAirportIdentifier();
        }
        
        // close the form
        // links:
        //  docLink: http://sql2x.org/documentationLink/6e648338-5d0d-4bf3-957e-07f4fe317d4b
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        // fetch AirportIdentifier's from business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/75fb8ca9-978e-42eb-b15f-4a9f56dc6454
        public void RefreshAirportIdentifier() {
            var airportIdentifier = new AirportSearchServiceClient();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = airportIdentifier.AirportIdentifierIndexWithFilter();
                dataGridViewAirportIdentifier.AutoGenerateColumns = false;
                dataGridViewAirportIdentifier.DataSource = bindingSource;
                dataGridViewAirportIdentifier.AutoResizeColumns();
                dataGridViewAirportIdentifier.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                airportIdentifier.Close();
            }
        }
        
        // initialize grid forAirportIdentifier's
        // links:
        //  docLink: http://sql2x.org/documentationLink/d6ea3697-5f07-488c-9680-d154a8dee287
        private void InitializeGridAirportIdentifier() {
            dataGridViewAirportIdentifier.Columns.Clear();
            dataGridViewAirportIdentifier.AutoGenerateColumns = false;
            dataGridViewAirportIdentifier.Columns.Add("AirportName","Airport Name");
            dataGridViewAirportIdentifier.Columns["AirportName"].DataPropertyName = "AirportName";
            dataGridViewAirportIdentifier.Columns.Add("AirportIdentifierTypeName","Airport Identifier Type Name");
            dataGridViewAirportIdentifier.Columns["AirportIdentifierTypeName"].DataPropertyName = "AirportIdentifierTypeName";
            dataGridViewAirportIdentifier.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewAirportIdentifier.Columns["DefaultUserName"].DataPropertyName = "DefaultUserName";
            dataGridViewAirportIdentifier.Columns.Add("AirportId","Airport Id");
            dataGridViewAirportIdentifier.Columns["AirportId"].DataPropertyName = "AirportId";
            dataGridViewAirportIdentifier.Columns["AirportId"].Visible = false;
            dataGridViewAirportIdentifier.Columns.Add("AirportIdentifierTypeRcd","Airport Identifier Type");
            dataGridViewAirportIdentifier.Columns["AirportIdentifierTypeRcd"].DataPropertyName = "AirportIdentifierTypeRcd";
            dataGridViewAirportIdentifier.Columns.Add("AirportIdentifierCode","Airport Identifier Code");
            dataGridViewAirportIdentifier.Columns["AirportIdentifierCode"].DataPropertyName = "AirportIdentifierCode";
            dataGridViewAirportIdentifier.Columns.Add("UserId","User Id");
            dataGridViewAirportIdentifier.Columns["UserId"].DataPropertyName = "UserId";
            dataGridViewAirportIdentifier.Columns["UserId"].Visible = false;
            dataGridViewAirportIdentifier.Columns.Add("DateTime","Date Time");
            dataGridViewAirportIdentifier.Columns["DateTime"].DataPropertyName = "DateTime";
            dataGridViewAirportIdentifier.Columns.Add("AirportIdentifierId","Airport Identifier Id");
            dataGridViewAirportIdentifier.Columns["AirportIdentifierId"].DataPropertyName = "AirportIdentifierId";
            dataGridViewAirportIdentifier.Columns["AirportIdentifierId"].Visible = false;
            dataGridViewAirportIdentifier.Columns.Add("ExtensionData", "");
            dataGridViewAirportIdentifier.Columns["ExtensionData"].Visible = false;

            dataGridViewAirportIdentifier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAirportIdentifier.AutoResizeColumns();
        }
    }
}
