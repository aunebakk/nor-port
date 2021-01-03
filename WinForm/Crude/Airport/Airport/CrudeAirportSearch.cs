/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/3/2021 8:01:51 AM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//  docLink: http://sql2x.org/documentationLink/d8f07424-3438-4ff9-8853-3976c1227bad
namespace SolutionNorSolutionPort.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    // links:
    //  docLink: http://sql2x.org/documentationLink/9dd1c3bf-68b5-40b4-868a-735ee7394422
    public partial class CrudeAirportSearch : Form {
        
        // the following fields holds initial state for foreign key's
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a58
        private string _airportTypeRcd;
        
        private System.Guid _cityId;
        
        private System.Guid _productId;
        
        private System.Guid _timezoneId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/4b63dffb-c4e4-44d4-8efd-0313f43db503
        public CrudeAirportSearch() {
            InitializeComponent();
            InitializeGridCrudeAirport();
            this.AcceptButton = buttonCrudeAirportSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        // links:
        //  docLink: http://sql2x.org/documentationLink/5a2d259e-c278-4e61-8414-4f659db90878
        public void Show(string airportTypeRcd, System.Guid cityId, System.Guid productId, System.Guid timezoneId, System.Guid userId) {
            try {
                _airportTypeRcd = airportTypeRcd;
                _cityId = cityId;
                _productId = productId;
                _timezoneId = timezoneId;
                _userId = userId;
                userPicker.SelectedValue = userId;

                RefreshCrudeAirport();

                base.Show();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/c778f8fe-1b09-4755-891f-f9d3126d1b85
        private void buttonCrudeAirportEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeAirportEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeAirport.CurrentRow.Cells["AirportId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows a form for adding more rows
        // links:
        //  docLink: http://sql2x.org/documentationLink/499f894b-7c95-446b-be0a-57fd47b768e3
        private void buttonCrudeAirportAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeAirportEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsAddByRules(_userId);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // shows the detailed version of the selected grid row, in edit modus
        // links:
        //  docLink: http://sql2x.org/documentationLink/b9e26c97-bd6d-404a-80ad-d252a24c6fe8
        private void dataGridViewCrudeAirport_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeAirportEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeAirport.CurrentRow.Cells["AirportId"].Value);
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // does a search based on the filter and populates the grid
        // links:
        //  docLink: http://sql2x.org/documentationLink/4c1fe3ad-84a0-4295-bd83-73d9e9afe750
        private void buttonCrudeAirportSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeAirport();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
        
        // closes the form
        // links:
        //  docLink: http://sql2x.org/documentationLink/6b990ce5-1c34-4759-bffd-659ae312004d
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        // refresh the grid
        // links:
        //  docLink: http://sql2x.org/documentationLink/a90065e7-8ace-4de7-9367-d4653a7c637f
        public void RefreshCrudeAirport() {
            var airport = new CrudeAirportServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = airport.FetchWithFilter(
                             Guid.Empty
                            ,textBoxAirportName.Text
                            ,airportTypeRefCombo.Text
                            ,cityPicker.SelectedValue
                            ,Guid.Empty
                            ,maskedTextBoxUtcOffset.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxUtcOffset.Text)
                            ,maskedTextBoxElevationInMeters.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxElevationInMeters.Text)
                            ,maskedTextBoxRunwayInMeters.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxRunwayInMeters.Text)
                            ,textBoxLatitude.Text
                            ,textBoxLongitude.Text
                            ,Guid.Empty
                            ,textBoxVariation.Text
                            ,textBoxAttendance.Text
                            ,Convert.ToBoolean(checkBoxControlTowerFlag.Checked)
                            ,dateTimePickerActivationDateTime.Checked ? Convert.ToDateTime(dateTimePickerActivationDateTime.Value): DateTime.MinValue
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeAirport.AutoGenerateColumns = false;
                dataGridViewCrudeAirport.DataSource = bindingSource;
                dataGridViewCrudeAirport.AutoResizeColumns();
                dataGridViewCrudeAirport.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                airport.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        // links:
        //  docLink: http://sql2x.org/documentationLink/634adebf-e682-407b-bf2e-223610d00e66
        private void InitializeGridCrudeAirport() {
            try {
                dataGridViewCrudeAirport.Columns.Clear();
                dataGridViewCrudeAirport.AutoGenerateColumns = false;
                dataGridViewCrudeAirport.Columns.Add("AirportName","Airport Name");
                dataGridViewCrudeAirport.Columns["AirportName"].DataPropertyName = "AirportName";
                dataGridViewCrudeAirport.Columns.Add("AirportTypeRcd","Airport Type");
                dataGridViewCrudeAirport.Columns["AirportTypeRcd"].DataPropertyName = "AirportTypeRcd";
                dataGridViewCrudeAirport.Columns.Add("Latitude","Latitude");
                dataGridViewCrudeAirport.Columns["Latitude"].DataPropertyName = "Latitude";
                dataGridViewCrudeAirport.Columns.Add("Longitude","Longitude");
                dataGridViewCrudeAirport.Columns["Longitude"].DataPropertyName = "Longitude";
                dataGridViewCrudeAirport.Columns.Add("Variation","Variation");
                dataGridViewCrudeAirport.Columns["Variation"].DataPropertyName = "Variation";
                dataGridViewCrudeAirport.Columns.Add("Attendance","Attendance");
                dataGridViewCrudeAirport.Columns["Attendance"].DataPropertyName = "Attendance";
                dataGridViewCrudeAirport.Columns.Add("UtcOffset","Utc Offset");
                dataGridViewCrudeAirport.Columns["UtcOffset"].DataPropertyName = "UtcOffset";
                dataGridViewCrudeAirport.Columns.Add("ElevationInMeters","Elevation In Meters");
                dataGridViewCrudeAirport.Columns["ElevationInMeters"].DataPropertyName = "ElevationInMeters";
                dataGridViewCrudeAirport.Columns.Add("RunwayInMeters","Runway In Meters");
                dataGridViewCrudeAirport.Columns["RunwayInMeters"].DataPropertyName = "RunwayInMeters";
                dataGridViewCrudeAirport.Columns.Add("ActivationDateTime","Activation Date Time");
                dataGridViewCrudeAirport.Columns["ActivationDateTime"].DataPropertyName = "ActivationDateTime";
                dataGridViewCrudeAirport.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeAirport.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeAirport.Columns.Add("AirportId","Airport");
                dataGridViewCrudeAirport.Columns["AirportId"].DataPropertyName = "AirportId";
                dataGridViewCrudeAirport.Columns["AirportId"].Visible = false;
                dataGridViewCrudeAirport.Columns.Add("CityId","City");
                dataGridViewCrudeAirport.Columns["CityId"].DataPropertyName = "CityId";
                dataGridViewCrudeAirport.Columns["CityId"].Visible = false;
                dataGridViewCrudeAirport.Columns.Add("ProductId","Product");
                dataGridViewCrudeAirport.Columns["ProductId"].DataPropertyName = "ProductId";
                dataGridViewCrudeAirport.Columns["ProductId"].Visible = false;
                dataGridViewCrudeAirport.Columns.Add("TimezoneId","Timezone");
                dataGridViewCrudeAirport.Columns["TimezoneId"].DataPropertyName = "TimezoneId";
                dataGridViewCrudeAirport.Columns["TimezoneId"].Visible = false;
                dataGridViewCrudeAirport.Columns.Add("ControlTowerFlag","Control Tower Flag");
                dataGridViewCrudeAirport.Columns["ControlTowerFlag"].DataPropertyName = "ControlTowerFlag";
                dataGridViewCrudeAirport.Columns.Add("ExtensionData", "");
                dataGridViewCrudeAirport.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeAirport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeAirport.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
