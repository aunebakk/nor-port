using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class GetAvailableCurrenciesDurian : UserControl {
        
        public GetAvailableCurrenciesDurian() {
           InitializeComponent();
           InitializeGridGetAvailableCurrencies();
        }
        
        public virtual string FinancialCurrencyAgainstFinancialCurrencyTypeRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetAvailableCurrencies.CurrentRow.Cells["FinancialCurrencyAgainstFinancialCurrencyTypeRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string FinancialCurrencyTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetAvailableCurrencies.CurrentRow.Cells["FinancialCurrencyTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual decimal Amount {
            get {
                if (!DesignMode) return (System.Decimal) dataGridViewGetAvailableCurrencies.CurrentRow.Cells["Amount"].Value; else return 0;;
            }
        }
        
        public virtual decimal EqualsAmount {
            get {
                if (!DesignMode) return (System.Decimal) dataGridViewGetAvailableCurrencies.CurrentRow.Cells["EqualsAmount"].Value; else return 0;;
            }
        }
        
        public virtual int DecimalCount {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewGetAvailableCurrencies.CurrentRow.Cells["DecimalCount"].Value; else return 0;;
            }
        }
        
        public virtual System.Guid FinancialCurrencyId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetAvailableCurrencies.CurrentRow.Cells["FinancialCurrencyId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewGetAvailableCurrencies.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewGetAvailableCurrencies_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshGetAvailableCurrencies(System.Guid financialCurrencyId, System.DateTime currencyDateTime) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewGetAvailableCurrencies.CurrentRow != null)
                    position = dataGridViewGetAvailableCurrencies.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new FinancialSearchServiceClient().GetAvailableCurrencies(financialCurrencyId,currencyDateTime);
                dataGridViewGetAvailableCurrencies.AutoGenerateColumns = true;
                dataGridViewGetAvailableCurrencies.DataSource = bindingSource;
                dataGridViewGetAvailableCurrencies.AutoResizeColumns();

                // position to previous row
                if (dataGridViewGetAvailableCurrencies.Rows.Count > 0) { 
                    dataGridViewGetAvailableCurrencies.CurrentCell = 
                        dataGridViewGetAvailableCurrencies.Rows[position].Cells[1];
                    dataGridViewGetAvailableCurrencies.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridGetAvailableCurrencies() {
            dataGridViewGetAvailableCurrencies.Columns.Clear();
            dataGridViewGetAvailableCurrencies.AutoGenerateColumns = false;
            dataGridViewGetAvailableCurrencies.Columns.Add("FinancialCurrencyAgainstFinancialCurrencyTypeRcd","Financial Currency Against Financial Currency Type");
            dataGridViewGetAvailableCurrencies.Columns.Add("FinancialCurrencyTypeName","Financial Currency Type Name");
            dataGridViewGetAvailableCurrencies.Columns.Add("Amount","Amount");
            dataGridViewGetAvailableCurrencies.Columns.Add("EqualsAmount","Equals Amount");
            dataGridViewGetAvailableCurrencies.Columns.Add("DecimalCount","Decimal Count");
            dataGridViewGetAvailableCurrencies.Columns.Add("FinancialCurrencyId","Financial Currency Id");
            dataGridViewGetAvailableCurrencies.Columns.Add("ExtensionData", "");
            dataGridViewGetAvailableCurrencies.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewGetAvailableCurrencies.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewGetAvailableCurrencies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewGetAvailableCurrencies.AutoResizeColumns();
        }
    }
}
