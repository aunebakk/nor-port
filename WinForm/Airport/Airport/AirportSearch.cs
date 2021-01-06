/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/6/2021 7:47:23 AM
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
    public partial class AirportSearch : Form {
        
        // keep foreign keys as private members
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a59
        private string _airportTypeRcd;
        
        private System.Guid _cityId;
        
        private System.Guid _productId;
        
        private System.Guid _timezoneId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/79943c87-e38f-4cb4-82f2-d55079e54b54
        public AirportSearch() {
            InitializeComponent();
            InitializeGridAirport();
            this.AcceptButton = buttonAirportSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/c25d8511-8577-4915-821a-4c7ec7a5b8ce
        public void Show(string airportTypeRcd, System.Guid cityId, System.Guid productId, System.Guid timezoneId, System.Guid userId) {
            _airportTypeRcd = airportTypeRcd;
            _cityId = cityId;
            _productId = productId;
            _timezoneId = timezoneId;
            _userId = userId;
            userPicker.SelectedValue = userId;
            RefreshAirport();
            base.Show();
        }
        
        // bring up edit form for Airport
        // links:
        //  docLink: http://sql2x.org/documentationLink/883480d1-2639-43f1-9096-131194b043c8
        private void buttonAirportEdit_Click(object sender, EventArgs e) {
            var editForm = new AirportEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewAirport.CurrentRow.Cells["AirportId"].Value);
        }
        
        // bring up add form for Airport
        // links:
        //  docLink: http://sql2x.org/documentationLink/99b0d247-c5de-47a0-a27a-a6825fb73541
        private void buttonAirportAdd_Click(object sender, EventArgs e) {
            var editForm = new AirportEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAddByRules(_userId);
        }
        
        // bring up edit form for Airport
        // links:
        //  docLink: http://sql2x.org/documentationLink/c7fc6d72-476a-4d4b-b327-08e419db92a5
        private void dataGridViewAirport_DoubleClick(object sender, EventArgs e) {
            var editForm = new AirportEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewAirport.CurrentRow.Cells["AirportId"].Value);
        }
        
        // search Airport's using values from comboboxes and edit fields
        // links:
        //  docLink: http://sql2x.org/documentationLink/3d544c02-f541-4590-ac27-775c1f57bcea
        private void buttonAirportSearch_Click(object sender, EventArgs e) {
            RefreshAirport();
        }
        
        // close the form
        // links:
        //  docLink: http://sql2x.org/documentationLink/6e648338-5d0d-4bf3-957e-07f4fe317d4b
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        // fetch Airport's from business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/75fb8ca9-978e-42eb-b15f-4a9f56dc6454
        public void RefreshAirport() {
            var airport = new AirportSearchServiceClient();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = airport.GetAirportIndexWithFilter();
                dataGridViewAirport.AutoGenerateColumns = false;
                dataGridViewAirport.DataSource = bindingSource;
                dataGridViewAirport.AutoResizeColumns();
                dataGridViewAirport.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                airport.Close();
            }
        }
        
        // initialize grid forAirport's
        // links:
        //  docLink: http://sql2x.org/documentationLink/d6ea3697-5f07-488c-9680-d154a8dee287
        private void InitializeGridAirport() {
            dataGridViewAirport.Columns.Clear();
            dataGridViewAirport.AutoGenerateColumns = false;
            dataGridViewAirport.Columns.Add("AirportName","Airport Name");
            dataGridViewAirport.Columns["AirportName"].DataPropertyName = "AirportName";
            dataGridViewAirport.Columns.Add("AirportTypeName","Airport Type Name");
            dataGridViewAirport.Columns["AirportTypeName"].DataPropertyName = "AirportTypeName";
            dataGridViewAirport.Columns.Add("CityName","City Name");
            dataGridViewAirport.Columns["CityName"].DataPropertyName = "CityName";
            dataGridViewAirport.Columns.Add("ProductName","Product Name");
            dataGridViewAirport.Columns["ProductName"].DataPropertyName = "ProductName";
            dataGridViewAirport.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewAirport.Columns["DefaultUserName"].DataPropertyName = "DefaultUserName";
            dataGridViewAirport.Columns.Add("AirportTypeRcd","Airport Type");
            dataGridViewAirport.Columns["AirportTypeRcd"].DataPropertyName = "AirportTypeRcd";
            dataGridViewAirport.Columns.Add("CityId","City Id");
            dataGridViewAirport.Columns["CityId"].DataPropertyName = "CityId";
            dataGridViewAirport.Columns["CityId"].Visible = false;
            dataGridViewAirport.Columns.Add("ProductId","Product Id");
            dataGridViewAirport.Columns["ProductId"].DataPropertyName = "ProductId";
            dataGridViewAirport.Columns["ProductId"].Visible = false;
            dataGridViewAirport.Columns.Add("UtcOffset","Utc Offset");
            dataGridViewAirport.Columns["UtcOffset"].DataPropertyName = "UtcOffset";
            dataGridViewAirport.Columns.Add("ElevationInMeters","Elevation In Meters");
            dataGridViewAirport.Columns["ElevationInMeters"].DataPropertyName = "ElevationInMeters";
            dataGridViewAirport.Columns.Add("RunwayInMeters","Runway In Meters");
            dataGridViewAirport.Columns["RunwayInMeters"].DataPropertyName = "RunwayInMeters";
            dataGridViewAirport.Columns.Add("Latitude","Latitude");
            dataGridViewAirport.Columns["Latitude"].DataPropertyName = "Latitude";
            dataGridViewAirport.Columns.Add("Longitude","Longitude");
            dataGridViewAirport.Columns["Longitude"].DataPropertyName = "Longitude";
            dataGridViewAirport.Columns.Add("TimezoneId","Timezone Id");
            dataGridViewAirport.Columns["TimezoneId"].DataPropertyName = "TimezoneId";
            dataGridViewAirport.Columns["TimezoneId"].Visible = false;
            dataGridViewAirport.Columns.Add("Variation","Variation");
            dataGridViewAirport.Columns["Variation"].DataPropertyName = "Variation";
            dataGridViewAirport.Columns.Add("Attendance","Attendance");
            dataGridViewAirport.Columns["Attendance"].DataPropertyName = "Attendance";
            dataGridViewAirport.Columns.Add("ControlTowerFlag","Control Tower Flag");
            dataGridViewAirport.Columns["ControlTowerFlag"].DataPropertyName = "ControlTowerFlag";
            dataGridViewAirport.Columns.Add("ActivationDateTime","Activation Date Time");
            dataGridViewAirport.Columns["ActivationDateTime"].DataPropertyName = "ActivationDateTime";
            dataGridViewAirport.Columns.Add("UserId","User Id");
            dataGridViewAirport.Columns["UserId"].DataPropertyName = "UserId";
            dataGridViewAirport.Columns["UserId"].Visible = false;
            dataGridViewAirport.Columns.Add("DateTime","Date Time");
            dataGridViewAirport.Columns["DateTime"].DataPropertyName = "DateTime";
            dataGridViewAirport.Columns.Add("AirportId","Airport Id");
            dataGridViewAirport.Columns["AirportId"].DataPropertyName = "AirportId";
            dataGridViewAirport.Columns["AirportId"].Visible = false;
            dataGridViewAirport.Columns.Add("ExtensionData", "");
            dataGridViewAirport.Columns["ExtensionData"].Visible = false;

            dataGridViewAirport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAirport.AutoResizeColumns();
        }
    }
}
