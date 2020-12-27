using System;
using System.ComponentModel;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface
{

    public partial class FinancialCurrencyLivePicker : UserControl
    {

        public event EventHandler Picked;

        private System.Guid _financialCurrencyId;

        public FinancialCurrencyLivePicker() {
            InitializeComponent();
        }

        public System.Guid SelectedValue {
            get {
                return _financialCurrencyId;
            }
            set {
                if ( !DesignMode && _financialCurrencyId != value ) {
                    _financialCurrencyId = value;
                    var financialCurrency = new CrudeFinancialCurrencyServiceClient();
                    try {
                        CrudeFinancialCurrencyContract contract = financialCurrency.FetchByFinancialCurrencyId(_financialCurrencyId);
                        if ( contract != null ) {
                            txtFinancialCurrencyName.Text = contract.FinancialCurrencyTypeName;
                            txtFinancialCurrencyCode.Text = contract.FinancialCurrencyTypeCode;
                        }
                    } catch ( Exception ex ) {
                        MessageBox.Show(ex.Message);
                    } finally {
                        if ( financialCurrency != null )
                            financialCurrency.Close();
                    }

                    if ( this.Picked != null )
                        this.Picked(new object(), new EventArgs());
                };
            }
        }

        private void txtFinancialCurrencyCode_Validating(object sender, CancelEventArgs e) {
            if ( !DesignMode ) {
                // empty picker on no code
                if ( txtFinancialCurrencyCode.Text == String.Empty ) {
                    _financialCurrencyId = Guid.Empty;
                    txtFinancialCurrencyName.Text = string.Empty;
                    txtFinancialCurrencyCode.Text = string.Empty;
                    return;
                }

                CrudeFinancialCurrencyServiceClient financialCurrency = null;

                try {
                    financialCurrency = new CrudeFinancialCurrencyServiceClient();
                    CrudeFinancialCurrencyContract contract = financialCurrency.FetchByFinancialCurrencyTypeCode(txtFinancialCurrencyCode.Text);

                    if ( contract != null ) {
                        txtFinancialCurrencyCode.Text = contract.FinancialCurrencyTypeCode;
                        txtFinancialCurrencyName.Text = contract.FinancialCurrencyTypeName;
                        _financialCurrencyId = contract.FinancialCurrencyId;
                    }

                    if ( this.Picked != null )
                        this.Picked(new object(), new EventArgs());
                } catch ( Exception ex ) {
                    MessageBox.Show(ex.Message);
                } finally {
                    if ( financialCurrency != null )
                        financialCurrency.Close();
                }
            }
        }
    }
}
