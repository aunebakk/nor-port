using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingsOpenDurian : UserControl {
        
        public BookingsOpenDurian() {
           InitializeComponent();
           InitializeGridBookingsOpen();
        }
        
        public virtual System.Guid BookingId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewBookingsOpen.CurrentRow.Cells["BookingId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string RecordLocator {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingsOpen.CurrentRow.Cells["RecordLocator"].Value; else return String.Empty;;
            }
        }
        
        public virtual string LastBookingEventTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingsOpen.CurrentRow.Cells["LastBookingEventTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime LastBookingEventDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewBookingsOpen.CurrentRow.Cells["LastBookingEventDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual string LastBookingContactMethod {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingsOpen.CurrentRow.Cells["LastBookingContactMethod"].Value; else return String.Empty;;
            }
        }
        
        public virtual string BookingSourceName {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingsOpen.CurrentRow.Cells["BookingSourceName"].Value; else return String.Empty;;
            }
        }
        
        public virtual int AdultCount {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewBookingsOpen.CurrentRow.Cells["AdultCount"].Value; else return 0;;
            }
        }
        
        public virtual int ChildCount {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewBookingsOpen.CurrentRow.Cells["ChildCount"].Value; else return 0;;
            }
        }
        
        public virtual int InfantCount {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewBookingsOpen.CurrentRow.Cells["InfantCount"].Value; else return 0;;
            }
        }
        
        public virtual decimal BalanceAmount {
            get {
                if (!DesignMode) return (System.Decimal) dataGridViewBookingsOpen.CurrentRow.Cells["BalanceAmount"].Value; else return 0;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewBookingsOpen.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewBookingsOpen_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshBookingsOpen() {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewBookingsOpen.CurrentRow != null)
                    position = dataGridViewBookingsOpen.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new BookingSearchService().BookingsOpen();
                dataGridViewBookingsOpen.AutoGenerateColumns = true;
                dataGridViewBookingsOpen.DataSource = bindingSource;
                dataGridViewBookingsOpen.AutoResizeColumns();

                // position to previous row
                if (dataGridViewBookingsOpen.Rows.Count > 0) { 
                    dataGridViewBookingsOpen.CurrentCell = 
                        dataGridViewBookingsOpen.Rows[position].Cells[1];
                    dataGridViewBookingsOpen.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridBookingsOpen() {
            dataGridViewBookingsOpen.Columns.Clear();
            dataGridViewBookingsOpen.AutoGenerateColumns = false;
            dataGridViewBookingsOpen.Columns.Add("BookingId","Booking Id");
            dataGridViewBookingsOpen.Columns.Add("RecordLocator","Record Locator");
            dataGridViewBookingsOpen.Columns.Add("LastBookingEventTypeName","Last Booking Event Type Name");
            dataGridViewBookingsOpen.Columns.Add("LastBookingEventDateTime","Last Booking Event Date Time");
            dataGridViewBookingsOpen.Columns.Add("LastBookingContactMethod","Last Booking Contact Method");
            dataGridViewBookingsOpen.Columns.Add("BookingSourceName","Booking Source Name");
            dataGridViewBookingsOpen.Columns.Add("AdultCount","Adult Count");
            dataGridViewBookingsOpen.Columns.Add("ChildCount","Child Count");
            dataGridViewBookingsOpen.Columns.Add("InfantCount","Infant Count");
            dataGridViewBookingsOpen.Columns.Add("BalanceAmount","Balance Amount");
            dataGridViewBookingsOpen.Columns.Add("ExtensionData", "");
            dataGridViewBookingsOpen.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewBookingsOpen.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewBookingsOpen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewBookingsOpen.AutoResizeColumns();
        }
    }
}
