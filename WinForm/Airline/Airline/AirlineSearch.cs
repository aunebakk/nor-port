/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 1/3/2021 4:15:26 AM
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
    public partial class AirlineSearch : Form {
        
        // keep foreign keys as private members
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a59
        private string _airlineTypeRcd;
        
        private System.Guid _addressId;
        
        private System.Guid _productId;
        
        private System.Guid _userId;
        
        // Constructs the form with a Save button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/79943c87-e38f-4cb4-82f2-d55079e54b54
        public AirlineSearch() {
            InitializeComponent();
            InitializeGridAirline();
            this.AcceptButton = buttonAirlineSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with default values for comboboxes and pickers
        // links:
        //  docLink: http://sql2x.org/documentationLink/c25d8511-8577-4915-821a-4c7ec7a5b8ce
        public void Show(string airlineTypeRcd, System.Guid addressId, System.Guid productId, System.Guid userId) {
            _airlineTypeRcd = airlineTypeRcd;
            _addressId = addressId;
            _productId = productId;
            _userId = userId;
            userPicker.SelectedValue = userId;
            RefreshAirline();
            base.Show();
        }
        
        // bring up edit form for Airline
        // links:
        //  docLink: http://sql2x.org/documentationLink/883480d1-2639-43f1-9096-131194b043c8
        private void buttonAirlineEdit_Click(object sender, EventArgs e) {
            var editForm = new AirlineEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewAirline.CurrentRow.Cells["AirlineId"].Value);
        }
        
        // bring up add form for Airline
        // links:
        //  docLink: http://sql2x.org/documentationLink/99b0d247-c5de-47a0-a27a-a6825fb73541
        private void buttonAirlineAdd_Click(object sender, EventArgs e) {
            var editForm = new AirlineEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsAddByRules(_userId);
        }
        
        // bring up edit form for Airline
        // links:
        //  docLink: http://sql2x.org/documentationLink/c7fc6d72-476a-4d4b-b327-08e419db92a5
        private void dataGridViewAirline_DoubleClick(object sender, EventArgs e) {
            var editForm = new AirlineEdit();
            editForm.MdiParent = this.MdiParent;
            editForm.ShowAsEdit((System.Guid) dataGridViewAirline.CurrentRow.Cells["AirlineId"].Value);
        }
        
        // search Airline's using values from comboboxes and edit fields
        // links:
        //  docLink: http://sql2x.org/documentationLink/3d544c02-f541-4590-ac27-775c1f57bcea
        private void buttonAirlineSearch_Click(object sender, EventArgs e) {
            RefreshAirline();
        }
        
        // close the form
        // links:
        //  docLink: http://sql2x.org/documentationLink/6e648338-5d0d-4bf3-957e-07f4fe317d4b
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }
        
        // fetch Airline's from business layer
        // links:
        //  docLink: http://sql2x.org/documentationLink/75fb8ca9-978e-42eb-b15f-4a9f56dc6454
        public void RefreshAirline() {
            var airline = new AirlineSearchServiceClient();
            var bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = airline.GetAirlineIndexWithFilter();
                dataGridViewAirline.AutoGenerateColumns = false;
                dataGridViewAirline.DataSource = bindingSource;
                dataGridViewAirline.AutoResizeColumns();
                dataGridViewAirline.Refresh();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                airline.Close();
            }
        }
        
        // initialize grid forAirline's
        // links:
        //  docLink: http://sql2x.org/documentationLink/d6ea3697-5f07-488c-9680-d154a8dee287
        private void InitializeGridAirline() {
            dataGridViewAirline.Columns.Clear();
            dataGridViewAirline.AutoGenerateColumns = false;
            dataGridViewAirline.Columns.Add("AirlineName","Airline Name");
            dataGridViewAirline.Columns["AirlineName"].DataPropertyName = "AirlineName";
            dataGridViewAirline.Columns.Add("AirlineTypeName","Airline Type Name");
            dataGridViewAirline.Columns["AirlineTypeName"].DataPropertyName = "AirlineTypeName";
            dataGridViewAirline.Columns.Add("LegalName","Legal Name");
            dataGridViewAirline.Columns["LegalName"].DataPropertyName = "LegalName";
            dataGridViewAirline.Columns.Add("ProductName","Product Name");
            dataGridViewAirline.Columns["ProductName"].DataPropertyName = "ProductName";
            dataGridViewAirline.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewAirline.Columns["DefaultUserName"].DataPropertyName = "DefaultUserName";
            dataGridViewAirline.Columns.Add("AirlineTypeRcd","Airline Type");
            dataGridViewAirline.Columns["AirlineTypeRcd"].DataPropertyName = "AirlineTypeRcd";
            dataGridViewAirline.Columns.Add("AddressOne","Address One");
            dataGridViewAirline.Columns["AddressOne"].DataPropertyName = "AddressOne";
            dataGridViewAirline.Columns.Add("AddressTwo","Address Two");
            dataGridViewAirline.Columns["AddressTwo"].DataPropertyName = "AddressTwo";
            dataGridViewAirline.Columns.Add("AddressThree","Address Three");
            dataGridViewAirline.Columns["AddressThree"].DataPropertyName = "AddressThree";
            dataGridViewAirline.Columns.Add("City","City");
            dataGridViewAirline.Columns["City"].DataPropertyName = "City";
            dataGridViewAirline.Columns.Add("Street","Street");
            dataGridViewAirline.Columns["Street"].DataPropertyName = "Street";
            dataGridViewAirline.Columns.Add("State","State");
            dataGridViewAirline.Columns["State"].DataPropertyName = "State";
            dataGridViewAirline.Columns.Add("District","District");
            dataGridViewAirline.Columns["District"].DataPropertyName = "District";
            dataGridViewAirline.Columns.Add("Province","Province");
            dataGridViewAirline.Columns["Province"].DataPropertyName = "Province";
            dataGridViewAirline.Columns.Add("ZipCode","Zip Code");
            dataGridViewAirline.Columns["ZipCode"].DataPropertyName = "ZipCode";
            dataGridViewAirline.Columns.Add("PoBox","Po Box");
            dataGridViewAirline.Columns["PoBox"].DataPropertyName = "PoBox";
            dataGridViewAirline.Columns.Add("Comment","Comment");
            dataGridViewAirline.Columns["Comment"].DataPropertyName = "Comment";
            dataGridViewAirline.Columns.Add("AddressId","Address Id");
            dataGridViewAirline.Columns["AddressId"].DataPropertyName = "AddressId";
            dataGridViewAirline.Columns["AddressId"].Visible = false;
            dataGridViewAirline.Columns.Add("ProductId","Product Id");
            dataGridViewAirline.Columns["ProductId"].DataPropertyName = "ProductId";
            dataGridViewAirline.Columns["ProductId"].Visible = false;
            dataGridViewAirline.Columns.Add("StockMarketSymbol","Stock Market Symbol");
            dataGridViewAirline.Columns["StockMarketSymbol"].DataPropertyName = "StockMarketSymbol";
            dataGridViewAirline.Columns.Add("AircraftCount","Aircraft Count");
            dataGridViewAirline.Columns["AircraftCount"].DataPropertyName = "AircraftCount";
            dataGridViewAirline.Columns.Add("UserId","User Id");
            dataGridViewAirline.Columns["UserId"].DataPropertyName = "UserId";
            dataGridViewAirline.Columns["UserId"].Visible = false;
            dataGridViewAirline.Columns.Add("DateTime","Date Time");
            dataGridViewAirline.Columns["DateTime"].DataPropertyName = "DateTime";
            dataGridViewAirline.Columns.Add("AirlineId","Airline Id");
            dataGridViewAirline.Columns["AirlineId"].DataPropertyName = "AirlineId";
            dataGridViewAirline.Columns["AirlineId"].Visible = false;
            dataGridViewAirline.Columns.Add("ExtensionData", "");
            dataGridViewAirline.Columns["ExtensionData"].Visible = false;

            dataGridViewAirline.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAirline.AutoResizeColumns();
        }
    }
}
