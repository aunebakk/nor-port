using System;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface
{


    public partial class GetAvailableCurrenciesLiveSearch : Form
    {

        public GetAvailableCurrenciesLiveSearch() {
            InitializeComponent();
            InitializeGridGetAvailableCurrencies();
            this.AcceptButton = buttonClose;
            this.CancelButton = buttonClose;
        }

        public void Show(
            System.Guid financialCurrencyId,
            System.DateTime currencyDateTime
            ) {

            RefreshGetAvailableCurrencies(
                financialCurrencyId,
                currencyDateTime
            );

            base.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void RefreshGetAvailableCurrencies(
            System.Guid financialCurrencyId,
            System.DateTime currencyDateTime
            ) {
            FinancialSearchService getAvailableCurrencies = new FinancialSearchService();
            BindingSource bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = getAvailableCurrencies.GetAvailableCurrencies(
                    financialCurrencyId,
                    currencyDateTime
                    );

                dataGridViewGetAvailableCurrencies.AutoGenerateColumns = true;
                dataGridViewGetAvailableCurrencies.DataSource = bindingSource;
                dataGridViewGetAvailableCurrencies.AutoResizeColumns();
                dataGridViewGetAvailableCurrencies.Refresh();
            } catch ( Exception ex ) {
                MessageBox.Show(ex.Message);
            } finally {
                getAvailableCurrencies.Close();
            }
        }

        private void InitializeGridGetAvailableCurrencies() {
            dataGridViewGetAvailableCurrencies.Columns.Clear();
            dataGridViewGetAvailableCurrencies.AutoGenerateColumns = false;
            dataGridViewGetAvailableCurrencies.Columns.Add("FinancialCurrencyAgainstFinancialCurrencyTypeRcd", "Financial Currency Against Financial Currency Type");
            dataGridViewGetAvailableCurrencies.Columns.Add("Amount", "Amount");
            dataGridViewGetAvailableCurrencies.Columns.Add("EqualsAmount", "Equals Amount");
            dataGridViewGetAvailableCurrencies.Columns.Add("DecimalCount", "Decimal Count");
            dataGridViewGetAvailableCurrencies.Columns.Add("FinancialCurrencyId", "Financial Currency Id");
            dataGridViewGetAvailableCurrencies.Columns.Add("ExtensionData", "");
            dataGridViewGetAvailableCurrencies.Columns["ExtensionData"].Visible = false;

            foreach ( DataGridViewColumn column in dataGridViewGetAvailableCurrencies.Columns ) {
                column.DataPropertyName = column.Name;
                if ( column.Name.EndsWith("Id") )
                    column.Visible = false;
            }

            dataGridViewGetAvailableCurrencies.AutoResizeColumns();
        }
    }
}
