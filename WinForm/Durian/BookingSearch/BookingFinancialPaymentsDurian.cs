using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingFinancialPaymentsDurian : UserControl {
        
        public BookingFinancialPaymentsDurian() {
           InitializeComponent();
           InitializeGridBookingFinancialPayments();
        }
        
        public virtual int TransactionNumber {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewBookingFinancialPayments.CurrentRow.Cells["TransactionNumber"].Value; else return 0;;
            }
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewBookingFinancialPayments.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual string FinancialPaymentTypeRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingFinancialPayments.CurrentRow.Cells["FinancialPaymentTypeRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string FinancialPaymentTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingFinancialPayments.CurrentRow.Cells["FinancialPaymentTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual decimal PaidCurrencyAmount {
            get {
                if (!DesignMode) return (System.Decimal) dataGridViewBookingFinancialPayments.CurrentRow.Cells["PaidCurrencyAmount"].Value; else return 0;;
            }
        }
        
        public virtual string PaidCurrencyType {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingFinancialPayments.CurrentRow.Cells["PaidCurrencyType"].Value; else return String.Empty;;
            }
        }
        
        public virtual decimal ExchangeRate {
            get {
                if (!DesignMode) return (System.Decimal) dataGridViewBookingFinancialPayments.CurrentRow.Cells["ExchangeRate"].Value; else return 0;;
            }
        }
        
        public virtual decimal BookingCurrencyAmount {
            get {
                if (!DesignMode) return (System.Decimal) dataGridViewBookingFinancialPayments.CurrentRow.Cells["BookingCurrencyAmount"].Value; else return 0;;
            }
        }
        
        public virtual string BookingCurrencyType {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingFinancialPayments.CurrentRow.Cells["BookingCurrencyType"].Value; else return String.Empty;;
            }
        }
        
        public virtual string PaymentDescription {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingFinancialPayments.CurrentRow.Cells["PaymentDescription"].Value; else return String.Empty;;
            }
        }
        
        public virtual string FinancialCostcentreCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingFinancialPayments.CurrentRow.Cells["FinancialCostcentreCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string FinancialCostcentreName {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingFinancialPayments.CurrentRow.Cells["FinancialCostcentreName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DefaultUserCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingFinancialPayments.CurrentRow.Cells["DefaultUserCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DefaultUserName {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingFinancialPayments.CurrentRow.Cells["DefaultUserName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid FinancialPaymentId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewBookingFinancialPayments.CurrentRow.Cells["FinancialPaymentId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewBookingFinancialPayments.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewBookingFinancialPayments_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshBookingFinancialPayments(System.Guid bookingId) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewBookingFinancialPayments.CurrentRow != null)
                    position = dataGridViewBookingFinancialPayments.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new BookingSearchServiceClient().BookingFinancialPayments(bookingId);
                dataGridViewBookingFinancialPayments.AutoGenerateColumns = true;
                dataGridViewBookingFinancialPayments.DataSource = bindingSource;
                dataGridViewBookingFinancialPayments.AutoResizeColumns();

                // position to previous row
                if (dataGridViewBookingFinancialPayments.Rows.Count > 0) { 
                    dataGridViewBookingFinancialPayments.CurrentCell = 
                        dataGridViewBookingFinancialPayments.Rows[position].Cells[1];
                    dataGridViewBookingFinancialPayments.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridBookingFinancialPayments() {
            dataGridViewBookingFinancialPayments.Columns.Clear();
            dataGridViewBookingFinancialPayments.AutoGenerateColumns = false;
            dataGridViewBookingFinancialPayments.Columns.Add("TransactionNumber","Transaction Number");
            dataGridViewBookingFinancialPayments.Columns.Add("DateTime","Date Time");
            dataGridViewBookingFinancialPayments.Columns.Add("FinancialPaymentTypeRcd","Financial Payment Type");
            dataGridViewBookingFinancialPayments.Columns.Add("FinancialPaymentTypeName","Financial Payment Type Name");
            dataGridViewBookingFinancialPayments.Columns.Add("PaidCurrencyAmount","Paid Currency Amount");
            dataGridViewBookingFinancialPayments.Columns.Add("PaidCurrencyType","Paid Currency Type");
            dataGridViewBookingFinancialPayments.Columns.Add("ExchangeRate","Exchange Rate");
            dataGridViewBookingFinancialPayments.Columns.Add("BookingCurrencyAmount","Booking Currency Amount");
            dataGridViewBookingFinancialPayments.Columns.Add("BookingCurrencyType","Booking Currency Type");
            dataGridViewBookingFinancialPayments.Columns.Add("PaymentDescription","Payment Description");
            dataGridViewBookingFinancialPayments.Columns.Add("FinancialCostcentreCode","Financial Costcentre Code");
            dataGridViewBookingFinancialPayments.Columns.Add("FinancialCostcentreName","Financial Costcentre Name");
            dataGridViewBookingFinancialPayments.Columns.Add("DefaultUserCode","Default User Code");
            dataGridViewBookingFinancialPayments.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewBookingFinancialPayments.Columns.Add("FinancialPaymentId","Financial Payment Id");
            dataGridViewBookingFinancialPayments.Columns.Add("ExtensionData", "");
            dataGridViewBookingFinancialPayments.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewBookingFinancialPayments.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewBookingFinancialPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewBookingFinancialPayments.AutoResizeColumns();
        }
    }
}
