using SolutionNorSolutionPort.BusinessLogicLayer;
using System;
using System.Windows.Forms;

namespace SolutionNorSolutionPort.UserInterface {


    public partial class BookingsOpenSearchLive : Form {

        public BookingsOpenSearchLive() {
            InitializeComponent();
            InitializeGridBookingsOpen();
            AcceptButton = btnSearch;
            CancelButton = btnClose;
        }

        public new void Show() {
            btnSearch_Click(new object(), new EventArgs());
            base.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            BookingSearchService bookingsOpen = new BookingSearchService();
            BindingSource bindingSource = new BindingSource();

            try {
                bindingSource.DataSource = bookingsOpen.BookingsOpen();
                gridBookingsOpen.AutoGenerateColumns = true;
                gridBookingsOpen.DataSource = bindingSource;
                gridBookingsOpen.AutoResizeColumns();
                gridBookingsOpen.Refresh();
            } catch (Exception ex) {
                Singleton.Instance.Error(ex);
                MessageBox.Show(ex.Message);
            } finally {
                bookingsOpen.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void InitializeGridBookingsOpen() {
            gridBookingsOpen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridBookingsOpen.Columns.Clear();
            gridBookingsOpen.AutoGenerateColumns = false;
            gridBookingsOpen.Columns.Add("BookingId", "Booking Id");
            gridBookingsOpen.Columns.Add("RecordLocator", "Record Locator");
            gridBookingsOpen.Columns.Add("LastBookingEventTypeName", "Last Booking Event Type Name");
            gridBookingsOpen.Columns.Add("LastBookingContactMethod", "Last Booking Contact Method");
            gridBookingsOpen.Columns.Add("BookingSourceName", "Booking Source Name");
            gridBookingsOpen.Columns.Add("AdultCount", "Adult Count");
            gridBookingsOpen.Columns.Add("ChildCount", "Child Count");
            gridBookingsOpen.Columns.Add("InfantCount", "Infant Count");
            gridBookingsOpen.Columns.Add("LastBookingEventDateTime", "Date Time");
            gridBookingsOpen.Columns.Add("ExtensionData", "");
            gridBookingsOpen.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in gridBookingsOpen.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id")) {
                    column.Visible = false;
                }
            }

            gridBookingsOpen.AutoResizeColumns();
        }

        private void buttonNew_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                Singleton.Instance.Log("Booking New");

                var mdiChild = new Booking();
                mdiChild.MdiParent = MdiParent;
                mdiChild.ShowAsAdd(Singleton.Instance.UserId);

            } catch (Exception ex) {
                Singleton.Instance.Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void buttonEdit_Click(object sender, EventArgs e) {
            Cursor.Current = Cursors.WaitCursor;
            try {
                Singleton.Instance.Log("Booking Edit");

                var mdiChild = new Booking();
                mdiChild.MdiParent = MdiParent;
                mdiChild.ShowAsEdit(
                    (Guid)gridBookingsOpen.CurrentRow.Cells["BookingId"].Value,
                    Singleton.Instance.UserId
                    );

            } catch (Exception ex) {
                Singleton.Instance.Error(ex);
            }
            Cursor.Current = Cursors.Default;
        }

        private void BookingsOpenSearchLive_Load(object sender, EventArgs e) {
            btnSearch_Click(new object(), new EventArgs());
        }
    }
}
