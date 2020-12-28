using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class BookingFinancialTransactionsDurian : UserControl {
        
        public BookingFinancialTransactionsDurian() {
           InitializeComponent();
           InitializeGridBookingFinancialTransactions();
        }
        
        public virtual int TransactionNumber {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewBookingFinancialTransactions.CurrentRow.Cells["TransactionNumber"].Value; else return 0;;
            }
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewBookingFinancialTransactions.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual string TransactionType {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingFinancialTransactions.CurrentRow.Cells["TransactionType"].Value; else return String.Empty;;
            }
        }
        
        public virtual string TypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingFinancialTransactions.CurrentRow.Cells["TypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual decimal DebitAmount {
            get {
                if (!DesignMode) return (System.Decimal) dataGridViewBookingFinancialTransactions.CurrentRow.Cells["DebitAmount"].Value; else return 0;;
            }
        }
        
        public virtual decimal CreditAmount {
            get {
                if (!DesignMode) return (System.Decimal) dataGridViewBookingFinancialTransactions.CurrentRow.Cells["CreditAmount"].Value; else return 0;;
            }
        }
        
        public virtual string FinancialCurrencyTypeRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingFinancialTransactions.CurrentRow.Cells["FinancialCurrencyTypeRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string FinancialCostcentreCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingFinancialTransactions.CurrentRow.Cells["FinancialCostcentreCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string FinancialCostcentreName {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingFinancialTransactions.CurrentRow.Cells["FinancialCostcentreName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DefaultUserCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingFinancialTransactions.CurrentRow.Cells["DefaultUserCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DefaultUserName {
            get {
                if (!DesignMode) return (System.String) dataGridViewBookingFinancialTransactions.CurrentRow.Cells["DefaultUserName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid BookingId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewBookingFinancialTransactions.CurrentRow.Cells["BookingId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewBookingFinancialTransactions.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewBookingFinancialTransactions_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshBookingFinancialTransactions(System.Guid bookingId) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewBookingFinancialTransactions.CurrentRow != null)
                    position = dataGridViewBookingFinancialTransactions.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new BookingSearchService().BookingFinancialTransactions(bookingId);
                dataGridViewBookingFinancialTransactions.AutoGenerateColumns = true;
                dataGridViewBookingFinancialTransactions.DataSource = bindingSource;
                dataGridViewBookingFinancialTransactions.AutoResizeColumns();

                // position to previous row
                if (dataGridViewBookingFinancialTransactions.Rows.Count > 0) { 
                    dataGridViewBookingFinancialTransactions.CurrentCell = 
                        dataGridViewBookingFinancialTransactions.Rows[position].Cells[1];
                    dataGridViewBookingFinancialTransactions.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridBookingFinancialTransactions() {
            dataGridViewBookingFinancialTransactions.Columns.Clear();
            dataGridViewBookingFinancialTransactions.AutoGenerateColumns = false;
            dataGridViewBookingFinancialTransactions.Columns.Add("TransactionNumber","Transaction Number");
            dataGridViewBookingFinancialTransactions.Columns.Add("DateTime","Date Time");
            dataGridViewBookingFinancialTransactions.Columns.Add("TransactionType","Transaction Type");
            dataGridViewBookingFinancialTransactions.Columns.Add("TypeName","Type Name");
            dataGridViewBookingFinancialTransactions.Columns.Add("DebitAmount","Debit Amount");
            dataGridViewBookingFinancialTransactions.Columns.Add("CreditAmount","Credit Amount");
            dataGridViewBookingFinancialTransactions.Columns.Add("FinancialCurrencyTypeRcd","Financial Currency Type");
            dataGridViewBookingFinancialTransactions.Columns.Add("FinancialCostcentreCode","Financial Costcentre Code");
            dataGridViewBookingFinancialTransactions.Columns.Add("FinancialCostcentreName","Financial Costcentre Name");
            dataGridViewBookingFinancialTransactions.Columns.Add("DefaultUserCode","Default User Code");
            dataGridViewBookingFinancialTransactions.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewBookingFinancialTransactions.Columns.Add("BookingId","Booking Id");
            dataGridViewBookingFinancialTransactions.Columns.Add("ExtensionData", "");
            dataGridViewBookingFinancialTransactions.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewBookingFinancialTransactions.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewBookingFinancialTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewBookingFinancialTransactions.AutoResizeColumns();
        }
    }
}
