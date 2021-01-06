/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/6/2021 7:14:17 AM
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
    public partial class CrudeAirportIdentifierSearch : Form {
        
        // the following fields holds initial state for foreign key's
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a58
        private string _airportIdentifierTypeRcd;
        
        private System.Guid _airportId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/4b63dffb-c4e4-44d4-8efd-0313f43db503
        public CrudeAirportIdentifierSearch() {
            InitializeComponent();
            InitializeGridCrudeAirportIdentifier();
            this.AcceptButton = buttonCrudeAirportIdentifierSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        // links:
        //  docLink: http://sql2x.org/documentationLink/5a2d259e-c278-4e61-8414-4f659db90878
        public void Show(string airportIdentifierTypeRcd, System.Guid airportId, System.Guid userId) {
            try {
                _airportIdentifierTypeRcd = airportIdentifierTypeRcd;
                _airportId = airportId;
                _userId = userId;
                userPicker.SelectedValue = userId;

                RefreshCrudeAirportIdentifier();

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
        private void buttonCrudeAirportIdentifierEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeAirportIdentifierEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeAirportIdentifier.CurrentRow.Cells["AirportIdentifierId"].Value);
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
        private void buttonCrudeAirportIdentifierAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeAirportIdentifierEdit();
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
        private void dataGridViewCrudeAirportIdentifier_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeAirportIdentifierEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeAirportIdentifier.CurrentRow.Cells["AirportIdentifierId"].Value);
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
        private void buttonCrudeAirportIdentifierSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeAirportIdentifier();
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
        public void RefreshCrudeAirportIdentifier() {
            var airportIdentifier = new CrudeAirportIdentifierServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = airportIdentifier.FetchWithFilter(
                             Guid.Empty
                            ,airportPicker.SelectedValue
                            ,airportIdentifierTypeRefCombo.Text
                            ,textBoxAirportIdentifierCode.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeAirportIdentifier.AutoGenerateColumns = false;
                dataGridViewCrudeAirportIdentifier.DataSource = bindingSource;
                dataGridViewCrudeAirportIdentifier.AutoResizeColumns();
                dataGridViewCrudeAirportIdentifier.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                airportIdentifier.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        // links:
        //  docLink: http://sql2x.org/documentationLink/634adebf-e682-407b-bf2e-223610d00e66
        private void InitializeGridCrudeAirportIdentifier() {
            try {
                dataGridViewCrudeAirportIdentifier.Columns.Clear();
                dataGridViewCrudeAirportIdentifier.AutoGenerateColumns = false;
                dataGridViewCrudeAirportIdentifier.Columns.Add("AirportIdentifierTypeRcd","Airport Identifier Type");
                dataGridViewCrudeAirportIdentifier.Columns["AirportIdentifierTypeRcd"].DataPropertyName = "AirportIdentifierTypeRcd";
                dataGridViewCrudeAirportIdentifier.Columns.Add("AirportIdentifierCode","Airport Identifier Code");
                dataGridViewCrudeAirportIdentifier.Columns["AirportIdentifierCode"].DataPropertyName = "AirportIdentifierCode";
                dataGridViewCrudeAirportIdentifier.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeAirportIdentifier.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeAirportIdentifier.Columns.Add("AirportIdentifierId","Airport Identifier");
                dataGridViewCrudeAirportIdentifier.Columns["AirportIdentifierId"].DataPropertyName = "AirportIdentifierId";
                dataGridViewCrudeAirportIdentifier.Columns["AirportIdentifierId"].Visible = false;
                dataGridViewCrudeAirportIdentifier.Columns.Add("AirportId","Airport");
                dataGridViewCrudeAirportIdentifier.Columns["AirportId"].DataPropertyName = "AirportId";
                dataGridViewCrudeAirportIdentifier.Columns["AirportId"].Visible = false;
                dataGridViewCrudeAirportIdentifier.Columns.Add("ExtensionData", "");
                dataGridViewCrudeAirportIdentifier.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeAirportIdentifier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeAirportIdentifier.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
