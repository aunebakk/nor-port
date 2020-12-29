/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/29/2020 2:30:27 AM
  From Machine: DESKTOP-517I8BU
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
    public partial class CrudeCitySearch : Form {
        
        // the following fields holds initial state for foreign key's
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a58
        private System.Guid _countryId;
        
        private System.Guid _productId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/4b63dffb-c4e4-44d4-8efd-0313f43db503
        public CrudeCitySearch() {
            InitializeComponent();
            InitializeGridCrudeCity();
            this.AcceptButton = buttonCrudeCitySearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        // links:
        //  docLink: http://sql2x.org/documentationLink/5a2d259e-c278-4e61-8414-4f659db90878
        public void Show(System.Guid countryId, System.Guid productId, System.Guid userId) {
            try {
                _countryId = countryId;
                _productId = productId;
                _userId = userId;
                userPicker.SelectedValue = userId;

                RefreshCrudeCity();

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
        private void buttonCrudeCityEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeCityEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeCity.CurrentRow.Cells["CityId"].Value);
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
        private void buttonCrudeCityAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeCityEdit();
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
        private void dataGridViewCrudeCity_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeCityEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeCity.CurrentRow.Cells["CityId"].Value);
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
        private void buttonCrudeCitySearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeCity();
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
        public void RefreshCrudeCity() {
            var city = new CrudeCityServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = city.FetchWithFilter(
                             Guid.Empty
                            ,countryPicker.SelectedValue
                            ,textBoxCityCode.Text
                            ,textBoxCityName.Text
                            ,Guid.Empty
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeCity.AutoGenerateColumns = false;
                dataGridViewCrudeCity.DataSource = bindingSource;
                dataGridViewCrudeCity.AutoResizeColumns();
                dataGridViewCrudeCity.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                city.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        // links:
        //  docLink: http://sql2x.org/documentationLink/634adebf-e682-407b-bf2e-223610d00e66
        private void InitializeGridCrudeCity() {
            try {
                dataGridViewCrudeCity.Columns.Clear();
                dataGridViewCrudeCity.AutoGenerateColumns = false;
                dataGridViewCrudeCity.Columns.Add("CityName","City Name");
                dataGridViewCrudeCity.Columns["CityName"].DataPropertyName = "CityName";
                dataGridViewCrudeCity.Columns.Add("CityCode","City Code");
                dataGridViewCrudeCity.Columns["CityCode"].DataPropertyName = "CityCode";
                dataGridViewCrudeCity.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeCity.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeCity.Columns.Add("CityId","City");
                dataGridViewCrudeCity.Columns["CityId"].DataPropertyName = "CityId";
                dataGridViewCrudeCity.Columns["CityId"].Visible = false;
                dataGridViewCrudeCity.Columns.Add("CountryId","Country");
                dataGridViewCrudeCity.Columns["CountryId"].DataPropertyName = "CountryId";
                dataGridViewCrudeCity.Columns["CountryId"].Visible = false;
                dataGridViewCrudeCity.Columns.Add("ProductId","Product");
                dataGridViewCrudeCity.Columns["ProductId"].DataPropertyName = "ProductId";
                dataGridViewCrudeCity.Columns["ProductId"].Visible = false;
                dataGridViewCrudeCity.Columns.Add("ExtensionData", "");
                dataGridViewCrudeCity.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeCity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeCity.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
