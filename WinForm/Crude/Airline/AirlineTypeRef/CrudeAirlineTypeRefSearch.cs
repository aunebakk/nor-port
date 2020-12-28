﻿/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 1.0
  http://sql2x.org/
  Generated Date: 12/27/2020 11:15:08 PM
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
    public partial class CrudeAirlineTypeRefSearch : Form {
        
        // the following fields holds initial state for foreign key's
        // links:
        //  docLink: http://sql2x.org/documentationLink/295992ed-7cde-4e32-bf12-1e9163411a58
        private System.Guid _userId;
        
        // Constructs the form with a Grid and Search button which is default on Enter
        //  and a Close button which works with the esc key
        // links:
        //  docLink: http://sql2x.org/documentationLink/4b63dffb-c4e4-44d4-8efd-0313f43db503
        public CrudeAirlineTypeRefSearch() {
            InitializeComponent();
            InitializeGridCrudeAirlineTypeRef();
            this.AcceptButton = buttonCrudeAirlineTypeRefSearch;
            this.CancelButton = buttonClose;
        }
        
        // shows the form with initial values for comboboxes and pickers
        //  an search is done with these initial values
        // links:
        //  docLink: http://sql2x.org/documentationLink/5a2d259e-c278-4e61-8414-4f659db90878
        public void Show(System.Guid userId) {
            try {
                _userId = userId;

                RefreshCrudeAirlineTypeRef();

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
        private void buttonCrudeAirlineTypeRefEdit_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeAirlineTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeAirlineTypeRef.CurrentRow.Cells["AirlineTypeRcd"].Value,_userId);
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
        private void buttonCrudeAirlineTypeRefAdd_Click(object sender, EventArgs e) {
            try {
                var editForm = new CrudeAirlineTypeRefEdit();
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
        private void dataGridViewCrudeAirlineTypeRef_DoubleClick(object sender, EventArgs e) {
            try {
                var editForm = new CrudeAirlineTypeRefEdit();
                editForm.MdiParent = this.MdiParent;
                editForm.ShowAsEdit((System.String) dataGridViewCrudeAirlineTypeRef.CurrentRow.Cells["AirlineTypeRcd"].Value,_userId);
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
        private void buttonCrudeAirlineTypeRefSearch_Click(object sender, EventArgs e) {
            try {
                RefreshCrudeAirlineTypeRef();
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
        public void RefreshCrudeAirlineTypeRef() {
            var airlineTypeRef = new CrudeAirlineTypeRefServiceClient();

            try {
                var bindingSource = new BindingSource();
                bindingSource.DataSource = airlineTypeRef.FetchWithFilter(
                             textBoxAirlineType.Text
                            ,textBoxAirlineTypeName.Text
                            ,Guid.Empty
                            ,DateTime.MinValue
                            );
                dataGridViewCrudeAirlineTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeAirlineTypeRef.DataSource = bindingSource;
                dataGridViewCrudeAirlineTypeRef.AutoResizeColumns();
                dataGridViewCrudeAirlineTypeRef.Refresh();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            } finally {
                airlineTypeRef.Close();
            }
        }
        
        // initialize the grid, hiding fields like guids and images
        // links:
        //  docLink: http://sql2x.org/documentationLink/634adebf-e682-407b-bf2e-223610d00e66
        private void InitializeGridCrudeAirlineTypeRef() {
            try {
                dataGridViewCrudeAirlineTypeRef.Columns.Clear();
                dataGridViewCrudeAirlineTypeRef.AutoGenerateColumns = false;
                dataGridViewCrudeAirlineTypeRef.Columns.Add("AirlineTypeName","Airline Type Name");
                dataGridViewCrudeAirlineTypeRef.Columns["AirlineTypeName"].DataPropertyName = "AirlineTypeName";
                dataGridViewCrudeAirlineTypeRef.Columns.Add("AirlineTypeRcd","Airline Type");
                dataGridViewCrudeAirlineTypeRef.Columns["AirlineTypeRcd"].DataPropertyName = "AirlineTypeRcd";
                dataGridViewCrudeAirlineTypeRef.Columns.Add("DateTime","Date Time");
                dataGridViewCrudeAirlineTypeRef.Columns["DateTime"].DataPropertyName = "DateTime";
                dataGridViewCrudeAirlineTypeRef.Columns.Add("ExtensionData", "");
                dataGridViewCrudeAirlineTypeRef.Columns["ExtensionData"].Visible = false;

                dataGridViewCrudeAirlineTypeRef.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewCrudeAirlineTypeRef.AutoResizeColumns();
            } catch ( Exception ex ) {
                if ( ex == null )
                    { }
                else
                    System.Diagnostics.Debugger.Break ();
            }
        }
    }
}