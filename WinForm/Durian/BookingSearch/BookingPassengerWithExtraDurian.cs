using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingPassengerWithExtraDurian : UserControl {
        
        public BookingPassengerWithExtraDurian() {
           InitializeComponent();
           InitializeGridBookingPassengerWithExtra();
        }
        
        public virtual System.Guid BookingPassengerId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewBookingPassengerWithExtra.CurrentRow.Cells["BookingPassengerId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.Guid BookingId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewBookingPassengerWithExtra.CurrentRow.Cells["BookingId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.Guid PassengerId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewBookingPassengerWithExtra.CurrentRow.Cells["PassengerId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string PassengerTypeRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingPassengerWithExtra.CurrentRow.Cells["PassengerTypeRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string PassengerName {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingPassengerWithExtra.CurrentRow.Cells["PassengerName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DefaultStateRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingPassengerWithExtra.CurrentRow.Cells["DefaultStateRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid UserId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewBookingPassengerWithExtra.CurrentRow.Cells["UserId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewBookingPassengerWithExtra.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewBookingPassengerWithExtra.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewBookingPassengerWithExtra_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshBookingPassengerWithExtra(System.Guid bookingPassengerId) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewBookingPassengerWithExtra.CurrentRow != null)
                    position = dataGridViewBookingPassengerWithExtra.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new BookingSearchServiceClient().BookingPassengerWithExtra(bookingPassengerId);
                dataGridViewBookingPassengerWithExtra.AutoGenerateColumns = true;
                dataGridViewBookingPassengerWithExtra.DataSource = bindingSource;
                dataGridViewBookingPassengerWithExtra.AutoResizeColumns();

                // position to previous row
                if (dataGridViewBookingPassengerWithExtra.Rows.Count > 0) { 
                    dataGridViewBookingPassengerWithExtra.CurrentCell = 
                        dataGridViewBookingPassengerWithExtra.Rows[position].Cells[1];
                    dataGridViewBookingPassengerWithExtra.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridBookingPassengerWithExtra() {
            dataGridViewBookingPassengerWithExtra.Columns.Clear();
            dataGridViewBookingPassengerWithExtra.AutoGenerateColumns = false;
            dataGridViewBookingPassengerWithExtra.Columns.Add("BookingPassengerId","Booking Passenger Id");
            dataGridViewBookingPassengerWithExtra.Columns.Add("BookingId","Booking Id");
            dataGridViewBookingPassengerWithExtra.Columns.Add("PassengerId","Passenger Id");
            dataGridViewBookingPassengerWithExtra.Columns.Add("PassengerTypeRcd","Passenger Type");
            dataGridViewBookingPassengerWithExtra.Columns.Add("PassengerName","Passenger Name");
            dataGridViewBookingPassengerWithExtra.Columns.Add("DefaultStateRcd","Default State");
            dataGridViewBookingPassengerWithExtra.Columns.Add("UserId","User Id");
            dataGridViewBookingPassengerWithExtra.Columns.Add("DateTime","Date Time");
            dataGridViewBookingPassengerWithExtra.Columns.Add("ExtensionData", "");
            dataGridViewBookingPassengerWithExtra.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewBookingPassengerWithExtra.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewBookingPassengerWithExtra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewBookingPassengerWithExtra.AutoResizeColumns();
        }
    }
}
