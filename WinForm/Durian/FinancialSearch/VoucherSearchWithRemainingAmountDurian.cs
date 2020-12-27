using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class VoucherSearchWithRemainingAmountDurian : UserControl {
        
        public VoucherSearchWithRemainingAmountDurian() {
           InitializeComponent();
           InitializeGridVoucherSearchWithRemainingAmount();
        }
        
        public virtual System.Guid FinancialVoucherId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewVoucherSearchWithRemainingAmount.CurrentRow.Cells["FinancialVoucherId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.Guid FinancialCurrencyId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewVoucherSearchWithRemainingAmount.CurrentRow.Cells["FinancialCurrencyId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual int VoucherNumber {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewVoucherSearchWithRemainingAmount.CurrentRow.Cells["VoucherNumber"].Value; else return 0;;
            }
        }
        
        public virtual string VoucherDescription {
            get {
                if (!DesignMode) return (System.String) dataGridViewVoucherSearchWithRemainingAmount.CurrentRow.Cells["VoucherDescription"].Value; else return String.Empty;;
            }
        }
        
        public virtual decimal RemainingAmount {
            get {
                if (!DesignMode) return (System.Decimal) dataGridViewVoucherSearchWithRemainingAmount.CurrentRow.Cells["RemainingAmount"].Value; else return 0;;
            }
        }
        
        public virtual string FinancialCurrencyTypeCode {
            get {
                if (!DesignMode) return (System.String) dataGridViewVoucherSearchWithRemainingAmount.CurrentRow.Cells["FinancialCurrencyTypeCode"].Value; else return String.Empty;;
            }
        }
        
        public virtual string FinancialCurrencyTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewVoucherSearchWithRemainingAmount.CurrentRow.Cells["FinancialCurrencyTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime ValidFromDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewVoucherSearchWithRemainingAmount.CurrentRow.Cells["ValidFromDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.DateTime ValidUntilDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewVoucherSearchWithRemainingAmount.CurrentRow.Cells["ValidUntilDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewVoucherSearchWithRemainingAmount.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewVoucherSearchWithRemainingAmount_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshVoucherSearchWithRemainingAmount(System.DateTime voucherValidOnDateTime) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewVoucherSearchWithRemainingAmount.CurrentRow != null)
                    position = dataGridViewVoucherSearchWithRemainingAmount.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new FinancialSearchService().VoucherSearchWithRemainingAmount(voucherValidOnDateTime);
                dataGridViewVoucherSearchWithRemainingAmount.AutoGenerateColumns = true;
                dataGridViewVoucherSearchWithRemainingAmount.DataSource = bindingSource;
                dataGridViewVoucherSearchWithRemainingAmount.AutoResizeColumns();

                // position to previous row
                if (dataGridViewVoucherSearchWithRemainingAmount.Rows.Count > 0) { 
                    dataGridViewVoucherSearchWithRemainingAmount.CurrentCell = 
                        dataGridViewVoucherSearchWithRemainingAmount.Rows[position].Cells[1];
                    dataGridViewVoucherSearchWithRemainingAmount.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridVoucherSearchWithRemainingAmount() {
            dataGridViewVoucherSearchWithRemainingAmount.Columns.Clear();
            dataGridViewVoucherSearchWithRemainingAmount.AutoGenerateColumns = false;
            dataGridViewVoucherSearchWithRemainingAmount.Columns.Add("FinancialVoucherId","Financial Voucher Id");
            dataGridViewVoucherSearchWithRemainingAmount.Columns.Add("FinancialCurrencyId","Financial Currency Id");
            dataGridViewVoucherSearchWithRemainingAmount.Columns.Add("VoucherNumber","Voucher Number");
            dataGridViewVoucherSearchWithRemainingAmount.Columns.Add("VoucherDescription","Voucher Description");
            dataGridViewVoucherSearchWithRemainingAmount.Columns.Add("RemainingAmount","Remaining Amount");
            dataGridViewVoucherSearchWithRemainingAmount.Columns.Add("FinancialCurrencyTypeCode","Financial Currency Type Code");
            dataGridViewVoucherSearchWithRemainingAmount.Columns.Add("FinancialCurrencyTypeName","Financial Currency Type Name");
            dataGridViewVoucherSearchWithRemainingAmount.Columns.Add("ValidFromDateTime","Valid From Date Time");
            dataGridViewVoucherSearchWithRemainingAmount.Columns.Add("ValidUntilDateTime","Valid Until Date Time");
            dataGridViewVoucherSearchWithRemainingAmount.Columns.Add("ExtensionData", "");
            dataGridViewVoucherSearchWithRemainingAmount.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewVoucherSearchWithRemainingAmount.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewVoucherSearchWithRemainingAmount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewVoucherSearchWithRemainingAmount.AutoResizeColumns();
        }
    }
}
