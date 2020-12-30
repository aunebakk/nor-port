/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/30/2020 5:21:49 AM
  From Machine: DESKTOP-LSRVP12
  Template: sql2x.TemplateCrudeWinForm.WinFormGenerateSearchStyle3
*/
using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

// Client WinForm Layer
// the Client WinForm Layer uses the Proxy Layer to tie into SOAP services
// links:
//  client winform layer: https://docs.microsoft.com/en-us/dotnet/framework/winforms/
//  docLink: http://sql2x.org/documentationLink/d8f07424-3438-4ff9-8853-3976c1227bad
namespace SolutionNorSolutionPort.UserInterface {

    // this form class is used to consume Crude SOAP Services through a WCF Proxy Client
    // links:
    //  docLink: http://sql2x.org/documentationLink/9dd1c3bf-68b5-40b4-868a-735ee7394422
    public partial class CrudeAirlineIdentifierSearch : Form {
        
        // the following fields holds initial state for foreign key's
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a58
        private string _airlineIdentifierTypeRcd;
        
        private System.Guid _airlineId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/4b63dffb-c4e4-44d4-8efd-0313f43db503
        public CrudeAirlineIdentifierSearch() {
            InitializeComponent();
            InitializeGridCrudeAirlineIdentifier();
            this.AcceptButton = buttonCrudeAirlineIdentifierSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        // links:
        //  docLink: http://sql2x.org/documentationLink/5a2d259e-c278-4e61-8414-4f659db90878
        public void Show(string airlineIdentifierTypeRcd, System.Guid airlineId, System.Guid userId) {
            try {
                _airlineIdentifierTypeRcd = airlineIdentifierTypeRcd;
                _airlineId = airlineId;
                _userId = userId;
                userPicker.SelectedValue = userId;

                RefreshCrudeAirlineIdentifier();

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
        private void buttonCrudeAirlineIdentifierEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeAirlineIdentifierEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeAirlineIdentifier.CurrentRow.Cells["AirlineIdentifierId"].Value);
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
        private void buttonCrudeAirlineIdentifierAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeAirlineIdentifierEdit();
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
        private void dataGridViewCrudeAirlineIdentifier_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeAirlineIdentifierEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeAirlineIdentifier.CurrentRow.Cells["AirlineIdentifierId"].Value);
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
        private void buttonCrudeAirlineIdentifierSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeAirlineIdentifier();
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
        public void RefreshCrudeAirlineIdentifier() {
            var airlineIdentifier = new CrudeAirlineIdentifierServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = airlineIdentifier.FetchWithFilter(
                             Guid.Empty
                            ,airlinePicker.SelectedValue
                            ,airlineIdentifierTypeRefCombo.Text
                            ,textBoxAirlineIdentifierCode.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeAirlineIdentifier.AutoGenerateColumns = false;
                dataGridViewCrudeAirlineIdentifier.DataSource = bindingSource;
                dataGridViewCrudeAirlineIdentifier.AutoResizeColumns();
                dataGridViewCrudeAirlineIdentifier.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                airlineIdentifier.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        // links:
        //  docLink: http://sql2x.org/documentationLink/634adebf-e682-407b-bf2e-223610d00e66
        private void InitializeGridCrudeAirlineIdentifier() {
            try {
                dataGridViewCrudeAirlineIdentifier.Columns.Clear();
                dataGridViewCrudeAirlineIdentifier.AutoGenerateColumns = false;
                dataGridViewCrudeAirlineIdentifier.Columns.Add("AirlineIdentifierTypeRcd","Airline Identifier Type");
                dataGridViewCrudeAirlineIdentifier.Columns["AirlineIdentifierTypeRcd"].DataPropertyName = "AirlineIdentifierTypeRcd";
                dataGridViewCrudeAirlineIdentifier.Columns.Add("AirlineIdentifierCode","Airline Identifier Code");
                dataGridViewCrudeAirlineIdentifier.Columns["AirlineIdentifierCode"].DataPropertyName = "AirlineIdentifierCode";
                dataGridViewCrudeAirlineIdentifier.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeAirlineIdentifier.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeAirlineIdentifier.Columns.Add("AirlineIdentifierId","Airline Identifier");
                dataGridViewCrudeAirlineIdentifier.Columns["AirlineIdentifierId"].DataPropertyName = "AirlineIdentifierId";
                dataGridViewCrudeAirlineIdentifier.Columns["AirlineIdentifierId"].Visible = false;
                dataGridViewCrudeAirlineIdentifier.Columns.Add("AirlineId","Airline");
                dataGridViewCrudeAirlineIdentifier.Columns["AirlineId"].DataPropertyName = "AirlineId";
                dataGridViewCrudeAirlineIdentifier.Columns["AirlineId"].Visible = false;
                dataGridViewCrudeAirlineIdentifier.Columns.Add("ExtensionData", "");
                dataGridViewCrudeAirlineIdentifier.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeAirlineIdentifier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeAirlineIdentifier.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
