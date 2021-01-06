using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class VoucherTransactionsDurian : UserControl {
        
        public VoucherTransactionsDurian() {
           InitializeComponent();
           InitializeGridVoucherTransactions();
        }
        
        public virtual int VoucherNumber {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewVoucherTransactions.CurrentRow.Cells["VoucherNumber"].Value; else return 0;;
            }
        }
        
        public virtual string VoucherDescription {
            get {
                if (!DesignMode) return (System.String) dataGridViewVoucherTransactions.CurrentRow.Cells["VoucherDescription"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewVoucherTransactions.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual decimal PaidCurrencyAmount {
            get {
                if (!DesignMode) return (System.Decimal) dataGridViewVoucherTransactions.CurrentRow.Cells["PaidCurrencyAmount"].Value; else return 0;;
            }
        }
        
        public virtual string PaidCurrencyType {
            get {
                if (!DesignMode) return (System.String) dataGridViewVoucherTransactions.CurrentRow.Cells["PaidCurrencyType"].Value; else return String.Empty;;
            }
        }
        
        public virtual decimal ExchangeRate {
            get {
                if (!DesignMode) return (System.Decimal) dataGridViewVoucherTransactions.CurrentRow.Cells["ExchangeRate"].Value; else return 0;;
            }
        }
        
        public virtual decimal BookingCurrencyAmount {
            get {
                if (!DesignMode) return (System.Decimal) dataGridViewVoucherTransactions.CurrentRow.Cells["BookingCurrencyAmount"].Value; else return 0;;
            }
        }
        
        public virtual string BookingCurrencyType {
            get {
                if (!DesignMode) return (System.String) dataGridViewVoucherTransactions.CurrentRow.Cells["BookingCurrencyType"].Value; else return String.Empty;;
            }
        }
        
        public virtual string FinancialCostcentreCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewVoucherTransactions.CurrentRow.Cells["FinancialCostcentreCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string FinancialCostcentreName {
            get {
                if (!DesignMode) return (System.String) dataGridViewVoucherTransactions.CurrentRow.Cells["FinancialCostcentreName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DefaultUserCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewVoucherTransactions.CurrentRow.Cells["DefaultUserCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DefaultUserName {
            get {
                if (!DesignMode) return (System.String) dataGridViewVoucherTransactions.CurrentRow.Cells["DefaultUserName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid FinancialPaymentId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewVoucherTransactions.CurrentRow.Cells["FinancialPaymentId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.Guid BookingId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewVoucherTransactions.CurrentRow.Cells["BookingId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewVoucherTransactions.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewVoucherTransactions_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshVoucherTransactions(System.Guid financialVoucherId) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewVoucherTransactions.CurrentRow != null)
                    position = dataGridViewVoucherTransactions.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new FinancialSearchServiceClient().VoucherTransactions(financialVoucherId);
                dataGridViewVoucherTransactions.AutoGenerateColumns = true;
                dataGridViewVoucherTransactions.DataSource = bindingSource;
                dataGridViewVoucherTransactions.AutoResizeColumns();

                // position to previous row
                if (dataGridViewVoucherTransactions.Rows.Count > 0) { 
                    dataGridViewVoucherTransactions.CurrentCell = 
                        dataGridViewVoucherTransactions.Rows[position].Cells[1];
                    dataGridViewVoucherTransactions.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridVoucherTransactions() {
            dataGridViewVoucherTransactions.Columns.Clear();
            dataGridViewVoucherTransactions.AutoGenerateColumns = false;
            dataGridViewVoucherTransactions.Columns.Add("VoucherNumber","Voucher Number");
            dataGridViewVoucherTransactions.Columns.Add("VoucherDescription","Voucher Description");
            dataGridViewVoucherTransactions.Columns.Add("DateTime","Date Time");
            dataGridViewVoucherTransactions.Columns.Add("PaidCurrencyAmount","Paid Currency Amount");
            dataGridViewVoucherTransactions.Columns.Add("PaidCurrencyType","Paid Currency Type");
            dataGridViewVoucherTransactions.Columns.Add("ExchangeRate","Exchange Rate");
            dataGridViewVoucherTransactions.Columns.Add("BookingCurrencyAmount","Booking Currency Amount");
            dataGridViewVoucherTransactions.Columns.Add("BookingCurrencyType","Booking Currency Type");
            dataGridViewVoucherTransactions.Columns.Add("FinancialCostcentreCode","Financial Costcentre Code");
            dataGridViewVoucherTransactions.Columns.Add("FinancialCostcentreName","Financial Costcentre Name");
            dataGridViewVoucherTransactions.Columns.Add("DefaultUserCode","Default User Code");
            dataGridViewVoucherTransactions.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewVoucherTransactions.Columns.Add("FinancialPaymentId","Financial Payment Id");
            dataGridViewVoucherTransactions.Columns.Add("BookingId","Booking Id");
            dataGridViewVoucherTransactions.Columns.Add("ExtensionData", "");
            dataGridViewVoucherTransactions.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewVoucherTransactions.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewVoucherTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewVoucherTransactions.AutoResizeColumns();
        }
    }
}
