using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class FinancialServiceDetailsForBookingDurian : UserControl {
        
        public FinancialServiceDetailsForBookingDurian() {
           InitializeComponent();
           InitializeGridFinancialServiceDetailsForBooking();
        }
        
        public virtual string ServiceTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFinancialServiceDetailsForBooking.CurrentRow.Cells["ServiceTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ServiceDescription {
            get {
                if (!DesignMode) return (System.String) dataGridViewFinancialServiceDetailsForBooking.CurrentRow.Cells["ServiceDescription"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ServiceRequestStatusName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFinancialServiceDetailsForBooking.CurrentRow.Cells["ServiceRequestStatusName"].Value; else return String.Empty;;
            }
        }
        
        public virtual decimal ServiceAmount {
            get {
                if (!DesignMode) return (System.Decimal) dataGridViewFinancialServiceDetailsForBooking.CurrentRow.Cells["ServiceAmount"].Value; else return 0;;
            }
        }
        
        public virtual string ServiceCurrencyTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewFinancialServiceDetailsForBooking.CurrentRow.Cells["ServiceCurrencyTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid BookingServiceRequestId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewFinancialServiceDetailsForBooking.CurrentRow.Cells["BookingServiceRequestId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.Guid ServiceSpecialServiceRequestId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewFinancialServiceDetailsForBooking.CurrentRow.Cells["ServiceSpecialServiceRequestId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.Guid ServiceHotelId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewFinancialServiceDetailsForBooking.CurrentRow.Cells["ServiceHotelId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.Guid ServiceCarRentalId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewFinancialServiceDetailsForBooking.CurrentRow.Cells["ServiceCarRentalId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewFinancialServiceDetailsForBooking.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewFinancialServiceDetailsForBooking_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshFinancialServiceDetailsForBooking(System.Guid bookingId) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewFinancialServiceDetailsForBooking.CurrentRow != null)
                    position = dataGridViewFinancialServiceDetailsForBooking.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new FinancialSearchService().FinancialServiceDetailsForBooking(bookingId);
                dataGridViewFinancialServiceDetailsForBooking.AutoGenerateColumns = true;
                dataGridViewFinancialServiceDetailsForBooking.DataSource = bindingSource;
                dataGridViewFinancialServiceDetailsForBooking.AutoResizeColumns();

                // position to previous row
                if (dataGridViewFinancialServiceDetailsForBooking.Rows.Count > 0) { 
                    dataGridViewFinancialServiceDetailsForBooking.CurrentCell = 
                        dataGridViewFinancialServiceDetailsForBooking.Rows[position].Cells[1];
                    dataGridViewFinancialServiceDetailsForBooking.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridFinancialServiceDetailsForBooking() {
            dataGridViewFinancialServiceDetailsForBooking.Columns.Clear();
            dataGridViewFinancialServiceDetailsForBooking.AutoGenerateColumns = false;
            dataGridViewFinancialServiceDetailsForBooking.Columns.Add("ServiceTypeName","Service Type Name");
            dataGridViewFinancialServiceDetailsForBooking.Columns.Add("ServiceDescription","Service Description");
            dataGridViewFinancialServiceDetailsForBooking.Columns.Add("ServiceRequestStatusName","Service Request Status Name");
            dataGridViewFinancialServiceDetailsForBooking.Columns.Add("ServiceAmount","Service Amount");
            dataGridViewFinancialServiceDetailsForBooking.Columns.Add("ServiceCurrencyTypeName","Service Currency Type Name");
            dataGridViewFinancialServiceDetailsForBooking.Columns.Add("BookingServiceRequestId","Booking Service Request Id");
            dataGridViewFinancialServiceDetailsForBooking.Columns.Add("ServiceSpecialServiceRequestId","Service Special Service Request Id");
            dataGridViewFinancialServiceDetailsForBooking.Columns.Add("ServiceHotelId","Service Hotel Id");
            dataGridViewFinancialServiceDetailsForBooking.Columns.Add("ServiceCarRentalId","Service Car Rental Id");
            dataGridViewFinancialServiceDetailsForBooking.Columns.Add("ExtensionData", "");
            dataGridViewFinancialServiceDetailsForBooking.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewFinancialServiceDetailsForBooking.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewFinancialServiceDetailsForBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewFinancialServiceDetailsForBooking.AutoResizeColumns();
        }
    }
}
