using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingPassengersDurian : UserControl {
        
        public BookingPassengersDurian() {
           InitializeComponent();
           InitializeGridBookingPassengers();
        }
        
        public virtual System.Guid BookingPassengerId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewBookingPassengers.CurrentRow.Cells["BookingPassengerId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.Guid PassengerId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewBookingPassengers.CurrentRow.Cells["PassengerId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string PassengerTypeRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingPassengers.CurrentRow.Cells["PassengerTypeRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string PassengerTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingPassengers.CurrentRow.Cells["PassengerTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string PassengerName {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingPassengers.CurrentRow.Cells["PassengerName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid UserId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewBookingPassengers.CurrentRow.Cells["UserId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewBookingPassengers.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewBookingPassengers.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewBookingPassengers_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshBookingPassengers(System.Guid bookingId) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewBookingPassengers.CurrentRow != null)
                    position = dataGridViewBookingPassengers.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new BookingSearchService().BookingPassengers(bookingId);
                dataGridViewBookingPassengers.AutoGenerateColumns = true;
                dataGridViewBookingPassengers.DataSource = bindingSource;
                dataGridViewBookingPassengers.AutoResizeColumns();

                // position to previous row
                if (dataGridViewBookingPassengers.Rows.Count > 0) { 
                    dataGridViewBookingPassengers.CurrentCell = 
                        dataGridViewBookingPassengers.Rows[position].Cells[1];
                    dataGridViewBookingPassengers.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridBookingPassengers() {
            dataGridViewBookingPassengers.Columns.Clear();
            dataGridViewBookingPassengers.AutoGenerateColumns = false;
            dataGridViewBookingPassengers.Columns.Add("BookingPassengerId","Booking Passenger Id");
            dataGridViewBookingPassengers.Columns.Add("PassengerId","Passenger Id");
            dataGridViewBookingPassengers.Columns.Add("PassengerTypeRcd","Passenger Type");
            dataGridViewBookingPassengers.Columns.Add("PassengerTypeName","Passenger Type Name");
            dataGridViewBookingPassengers.Columns.Add("PassengerName","Passenger Name");
            dataGridViewBookingPassengers.Columns.Add("UserId","User Id");
            dataGridViewBookingPassengers.Columns.Add("DateTime","Date Time");
            dataGridViewBookingPassengers.Columns.Add("ExtensionData", "");
            dataGridViewBookingPassengers.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewBookingPassengers.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewBookingPassengers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewBookingPassengers.AutoResizeColumns();
        }
    }
}
