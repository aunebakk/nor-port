using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class AirportsAvailableWithFilterDurian : UserControl {
        
        public AirportsAvailableWithFilterDurian() {
           InitializeComponent();
           InitializeGridAirportsAvailableWithFilter();
        }
        
        public virtual System.Guid AirportId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewAirportsAvailableWithFilter.CurrentRow.Cells["AirportId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string AirportIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewAirportsAvailableWithFilter.CurrentRow.Cells["AirportIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string AirportName {
            get {
                if (!DesignMode) return (System.String) dataGridViewAirportsAvailableWithFilter.CurrentRow.Cells["AirportName"].Value; else return String.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewAirportsAvailableWithFilter.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewAirportsAvailableWithFilter_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshAirportsAvailableWithFilter(System.Guid departureAirportId, System.Guid arrivalAirportId, System.DateTime fromDateTime, System.DateTime untilDateTime) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewAirportsAvailableWithFilter.CurrentRow != null)
                    position = dataGridViewAirportsAvailableWithFilter.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new FlightSearchServiceClient().AirportsAvailableWithFilter(departureAirportId,arrivalAirportId,fromDateTime,untilDateTime);
                dataGridViewAirportsAvailableWithFilter.AutoGenerateColumns = true;
                dataGridViewAirportsAvailableWithFilter.DataSource = bindingSource;
                dataGridViewAirportsAvailableWithFilter.AutoResizeColumns();

                // position to previous row
                if (dataGridViewAirportsAvailableWithFilter.Rows.Count > 0) { 
                    dataGridViewAirportsAvailableWithFilter.CurrentCell = 
                        dataGridViewAirportsAvailableWithFilter.Rows[position].Cells[1];
                    dataGridViewAirportsAvailableWithFilter.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridAirportsAvailableWithFilter() {
            dataGridViewAirportsAvailableWithFilter.Columns.Clear();
            dataGridViewAirportsAvailableWithFilter.AutoGenerateColumns = false;
            dataGridViewAirportsAvailableWithFilter.Columns.Add("AirportId","Airport Id");
            dataGridViewAirportsAvailableWithFilter.Columns.Add("AirportIdentifierCode","Airport Identifier Code");
            dataGridViewAirportsAvailableWithFilter.Columns.Add("AirportName","Airport Name");
            dataGridViewAirportsAvailableWithFilter.Columns.Add("ExtensionData", "");
            dataGridViewAirportsAvailableWithFilter.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewAirportsAvailableWithFilter.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewAirportsAvailableWithFilter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAirportsAvailableWithFilter.AutoResizeColumns();
        }
    }
}
