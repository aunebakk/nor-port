using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingStatisticsDurian : UserControl {
        
        public BookingStatisticsDurian() {
           InitializeComponent();
           InitializeGridBookingStatistics();
        }
        
        public virtual System.DateTime Date {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewBookingStatistics.CurrentRow.Cells["Date"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual int PassengersBookedCount {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewBookingStatistics.CurrentRow.Cells["PassengersBookedCount"].Value; else return 0;;
            }
        }
        
        public virtual int AdultBookedCount {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewBookingStatistics.CurrentRow.Cells["AdultBookedCount"].Value; else return 0;;
            }
        }
        
        public virtual int ChildBookedCount {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewBookingStatistics.CurrentRow.Cells["ChildBookedCount"].Value; else return 0;;
            }
        }
        
        public virtual int InfantBookedCount {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewBookingStatistics.CurrentRow.Cells["InfantBookedCount"].Value; else return 0;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewBookingStatistics.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewBookingStatistics_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshBookingStatistics(System.Guid departureAirportId, System.Guid arrivalAirportId, System.DateTime fromDateTime, System.DateTime untilDateTime) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewBookingStatistics.CurrentRow != null)
                    position = dataGridViewBookingStatistics.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new BookingSearchService().BookingStatistics(departureAirportId,arrivalAirportId,fromDateTime,untilDateTime);
                dataGridViewBookingStatistics.AutoGenerateColumns = true;
                dataGridViewBookingStatistics.DataSource = bindingSource;
                dataGridViewBookingStatistics.AutoResizeColumns();

                // position to previous row
                if (dataGridViewBookingStatistics.Rows.Count > 0) { 
                    dataGridViewBookingStatistics.CurrentCell = 
                        dataGridViewBookingStatistics.Rows[position].Cells[1];
                    dataGridViewBookingStatistics.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridBookingStatistics() {
            dataGridViewBookingStatistics.Columns.Clear();
            dataGridViewBookingStatistics.AutoGenerateColumns = false;
            dataGridViewBookingStatistics.Columns.Add("Date","Date");
            dataGridViewBookingStatistics.Columns.Add("PassengersBookedCount","Passengers Booked Count");
            dataGridViewBookingStatistics.Columns.Add("AdultBookedCount","Adult Booked Count");
            dataGridViewBookingStatistics.Columns.Add("ChildBookedCount","Child Booked Count");
            dataGridViewBookingStatistics.Columns.Add("InfantBookedCount","Infant Booked Count");
            dataGridViewBookingStatistics.Columns.Add("ExtensionData", "");
            dataGridViewBookingStatistics.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewBookingStatistics.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewBookingStatistics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewBookingStatistics.AutoResizeColumns();
        }
    }
}
