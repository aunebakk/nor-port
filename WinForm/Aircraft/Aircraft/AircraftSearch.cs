/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/4/2021 9:03:34 PM
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
    public partial class AircraftSearch : Form {
        
        // keep foreign keys as private members
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a59
        private string _aircraftTypeRcd;
        
        private string _aircraftConfigurationRcd;
        
        private string _aircraftBodyRcd;
        
        private System.Guid _aircraftMeasurementId;
        
        private System.Guid _productId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/79943c87-e38f-4cb4-82f2-d55079e54b54
        public AircraftSearch() {
            InitializeComponent();
            InitializeGridAircraft();
            this.AcceptButton = buttonAircraftSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/c25d8511-8577-4915-821a-4c7ec7a5b8ce
        public void Show(string aircraftTypeRcd, string aircraftConfigurationRcd, string aircraftBodyRcd, System.Guid aircraftMeasurementId, System.Guid productId, System.Guid userId) {
            _aircraftTypeRcd = aircraftTypeRcd;
            _aircraftConfigurationRcd = aircraftConfigurationRcd;
            _aircraftBodyRcd = aircraftBodyRcd;
            _aircraftMeasurementId = aircraftMeasurementId;
            _productId = productId;
            _userId = userId;
            userPicker.SelectedValue = userId;
            RefreshAircraft();
            base.Show();
        }
        
        // bring up edit form for Aircraft
        // links:
        //  docLink: http://sql2x.org/documentationLink/883480d1-2639-43f1-9096-131194b043c8
        private void buttonAircraftEdit_Click(object sender, EventArgs e) {
            var editForm = new AircraftEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewAircraft.CurrentRow.Cells["AircraftId"].Value);
        }
        
        // bring up add form for Aircraft
        // links:
        //  docLink: http://sql2x.org/documentationLink/99b0d247-c5de-47a0-a27a-a6825fb73541
        private void buttonAircraftAdd_Click(object sender, EventArgs e) {
            var editForm = new AircraftEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAddByRules(_userId);
        }
        
        // bring up edit form for Aircraft
        // links:
        //  docLink: http://sql2x.org/documentationLink/c7fc6d72-476a-4d4b-b327-08e419db92a5
        private void dataGridViewAircraft_DoubleClick(object sender, EventArgs e) {
            var editForm = new AircraftEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewAircraft.CurrentRow.Cells["AircraftId"].Value);
        }
        
        // search Aircraft's using values from comboboxes and edit fields
        // links:
        //  docLink: http://sql2x.org/documentationLink/3d544c02-f541-4590-ac27-775c1f57bcea
        private void buttonAircraftSearch_Click(object sender, EventArgs e) {
            RefreshAircraft();
        }
        
        // close the form
        // links:
        //  docLink: http://sql2x.org/documentationLink/6e648338-5d0d-4bf3-957e-07f4fe317d4b
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        // fetch Aircraft's from business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/75fb8ca9-978e-42eb-b15f-4a9f56dc6454
        public void RefreshAircraft() {
            var aircraft = new AircraftSearchServiceClient();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = aircraft.AircraftIndexWithFilter();
                dataGridViewAircraft.AutoGenerateColumns = false;
                dataGridViewAircraft.DataSource = bindingSource;
                dataGridViewAircraft.AutoResizeColumns();
                dataGridViewAircraft.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                aircraft.Close();
            }
        }
        
        // initialize grid forAircraft's
        // links:
        //  docLink: http://sql2x.org/documentationLink/d6ea3697-5f07-488c-9680-d154a8dee287
        private void InitializeGridAircraft() {
            dataGridViewAircraft.Columns.Clear();
            dataGridViewAircraft.AutoGenerateColumns = false;
            dataGridViewAircraft.Columns.Add("AircraftName","Aircraft Name");
            dataGridViewAircraft.Columns["AircraftName"].DataPropertyName = "AircraftName";
            dataGridViewAircraft.Columns.Add("AircraftTypeName","Aircraft Type Name");
            dataGridViewAircraft.Columns["AircraftTypeName"].DataPropertyName = "AircraftTypeName";
            dataGridViewAircraft.Columns.Add("AircraftConfigurationName","Aircraft Configuration Name");
            dataGridViewAircraft.Columns["AircraftConfigurationName"].DataPropertyName = "AircraftConfigurationName";
            dataGridViewAircraft.Columns.Add("AircraftBodyName","Aircraft Body Name");
            dataGridViewAircraft.Columns["AircraftBodyName"].DataPropertyName = "AircraftBodyName";
            dataGridViewAircraft.Columns.Add("ProductName","Product Name");
            dataGridViewAircraft.Columns["ProductName"].DataPropertyName = "ProductName";
            dataGridViewAircraft.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewAircraft.Columns["DefaultUserName"].DataPropertyName = "DefaultUserName";
            dataGridViewAircraft.Columns.Add("AircraftTypeRcd","Aircraft Type");
            dataGridViewAircraft.Columns["AircraftTypeRcd"].DataPropertyName = "AircraftTypeRcd";
            dataGridViewAircraft.Columns.Add("AircraftConfigurationRcd","Aircraft Configuration");
            dataGridViewAircraft.Columns["AircraftConfigurationRcd"].DataPropertyName = "AircraftConfigurationRcd";
            dataGridViewAircraft.Columns.Add("AircraftBodyRcd","Aircraft Body");
            dataGridViewAircraft.Columns["AircraftBodyRcd"].DataPropertyName = "AircraftBodyRcd";
            dataGridViewAircraft.Columns.Add("AircraftMeasurementId","Aircraft Measurement Id");
            dataGridViewAircraft.Columns["AircraftMeasurementId"].DataPropertyName = "AircraftMeasurementId";
            dataGridViewAircraft.Columns["AircraftMeasurementId"].Visible = false;
            dataGridViewAircraft.Columns.Add("ProductId","Product Id");
            dataGridViewAircraft.Columns["ProductId"].DataPropertyName = "ProductId";
            dataGridViewAircraft.Columns["ProductId"].Visible = false;
            dataGridViewAircraft.Columns.Add("OperationalDateTime","Operational Date Time");
            dataGridViewAircraft.Columns["OperationalDateTime"].DataPropertyName = "OperationalDateTime";
            dataGridViewAircraft.Columns.Add("FirstFlightDateTime","First Flight Date Time");
            dataGridViewAircraft.Columns["FirstFlightDateTime"].DataPropertyName = "FirstFlightDateTime";
            dataGridViewAircraft.Columns.Add("EngineType","Engine Type");
            dataGridViewAircraft.Columns["EngineType"].DataPropertyName = "EngineType";
            dataGridViewAircraft.Columns.Add("PassengerCapacity","Passenger Capacity");
            dataGridViewAircraft.Columns["PassengerCapacity"].DataPropertyName = "PassengerCapacity";
            dataGridViewAircraft.Columns.Add("UserId","User Id");
            dataGridViewAircraft.Columns["UserId"].DataPropertyName = "UserId";
            dataGridViewAircraft.Columns["UserId"].Visible = false;
            dataGridViewAircraft.Columns.Add("DateTime","Date Time");
            dataGridViewAircraft.Columns["DateTime"].DataPropertyName = "DateTime";
            dataGridViewAircraft.Columns.Add("AircraftId","Aircraft Id");
            dataGridViewAircraft.Columns["AircraftId"].DataPropertyName = "AircraftId";
            dataGridViewAircraft.Columns["AircraftId"].Visible = false;
            dataGridViewAircraft.Columns.Add("ExtensionData", "");
            dataGridViewAircraft.Columns["ExtensionData"].Visible = false;

            dataGridViewAircraft.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAircraft.AutoResizeColumns();
        }
    }
}
