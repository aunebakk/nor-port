using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class TransactionsCreditDebitBalanceDurian : UserControl {
        
        public TransactionsCreditDebitBalanceDurian() {
           InitializeComponent();
           InitializeGridTransactionsCreditDebitBalance();
        }
        
        public virtual string Date {
            get {
                if (!DesignMode) return (System.String) dataGridViewTransactionsCreditDebitBalance.CurrentRow.Cells["Date"].Value; else return String.Empty;;
            }
        }
        
        public virtual decimal DebitAmount {
            get {
                if (!DesignMode) return (System.Decimal) dataGridViewTransactionsCreditDebitBalance.CurrentRow.Cells["DebitAmount"].Value; else return 0;;
            }
        }
        
        public virtual decimal CreditAmount {
            get {
                if (!DesignMode) return (System.Decimal) dataGridViewTransactionsCreditDebitBalance.CurrentRow.Cells["CreditAmount"].Value; else return 0;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewTransactionsCreditDebitBalance.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewTransactionsCreditDebitBalance_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshTransactionsCreditDebitBalance(System.DateTime fromDateTime, System.DateTime untilDateTime) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewTransactionsCreditDebitBalance.CurrentRow != null)
                    position = dataGridViewTransactionsCreditDebitBalance.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new FinancialSearchServiceClient().TransactionsCreditDebitBalance(fromDateTime,untilDateTime);
                dataGridViewTransactionsCreditDebitBalance.AutoGenerateColumns = true;
                dataGridViewTransactionsCreditDebitBalance.DataSource = bindingSource;
                dataGridViewTransactionsCreditDebitBalance.AutoResizeColumns();

                // position to previous row
                if (dataGridViewTransactionsCreditDebitBalance.Rows.Count > 0) { 
                    dataGridViewTransactionsCreditDebitBalance.CurrentCell = 
                        dataGridViewTransactionsCreditDebitBalance.Rows[position].Cells[1];
                    dataGridViewTransactionsCreditDebitBalance.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridTransactionsCreditDebitBalance() {
            dataGridViewTransactionsCreditDebitBalance.Columns.Clear();
            dataGridViewTransactionsCreditDebitBalance.AutoGenerateColumns = false;
            dataGridViewTransactionsCreditDebitBalance.Columns.Add("Date","Date");
            dataGridViewTransactionsCreditDebitBalance.Columns.Add("DebitAmount","Debit Amount");
            dataGridViewTransactionsCreditDebitBalance.Columns.Add("CreditAmount","Credit Amount");
            dataGridViewTransactionsCreditDebitBalance.Columns.Add("ExtensionData", "");
            dataGridViewTransactionsCreditDebitBalance.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewTransactionsCreditDebitBalance.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewTransactionsCreditDebitBalance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewTransactionsCreditDebitBalance.AutoResizeColumns();
        }
    }
}
