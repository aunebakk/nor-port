using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightsForPeriodDurian : UserControl {
        
        public FlightsForPeriodDurian() {
           InitializeComponent();
           InitializeGridFlightsForPeriod();
        }
        
        public virtual System.Guid FlightId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewFlightsForPeriod.CurrentRow.Cells["FlightId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string AirlineIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsForPeriod.CurrentRow.Cells["AirlineIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string FlightNumber {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsForPeriod.CurrentRow.Cells["FlightNumber"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DepartureAirportIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsForPeriod.CurrentRow.Cells["DepartureAirportIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DepartureAirportName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsForPeriod.CurrentRow.Cells["DepartureAirportName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ArrivalAirportIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsForPeriod.CurrentRow.Cells["ArrivalAirportIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ArrivalAirportName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsForPeriod.CurrentRow.Cells["ArrivalAirportName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime FromDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewFlightsForPeriod.CurrentRow.Cells["FromDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.DateTime UntilDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewFlightsForPeriod.CurrentRow.Cells["UntilDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual string LastDateTimeTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsForPeriod.CurrentRow.Cells["LastDateTimeTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime PlannedDepartureDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewFlightsForPeriod.CurrentRow.Cells["PlannedDepartureDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.DateTime EstimatedDepartureDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewFlightsForPeriod.CurrentRow.Cells["EstimatedDepartureDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual string Comment {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightsForPeriod.CurrentRow.Cells["Comment"].Value; else return String.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewFlightsForPeriod.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewFlightsForPeriod_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshFlightsForPeriod(System.Guid departureAirportId, System.Guid arrivalAirportId, System.DateTime fromDateTime, System.DateTime untilDateTime) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewFlightsForPeriod.CurrentRow != null)
                    position = dataGridViewFlightsForPeriod.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new FlightSearchService().FlightsForPeriod(departureAirportId,arrivalAirportId,fromDateTime,untilDateTime);
                dataGridViewFlightsForPeriod.AutoGenerateColumns = true;
                dataGridViewFlightsForPeriod.DataSource = bindingSource;
                dataGridViewFlightsForPeriod.AutoResizeColumns();

                // position to previous row
                if (dataGridViewFlightsForPeriod.Rows.Count > 0) { 
                    dataGridViewFlightsForPeriod.CurrentCell = 
                        dataGridViewFlightsForPeriod.Rows[position].Cells[1];
                    dataGridViewFlightsForPeriod.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridFlightsForPeriod() {
            dataGridViewFlightsForPeriod.Columns.Clear();
            dataGridViewFlightsForPeriod.AutoGenerateColumns = false;
            dataGridViewFlightsForPeriod.Columns.Add("FlightId","Flight Id");
            dataGridViewFlightsForPeriod.Columns.Add("AirlineIdentifierCode","Airline Identifier Code");
            dataGridViewFlightsForPeriod.Columns.Add("FlightNumber","Flight Number");
            dataGridViewFlightsForPeriod.Columns.Add("DepartureAirportIdentifierCode","Departure Airport Identifier Code");
            dataGridViewFlightsForPeriod.Columns.Add("DepartureAirportName","Departure Airport Name");
            dataGridViewFlightsForPeriod.Columns.Add("ArrivalAirportIdentifierCode","Arrival Airport Identifier Code");
            dataGridViewFlightsForPeriod.Columns.Add("ArrivalAirportName","Arrival Airport Name");
            dataGridViewFlightsForPeriod.Columns.Add("FromDateTime","From Date Time");
            dataGridViewFlightsForPeriod.Columns.Add("UntilDateTime","Until Date Time");
            dataGridViewFlightsForPeriod.Columns.Add("LastDateTimeTypeName","Last Date Time Type Name");
            dataGridViewFlightsForPeriod.Columns.Add("PlannedDepartureDateTime","Planned Departure Date Time");
            dataGridViewFlightsForPeriod.Columns.Add("EstimatedDepartureDateTime","Estimated Departure Date Time");
            dataGridViewFlightsForPeriod.Columns.Add("Comment","Comment");
            dataGridViewFlightsForPeriod.Columns.Add("ExtensionData", "");
            dataGridViewFlightsForPeriod.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewFlightsForPeriod.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewFlightsForPeriod.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewFlightsForPeriod.AutoResizeColumns();
        }
    }
}
