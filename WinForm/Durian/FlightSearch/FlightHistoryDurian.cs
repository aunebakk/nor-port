using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightHistoryDurian : UserControl {
        
        public FlightHistoryDurian() {
           InitializeComponent();
           InitializeGridFlightHistory();
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewFlightHistory.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.Guid FlightId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewFlightHistory.CurrentRow.Cells["FlightId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string AirlineIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightHistory.CurrentRow.Cells["AirlineIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string AirlineName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightHistory.CurrentRow.Cells["AirlineName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string FlightNumber {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightHistory.CurrentRow.Cells["FlightNumber"].Value; else return String.Empty;;
            }
        }
        
        public virtual string AircraftTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightHistory.CurrentRow.Cells["AircraftTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DepartureAirportIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightHistory.CurrentRow.Cells["DepartureAirportIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DepartureAirportName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightHistory.CurrentRow.Cells["DepartureAirportName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ArrivalAirportIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightHistory.CurrentRow.Cells["ArrivalAirportIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ArrivalAirportName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightHistory.CurrentRow.Cells["ArrivalAirportName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime FromDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewFlightHistory.CurrentRow.Cells["FromDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.DateTime UntilDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewFlightHistory.CurrentRow.Cells["UntilDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual int SegmentCount {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewFlightHistory.CurrentRow.Cells["SegmentCount"].Value; else return 0;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewFlightHistory.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewFlightHistory_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshFlightHistory(System.Guid flightId) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewFlightHistory.CurrentRow != null)
                    position = dataGridViewFlightHistory.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new FlightSearchService().FlightHistory(flightId);
                dataGridViewFlightHistory.AutoGenerateColumns = true;
                dataGridViewFlightHistory.DataSource = bindingSource;
                dataGridViewFlightHistory.AutoResizeColumns();

                // position to previous row
                if (dataGridViewFlightHistory.Rows.Count > 0) { 
                    dataGridViewFlightHistory.CurrentCell = 
                        dataGridViewFlightHistory.Rows[position].Cells[1];
                    dataGridViewFlightHistory.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridFlightHistory() {
            dataGridViewFlightHistory.Columns.Clear();
            dataGridViewFlightHistory.AutoGenerateColumns = false;
            dataGridViewFlightHistory.Columns.Add("DateTime","Date Time");
            dataGridViewFlightHistory.Columns.Add("FlightId","Flight Id");
            dataGridViewFlightHistory.Columns.Add("AirlineIdentifierCode","Airline Identifier Code");
            dataGridViewFlightHistory.Columns.Add("AirlineName","Airline Name");
            dataGridViewFlightHistory.Columns.Add("FlightNumber","Flight Number");
            dataGridViewFlightHistory.Columns.Add("AircraftTypeName","Aircraft Type Name");
            dataGridViewFlightHistory.Columns.Add("DepartureAirportIdentifierCode","Departure Airport Identifier Code");
            dataGridViewFlightHistory.Columns.Add("DepartureAirportName","Departure Airport Name");
            dataGridViewFlightHistory.Columns.Add("ArrivalAirportIdentifierCode","Arrival Airport Identifier Code");
            dataGridViewFlightHistory.Columns.Add("ArrivalAirportName","Arrival Airport Name");
            dataGridViewFlightHistory.Columns.Add("FromDateTime","From Date Time");
            dataGridViewFlightHistory.Columns.Add("UntilDateTime","Until Date Time");
            dataGridViewFlightHistory.Columns.Add("SegmentCount","Segment Count");
            dataGridViewFlightHistory.Columns.Add("ExtensionData", "");
            dataGridViewFlightHistory.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewFlightHistory.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewFlightHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewFlightHistory.AutoResizeColumns();
        }
    }
}
