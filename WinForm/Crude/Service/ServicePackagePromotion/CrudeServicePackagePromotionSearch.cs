/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:15:15 PM
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
    public partial class CrudeServicePackagePromotionSearch : Form {
        
        // the following fields holds initial state for foreign key's
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a58
        private System.Guid _servicePackageId;
        
        private System.Guid _financialCurrencyId;
        
        private System.Guid _userId;
        
        private System.Guid _bookingId;
        
        private System.Guid _clientId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/4b63dffb-c4e4-44d4-8efd-0313f43db503
        public CrudeServicePackagePromotionSearch() {
            InitializeComponent();
            InitializeGridCrudeServicePackagePromotion();
            this.AcceptButton = buttonCrudeServicePackagePromotionSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        // links:
        //  docLink: http://sql2x.org/documentationLink/5a2d259e-c278-4e61-8414-4f659db90878
        public void Show(System.Guid servicePackageId, System.Guid financialCurrencyId, System.Guid userId, System.Guid bookingId, System.Guid clientId) {
            try {
                _servicePackageId = servicePackageId;
                _financialCurrencyId = financialCurrencyId;
                _userId = userId;
                userPicker.SelectedValue = userId;
                _bookingId = bookingId;
                _clientId = clientId;

                RefreshCrudeServicePackagePromotion();

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
        private void buttonCrudeServicePackagePromotionEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeServicePackagePromotionEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeServicePackagePromotion.CurrentRow.Cells["ServicePackagePromotionId"].Value);
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
        private void buttonCrudeServicePackagePromotionAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeServicePackagePromotionEdit();
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
        private void dataGridViewCrudeServicePackagePromotion_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeServicePackagePromotionEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.Guid) dataGridViewCrudeServicePackagePromotion.CurrentRow.Cells["ServicePackagePromotionId"].Value);
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
        private void buttonCrudeServicePackagePromotionSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeServicePackagePromotion();
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
        public void RefreshCrudeServicePackagePromotion() {
            var servicePackagePromotion = new CrudeServicePackagePromotionServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = servicePackagePromotion.FetchWithFilter(
                             Guid.Empty
                            ,servicePackagePicker.SelectedValue
                            ,maskedTextBoxPromotionPriceAmount.Text == String.Empty ? 0 : Convert.ToDecimal(maskedTextBoxPromotionPriceAmount.Text)
                            ,financialCurrencyPicker.SelectedValue
                            ,Guid.Empty
                            ,DateTime.MinValue
                            ,Guid.Empty
                            ,clientPicker.SelectedValue
                            );
                dataGridViewCrudeServicePackagePromotion.AutoGenerateColumns = false;
                dataGridViewCrudeServicePackagePromotion.DataSource = bindingSource;
                dataGridViewCrudeServicePackagePromotion.AutoResizeColumns();
                dataGridViewCrudeServicePackagePromotion.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                servicePackagePromotion.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        // links:
        //  docLink: http://sql2x.org/documentationLink/634adebf-e682-407b-bf2e-223610d00e66
        private void InitializeGridCrudeServicePackagePromotion() {
            try {
                dataGridViewCrudeServicePackagePromotion.Columns.Clear();
                dataGridViewCrudeServicePackagePromotion.AutoGenerateColumns = false;
                dataGridViewCrudeServicePackagePromotion.Columns.Add("PromotionPriceAmount","Promotion Price Amount");
                dataGridViewCrudeServicePackagePromotion.Columns["PromotionPriceAmount"].DataPropertyName = "PromotionPriceAmount";
                dataGridViewCrudeServicePackagePromotion.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeServicePackagePromotion.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeServicePackagePromotion.Columns.Add("ServicePackagePromotionId","Service Package Promotion");
                dataGridViewCrudeServicePackagePromotion.Columns["ServicePackagePromotionId"].DataPropertyName = "ServicePackagePromotionId";
                dataGridViewCrudeServicePackagePromotion.Columns["ServicePackagePromotionId"].Visible = false;
                dataGridViewCrudeServicePackagePromotion.Columns.Add("ServicePackageId","Service Package");
                dataGridViewCrudeServicePackagePromotion.Columns["ServicePackageId"].DataPropertyName = "ServicePackageId";
                dataGridViewCrudeServicePackagePromotion.Columns["ServicePackageId"].Visible = false;
                dataGridViewCrudeServicePackagePromotion.Columns.Add("FinancialCurrencyId","Financial Currency");
                dataGridViewCrudeServicePackagePromotion.Columns["FinancialCurrencyId"].DataPropertyName = "FinancialCurrencyId";
                dataGridViewCrudeServicePackagePromotion.Columns["FinancialCurrencyId"].Visible = false;
                dataGridViewCrudeServicePackagePromotion.Columns.Add("BookingId","Booking");
                dataGridViewCrudeServicePackagePromotion.Columns["BookingId"].DataPropertyName = "BookingId";
                dataGridViewCrudeServicePackagePromotion.Columns["BookingId"].Visible = false;
                dataGridViewCrudeServicePackagePromotion.Columns.Add("ClientId","Client");
                dataGridViewCrudeServicePackagePromotion.Columns["ClientId"].DataPropertyName = "ClientId";
                dataGridViewCrudeServicePackagePromotion.Columns["ClientId"].Visible = false;
                dataGridViewCrudeServicePackagePromotion.Columns.Add("ExtensionData", "");
                dataGridViewCrudeServicePackagePromotion.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeServicePackagePromotion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeServicePackagePromotion.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}
