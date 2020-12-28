using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingEventHistoryDurian : UserControl {
        
        public BookingEventHistoryDurian() {
           InitializeComponent();
           InitializeGridBookingEventHistory();
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewBookingEventHistory.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual string HistoryEventGroupName {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingEventHistory.CurrentRow.Cells["HistoryEventGroupName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string HistoryEventTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingEventHistory.CurrentRow.Cells["HistoryEventTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string HistoryEventDescription {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingEventHistory.CurrentRow.Cells["HistoryEventDescription"].Value; else return String.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewBookingEventHistory.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewBookingEventHistory_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshBookingEventHistory(System.Guid bookingId) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewBookingEventHistory.CurrentRow != null)
                    position = dataGridViewBookingEventHistory.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new BookingSearchService().BookingEventHistory(bookingId);
                dataGridViewBookingEventHistory.AutoGenerateColumns = true;
                dataGridViewBookingEventHistory.DataSource = bindingSource;
                dataGridViewBookingEventHistory.AutoResizeColumns();

                // position to previous row
                if (dataGridViewBookingEventHistory.Rows.Count > 0) { 
                    dataGridViewBookingEventHistory.CurrentCell = 
                        dataGridViewBookingEventHistory.Rows[position].Cells[1];
                    dataGridViewBookingEventHistory.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridBookingEventHistory() {
            dataGridViewBookingEventHistory.Columns.Clear();
            dataGridViewBookingEventHistory.AutoGenerateColumns = false;
            dataGridViewBookingEventHistory.Columns.Add("DateTime","Date Time");
            dataGridViewBookingEventHistory.Columns.Add("HistoryEventGroupName","History Event Group Name");
            dataGridViewBookingEventHistory.Columns.Add("HistoryEventTypeName","History Event Type Name");
            dataGridViewBookingEventHistory.Columns.Add("HistoryEventDescription","History Event Description");
            dataGridViewBookingEventHistory.Columns.Add("ExtensionData", "");
            dataGridViewBookingEventHistory.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewBookingEventHistory.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewBookingEventHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewBookingEventHistory.AutoResizeColumns();
        }
    }
}
