using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class GetServicePackageDurian : UserControl {
        
        public GetServicePackageDurian() {
           InitializeComponent();
           InitializeGridGetServicePackage();
        }
        
        public virtual string ServicePackageName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetServicePackage.CurrentRow.Cells["ServicePackageName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid ServiceHotelId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetServicePackage.CurrentRow.Cells["ServiceHotelId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string HotelName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetServicePackage.CurrentRow.Cells["HotelName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid ServiceSpecialServiceRequestId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetServicePackage.CurrentRow.Cells["ServiceSpecialServiceRequestId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string ServiceSpecialServiceRequestName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetServicePackage.CurrentRow.Cells["ServiceSpecialServiceRequestName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid ServiceCarRentalId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetServicePackage.CurrentRow.Cells["ServiceCarRentalId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string CarName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetServicePackage.CurrentRow.Cells["CarName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid DepartureAirportId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetServicePackage.CurrentRow.Cells["DepartureAirportId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string DepartureAirportName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetServicePackage.CurrentRow.Cells["DepartureAirportName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid ArrivalAirportId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetServicePackage.CurrentRow.Cells["ArrivalAirportId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string ArrivalAirportName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetServicePackage.CurrentRow.Cells["ArrivalAirportName"].Value; else return String.Empty;;
            }
        }
        
        public virtual int StayDurationDays {
            get {
                if (!DesignMode) return (System.Int32) dataGridViewGetServicePackage.CurrentRow.Cells["StayDurationDays"].Value; else return 0;;
            }
        }
        
        public virtual System.Guid UserId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetServicePackage.CurrentRow.Cells["UserId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string DefaultUserName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetServicePackage.CurrentRow.Cells["DefaultUserName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewGetServicePackage.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.Guid ServicePackageId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetServicePackage.CurrentRow.Cells["ServicePackageId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewGetServicePackage.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewGetServicePackage_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshGetServicePackage(System.Guid servicePackageId) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewGetServicePackage.CurrentRow != null)
                    position = dataGridViewGetServicePackage.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new ServiceSearchService().GetServicePackage(servicePackageId);
                dataGridViewGetServicePackage.AutoGenerateColumns = true;
                dataGridViewGetServicePackage.DataSource = bindingSource;
                dataGridViewGetServicePackage.AutoResizeColumns();

                // position to previous row
                if (dataGridViewGetServicePackage.Rows.Count > 0) { 
                    dataGridViewGetServicePackage.CurrentCell = 
                        dataGridViewGetServicePackage.Rows[position].Cells[1];
                    dataGridViewGetServicePackage.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridGetServicePackage() {
            dataGridViewGetServicePackage.Columns.Clear();
            dataGridViewGetServicePackage.AutoGenerateColumns = false;
            dataGridViewGetServicePackage.Columns.Add("ServicePackageName","Service Package Name");
            dataGridViewGetServicePackage.Columns.Add("ServiceHotelId","Service Hotel Id");
            dataGridViewGetServicePackage.Columns.Add("HotelName","Hotel Name");
            dataGridViewGetServicePackage.Columns.Add("ServiceSpecialServiceRequestId","Service Special Service Request Id");
            dataGridViewGetServicePackage.Columns.Add("ServiceSpecialServiceRequestName","Service Special Service Request Name");
            dataGridViewGetServicePackage.Columns.Add("ServiceCarRentalId","Service Car Rental Id");
            dataGridViewGetServicePackage.Columns.Add("CarName","Car Name");
            dataGridViewGetServicePackage.Columns.Add("DepartureAirportId","Departure Airport Id");
            dataGridViewGetServicePackage.Columns.Add("DepartureAirportName","Departure Airport Name");
            dataGridViewGetServicePackage.Columns.Add("ArrivalAirportId","Arrival Airport Id");
            dataGridViewGetServicePackage.Columns.Add("ArrivalAirportName","Arrival Airport Name");
            dataGridViewGetServicePackage.Columns.Add("StayDurationDays","Stay Duration Days");
            dataGridViewGetServicePackage.Columns.Add("UserId","User Id");
            dataGridViewGetServicePackage.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewGetServicePackage.Columns.Add("DateTime","Date Time");
            dataGridViewGetServicePackage.Columns.Add("ServicePackageId","Service Package Id");
            dataGridViewGetServicePackage.Columns.Add("ExtensionData", "");
            dataGridViewGetServicePackage.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewGetServicePackage.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewGetServicePackage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewGetServicePackage.AutoResizeColumns();
        }
    }
}
