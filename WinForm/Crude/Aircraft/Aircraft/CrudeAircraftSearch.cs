/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/3/2021 3:45:44 AM
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
    public partial class CrudeAircraftSearch : Form {
        
        // the following fields holds initial state for foreign key's
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a58
        private string _aircraftTypeRcd;
        
        private string _aircraftConfigurationRcd;
        
        private string _aircraftBodyRcd;
        
        private System.Guid _aircraftMeasurementId;
        
        private System.Guid _productId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/4b63dffb-c4e4-44d4-8efd-0313f43db503
        public CrudeAircraftSearch() {
            InitializeComponent();
            InitializeGridCrudeAircraft();
            this.AcceptButton = buttonCrudeAircraftSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        // links:
        //  docLink: http://sql2x.org/documentationLink/5a2d259e-c278-4e61-8414-4f659db90878
        public void Show(string aircraftTypeRcd, string aircraftConfigurationRcd, string aircraftBodyRcd, System.Guid aircraftMeasurementId, System.Guid productId, System.Guid userId) {
            try {
                _aircraftTypeRcd = aircraftTypeRcd;
                _aircraftConfigurationRcd = aircraftConfigurationRcd;
                _aircraftBodyRcd = aircraftBodyRcd;
                _aircraftMeasurementId = aircraftMeasurementId;
                _productId = productId;
                _userId = userId;
                userPicker.SelectedValue = userId;

                RefreshCrudeAircraft();

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
        private void buttonCrudeAircraftEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeAircraftEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeAircraft.CurrentRow.Cells["AircraftId"].Value);
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
        private void buttonCrudeAircraftAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeAircraftEdit();
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
        private void dataGridViewCrudeAircraft_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeAircraftEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeAircraft.CurrentRow.Cells["AircraftId"].Value);
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
        private void buttonCrudeAircraftSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeAircraft();
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
        public void RefreshCrudeAircraft() {
            var aircraft = new CrudeAircraftServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = aircraft.FetchWithFilter(
                             Guid.Empty
                            ,textBoxAircraftName.Text
                            ,aircraftTypeRefCombo.Text
                            ,aircraftConfigurationRefCombo.Text
                            ,aircraftBodyRefCombo.Text
                            ,Guid.Empty
                            ,Guid.Empty
                            ,dateTimePickerOperationalDateTime.Checked ? Convert.ToDateTime(dateTimePickerOperationalDateTime.Value): DateTime.MinValue
                            ,dateTimePickerFirstFlightDateTime.Checked ? Convert.ToDateTime(dateTimePickerFirstFlightDateTime.Value): DateTime.MinValue
                            ,textBoxEngineType.Text
                            ,maskedTextBoxPassengerCapacity.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxPassengerCapacity.Text)
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeAircraft.AutoGenerateColumns = false;
                dataGridViewCrudeAircraft.DataSource = bindingSource;
                dataGridViewCrudeAircraft.AutoResizeColumns();
                dataGridViewCrudeAircraft.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                aircraft.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        // links:
        //  docLink: http://sql2x.org/documentationLink/634adebf-e682-407b-bf2e-223610d00e66
        private void InitializeGridCrudeAircraft() {
            try {
                dataGridViewCrudeAircraft.Columns.Clear();
                dataGridViewCrudeAircraft.AutoGenerateColumns = false;
                dataGridViewCrudeAircraft.Columns.Add("AircraftName","Aircraft Name");
                dataGridViewCrudeAircraft.Columns["AircraftName"].DataPropertyName = "AircraftName";
                dataGridViewCrudeAircraft.Columns.Add("AircraftTypeRcd","Aircraft Type");
                dataGridViewCrudeAircraft.Columns["AircraftTypeRcd"].DataPropertyName = "AircraftTypeRcd";
                dataGridViewCrudeAircraft.Columns.Add("AircraftConfigurationRcd","Aircraft Configuration");
                dataGridViewCrudeAircraft.Columns["AircraftConfigurationRcd"].DataPropertyName = "AircraftConfigurationRcd";
                dataGridViewCrudeAircraft.Columns.Add("AircraftBodyRcd","Aircraft Body");
                dataGridViewCrudeAircraft.Columns["AircraftBodyRcd"].DataPropertyName = "AircraftBodyRcd";
                dataGridViewCrudeAircraft.Columns.Add("EngineType","Engine Type");
                dataGridViewCrudeAircraft.Columns["EngineType"].DataPropertyName = "EngineType";
                dataGridViewCrudeAircraft.Columns.Add("PassengerCapacity","Passenger Capacity");
                dataGridViewCrudeAircraft.Columns["PassengerCapacity"].DataPropertyName = "PassengerCapacity";
                dataGridViewCrudeAircraft.Columns.Add("OperationalDateTime","Operational Date Time");
                dataGridViewCrudeAircraft.Columns["OperationalDateTime"].DataPropertyName = "OperationalDateTime";
                dataGridViewCrudeAircraft.Columns.Add("FirstFlightDateTime","First Flight Date Time");
                dataGridViewCrudeAircraft.Columns["FirstFlightDateTime"].DataPropertyName = "FirstFlightDateTime";
                dataGridViewCrudeAircraft.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeAircraft.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeAircraft.Columns.Add("AircraftId","Aircraft");
                dataGridViewCrudeAircraft.Columns["AircraftId"].DataPropertyName = "AircraftId";
                dataGridViewCrudeAircraft.Columns["AircraftId"].Visible = false;
                dataGridViewCrudeAircraft.Columns.Add("AircraftMeasurementId","Aircraft Measurement");
                dataGridViewCrudeAircraft.Columns["AircraftMeasurementId"].DataPropertyName = "AircraftMeasurementId";
                dataGridViewCrudeAircraft.Columns["AircraftMeasurementId"].Visible = false;
                dataGridViewCrudeAircraft.Columns.Add("ProductId","Product");
                dataGridViewCrudeAircraft.Columns["ProductId"].DataPropertyName = "ProductId";
                dataGridViewCrudeAircraft.Columns["ProductId"].Visible = false;
                dataGridViewCrudeAircraft.Columns.Add("ExtensionData", "");
                dataGridViewCrudeAircraft.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeAircraft.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeAircraft.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
