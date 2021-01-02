using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightSegmentsScheduleDurian : UserControl {
        
        public FlightSegmentsScheduleDurian() {
           InitializeComponent();
           InitializeGridFlightSegmentsSchedule();
        }
        
        public virtual System.Guid FlightScheduleId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewFlightSegmentsSchedule.CurrentRow.Cells["FlightScheduleId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.Guid FlightScheduleSegmentId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewFlightSegmentsSchedule.CurrentRow.Cells["FlightScheduleSegmentId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string AirlineIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightSegmentsSchedule.CurrentRow.Cells["AirlineIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string FlightNumber {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightSegmentsSchedule.CurrentRow.Cells["FlightNumber"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DepartureAirportIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightSegmentsSchedule.CurrentRow.Cells["DepartureAirportIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DepartureAirportName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightSegmentsSchedule.CurrentRow.Cells["DepartureAirportName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ArrivalAirportIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightSegmentsSchedule.CurrentRow.Cells["ArrivalAirportIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ArrivalAirportName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightSegmentsSchedule.CurrentRow.Cells["ArrivalAirportName"].Value; else return String.Empty;;
            }
        }
        
        public virtual int LogicalSegmentNumber {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewFlightSegmentsSchedule.CurrentRow.Cells["LogicalSegmentNumber"].Value; else return 0;;
            }
        }
        
        public virtual int PhysicalSegmentNumber {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewFlightSegmentsSchedule.CurrentRow.Cells["PhysicalSegmentNumber"].Value; else return 0;;
            }
        }
        
        public virtual System.TimeSpan DepartureTime {
            get {
                if (!DesignMode) return (System.TimeSpan) dataGridViewFlightSegmentsSchedule.CurrentRow.Cells["DepartureTime"].Value; else return TimeSpan.MinValue;;
            }
        }
        
        public virtual System.TimeSpan ArrivalTime {
            get {
                if (!DesignMode) return (System.TimeSpan) dataGridViewFlightSegmentsSchedule.CurrentRow.Cells["ArrivalTime"].Value; else return TimeSpan.MinValue;;
            }
        }
        
        public virtual string DepartureGate {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightSegmentsSchedule.CurrentRow.Cells["DepartureGate"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ArrivalGate {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightSegmentsSchedule.CurrentRow.Cells["ArrivalGate"].Value; else return String.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewFlightSegmentsSchedule.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewFlightSegmentsSchedule_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshFlightSegmentsSchedule(System.Guid flightScheduleId) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewFlightSegmentsSchedule.CurrentRow != null)
                    position = dataGridViewFlightSegmentsSchedule.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new ScheduleSearchServiceClient().FlightSegmentsSchedule(flightScheduleId);
                dataGridViewFlightSegmentsSchedule.AutoGenerateColumns = true;
                dataGridViewFlightSegmentsSchedule.DataSource = bindingSource;
                dataGridViewFlightSegmentsSchedule.AutoResizeColumns();

                // position to previous row
                if (dataGridViewFlightSegmentsSchedule.Rows.Count > 0) { 
                    dataGridViewFlightSegmentsSchedule.CurrentCell = 
                        dataGridViewFlightSegmentsSchedule.Rows[position].Cells[1];
                    dataGridViewFlightSegmentsSchedule.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridFlightSegmentsSchedule() {
            dataGridViewFlightSegmentsSchedule.Columns.Clear();
            dataGridViewFlightSegmentsSchedule.AutoGenerateColumns = false;
            dataGridViewFlightSegmentsSchedule.Columns.Add("FlightScheduleId","Flight Schedule Id");
            dataGridViewFlightSegmentsSchedule.Columns.Add("FlightScheduleSegmentId","Flight Schedule Segment Id");
            dataGridViewFlightSegmentsSchedule.Columns.Add("AirlineIdentifierCode","Airline Identifier Code");
            dataGridViewFlightSegmentsSchedule.Columns.Add("FlightNumber","Flight Number");
            dataGridViewFlightSegmentsSchedule.Columns.Add("DepartureAirportIdentifierCode","Departure Airport Identifier Code");
            dataGridViewFlightSegmentsSchedule.Columns.Add("DepartureAirportName","Departure Airport Name");
            dataGridViewFlightSegmentsSchedule.Columns.Add("ArrivalAirportIdentifierCode","Arrival Airport Identifier Code");
            dataGridViewFlightSegmentsSchedule.Columns.Add("ArrivalAirportName","Arrival Airport Name");
            dataGridViewFlightSegmentsSchedule.Columns.Add("LogicalSegmentNumber","Logical Segment Number");
            dataGridViewFlightSegmentsSchedule.Columns.Add("PhysicalSegmentNumber","Physical Segment Number");
            dataGridViewFlightSegmentsSchedule.Columns.Add("DepartureTime","Departure Time");
            dataGridViewFlightSegmentsSchedule.Columns.Add("ArrivalTime","Arrival Time");
            dataGridViewFlightSegmentsSchedule.Columns.Add("DepartureGate","Departure Gate");
            dataGridViewFlightSegmentsSchedule.Columns.Add("ArrivalGate","Arrival Gate");
            dataGridViewFlightSegmentsSchedule.Columns.Add("ExtensionData", "");
            dataGridViewFlightSegmentsSchedule.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewFlightSegmentsSchedule.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewFlightSegmentsSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewFlightSegmentsSchedule.AutoResizeColumns();
        }
    }
}
