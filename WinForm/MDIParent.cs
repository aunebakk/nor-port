using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolutionNorSolutionPort.UserInterface {
    public partial class MDIParent : Form {
        private int childFormNumber = 0;

        public MDIParent () {
            InitializeComponent ();
        }

        private void ShowNewForm ( object sender , EventArgs e ) {
            Form childForm = new Form ();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show ();
        }

        private void OpenFile ( object sender , EventArgs e ) {
            OpenFileDialog openFileDialog = new OpenFileDialog ();
            openFileDialog.InitialDirectory = Environment.GetFolderPath ( Environment.SpecialFolder.Personal );
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if ( openFileDialog.ShowDialog ( this ) == DialogResult.OK ) {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click ( object sender , EventArgs e ) {
            SaveFileDialog saveFileDialog = new SaveFileDialog ();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath ( Environment.SpecialFolder.Personal );
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if ( saveFileDialog.ShowDialog ( this ) == DialogResult.OK ) {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click ( object sender , EventArgs e ) {
            this.Close ();
        }

        private void CutToolStripMenuItem_Click ( object sender , EventArgs e ) {
        }

        private void CopyToolStripMenuItem_Click ( object sender , EventArgs e ) {
        }

        private void PasteToolStripMenuItem_Click ( object sender , EventArgs e ) {
        }

        private void ToolBarToolStripMenuItem_Click ( object sender , EventArgs e ) {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click ( object sender , EventArgs e ) {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click ( object sender , EventArgs e ) {
            LayoutMdi ( MdiLayout.Cascade );
        }

        private void TileVerticalToolStripMenuItem_Click ( object sender , EventArgs e ) {
            LayoutMdi ( MdiLayout.TileVertical );
        }

        private void TileHorizontalToolStripMenuItem_Click ( object sender , EventArgs e ) {
            LayoutMdi ( MdiLayout.TileHorizontal );
        }

        private void ArrangeIconsToolStripMenuItem_Click ( object sender , EventArgs e ) {
            LayoutMdi ( MdiLayout.ArrangeIcons );
        }

        private void CloseAllToolStripMenuItem_Click ( object sender , EventArgs e ) {
            foreach ( Form childForm in MdiChildren ) {
                childForm.Close ();
            }
        }

        private void crudeAddressToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeAddressSearch ();
            child.Show ( this );
        }
        private void crudeAgencyToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeAgencySearch ();
            child.Show ( this );
        }
        private void crudeAircraftToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeAircraftSearch ();
            child.Show ( this );
        }
        private void crudeAircraftCompartmentToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeAircraftCompartmentSearch ();
            child.Show ( this );
        }
        private void crudeAircraftCompartmentMeasurementToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeAircraftCompartmentMeasurementSearch ();
            child.Show ( this );
        }
        private void crudeAircraftDocumentToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeAircraftDocumentSearch ();
            child.Show ( this );
        }
        private void crudeAircraftIdentifierToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeAircraftIdentifierSearch ();
            child.Show ( this );
        }
        private void crudeAircraftMeasurementToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeAircraftMeasurementSearch ();
            child.Show ( this );
        }
        private void crudeAirlineToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeAirlineSearch ();
            child.Show ( this );
        }
        private void crudeAirlineBaseAirportToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeAirlineBaseAirportSearch ();
            child.Show ( this );
        }
        private void crudeAirlineContactMethodToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeAirlineContactMethodSearch ();
            child.Show ( this );
        }
        private void crudeAirlineIdentifierToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeAirlineIdentifierSearch ();
            child.Show ( this );
        }
        private void crudeAirlineLanguageToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeAirlineLanguageSearch ();
            child.Show ( this );
        }
        private void crudeAirlineLinkToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeAirlineLinkSearch ();
            child.Show ( this );
        }
        private void crudeAirportToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeAirportSearch ();
            child.Show ( this );
        }
        private void crudeAirportFacilityToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeAirportFacilitySearch ();
            child.Show ( this );
        }
        private void crudeAirportHotelLinkToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeAirportHotelLinkSearch ();
            child.Show ( this );
        }
        private void crudeAirportIdentifierToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeAirportIdentifierSearch ();
            child.Show ( this );
        }
        private void crudeAirportLinkToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeAirportLinkSearch ();
            child.Show ( this );
        }
        private void crudeAirportRunwayToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeAirportRunwaySearch ();
            child.Show ( this );
        }
        private void crudeAirportSupplierToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeAirportSupplierSearch ();
            child.Show ( this );
        }
        private void crudeAirportSupplierLinkToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeAirportSupplierLinkSearch ();
            child.Show ( this );
        }
        private void crudeAirportTerminalToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeAirportTerminalSearch ();
            child.Show ( this );
        }
        private void crudeAirportTerminalAirlineToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeAirportTerminalAirlineSearch ();
            child.Show ( this );
        }
        private void crudeBookingToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeBookingSearch ();
            child.Show ( this );
        }
        private void crudeBookingContactMethodToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeBookingContactMethodSearch ();
            child.Show ( this );
        }
        private void crudeBookingDocumentToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeBookingDocumentSearch ();
            child.Show ( this );
        }
        private void crudeBookingEventToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeBookingEventSearch ();
            child.Show ( this );
        }
        private void crudeBookingFlightSegmentToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeBookingFlightSegmentSearch ();
            child.Show ( this );
        }
        private void crudeBookingIdentifierToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeBookingIdentifierSearch ();
            child.Show ( this );
        }
        private void crudeBookingPassengerToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeBookingPassengerSearch ();
            child.Show ( this );
        }
        private void crudeBookingPassengerBaggageToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeBookingPassengerBaggageSearch ();
            child.Show ( this );
        }
        private void crudeBookingPassengerEventToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeBookingPassengerEventSearch ();
            child.Show ( this );
        }
        private void crudeBookingPassengerSeatToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeBookingPassengerSeatSearch ();
            child.Show ( this );
        }
        private void crudeBookingPassengerTicketToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeBookingPassengerTicketSearch ();
            child.Show ( this );
        }
        private void crudeBookingServiceRequestToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeBookingServiceRequestSearch ();
            child.Show ( this );
        }
        private void crudeCartProductToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeCartProductSearch ();
            child.Show ( this );
        }
        private void crudeCartProductPriceToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeCartProductPriceSearch ();
            child.Show ( this );
        }
        private void crudeCartUserToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeCartUserSearch ();
            child.Show ( this );
        }
        private void crudeCityToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeCitySearch ();
            child.Show ( this );
        }
        private void crudeClientToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeClientSearch ();
            child.Show ( this );
        }
        private void crudeClientContactMethodToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeClientContactMethodSearch ();
            child.Show ( this );
        }
        private void crudeClientEventToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeClientEventSearch ();
            child.Show ( this );
        }
        private void crudeClientLinkToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeClientLinkSearch ();
            child.Show ( this );
        }
        private void crudeCountryToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeCountrySearch ();
            child.Show ( this );
        }
        private void crudeDefaultChangeLogToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeDefaultChangeLogSearch ();
            child.Show ( this );
        }
        private void crudeDefaultErrorToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeDefaultErrorSearch ();
            child.Show ( this );
        }
        private void crudeDefaultIssueToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeDefaultIssueSearch ();
            child.Show ( this );
        }
        private void crudeDefaultPerformanceIssueToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeDefaultPerformanceIssueSearch ();
            child.Show ( this );
        }
        private void crudeDefaultPerformanceTimeToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeDefaultPerformanceTimeSearch ();
            child.Show ( this );
        }
        private void crudeDefaultPerformanceTimeRollupToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeDefaultPerformanceTimeRollupSearch ();
            child.Show ( this );
        }
        private void crudeDefaultResourceMeasurementToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeDefaultResourceMeasurementSearch ();
            child.Show ( this );
        }
        private void crudeDefaultRuleToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeDefaultRuleSearch ();
            child.Show ( this );
        }
        private void crudeDefaultSystemReferenceTableToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeDefaultSystemReferenceTableSearch ();
            child.Show ( this );
        }
        private void crudeDefaultSystemSettingToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeDefaultSystemSettingSearch ();
            child.Show ( this );
        }
        private void crudeDefaultTestToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeDefaultTestSearch ();
            child.Show ( this );
        }
        private void crudeDefaultTestRunToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeDefaultTestRunSearch ();
            child.Show ( this );
        }
        private void crudeDefaultUserToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeDefaultUserSearch ();
            child.Show ( this );
        }
        private void crudeDefaultUserActivityToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeDefaultUserActivitySearch ();
            child.Show ( this );
        }
        private void crudeDefaultVersionToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeDefaultVersionSearch ();
            child.Show ( this );
        }
        private void crudeExternalSystemToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeExternalSystemSearch ();
            child.Show ( this );
        }
        private void crudeFerryToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFerrySearch ();
            child.Show ( this );
        }
        private void crudeFerryIdentifierToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFerryIdentifierSearch ();
            child.Show ( this );
        }
        private void crudeFinancialAdjustmentToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialAdjustmentSearch ();
            child.Show ( this );
        }
        private void crudeFinancialBookingTransactionToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialBookingTransactionSearch ();
            child.Show ( this );
        }
        private void crudeFinancialCarRentalToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialCarRentalSearch ();
            child.Show ( this );
        }
        private void crudeFinancialCompanyToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialCompanySearch ();
            child.Show ( this );
        }
        private void crudeFinancialCostcentreToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialCostcentreSearch ();
            child.Show ( this );
        }
        private void crudeFinancialCouponToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialCouponSearch ();
            child.Show ( this );
        }
        private void crudeFinancialCurrencyToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialCurrencySearch ();
            child.Show ( this );
        }
        private void crudeFinancialFareToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialFareSearch ();
            child.Show ( this );
        }
        private void crudeFinancialFeeToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialFeeSearch ();
            child.Show ( this );
        }
        private void crudeFinancialFerryBookingToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialFerryBookingSearch ();
            child.Show ( this );
        }
        private void crudeFinancialHotelBookingToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialHotelBookingSearch ();
            child.Show ( this );
        }
        private void crudeFinancialPaymentToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialPaymentSearch ();
            child.Show ( this );
        }
        private void crudeFinancialPaymentAccountingToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialPaymentAccountingSearch ();
            child.Show ( this );
        }
        private void crudeFinancialPaymentBankToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialPaymentBankSearch ();
            child.Show ( this );
        }
        private void crudeFinancialPaymentCardToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialPaymentCardSearch ();
            child.Show ( this );
        }
        private void crudeFinancialPaymentCashToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialPaymentCashSearch ();
            child.Show ( this );
        }
        private void crudeFinancialPaymentCouponToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialPaymentCouponSearch ();
            child.Show ( this );
        }
        private void crudeFinancialPaymentVoucherToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialPaymentVoucherSearch ();
            child.Show ( this );
        }
        private void crudeFinancialServiceToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialServiceSearch ();
            child.Show ( this );
        }
        private void crudeFinancialSpecialServiceToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialSpecialServiceSearch ();
            child.Show ( this );
        }
        private void crudeFinancialTaxToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialTaxSearch ();
            child.Show ( this );
        }
        private void crudeFinancialVoucherToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFinancialVoucherSearch ();
            child.Show ( this );
        }
        private void crudeFlightToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFlightSearch ();
            child.Show ( this );
        }
        private void crudeFlightEventToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFlightEventSearch ();
            child.Show ( this );
        }
        private void crudeFlightIdentifierToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFlightIdentifierSearch ();
            child.Show ( this );
        }
        private void crudeFlightScheduleToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFlightScheduleSearch ();
            child.Show ( this );
        }
        private void crudeFlightScheduleIdentifierToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFlightScheduleIdentifierSearch ();
            child.Show ( this );
        }
        private void crudeFlightScheduleSegmentToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFlightScheduleSegmentSearch ();
            child.Show ( this );
        }
        private void crudeFlightScheduleSegmentRuleToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFlightScheduleSegmentRuleSearch ();
            child.Show ( this );
        }
        private void crudeFlightSegmentToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFlightSegmentSearch ();
            child.Show ( this );
        }
        private void crudeFlightSegmentEventToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeFlightSegmentEventSearch ();
            child.Show ( this );
        }
        private void crudePassengerToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudePassengerSearch ();
            child.Show ( this );
        }
        private void crudeProductToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeProductSearch ();
            child.Show ( this );
        }
        private void crudeReportingRoundupToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeReportingRoundupSearch ();
            child.Show ( this );
        }
        private void crudeServiceCarRentalToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeServiceCarRentalSearch ();
            child.Show ( this );
        }
        private void crudeServiceCarRentalLinkToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeServiceCarRentalLinkSearch ();
            child.Show ( this );
        }
        private void crudeServiceFerryToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeServiceFerrySearch ();
            child.Show ( this );
        }
        private void crudeServiceHotelToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeServiceHotelSearch ();
            child.Show ( this );
        }
        private void crudeServiceHotelImageToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeServiceHotelImageSearch ();
            child.Show ( this );
        }
        private void crudeServiceHotelLinkToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeServiceHotelLinkSearch ();
            child.Show ( this );
        }
        private void crudeServicePackageToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeServicePackageSearch ();
            child.Show ( this );
        }
        private void crudeServicePackagePromotionToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeServicePackagePromotionSearch ();
            child.Show ( this );
        }
        private void crudeServiceSpecialServiceRequestToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeServiceSpecialServiceRequestSearch ();
            child.Show ( this );
        }
        private void crudeTimezoneToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            var child = new CrudeTimezoneSearch ();
            child.Show ( this );
        }
    }
}
