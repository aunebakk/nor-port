/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/3/2021 3:42:07 PM
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
    public partial class CrudeAircraftCompartmentMeasurementSearch : Form {
        
        // the following fields holds initial state for foreign key's
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a58
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/4b63dffb-c4e4-44d4-8efd-0313f43db503
        public CrudeAircraftCompartmentMeasurementSearch() {
            InitializeComponent();
            InitializeGridCrudeAircraftCompartmentMeasurement();
            this.AcceptButton = buttonCrudeAircraftCompartmentMeasurementSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        // links:
        //  docLink: http://sql2x.org/documentationLink/5a2d259e-c278-4e61-8414-4f659db90878
        public void Show(System.Guid userId) {
            try {
                _userId = userId;
                userPicker.SelectedValue = userId;

                RefreshCrudeAircraftCompartmentMeasurement();

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
        private void buttonCrudeAircraftCompartmentMeasurementEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeAircraftCompartmentMeasurementEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeAircraftCompartmentMeasurement.CurrentRow.Cells["AircraftCompartmentMeasurementId"].Value);
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
        private void buttonCrudeAircraftCompartmentMeasurementAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeAircraftCompartmentMeasurementEdit();
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
        private void dataGridViewCrudeAircraftCompartmentMeasurement_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeAircraftCompartmentMeasurementEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeAircraftCompartmentMeasurement.CurrentRow.Cells["AircraftCompartmentMeasurementId"].Value);
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
        private void buttonCrudeAircraftCompartmentMeasurementSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeAircraftCompartmentMeasurement();
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
        public void RefreshCrudeAircraftCompartmentMeasurement() {
            var aircraftCompartmentMeasurement = new CrudeAircraftCompartmentMeasurementServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = aircraftCompartmentMeasurement.FetchWithFilter(
                             Guid.Empty
                            ,maskedTextBoxLength.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxLength.Text)
                            ,maskedTextBoxHeight.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxHeight.Text)
                            ,maskedTextBoxWidth.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxWidth.Text)
                            ,maskedTextBoxPayloadInKilo.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxPayloadInKilo.Text)
                            ,maskedTextBoxUnitLoadDevicePositions.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxUnitLoadDevicePositions.Text)
                            ,maskedTextBoxCarryOnBinCount.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxCarryOnBinCount.Text)
                            ,maskedTextBoxCarryOnPiecesAllowedCount.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxCarryOnPiecesAllowedCount.Text)
                            ,maskedTextBoxCarryOnPieceMaxWeightInKilo.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxCarryOnPieceMaxWeightInKilo.Text)
                            ,maskedTextBoxInfantLimit.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxInfantLimit.Text)
                            ,maskedTextBoxBookableLimit.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxBookableLimit.Text)
                            ,maskedTextBoxPassengerLimit.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxPassengerLimit.Text)
                            ,maskedTextBoxRowCount.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxRowCount.Text)
                            ,maskedTextBoxColumnCount.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxColumnCount.Text)
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeAircraftCompartmentMeasurement.AutoGenerateColumns = false;
                dataGridViewCrudeAircraftCompartmentMeasurement.DataSource = bindingSource;
                dataGridViewCrudeAircraftCompartmentMeasurement.AutoResizeColumns();
                dataGridViewCrudeAircraftCompartmentMeasurement.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                aircraftCompartmentMeasurement.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        // links:
        //  docLink: http://sql2x.org/documentationLink/634adebf-e682-407b-bf2e-223610d00e66
        private void InitializeGridCrudeAircraftCompartmentMeasurement() {
            try {
                dataGridViewCrudeAircraftCompartmentMeasurement.Columns.Clear();
                dataGridViewCrudeAircraftCompartmentMeasurement.AutoGenerateColumns = false;
                dataGridViewCrudeAircraftCompartmentMeasurement.Columns.Add("Length","Length");
                dataGridViewCrudeAircraftCompartmentMeasurement.Columns["Length"].DataPropertyName = "Length";
                dataGridViewCrudeAircraftCompartmentMeasurement.Columns.Add("Height","Height");
                dataGridViewCrudeAircraftCompartmentMeasurement.Columns["Height"].DataPropertyName = "Height";
                dataGridViewCrudeAircraftCompartmentMeasurement.Columns.Add("Width","Width");
                dataGridViewCrudeAircraftCompartmentMeasurement.Columns["Width"].DataPropertyName = "Width";
                dataGridViewCrudeAircraftCompartmentMeasurement.Columns.Add("PayloadInKilo","Payload In Kilo");
                dataGridViewCrudeAircraftCompartmentMeasurement.Columns["PayloadInKilo"].DataPropertyName = "PayloadInKilo";
                dataGridViewCrudeAircraftCompartmentMeasurement.Columns.Add("UnitLoadDevicePositions","Unit Load Device Positions");
                dataGridViewCrudeAircraftCompartmentMeasurement.Columns["UnitLoadDevicePositions"].DataPropertyName = "UnitLoadDevicePositions";
                dataGridViewCrudeAircraftCompartmentMeasurement.Columns.Add("CarryOnBinCount","Carry On Bin Count");
                dataGridViewCrudeAircraftCompartmentMeasurement.Columns["CarryOnBinCount"].DataPropertyName = "CarryOnBinCount";
                dataGridViewCrudeAircraftCompartmentMeasurement.Columns.Add("CarryOnPiecesAllowedCount","Carry On Pieces Allowed Count");
                dataGridViewCrudeAircraftCompartmentMeasurement.Columns["CarryOnPiecesAllowedCount"].DataPropertyName = "CarryOnPiecesAllowedCount";
                dataGridViewCrudeAircraftCompartmentMeasurement.Columns.Add("CarryOnPieceMaxWeightInKilo","Carry On Piece Max Weight In Kilo");
                dataGridViewCrudeAircraftCompartmentMeasurement.Columns["CarryOnPieceMaxWeightInKilo"].DataPropertyName = "CarryOnPieceMaxWeightInKilo";
                dataGridViewCrudeAircraftCompartmentMeasurement.Columns.Add("InfantLimit","Infant Limit");
                dataGridViewCrudeAircraftCompartmentMeasurement.Columns["InfantLimit"].DataPropertyName = "InfantLimit";
                dataGridViewCrudeAircraftCompartmentMeasurement.Columns.Add("BookableLimit","Bookable Limit");
                dataGridViewCrudeAircraftCompartmentMeasurement.Columns["BookableLimit"].DataPropertyName = "BookableLimit";
                dataGridViewCrudeAircraftCompartmentMeasurement.Columns.Add("PassengerLimit","Passenger Limit");
                dataGridViewCrudeAircraftCompartmentMeasurement.Columns["PassengerLimit"].DataPropertyName = "PassengerLimit";
                dataGridViewCrudeAircraftCompartmentMeasurement.Columns.Add("RowCount","Row Count");
                dataGridViewCrudeAircraftCompartmentMeasurement.Columns["RowCount"].DataPropertyName = "RowCount";
                dataGridViewCrudeAircraftCompartmentMeasurement.Columns.Add("ColumnCount","Column Count");
                dataGridViewCrudeAircraftCompartmentMeasurement.Columns["ColumnCount"].DataPropertyName = "ColumnCount";
                dataGridViewCrudeAircraftCompartmentMeasurement.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeAircraftCompartmentMeasurement.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeAircraftCompartmentMeasurement.Columns.Add("AircraftCompartmentMeasurementId","Aircraft Compartment Measurement");
                dataGridViewCrudeAircraftCompartmentMeasurement.Columns["AircraftCompartmentMeasurementId"].DataPropertyName = "AircraftCompartmentMeasurementId";
                dataGridViewCrudeAircraftCompartmentMeasurement.Columns["AircraftCompartmentMeasurementId"].Visible = false;
                dataGridViewCrudeAircraftCompartmentMeasurement.Columns.Add("ExtensionData", "");
                dataGridViewCrudeAircraftCompartmentMeasurement.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeAircraftCompartmentMeasurement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeAircraftCompartmentMeasurement.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
