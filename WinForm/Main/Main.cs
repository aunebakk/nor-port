using System;
using System.Net;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface
{
    public partial class Main : Form
    {
        public Main() {
            InitializeComponent();
            Size = new System.Drawing.Size(1024, 568);
        }

        private void Log(string message) {
            Singleton.Instance.Log(message);
        }

        private void Error(Exception ex) {
            Singleton.Instance.Error(ex);
        }

        private void CheckForm(Form form) {
            Singleton.Instance.CheckForm(form);
        }

        void FormOpened(string formName) {
            Log("open form: " + formName);

            if ( Singleton.Instance.UserId == Guid.Empty ) {
                MessageBox.Show("Please log in");
                return;
            }

            var activity = new DefaultUserActivityServiceClient();
            try {
                activity.AddActivity(   Singleton.Instance.UserId,  // Async
                                        DefaultUserActivityTypeRef.FormOpened,
                                        formName,
                                        Dns.GetHostName()
                                        );
            } catch {
            } finally {
                activity.Close();
            }

        }

        public void ShowUserInfo() {
            FormOpened("ShowUserInfo");

            var service = new CrudeDefaultUserServiceClient();

            try {
                var contract = service.FetchByDefaultUserId(Singleton.Instance.UserId);

                Text = "nor-port: User code: " + contract.DefaultUserCode
                        + ", Name: " + contract.DefaultUserName;

                Log(Text);

            } catch {
                throw;
            } finally {
                service.Close();
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e) {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e) {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e) {
            foreach ( Form childForm in MdiChildren ) {
                childForm.Close();
            }
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeDefaultUserSearch");

                var mdiChild = new CrudeDefaultUserSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(string.Empty, Singleton.Instance.UserId);
            } catch ( Exception ex ) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        protected override void OnSizeChanged(EventArgs e) {
            base.OnSizeChanged(e);
            this.Refresh();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            FormOpened("AboutBox");

            AboutBox newChild = new AboutBox();
            newChild.Show();
        }

        private void Main_Shown(object sender, EventArgs e) {
            Singleton.Instance.LoginShow(this);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e) {

            // todo, validate net connection first!
            Log("Closing main form");
            if ( Singleton.Instance.UserId == Guid.Empty )
                return;

            try {
                var activity = new DefaultUserActivityServiceClient();
                activity.AddActivity(   Singleton.Instance.UserId,  // Async
                                        DefaultUserActivityTypeRef.Logout,
                                        e.CloseReason.ToString(),
                                        Dns.GetHostName()
                                        );
                activity.Close();
            } catch {
                // never mind, just close
            } finally {
                // never mind, just close
            }
        }

        private void referenceToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("DefaultSystemReferenceTableSearch");

                var mdiChild = new DefaultSystemReferenceTableSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(Singleton.Instance.UserId);
            } catch ( Exception ex ) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeDefaultSystemSettingSearch");

                var mdiChild = new CrudeDefaultSystemSettingSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(string.Empty, Singleton.Instance.UserId);
            } catch ( Exception ex ) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void userActivityToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("DefaultUserActivityRecentSearch");

                var mdiChild = new DefaultUserActivityRecentSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch ( Exception ex ) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void activityOverviewToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("LogCountMonth");

                var mdiChild = new DefaultStatisticsByMonthSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch ( Exception ex ) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void generalStatisticsToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("Statistics");

                var mdiChild = new Statistics();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch ( Exception ex ) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void errorLogToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeDefaultErrorSearch");

                var mdiChild = new CrudeDefaultErrorSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(string.Empty, string.Empty, Singleton.Instance.UserId);
            } catch ( Exception ex ) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void changeLogToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeDefaultChangeLogSearch");

                var mdiChild = new CrudeDefaultChangeLogSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(string.Empty, Singleton.Instance.UserId, Guid.Empty);
            } catch ( Exception ex ) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void issueToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeDefaultIssueSearch");

                var mdiChild = new CrudeDefaultIssueSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(string.Empty, string.Empty, Guid.Empty, Singleton.Instance.UserId);
            } catch ( Exception ex ) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void errorRuleToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeDefaultRuleSearch");

                var mdiChild = new CrudeDefaultRuleSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(string.Empty, Singleton.Instance.UserId);
            } catch ( Exception ex ) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void countryToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeCountrySearch");

                var mdiChild = new CrudeCountrySearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(Guid.Empty, Singleton.Instance.UserId);
            } catch ( Exception ex ) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void cityToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeCitySearch");

                var mdiChild = new CrudeCitySearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(Guid.Empty, Singleton.Instance.UserId, Guid.Empty);
            } catch ( Exception ex ) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened ( "ClientSearch" );

                var mdiChild = new ClientSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(
                    //string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, Guid.Empty, 
                    userId:Singleton.Instance.UserId
                    );

            } catch ( Exception ex ) {
                Error ( ex );
            }
            Cursor.Current = Cursors.Default;
        }

        private void addressToolStripMenuItem_Click ( Object sender , EventArgs e ) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened ( "CrudeLocationAddressSearch" );

                var mdiChild = new CrudeAddressSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(string.Empty, Singleton.Instance.UserId);
            } catch ( Exception ex ) {
                Error ( ex );
            }
            Cursor.Current = Cursors.Default;
        }

        private void crudeAddressToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAddressSearch();
            child.Show(this);
        }
        private void crudeAddressTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAddressTypeRefSearch();
            child.Show(this);
        }
        private void crudeAgencyToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAgencySearch();
            child.Show(this);
        }
        private void crudeAircraftToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAircraftSearch();
            child.Show(this);
        }
        private void crudeAircraftBodyRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAircraftBodyRefSearch();
            child.Show(this);
        }
        private void crudeAircraftCompartmentToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAircraftCompartmentSearch();
            child.Show(this);
        }
        private void crudeAircraftCompartmentMeasurementToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAircraftCompartmentMeasurementSearch();
            child.Show(this);
        }
        private void crudeAircraftCompartmentTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAircraftCompartmentTypeRefSearch();
            child.Show(this);
        }
        private void crudeAircraftConfigurationRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAircraftConfigurationRefSearch();
            child.Show(this);
        }
        private void crudeAircraftDocumentToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAircraftDocumentSearch();
            child.Show(this);
        }
        private void crudeAircraftDocumentTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAircraftDocumentTypeRefSearch();
            child.Show(this);
        }
        private void crudeAircraftIdentifierToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAircraftIdentifierSearch();
            child.Show(this);
        }
        private void crudeAircraftIdentifierTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAircraftIdentifierTypeRefSearch();
            child.Show(this);
        }
        private void crudeAircraftMeasurementToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAircraftMeasurementSearch();
            child.Show(this);
        }
        private void crudeAircraftTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAircraftTypeRefSearch();
            child.Show(this);
        }
        private void crudeAirlineToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAirlineSearch();
            child.Show(this);
        }
        private void crudeAirlineBaseAirportToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAirlineBaseAirportSearch();
            child.Show(this);
        }
        private void crudeAirlineContactMethodToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAirlineContactMethodSearch();
            child.Show(this);
        }
        private void crudeAirlineIdentifierToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAirlineIdentifierSearch();
            child.Show(this);
        }
        private void crudeAirlineIdentifierTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAirlineIdentifierTypeRefSearch();
            child.Show(this);
        }
        private void crudeAirlineLanguageToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAirlineLanguageSearch();
            child.Show(this);
        }
        private void crudeAirlineLinkToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAirlineLinkSearch();
            child.Show(this);
        }
        private void crudeAirlineTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAirlineTypeRefSearch();
            child.Show(this);
        }
        private void crudeAirportToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAirportSearch();
            child.Show(this);
        }
        private void crudeAirportFacilityToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAirportFacilitySearch();
            child.Show(this);
        }
        private void crudeAirportFacilityTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAirportFacilityTypeRefSearch();
            child.Show(this);
        }
        private void crudeAirportHotelLinkToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAirportHotelLinkSearch();
            child.Show(this);
        }
        private void crudeAirportIdentifierToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAirportIdentifierSearch();
            child.Show(this);
        }
        private void crudeAirportIdentifierTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAirportIdentifierTypeRefSearch();
            child.Show(this);
        }
        private void crudeAirportLinkToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAirportLinkSearch();
            child.Show(this);
        }
        private void crudeAirportRunwayToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAirportRunwaySearch();
            child.Show(this);
        }
        private void crudeAirportSupplierToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAirportSupplierSearch();
            child.Show(this);
        }
        private void crudeAirportSupplierLinkToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAirportSupplierLinkSearch();
            child.Show(this);
        }
        private void crudeAirportTerminalToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAirportTerminalSearch();
            child.Show(this);
        }
        private void crudeAirportTerminalAirlineToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAirportTerminalAirlineSearch();
            child.Show(this);
        }
        private void crudeAirportTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeAirportTypeRefSearch();
            child.Show(this);
        }
        private void crudeBookingToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeBookingSearch();
            child.Show(this);
        }
        private void crudeBookingContactMethodToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeBookingContactMethodSearch();
            child.Show(this);
        }
        private void crudeBookingDocumentToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeBookingDocumentSearch();
            child.Show(this);
        }
        private void crudeBookingDocumentTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeBookingDocumentTypeRefSearch();
            child.Show(this);
        }
        private void crudeBookingEventToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeBookingEventSearch();
            child.Show(this);
        }
        private void crudeBookingEventTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeBookingEventTypeRefSearch();
            child.Show(this);
        }
        private void crudeBookingFlightSegmentToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeBookingFlightSegmentSearch();
            child.Show(this);
        }
        private void crudeBookingIdentifierToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeBookingIdentifierSearch();
            child.Show(this);
        }
        private void crudeBookingIdentifierTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeBookingIdentifierTypeRefSearch();
            child.Show(this);
        }
        private void crudeBookingPassengerToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeBookingPassengerSearch();
            child.Show(this);
        }
        private void crudeBookingPassengerBaggageToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeBookingPassengerBaggageSearch();
            child.Show(this);
        }
        private void crudeBookingPassengerEventToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeBookingPassengerEventSearch();
            child.Show(this);
        }
        private void crudeBookingPassengerEventTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeBookingPassengerEventTypeRefSearch();
            child.Show(this);
        }
        private void crudeBookingPassengerSeatToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeBookingPassengerSeatSearch();
            child.Show(this);
        }
        private void crudeBookingPassengerTicketToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeBookingPassengerTicketSearch();
            child.Show(this);
        }
        private void crudeBookingServiceRequestToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeBookingServiceRequestSearch();
            child.Show(this);
        }
        private void crudeBookingSourceRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeBookingSourceRefSearch();
            child.Show(this);
        }
        private void crudeCartProductToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeCartProductSearch();
            child.Show(this);
        }
        private void crudeCartProductPriceToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeCartProductPriceSearch();
            child.Show(this);
        }
        private void crudeCartUserToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeCartUserSearch();
            child.Show(this);
        }
        private void crudeCityToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeCitySearch();
            child.Show(this);
        }
        private void crudeClientToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeClientSearch();
            child.Show(this);
        }
        private void crudeClientContactMethodToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeClientContactMethodSearch();
            child.Show(this);
        }
        private void crudeClientEventToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeClientEventSearch();
            child.Show(this);
        }
        private void crudeClientEventTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeClientEventTypeRefSearch();
            child.Show(this);
        }
        private void crudeClientLinkToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeClientLinkSearch();
            child.Show(this);
        }
        private void crudeClientTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeClientTypeRefSearch();
            child.Show(this);
        }
        private void crudeContactMethodRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeContactMethodRefSearch();
            child.Show(this);
        }
        private void crudeCountryToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeCountrySearch();
            child.Show(this);
        }
        private void crudeDateTimeTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeDateTimeTypeRefSearch();
            child.Show(this);
        }
        private void crudeDefaultChangeLogToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeDefaultChangeLogSearch();
            child.Show(this);
        }
        private void crudeDefaultChangeLogTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeDefaultChangeLogTypeRefSearch();
            child.Show(this);
        }
        private void crudeDefaultErrorToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeDefaultErrorSearch();
            child.Show(this);
        }
        private void crudeDefaultErrorLayerRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeDefaultErrorLayerRefSearch();
            child.Show(this);
        }
        private void crudeDefaultErrorTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeDefaultErrorTypeRefSearch();
            child.Show(this);
        }
        private void crudeDefaultIssueToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeDefaultIssueSearch();
            child.Show(this);
        }
        private void crudeDefaultIssueStatusRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeDefaultIssueStatusRefSearch();
            child.Show(this);
        }
        private void crudeDefaultIssueTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeDefaultIssueTypeRefSearch();
            child.Show(this);
        }
        private void crudeDefaultPerformanceIssueToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeDefaultPerformanceIssueSearch();
            child.Show(this);
        }
        private void crudeDefaultPerformanceTimeToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeDefaultPerformanceTimeSearch();
            child.Show(this);
        }
        private void crudeDefaultPerformanceTimeRollupToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeDefaultPerformanceTimeRollupSearch();
            child.Show(this);
        }
        private void crudeDefaultResourceMeasurementToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeDefaultResourceMeasurementSearch();
            child.Show(this);
        }
        private void crudeDefaultRuleToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeDefaultRuleSearch();
            child.Show(this);
        }
        private void crudeDefaultRuleTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeDefaultRuleTypeRefSearch();
            child.Show(this);
        }
        private void crudeDefaultStateRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeDefaultStateRefSearch();
            child.Show(this);
        }
        private void crudeDefaultSystemReferenceTableToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeDefaultSystemReferenceTableSearch();
            child.Show(this);
        }
        private void crudeDefaultSystemSettingToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeDefaultSystemSettingSearch();
            child.Show(this);
        }
        private void crudeDefaultSystemSettingRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeDefaultSystemSettingRefSearch();
            child.Show(this);
        }
        private void crudeDefaultTestToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeDefaultTestSearch();
            child.Show(this);
        }
        private void crudeDefaultTestRunToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeDefaultTestRunSearch();
            child.Show(this);
        }
        private void crudeDefaultTestRunResultRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeDefaultTestRunResultRefSearch();
            child.Show(this);
        }
        private void crudeDefaultUserToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeDefaultUserSearch();
            child.Show(this);
        }
        private void crudeDefaultUserActivityToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeDefaultUserActivitySearch();
            child.Show(this);
        }
        private void crudeDefaultUserActivityTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeDefaultUserActivityTypeRefSearch();
            child.Show(this);
        }
        private void crudeDefaultVersionToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeDefaultVersionSearch();
            child.Show(this);
        }
        private void crudeExternalSystemToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeExternalSystemSearch();
            child.Show(this);
        }
        private void crudeFerryToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFerrySearch();
            child.Show(this);
        }
        private void crudeFerryIdentifierToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFerryIdentifierSearch();
            child.Show(this);
        }
        private void crudeFerryIdentifierTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFerryIdentifierTypeRefSearch();
            child.Show(this);
        }
        private void crudeFerryTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFerryTypeRefSearch();
            child.Show(this);
        }
        private void crudeFinancialAdjustmentToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFinancialAdjustmentSearch();
            child.Show(this);
        }
        private void crudeFinancialAdjustmentTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFinancialAdjustmentTypeRefSearch();
            child.Show(this);
        }
        private void crudeFinancialBankAccountNumberTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFinancialBankAccountNumberTypeRefSearch();
            child.Show(this);
        }
        private void crudeFinancialBookingTransactionToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFinancialBookingTransactionSearch();
            child.Show(this);
        }
        private void crudeFinancialBookingTransactionTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFinancialBookingTransactionTypeRefSearch();
            child.Show(this);
        }
        private void crudeFinancialCarRentalToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFinancialCarRentalSearch();
            child.Show(this);
        }
        private void crudeFinancialCardTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFinancialCardTypeRefSearch();
            child.Show(this);
        }
        private void crudeFinancialCompanyToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFinancialCompanySearch();
            child.Show(this);
        }
        private void crudeFinancialCostcentreToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFinancialCostcentreSearch();
            child.Show(this);
        }
        private void crudeFinancialCouponToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFinancialCouponSearch();
            child.Show(this);
        }
        private void crudeFinancialCouponTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFinancialCouponTypeRefSearch();
            child.Show(this);
        }
        private void crudeFinancialCurrencyToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFinancialCurrencySearch();
            child.Show(this);
        }
        private void crudeFinancialCurrencyTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFinancialCurrencyTypeRefSearch();
            child.Show(this);
        }
        private void crudeFinancialFareToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFinancialFareSearch();
            child.Show(this);
        }
        private void crudeFinancialFareTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFinancialFareTypeRefSearch();
            child.Show(this);
        }
        private void crudeFinancialFeeToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFinancialFeeSearch();
            child.Show(this);
        }
        private void crudeFinancialFeeTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFinancialFeeTypeRefSearch();
            child.Show(this);
        }
        private void crudeFinancialFerryBookingToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFinancialFerryBookingSearch();
            child.Show(this);
        }
        private void crudeFinancialHotelBookingToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFinancialHotelBookingSearch();
            child.Show(this);
        }
        private void crudeFinancialPaymentToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFinancialPaymentSearch();
            child.Show(this);
        }
        private void crudeFinancialPaymentAccountingToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFinancialPaymentAccountingSearch();
            child.Show(this);
        }
        private void crudeFinancialPaymentBankToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFinancialPaymentBankSearch();
            child.Show(this);
        }
        private void crudeFinancialPaymentCardToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFinancialPaymentCardSearch();
            child.Show(this);
        }
        private void crudeFinancialPaymentCashToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFinancialPaymentCashSearch();
            child.Show(this);
        }
        private void crudeFinancialPaymentCouponToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFinancialPaymentCouponSearch();
            child.Show(this);
        }
        private void crudeFinancialPaymentTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFinancialPaymentTypeRefSearch();
            child.Show(this);
        }
        private void crudeFinancialPaymentVoucherToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFinancialPaymentVoucherSearch();
            child.Show(this);
        }
        private void crudeFinancialServiceToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFinancialServiceSearch();
            child.Show(this);
        }
        private void crudeFinancialSpecialServiceToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFinancialSpecialServiceSearch();
            child.Show(this);
        }
        private void crudeFinancialTaxToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFinancialTaxSearch();
            child.Show(this);
        }
        private void crudeFinancialTaxTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFinancialTaxTypeRefSearch();
            child.Show(this);
        }
        private void crudeFinancialVoucherToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFinancialVoucherSearch();
            child.Show(this);
        }
        private void crudeFinancialVoucherTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFinancialVoucherTypeRefSearch();
            child.Show(this);
        }
        private void crudeFlightToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFlightSearch();
            child.Show(this);
        }
        private void crudeFlightEventToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFlightEventSearch();
            child.Show(this);
        }
        private void crudeFlightIdentifierToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFlightIdentifierSearch();
            child.Show(this);
        }
        private void crudeFlightIdentifierTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFlightIdentifierTypeRefSearch();
            child.Show(this);
        }
        private void crudeFlightScheduleToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFlightScheduleSearch();
            child.Show(this);
        }
        private void crudeFlightScheduleIdentifierToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFlightScheduleIdentifierSearch();
            child.Show(this);
        }
        private void crudeFlightScheduleSegmentToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFlightScheduleSegmentSearch();
            child.Show(this);
        }
        private void crudeFlightScheduleSegmentRuleToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFlightScheduleSegmentRuleSearch();
            child.Show(this);
        }
        private void crudeFlightScheduleSegmentRuleRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFlightScheduleSegmentRuleRefSearch();
            child.Show(this);
        }
        private void crudeFlightSegmentToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFlightSegmentSearch();
            child.Show(this);
        }
        private void crudeFlightSegmentEventToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeFlightSegmentEventSearch();
            child.Show(this);
        }
        private void crudeGenderRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeGenderRefSearch();
            child.Show(this);
        }
        private void crudeLanguageRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeLanguageRefSearch();
            child.Show(this);
        }
        private void crudeLinkTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeLinkTypeRefSearch();
            child.Show(this);
        }
        private void crudeNationalityRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeNationalityRefSearch();
            child.Show(this);
        }
        private void crudePassengerToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudePassengerSearch();
            child.Show(this);
        }
        private void crudePassengerTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudePassengerTypeRefSearch();
            child.Show(this);
        }
        private void crudeProductToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeProductSearch();
            child.Show(this);
        }
        private void crudeReportingRoundupToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeReportingRoundupSearch();
            child.Show(this);
        }
        private void crudeReportingRoundupTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeReportingRoundupTypeRefSearch();
            child.Show(this);
        }
        private void crudeServiceCarRentalToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeServiceCarRentalSearch();
            child.Show(this);
        }
        private void crudeServiceCarRentalLinkToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeServiceCarRentalLinkSearch();
            child.Show(this);
        }
        private void crudeServiceFerryToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeServiceFerrySearch();
            child.Show(this);
        }
        private void crudeServiceHotelToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeServiceHotelSearch();
            child.Show(this);
        }
        private void crudeServiceHotelImageToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeServiceHotelImageSearch();
            child.Show(this);
        }
        private void crudeServiceHotelLinkToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeServiceHotelLinkSearch();
            child.Show(this);
        }
        private void crudeServiceImageTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeServiceImageTypeRefSearch();
            child.Show(this);
        }
        private void crudeServicePackageToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeServicePackageSearch();
            child.Show(this);
        }
        private void crudeServicePackagePromotionToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeServicePackagePromotionSearch();
            child.Show(this);
        }
        private void crudeServiceRequestStatusRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeServiceRequestStatusRefSearch();
            child.Show(this);
        }
        private void crudeServiceSpecialServiceRequestToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeServiceSpecialServiceRequestSearch();
            child.Show(this);
        }
        private void crudeServiceSpecialServiceRequestGroupRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeServiceSpecialServiceRequestGroupRefSearch();
            child.Show(this);
        }
        private void crudeServiceSpecialServiceRequestOperationRuleRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeServiceSpecialServiceRequestOperationRuleRefSearch();
            child.Show(this);
        }
        private void crudeServiceSpecialServiceRequestRequirementRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeServiceSpecialServiceRequestRequirementRefSearch();
            child.Show(this);
        }
        private void crudeServiceTypeRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeServiceTypeRefSearch();
            child.Show(this);
        }
        private void crudeTimezoneToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeTimezoneSearch();
            child.Show(this);
        }
        private void crudeTitleRefToolStripMenuItem_Click(Object sender, EventArgs e) {
            var child = new CrudeTitleRefSearch();
            child.Show(this);
        }

        private void airlinesToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("AirlineSearch");

                var mdiChild = new AirlineSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(string.Empty, Guid.Empty, Guid.Empty, Singleton.Instance.UserId);
            }
            catch (Exception ex)
            {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void aircraftToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("Aircrafts");

                var mdiChild = new AircraftSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(
                        aircraftTypeRcd: string.Empty,
                        aircraftConfigurationRcd: string.Empty,
                        aircraftBodyRcd: string.Empty,
                        aircraftMeasurementId: Guid.Empty,
                        productId: Guid.Empty,
                        userId: Singleton.Instance.UserId
                        );

            } catch ( Exception ex ) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;

        }

        private void airportsToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeAirportSearch");

                var mdiChild = new CrudeAirportSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(string.Empty, Guid.Empty, Guid.Empty, Guid.Empty, Singleton.Instance.UserId);
            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void airportToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("AirportSearch");

                var mdiChild = new GetAirportIndexWithFilterSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(); // string.Empty, Guid.Empty, Guid.Empty, Singleton.Instance.UserId
            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void agencyToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeAgencySearch");

                var mdiChild = new CrudeAgencySearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(Singleton.Instance.UserId);
            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void ferryToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("ServiceFerryListSearch");

                var mdiChild = new ServiceFerryListSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(
                        //userId: Singleton.Instance.UserId
                        );

            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void externalSystemToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeExternalSystemSearch");

                var mdiChild = new CrudeExternalSystemSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(Singleton.Instance.UserId);
            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeFinancialCompanySearch");

                var mdiChild = new CrudeFinancialCompanySearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(Singleton.Instance.UserId);
            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void costcentreToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeFinancialCostcentreSearch");

                var mdiChild = new CrudeFinancialCostcentreSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(Guid.Empty, Singleton.Instance.UserId);
            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void currencyToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeFinancialCurrencySearch");

                var mdiChild = new CrudeFinancialCurrencySearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(string.Empty, string.Empty, Singleton.Instance.UserId);
            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void fareToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeFinancialFareSearch");

                var mdiChild = new CrudeFinancialFareSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(string.Empty,
                                Guid.Empty,
                                Guid.Empty,
                                Singleton.Instance.FinancialCurrencyId,
                                Singleton.Instance.UserId
                                );
            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void feeToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeFinancialFeeSearch");

                var mdiChild = new CrudeFinancialFeeSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(string.Empty, Singleton.Instance.UserId, Guid.Empty);
            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void taxToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("CrudeFinancialTaxSearch");

                var mdiChild = new CrudeFinancialTaxSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(string.Empty,
                                Singleton.Instance.FinancialCurrencyId,
                                Singleton.Instance.UserId
                                );
            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void passengerNameListToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void flightsFlownToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void activeFlightsToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("ScheduleSearch");

                var mdiChild = new ScheduleSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void flightsToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("FlightsForPeriodLiveSearch");

                var mdiChild = new FlightsForPeriodLiveSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void availabilityToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("FlightsWithBookingInformationSearch");

                var mdiChild = new FlightsWithBookingInformationLiveSearch();
                //var mdiChild = new FlightsWithBookingInformationSearch();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void bookingsToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("BookingList");

                var mdiChild = new BookingsOpenSearchLive();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show();
            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void checkinToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("Checkin");

                var mdiChild = new Checkin();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(Singleton.Instance.UserId);
            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void promotionToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                FormOpened("ServicePackagePromotion");

                var mdiChild = new ServicePackagePromotion();
                CheckForm(mdiChild);
                mdiChild.MdiParent = this;
                mdiChild.Show(Singleton.Instance.UserId);

            } catch (Exception ex) {
                Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
