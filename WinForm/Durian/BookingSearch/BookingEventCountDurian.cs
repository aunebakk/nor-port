using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingEventCountDurian : UserControl {
        
        public BookingEventCountDurian() {
           InitializeComponent();
           InitializeGridBookingEventCount();
        }
        
        public virtual int BookingContactCount {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewBookingEventCount.CurrentRow.Cells["BookingContactCount"].Value; else return 0;;
            }
        }
        
        public virtual int BookingIdentifierCount {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewBookingEventCount.CurrentRow.Cells["BookingIdentifierCount"].Value; else return 0;;
            }
        }
        
        public virtual int BookingServiceRequestCount {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewBookingEventCount.CurrentRow.Cells["BookingServiceRequestCount"].Value; else return 0;;
            }
        }
        
        public virtual int BookingEventCount {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewBookingEventCount.CurrentRow.Cells["BookingEventCount"].Value; else return 0;;
            }
        }
        
        public virtual int BookingFlightSegmentCount {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewBookingEventCount.CurrentRow.Cells["BookingFlightSegmentCount"].Value; else return 0;;
            }
        }
        
        public virtual int BookingPassengerCount {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewBookingEventCount.CurrentRow.Cells["BookingPassengerCount"].Value; else return 0;;
            }
        }
        
        public virtual int FinancialBookingTransactionCount {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewBookingEventCount.CurrentRow.Cells["FinancialBookingTransactionCount"].Value; else return 0;;
            }
        }
        
        public virtual int FinancialPaymentCount {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewBookingEventCount.CurrentRow.Cells["FinancialPaymentCount"].Value; else return 0;;
            }
        }
        
        public virtual int ConfirmedFlag {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewBookingEventCount.CurrentRow.Cells["ConfirmedFlag"].Value; else return 0;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewBookingEventCount.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewBookingEventCount_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshBookingEventCount(System.Guid bookingId) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewBookingEventCount.CurrentRow != null)
                    position = dataGridViewBookingEventCount.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new BookingSearchService().BookingEventCount(bookingId);
                dataGridViewBookingEventCount.AutoGenerateColumns = true;
                dataGridViewBookingEventCount.DataSource = bindingSource;
                dataGridViewBookingEventCount.AutoResizeColumns();

                // position to previous row
                if (dataGridViewBookingEventCount.Rows.Count > 0) { 
                    dataGridViewBookingEventCount.CurrentCell = 
                        dataGridViewBookingEventCount.Rows[position].Cells[1];
                    dataGridViewBookingEventCount.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridBookingEventCount() {
            dataGridViewBookingEventCount.Columns.Clear();
            dataGridViewBookingEventCount.AutoGenerateColumns = false;
            dataGridViewBookingEventCount.Columns.Add("BookingContactCount","Booking Contact Count");
            dataGridViewBookingEventCount.Columns.Add("BookingIdentifierCount","Booking Identifier Count");
            dataGridViewBookingEventCount.Columns.Add("BookingServiceRequestCount","Booking Service Request Count");
            dataGridViewBookingEventCount.Columns.Add("BookingEventCount","Booking Event Count");
            dataGridViewBookingEventCount.Columns.Add("BookingFlightSegmentCount","Booking Flight Segment Count");
            dataGridViewBookingEventCount.Columns.Add("BookingPassengerCount","Booking Passenger Count");
            dataGridViewBookingEventCount.Columns.Add("FinancialBookingTransactionCount","Financial Booking Transaction Count");
            dataGridViewBookingEventCount.Columns.Add("FinancialPaymentCount","Financial Payment Count");
            dataGridViewBookingEventCount.Columns.Add("ConfirmedFlag","Confirmed Flag");
            dataGridViewBookingEventCount.Columns.Add("ExtensionData", "");
            dataGridViewBookingEventCount.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewBookingEventCount.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewBookingEventCount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewBookingEventCount.AutoResizeColumns();
        }
    }
}
