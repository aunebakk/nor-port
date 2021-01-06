using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingServiceSummaryDurian : UserControl {
        
        public BookingServiceSummaryDurian() {
           InitializeComponent();
           InitializeGridBookingServiceSummary();
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewBookingServiceSummary.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.DateTime FromDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewBookingServiceSummary.CurrentRow.Cells["FromDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.DateTime UntilDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewBookingServiceSummary.CurrentRow.Cells["UntilDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual string ServiceTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingServiceSummary.CurrentRow.Cells["ServiceTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ServiceDescription {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingServiceSummary.CurrentRow.Cells["ServiceDescription"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ServiceRequestStatusName {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingServiceSummary.CurrentRow.Cells["ServiceRequestStatusName"].Value; else return String.Empty;;
            }
        }
        
        public virtual decimal ServiceAmount {
            get {
                if (!DesignMode) return (System.Decimal) dataGridViewBookingServiceSummary.CurrentRow.Cells["ServiceAmount"].Value; else return 0;;
            }
        }
        
        public virtual string ServiceCurrencyTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingServiceSummary.CurrentRow.Cells["ServiceCurrencyTypeName"].Value; else return String.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewBookingServiceSummary.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewBookingServiceSummary_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshBookingServiceSummary(System.Guid bookingId) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewBookingServiceSummary.CurrentRow != null)
                    position = dataGridViewBookingServiceSummary.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new BookingSearchServiceClient().BookingServiceSummary(bookingId);
                dataGridViewBookingServiceSummary.AutoGenerateColumns = true;
                dataGridViewBookingServiceSummary.DataSource = bindingSource;
                dataGridViewBookingServiceSummary.AutoResizeColumns();

                // position to previous row
                if (dataGridViewBookingServiceSummary.Rows.Count > 0) { 
                    dataGridViewBookingServiceSummary.CurrentCell = 
                        dataGridViewBookingServiceSummary.Rows[position].Cells[1];
                    dataGridViewBookingServiceSummary.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridBookingServiceSummary() {
            dataGridViewBookingServiceSummary.Columns.Clear();
            dataGridViewBookingServiceSummary.AutoGenerateColumns = false;
            dataGridViewBookingServiceSummary.Columns.Add("DateTime","Date Time");
            dataGridViewBookingServiceSummary.Columns.Add("FromDateTime","From Date Time");
            dataGridViewBookingServiceSummary.Columns.Add("UntilDateTime","Until Date Time");
            dataGridViewBookingServiceSummary.Columns.Add("ServiceTypeName","Service Type Name");
            dataGridViewBookingServiceSummary.Columns.Add("ServiceDescription","Service Description");
            dataGridViewBookingServiceSummary.Columns.Add("ServiceRequestStatusName","Service Request Status Name");
            dataGridViewBookingServiceSummary.Columns.Add("ServiceAmount","Service Amount");
            dataGridViewBookingServiceSummary.Columns.Add("ServiceCurrencyTypeName","Service Currency Type Name");
            dataGridViewBookingServiceSummary.Columns.Add("ExtensionData", "");
            dataGridViewBookingServiceSummary.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewBookingServiceSummary.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewBookingServiceSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewBookingServiceSummary.AutoResizeColumns();
        }
    }
}
