using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightScheduleHistoryDurian : UserControl {
        
        public FlightScheduleHistoryDurian() {
           InitializeComponent();
           InitializeGridFlightScheduleHistory();
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewFlightScheduleHistory.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.Guid FlightScheduleId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewFlightScheduleHistory.CurrentRow.Cells["FlightScheduleId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string AirlineIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightScheduleHistory.CurrentRow.Cells["AirlineIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string AirlineName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightScheduleHistory.CurrentRow.Cells["AirlineName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string FlightNumber {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightScheduleHistory.CurrentRow.Cells["FlightNumber"].Value; else return String.Empty;;
            }
        }
        
        public virtual string AircraftTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightScheduleHistory.CurrentRow.Cells["AircraftTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DepartureAirportIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightScheduleHistory.CurrentRow.Cells["DepartureAirportIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DepartureAirportName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightScheduleHistory.CurrentRow.Cells["DepartureAirportName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ArrivalAirportIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightScheduleHistory.CurrentRow.Cells["ArrivalAirportIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ArrivalAirportName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightScheduleHistory.CurrentRow.Cells["ArrivalAirportName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime FromDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewFlightScheduleHistory.CurrentRow.Cells["FromDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.DateTime UntilDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewFlightScheduleHistory.CurrentRow.Cells["UntilDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual int SegmentCount {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewFlightScheduleHistory.CurrentRow.Cells["SegmentCount"].Value; else return 0;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewFlightScheduleHistory.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewFlightScheduleHistory_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshFlightScheduleHistory(System.Guid flightScheduleId) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewFlightScheduleHistory.CurrentRow != null)
                    position = dataGridViewFlightScheduleHistory.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new ScheduleSearchServiceClient().FlightScheduleHistory(flightScheduleId);
                dataGridViewFlightScheduleHistory.AutoGenerateColumns = true;
                dataGridViewFlightScheduleHistory.DataSource = bindingSource;
                dataGridViewFlightScheduleHistory.AutoResizeColumns();

                // position to previous row
                if (dataGridViewFlightScheduleHistory.Rows.Count > 0) { 
                    dataGridViewFlightScheduleHistory.CurrentCell = 
                        dataGridViewFlightScheduleHistory.Rows[position].Cells[1];
                    dataGridViewFlightScheduleHistory.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridFlightScheduleHistory() {
            dataGridViewFlightScheduleHistory.Columns.Clear();
            dataGridViewFlightScheduleHistory.AutoGenerateColumns = false;
            dataGridViewFlightScheduleHistory.Columns.Add("DateTime","Date Time");
            dataGridViewFlightScheduleHistory.Columns.Add("FlightScheduleId","Flight Schedule Id");
            dataGridViewFlightScheduleHistory.Columns.Add("AirlineIdentifierCode","Airline Identifier Code");
            dataGridViewFlightScheduleHistory.Columns.Add("AirlineName","Airline Name");
            dataGridViewFlightScheduleHistory.Columns.Add("FlightNumber","Flight Number");
            dataGridViewFlightScheduleHistory.Columns.Add("AircraftTypeName","Aircraft Type Name");
            dataGridViewFlightScheduleHistory.Columns.Add("DepartureAirportIdentifierCode","Departure Airport Identifier Code");
            dataGridViewFlightScheduleHistory.Columns.Add("DepartureAirportName","Departure Airport Name");
            dataGridViewFlightScheduleHistory.Columns.Add("ArrivalAirportIdentifierCode","Arrival Airport Identifier Code");
            dataGridViewFlightScheduleHistory.Columns.Add("ArrivalAirportName","Arrival Airport Name");
            dataGridViewFlightScheduleHistory.Columns.Add("FromDateTime","From Date Time");
            dataGridViewFlightScheduleHistory.Columns.Add("UntilDateTime","Until Date Time");
            dataGridViewFlightScheduleHistory.Columns.Add("SegmentCount","Segment Count");
            dataGridViewFlightScheduleHistory.Columns.Add("ExtensionData", "");
            dataGridViewFlightScheduleHistory.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewFlightScheduleHistory.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewFlightScheduleHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewFlightScheduleHistory.AutoResizeColumns();
        }
    }
}
