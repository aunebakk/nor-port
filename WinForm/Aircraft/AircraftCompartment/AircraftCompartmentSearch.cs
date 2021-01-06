/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/6/2021 4:51:01 PM
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
    public partial class AircraftCompartmentSearch : Form {
        
        // keep foreign keys as private members
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a59
        private System.Guid _aircraftId;
        
        private System.Guid _aircraftCompartmentMeasurementId;
        
        private string _aircraftCompartmentTypeRcd;
        
        private System.Guid _userId;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/79943c87-e38f-4cb4-82f2-d55079e54b54
        public AircraftCompartmentSearch() {
            InitializeComponent();
            InitializeGridAircraftCompartment();
            this.AcceptButton = buttonAircraftCompartmentSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/c25d8511-8577-4915-821a-4c7ec7a5b8ce
        public void Show(System.Guid aircraftId, System.Guid aircraftCompartmentMeasurementId, string aircraftCompartmentTypeRcd, System.Guid userId) {
            _aircraftId = aircraftId;
            _aircraftCompartmentMeasurementId = aircraftCompartmentMeasurementId;
            _aircraftCompartmentTypeRcd = aircraftCompartmentTypeRcd;
            _userId = userId;
            userPicker.SelectedValue = userId;
            RefreshAircraftCompartment();
            base.Show();
        }
        
        // bring up edit form for AircraftCompartment
        // links:
        //  docLink: http://sql2x.org/documentationLink/883480d1-2639-43f1-9096-131194b043c8
        private void buttonAircraftCompartmentEdit_Click(object sender, EventArgs e) {
            var editForm = new AircraftCompartmentEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewAircraftCompartment.CurrentRow.Cells["AircraftCompartmentId"].Value);
        }
        
        // bring up add form for AircraftCompartment
        // links:
        //  docLink: http://sql2x.org/documentationLink/99b0d247-c5de-47a0-a27a-a6825fb73541
        private void buttonAircraftCompartmentAdd_Click(object sender, EventArgs e) {
            var editForm = new AircraftCompartmentEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAddByRules(_userId);
        }
        
        // bring up edit form for AircraftCompartment
        // links:
        //  docLink: http://sql2x.org/documentationLink/c7fc6d72-476a-4d4b-b327-08e419db92a5
        private void dataGridViewAircraftCompartment_DoubleClick(object sender, EventArgs e) {
            var editForm = new AircraftCompartmentEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewAircraftCompartment.CurrentRow.Cells["AircraftCompartmentId"].Value);
        }
        
        // search AircraftCompartment's using values from comboboxes and edit fields
        // links:
        //  docLink: http://sql2x.org/documentationLink/3d544c02-f541-4590-ac27-775c1f57bcea
        private void buttonAircraftCompartmentSearch_Click(object sender, EventArgs e) {
            RefreshAircraftCompartment();
        }
        
        // close the form
        // links:
        //  docLink: http://sql2x.org/documentationLink/6e648338-5d0d-4bf3-957e-07f4fe317d4b
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        // fetch AircraftCompartment's from business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/75fb8ca9-978e-42eb-b15f-4a9f56dc6454
        public void RefreshAircraftCompartment() {
            var aircraftCompartment = new AircraftSearchServiceClient();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = aircraftCompartment.AircraftCompartmentIndexWithFilter(_aircraftId);
                dataGridViewAircraftCompartment.AutoGenerateColumns = false;
                dataGridViewAircraftCompartment.DataSource = bindingSource;
                dataGridViewAircraftCompartment.AutoResizeColumns();
                dataGridViewAircraftCompartment.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                aircraftCompartment.Close();
            }
        }
        
        // initialize grid forAircraftCompartment's
        // links:
        //  docLink: http://sql2x.org/documentationLink/d6ea3697-5f07-488c-9680-d154a8dee287
        private void InitializeGridAircraftCompartment() {
            dataGridViewAircraftCompartment.Columns.Clear();
            dataGridViewAircraftCompartment.AutoGenerateColumns = false;
            dataGridViewAircraftCompartment.Columns.Add("AircraftName","Aircraft Name");
            dataGridViewAircraftCompartment.Columns["AircraftName"].DataPropertyName = "AircraftName";
            dataGridViewAircraftCompartment.Columns.Add("AircraftCompartmentTypeName","Aircraft Compartment Type Name");
            dataGridViewAircraftCompartment.Columns["AircraftCompartmentTypeName"].DataPropertyName = "AircraftCompartmentTypeName";
            dataGridViewAircraftCompartment.Columns.Add("AircraftCompartmentName","Aircraft Compartment Name");
            dataGridViewAircraftCompartment.Columns["AircraftCompartmentName"].DataPropertyName = "AircraftCompartmentName";
            dataGridViewAircraftCompartment.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewAircraftCompartment.Columns["DefaultUserName"].DataPropertyName = "DefaultUserName";
            dataGridViewAircraftCompartment.Columns.Add("EngineType","Engine Type");
            dataGridViewAircraftCompartment.Columns["EngineType"].DataPropertyName = "EngineType";
            dataGridViewAircraftCompartment.Columns.Add("AircraftId","Aircraft Id");
            dataGridViewAircraftCompartment.Columns["AircraftId"].DataPropertyName = "AircraftId";
            dataGridViewAircraftCompartment.Columns["AircraftId"].Visible = false;
            dataGridViewAircraftCompartment.Columns.Add("AircraftCompartmentMeasurementId","Aircraft Compartment Measurement Id");
            dataGridViewAircraftCompartment.Columns["AircraftCompartmentMeasurementId"].DataPropertyName = "AircraftCompartmentMeasurementId";
            dataGridViewAircraftCompartment.Columns["AircraftCompartmentMeasurementId"].Visible = false;
            dataGridViewAircraftCompartment.Columns.Add("AircraftCompartmentTypeRcd","Aircraft Compartment Type");
            dataGridViewAircraftCompartment.Columns["AircraftCompartmentTypeRcd"].DataPropertyName = "AircraftCompartmentTypeRcd";
            dataGridViewAircraftCompartment.Columns.Add("UserId","User Id");
            dataGridViewAircraftCompartment.Columns["UserId"].DataPropertyName = "UserId";
            dataGridViewAircraftCompartment.Columns["UserId"].Visible = false;
            dataGridViewAircraftCompartment.Columns.Add("DateTime","Date Time");
            dataGridViewAircraftCompartment.Columns["DateTime"].DataPropertyName = "DateTime";
            dataGridViewAircraftCompartment.Columns.Add("AircraftCompartmentId","Aircraft Compartment Id");
            dataGridViewAircraftCompartment.Columns["AircraftCompartmentId"].DataPropertyName = "AircraftCompartmentId";
            dataGridViewAircraftCompartment.Columns["AircraftCompartmentId"].Visible = false;
            dataGridViewAircraftCompartment.Columns.Add("ExtensionData", "");
            dataGridViewAircraftCompartment.Columns["ExtensionData"].Visible = false;

            dataGridViewAircraftCompartment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAircraftCompartment.AutoResizeColumns();
        }
    }
}
