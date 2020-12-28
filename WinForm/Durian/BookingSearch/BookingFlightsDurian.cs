using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingFlightsDurian : UserControl {
        
        public BookingFlightsDurian() {
           InitializeComponent();
           InitializeGridBookingFlights();
        }
        
        public virtual string AirlineIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingFlights.CurrentRow.Cells["AirlineIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string FlightNumber {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingFlights.CurrentRow.Cells["FlightNumber"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DepartureAirportIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingFlights.CurrentRow.Cells["DepartureAirportIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DepartureAirportName {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingFlights.CurrentRow.Cells["DepartureAirportName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ArrivalAirportIdentifierCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingFlights.CurrentRow.Cells["ArrivalAirportIdentifierCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ArrivalAirportName {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingFlights.CurrentRow.Cells["ArrivalAirportName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime FromDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewBookingFlights.CurrentRow.Cells["FromDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.DateTime UntilDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewBookingFlights.CurrentRow.Cells["UntilDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual string Comment {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingFlights.CurrentRow.Cells["Comment"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid BookingFlightSegmentId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewBookingFlights.CurrentRow.Cells["BookingFlightSegmentId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewBookingFlights.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewBookingFlights_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshBookingFlights(System.Guid bookingId) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewBookingFlights.CurrentRow != null)
                    position = dataGridViewBookingFlights.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new BookingSearchService().BookingFlights(bookingId);
                dataGridViewBookingFlights.AutoGenerateColumns = true;
                dataGridViewBookingFlights.DataSource = bindingSource;
                dataGridViewBookingFlights.AutoResizeColumns();

                // position to previous row
                if (dataGridViewBookingFlights.Rows.Count > 0) { 
                    dataGridViewBookingFlights.CurrentCell = 
                        dataGridViewBookingFlights.Rows[position].Cells[1];
                    dataGridViewBookingFlights.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridBookingFlights() {
            dataGridViewBookingFlights.Columns.Clear();
            dataGridViewBookingFlights.AutoGenerateColumns = false;
            dataGridViewBookingFlights.Columns.Add("AirlineIdentifierCode","Airline Identifier Code");
            dataGridViewBookingFlights.Columns.Add("FlightNumber","Flight Number");
            dataGridViewBookingFlights.Columns.Add("DepartureAirportIdentifierCode","Departure Airport Identifier Code");
            dataGridViewBookingFlights.Columns.Add("DepartureAirportName","Departure Airport Name");
            dataGridViewBookingFlights.Columns.Add("ArrivalAirportIdentifierCode","Arrival Airport Identifier Code");
            dataGridViewBookingFlights.Columns.Add("ArrivalAirportName","Arrival Airport Name");
            dataGridViewBookingFlights.Columns.Add("FromDateTime","From Date Time");
            dataGridViewBookingFlights.Columns.Add("UntilDateTime","Until Date Time");
            dataGridViewBookingFlights.Columns.Add("Comment","Comment");
            dataGridViewBookingFlights.Columns.Add("BookingFlightSegmentId","Booking Flight Segment Id");
            dataGridViewBookingFlights.Columns.Add("ExtensionData", "");
            dataGridViewBookingFlights.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewBookingFlights.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewBookingFlights.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewBookingFlights.AutoResizeColumns();
        }
    }
}
