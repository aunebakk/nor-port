/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/4/2021 9:58:59 PM
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
    public partial class CrudeFerrySearch : Form {
        
        // the following fields holds initial state for foreign key's
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a58
        private string _ferryTypeRcd;
        
        private System.Guid _productId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/4b63dffb-c4e4-44d4-8efd-0313f43db503
        public CrudeFerrySearch() {
            InitializeComponent();
            InitializeGridCrudeFerry();
            this.AcceptButton = buttonCrudeFerrySearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        // links:
        //  docLink: http://sql2x.org/documentationLink/5a2d259e-c278-4e61-8414-4f659db90878
        public void Show(string ferryTypeRcd, System.Guid productId, System.Guid userId) {
            try {
                _ferryTypeRcd = ferryTypeRcd;
                _productId = productId;
                _userId = userId;
                userPicker.SelectedValue = userId;

                RefreshCrudeFerry();

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
        private void buttonCrudeFerryEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFerryEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFerry.CurrentRow.Cells["FerryId"].Value);
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
        private void buttonCrudeFerryAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFerryEdit();
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
        private void dataGridViewCrudeFerry_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeFerryEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeFerry.CurrentRow.Cells["FerryId"].Value);
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
        private void buttonCrudeFerrySearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeFerry();
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
        public void RefreshCrudeFerry() {
            var ferry = new CrudeFerryServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = ferry.FetchWithFilter(
                             Guid.Empty
                            ,textBoxFerryName.Text
                            ,ferryTypeRefCombo.Text
                            ,Guid.Empty
                            ,dateTimePickerFirstFloatDateTime.Checked ? Convert.ToDateTime(dateTimePickerFirstFloatDateTime.Value): DateTime.MinValue
                            ,dateTimePickerOperationalDateTime.Checked ? Convert.ToDateTime(dateTimePickerOperationalDateTime.Value): DateTime.MinValue
                            ,textBoxEngineType.Text
                            ,maskedTextBoxPassengerCapacity.Text == String.Empty ? 0 : Convert.ToInt32(maskedTextBoxPassengerCapacity.Text)
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeFerry.AutoGenerateColumns = false;
                dataGridViewCrudeFerry.DataSource = bindingSource;
                dataGridViewCrudeFerry.AutoResizeColumns();
                dataGridViewCrudeFerry.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                ferry.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        // links:
        //  docLink: http://sql2x.org/documentationLink/634adebf-e682-407b-bf2e-223610d00e66
        private void InitializeGridCrudeFerry() {
            try {
                dataGridViewCrudeFerry.Columns.Clear();
                dataGridViewCrudeFerry.AutoGenerateColumns = false;
                dataGridViewCrudeFerry.Columns.Add("FerryName","Ferry Name");
                dataGridViewCrudeFerry.Columns["FerryName"].DataPropertyName = "FerryName";
                dataGridViewCrudeFerry.Columns.Add("FerryTypeRcd","Ferry Type");
                dataGridViewCrudeFerry.Columns["FerryTypeRcd"].DataPropertyName = "FerryTypeRcd";
                dataGridViewCrudeFerry.Columns.Add("EngineType","Engine Type");
                dataGridViewCrudeFerry.Columns["EngineType"].DataPropertyName = "EngineType";
                dataGridViewCrudeFerry.Columns.Add("PassengerCapacity","Passenger Capacity");
                dataGridViewCrudeFerry.Columns["PassengerCapacity"].DataPropertyName = "PassengerCapacity";
                dataGridViewCrudeFerry.Columns.Add("FirstFloatDateTime","First Float Date Time");
                dataGridViewCrudeFerry.Columns["FirstFloatDateTime"].DataPropertyName = "FirstFloatDateTime";
                dataGridViewCrudeFerry.Columns.Add("OperationalDateTime","Operational Date Time");
                dataGridViewCrudeFerry.Columns["OperationalDateTime"].DataPropertyName = "OperationalDateTime";
                dataGridViewCrudeFerry.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeFerry.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeFerry.Columns.Add("FerryId","Ferry");
                dataGridViewCrudeFerry.Columns["FerryId"].DataPropertyName = "FerryId";
                dataGridViewCrudeFerry.Columns["FerryId"].Visible = false;
                dataGridViewCrudeFerry.Columns.Add("ProductId","Product");
                dataGridViewCrudeFerry.Columns["ProductId"].DataPropertyName = "ProductId";
                dataGridViewCrudeFerry.Columns["ProductId"].Visible = false;
                dataGridViewCrudeFerry.Columns.Add("ExtensionData", "");
                dataGridViewCrudeFerry.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeFerry.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeFerry.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
