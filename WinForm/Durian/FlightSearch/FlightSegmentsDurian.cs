using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class FlightSegmentsDurian : UserControl {
        
        public FlightSegmentsDurian() {
           InitializeComponent();
           InitializeGridFlightSegments();
        }
        
        public virtual System.Guid FlightId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewFlightSegments.CurrentRow.Cells["FlightId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.Guid FlightSegmentId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewFlightSegments.CurrentRow.Cells["FlightSegmentId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string AirlineIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightSegments.CurrentRow.Cells["AirlineIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string FlightNumber {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightSegments.CurrentRow.Cells["FlightNumber"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DepartureAirportIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightSegments.CurrentRow.Cells["DepartureAirportIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DepartureAirportName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightSegments.CurrentRow.Cells["DepartureAirportName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ArrivalAirportIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightSegments.CurrentRow.Cells["ArrivalAirportIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ArrivalAirportName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightSegments.CurrentRow.Cells["ArrivalAirportName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime FromDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewFlightSegments.CurrentRow.Cells["FromDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.DateTime UntilDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewFlightSegments.CurrentRow.Cells["UntilDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual string DepartureGate {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightSegments.CurrentRow.Cells["DepartureGate"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ArrivalGate {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightSegments.CurrentRow.Cells["ArrivalGate"].Value; else return String.Empty;;
            }
        }
        
        public virtual int LogicalSegmentNumber {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewFlightSegments.CurrentRow.Cells["LogicalSegmentNumber"].Value; else return 0;;
            }
        }
        
        public virtual int PhysicalSegmentNumber {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewFlightSegments.CurrentRow.Cells["PhysicalSegmentNumber"].Value; else return 0;;
            }
        }
        
        public virtual string LastDateTimeTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFlightSegments.CurrentRow.Cells["LastDateTimeTypeName"].Value; else return String.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewFlightSegments.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewFlightSegments_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshFlightSegments(System.Guid flightId) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewFlightSegments.CurrentRow != null)
                    position = dataGridViewFlightSegments.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new FlightSearchServiceClient().FlightSegments(flightId);
                dataGridViewFlightSegments.AutoGenerateColumns = true;
                dataGridViewFlightSegments.DataSource = bindingSource;
                dataGridViewFlightSegments.AutoResizeColumns();

                // position to previous row
                if (dataGridViewFlightSegments.Rows.Count > 0) { 
                    dataGridViewFlightSegments.CurrentCell = 
                        dataGridViewFlightSegments.Rows[position].Cells[1];
                    dataGridViewFlightSegments.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridFlightSegments() {
            dataGridViewFlightSegments.Columns.Clear();
            dataGridViewFlightSegments.AutoGenerateColumns = false;
            dataGridViewFlightSegments.Columns.Add("FlightId","Flight Id");
            dataGridViewFlightSegments.Columns.Add("FlightSegmentId","Flight Segment Id");
            dataGridViewFlightSegments.Columns.Add("AirlineIdentifierCode","Airline Identifier Code");
            dataGridViewFlightSegments.Columns.Add("FlightNumber","Flight Number");
            dataGridViewFlightSegments.Columns.Add("DepartureAirportIdentifierCode","Departure Airport Identifier Code");
            dataGridViewFlightSegments.Columns.Add("DepartureAirportName","Departure Airport Name");
            dataGridViewFlightSegments.Columns.Add("ArrivalAirportIdentifierCode","Arrival Airport Identifier Code");
            dataGridViewFlightSegments.Columns.Add("ArrivalAirportName","Arrival Airport Name");
            dataGridViewFlightSegments.Columns.Add("FromDateTime","From Date Time");
            dataGridViewFlightSegments.Columns.Add("UntilDateTime","Until Date Time");
            dataGridViewFlightSegments.Columns.Add("DepartureGate","Departure Gate");
            dataGridViewFlightSegments.Columns.Add("ArrivalGate","Arrival Gate");
            dataGridViewFlightSegments.Columns.Add("LogicalSegmentNumber","Logical Segment Number");
            dataGridViewFlightSegments.Columns.Add("PhysicalSegmentNumber","Physical Segment Number");
            dataGridViewFlightSegments.Columns.Add("LastDateTimeTypeName","Last Date Time Type Name");
            dataGridViewFlightSegments.Columns.Add("ExtensionData", "");
            dataGridViewFlightSegments.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewFlightSegments.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewFlightSegments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewFlightSegments.AutoResizeColumns();
        }
    }
}
