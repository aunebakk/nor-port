using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightScheduleDurian : UserControl {
        
        public FlightScheduleDurian() {
           InitializeComponent();
           InitializeGridFlightSchedule();
        }
        
        public virtual System.Guid FlightScheduleId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewFlightSchedule.CurrentRow.Cells["FlightScheduleId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string AirlineIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightSchedule.CurrentRow.Cells["AirlineIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string AirlineName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightSchedule.CurrentRow.Cells["AirlineName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string FlightNumber {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightSchedule.CurrentRow.Cells["FlightNumber"].Value; else return String.Empty;;
            }
        }
        
        public virtual string AircraftTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightSchedule.CurrentRow.Cells["AircraftTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DepartureAirportIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightSchedule.CurrentRow.Cells["DepartureAirportIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DepartureAirportName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightSchedule.CurrentRow.Cells["DepartureAirportName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ArrivalAirportIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightSchedule.CurrentRow.Cells["ArrivalAirportIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ArrivalAirportName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightSchedule.CurrentRow.Cells["ArrivalAirportName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime FromDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewFlightSchedule.CurrentRow.Cells["FromDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.DateTime UntilDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewFlightSchedule.CurrentRow.Cells["UntilDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual int SegmentCount {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewFlightSchedule.CurrentRow.Cells["SegmentCount"].Value; else return 0;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewFlightSchedule.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewFlightSchedule_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshFlightSchedule() {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewFlightSchedule.CurrentRow != null)
                    position = dataGridViewFlightSchedule.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new ScheduleSearchServiceClient().FlightSchedule();
                dataGridViewFlightSchedule.AutoGenerateColumns = true;
                dataGridViewFlightSchedule.DataSource = bindingSource;
                dataGridViewFlightSchedule.AutoResizeColumns();

                // position to previous row
                if (dataGridViewFlightSchedule.Rows.Count > 0) { 
                    dataGridViewFlightSchedule.CurrentCell = 
                        dataGridViewFlightSchedule.Rows[position].Cells[1];
                    dataGridViewFlightSchedule.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridFlightSchedule() {
            dataGridViewFlightSchedule.Columns.Clear();
            dataGridViewFlightSchedule.AutoGenerateColumns = false;
            dataGridViewFlightSchedule.Columns.Add("FlightScheduleId","Flight Schedule Id");
            dataGridViewFlightSchedule.Columns.Add("AirlineIdentifierCode","Airline Identifier Code");
            dataGridViewFlightSchedule.Columns.Add("AirlineName","Airline Name");
            dataGridViewFlightSchedule.Columns.Add("FlightNumber","Flight Number");
            dataGridViewFlightSchedule.Columns.Add("AircraftTypeName","Aircraft Type Name");
            dataGridViewFlightSchedule.Columns.Add("DepartureAirportIdentifierCode","Departure Airport Identifier Code");
            dataGridViewFlightSchedule.Columns.Add("DepartureAirportName","Departure Airport Name");
            dataGridViewFlightSchedule.Columns.Add("ArrivalAirportIdentifierCode","Arrival Airport Identifier Code");
            dataGridViewFlightSchedule.Columns.Add("ArrivalAirportName","Arrival Airport Name");
            dataGridViewFlightSchedule.Columns.Add("FromDateTime","From Date Time");
            dataGridViewFlightSchedule.Columns.Add("UntilDateTime","Until Date Time");
            dataGridViewFlightSchedule.Columns.Add("SegmentCount","Segment Count");
            dataGridViewFlightSchedule.Columns.Add("ExtensionData", "");
            dataGridViewFlightSchedule.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewFlightSchedule.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewFlightSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewFlightSchedule.AutoResizeColumns();
        }
    }
}
