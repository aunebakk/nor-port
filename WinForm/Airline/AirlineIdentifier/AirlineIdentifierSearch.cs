/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/4/2021 1:50:05 PM
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
    public partial class AirlineIdentifierSearch : Form {
        
        // keep foreign keys as private members
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a59
        private System.Guid _airlineId;
        
        private string _airlineIdentifierTypeRcd;
        
        private System.Guid _userId;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/79943c87-e38f-4cb4-82f2-d55079e54b54
        public AirlineIdentifierSearch() {
            InitializeComponent();
            InitializeGridAirlineIdentifier();
            this.AcceptButton = buttonAirlineIdentifierSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/c25d8511-8577-4915-821a-4c7ec7a5b8ce
        public void Show(System.Guid airlineId, string airlineIdentifierTypeRcd, System.Guid userId) {
            _airlineId = airlineId;
            _airlineIdentifierTypeRcd = airlineIdentifierTypeRcd;
            _userId = userId;
            userPicker.SelectedValue = userId;
            RefreshAirlineIdentifier();
            base.Show();
        }
        
        // bring up edit form for AirlineIdentifier
        // links:
        //  docLink: http://sql2x.org/documentationLink/883480d1-2639-43f1-9096-131194b043c8
        private void buttonAirlineIdentifierEdit_Click(object sender, EventArgs e) {
            var editForm = new AirlineIdentifierEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewAirlineIdentifier.CurrentRow.Cells["AirlineIdentifierId"].Value);
        }
        
        // bring up add form for AirlineIdentifier
        // links:
        //  docLink: http://sql2x.org/documentationLink/99b0d247-c5de-47a0-a27a-a6825fb73541
        private void buttonAirlineIdentifierAdd_Click(object sender, EventArgs e) {
            var editForm = new AirlineIdentifierEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAddByRules(_userId);
        }
        
        // bring up edit form for AirlineIdentifier
        // links:
        //  docLink: http://sql2x.org/documentationLink/c7fc6d72-476a-4d4b-b327-08e419db92a5
        private void dataGridViewAirlineIdentifier_DoubleClick(object sender, EventArgs e) {
            var editForm = new AirlineIdentifierEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewAirlineIdentifier.CurrentRow.Cells["AirlineIdentifierId"].Value);
        }
        
        // search AirlineIdentifier's using values from comboboxes and edit fields
        // links:
        //  docLink: http://sql2x.org/documentationLink/3d544c02-f541-4590-ac27-775c1f57bcea
        private void buttonAirlineIdentifierSearch_Click(object sender, EventArgs e) {
            RefreshAirlineIdentifier();
        }
        
        // close the form
        // links:
        //  docLink: http://sql2x.org/documentationLink/6e648338-5d0d-4bf3-957e-07f4fe317d4b
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        // fetch AirlineIdentifier's from business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/75fb8ca9-978e-42eb-b15f-4a9f56dc6454
        public void RefreshAirlineIdentifier() {
            var airlineIdentifier = new AirlineSearchServiceClient();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = airlineIdentifier.AirlineIdentifierIndexWithFilter();
                dataGridViewAirlineIdentifier.AutoGenerateColumns = false;
                dataGridViewAirlineIdentifier.DataSource = bindingSource;
                dataGridViewAirlineIdentifier.AutoResizeColumns();
                dataGridViewAirlineIdentifier.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                airlineIdentifier.Close();
            }
        }
        
        // initialize grid forAirlineIdentifier's
        // links:
        //  docLink: http://sql2x.org/documentationLink/d6ea3697-5f07-488c-9680-d154a8dee287
        private void InitializeGridAirlineIdentifier() {
            dataGridViewAirlineIdentifier.Columns.Clear();
            dataGridViewAirlineIdentifier.AutoGenerateColumns = false;
            dataGridViewAirlineIdentifier.Columns.Add("AirlineName","Airline Name");
            dataGridViewAirlineIdentifier.Columns["AirlineName"].DataPropertyName = "AirlineName";
            dataGridViewAirlineIdentifier.Columns.Add("LegalName","Legal Name");
            dataGridViewAirlineIdentifier.Columns["LegalName"].DataPropertyName = "LegalName";
            dataGridViewAirlineIdentifier.Columns.Add("AirlineIdentifierTypeName","Airline Identifier Type Name");
            dataGridViewAirlineIdentifier.Columns["AirlineIdentifierTypeName"].DataPropertyName = "AirlineIdentifierTypeName";
            dataGridViewAirlineIdentifier.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewAirlineIdentifier.Columns["DefaultUserName"].DataPropertyName = "DefaultUserName";
            dataGridViewAirlineIdentifier.Columns.Add("AirlineId","Airline Id");
            dataGridViewAirlineIdentifier.Columns["AirlineId"].DataPropertyName = "AirlineId";
            dataGridViewAirlineIdentifier.Columns["AirlineId"].Visible = false;
            dataGridViewAirlineIdentifier.Columns.Add("AirlineIdentifierTypeRcd","Airline Identifier Type");
            dataGridViewAirlineIdentifier.Columns["AirlineIdentifierTypeRcd"].DataPropertyName = "AirlineIdentifierTypeRcd";
            dataGridViewAirlineIdentifier.Columns.Add("AirlineIdentifierCode","Airline Identifier Code");
            dataGridViewAirlineIdentifier.Columns["AirlineIdentifierCode"].DataPropertyName = "AirlineIdentifierCode";
            dataGridViewAirlineIdentifier.Columns.Add("UserId","User Id");
            dataGridViewAirlineIdentifier.Columns["UserId"].DataPropertyName = "UserId";
            dataGridViewAirlineIdentifier.Columns["UserId"].Visible = false;
            dataGridViewAirlineIdentifier.Columns.Add("DateTime","Date Time");
            dataGridViewAirlineIdentifier.Columns["DateTime"].DataPropertyName = "DateTime";
            dataGridViewAirlineIdentifier.Columns.Add("AirlineIdentifierId","Airline Identifier Id");
            dataGridViewAirlineIdentifier.Columns["AirlineIdentifierId"].DataPropertyName = "AirlineIdentifierId";
            dataGridViewAirlineIdentifier.Columns["AirlineIdentifierId"].Visible = false;
            dataGridViewAirlineIdentifier.Columns.Add("ExtensionData", "");
            dataGridViewAirlineIdentifier.Columns["ExtensionData"].Visible = false;

            dataGridViewAirlineIdentifier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAirlineIdentifier.AutoResizeColumns();
        }
    }
}
