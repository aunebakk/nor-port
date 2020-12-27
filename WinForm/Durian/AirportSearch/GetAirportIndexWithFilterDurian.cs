using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class GetAirportIndexWithFilterDurian : UserControl {
        
        public GetAirportIndexWithFilterDurian() {
           InitializeComponent();
           InitializeGridGetAirportIndexWithFilter();
        }
        
        public virtual string AirportName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetAirportIndexWithFilter.CurrentRow.Cells["AirportName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string CityName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetAirportIndexWithFilter.CurrentRow.Cells["CityName"].Value; else return String.Empty;;
            }
        }
        
        public new virtual string ProductName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetAirportIndexWithFilter.CurrentRow.Cells["ProductName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string AirportTypeRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetAirportIndexWithFilter.CurrentRow.Cells["AirportTypeRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid CityId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetAirportIndexWithFilter.CurrentRow.Cells["CityId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.Guid ProductId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetAirportIndexWithFilter.CurrentRow.Cells["ProductId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual decimal UtcOffset {
            get {
                if (!DesignMode) return (System.Decimal) dataGridViewGetAirportIndexWithFilter.CurrentRow.Cells["UtcOffset"].Value; else return 0;;
            }
        }
        
        public virtual decimal ElevationInMeters {
            get {
                if (!DesignMode) return (System.Decimal) dataGridViewGetAirportIndexWithFilter.CurrentRow.Cells["ElevationInMeters"].Value; else return 0;;
            }
        }
        
        public virtual decimal RunwayInMeters {
            get {
                if (!DesignMode) return (System.Decimal) dataGridViewGetAirportIndexWithFilter.CurrentRow.Cells["RunwayInMeters"].Value; else return 0;;
            }
        }
        
        public virtual string Latitude {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetAirportIndexWithFilter.CurrentRow.Cells["Latitude"].Value; else return String.Empty;;
            }
        }
        
        public virtual string Longitude {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetAirportIndexWithFilter.CurrentRow.Cells["Longitude"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid TimezoneId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetAirportIndexWithFilter.CurrentRow.Cells["TimezoneId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string Variation {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetAirportIndexWithFilter.CurrentRow.Cells["Variation"].Value; else return String.Empty;;
            }
        }
        
        public virtual string Attendance {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetAirportIndexWithFilter.CurrentRow.Cells["Attendance"].Value; else return String.Empty;;
            }
        }
        
        public virtual bool ControlTowerFlag {
            get {
                if (!DesignMode) return (System.Boolean) dataGridViewGetAirportIndexWithFilter.CurrentRow.Cells["ControlTowerFlag"].Value; else return false;;
            }
        }
        
        public virtual System.DateTime ActivationDateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewGetAirportIndexWithFilter.CurrentRow.Cells["ActivationDateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.Guid UserId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetAirportIndexWithFilter.CurrentRow.Cells["UserId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewGetAirportIndexWithFilter.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.Guid AirportId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetAirportIndexWithFilter.CurrentRow.Cells["AirportId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string AirportTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetAirportIndexWithFilter.CurrentRow.Cells["AirportTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string DefaultUserName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetAirportIndexWithFilter.CurrentRow.Cells["DefaultUserName"].Value; else return String.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewGetAirportIndexWithFilter.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewGetAirportIndexWithFilter_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshGetAirportIndexWithFilter() {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewGetAirportIndexWithFilter.CurrentRow != null)
                    position = dataGridViewGetAirportIndexWithFilter.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new AirportSearchService().GetAirportIndexWithFilter();
                dataGridViewGetAirportIndexWithFilter.AutoGenerateColumns = true;
                dataGridViewGetAirportIndexWithFilter.DataSource = bindingSource;
                dataGridViewGetAirportIndexWithFilter.AutoResizeColumns();

                // position to previous row
                if (dataGridViewGetAirportIndexWithFilter.Rows.Count > 0) { 
                    dataGridViewGetAirportIndexWithFilter.CurrentCell = 
                        dataGridViewGetAirportIndexWithFilter.Rows[position].Cells[1];
                    dataGridViewGetAirportIndexWithFilter.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridGetAirportIndexWithFilter() {
            dataGridViewGetAirportIndexWithFilter.Columns.Clear();
            dataGridViewGetAirportIndexWithFilter.AutoGenerateColumns = false;
            dataGridViewGetAirportIndexWithFilter.Columns.Add("AirportName","Airport Name");
            dataGridViewGetAirportIndexWithFilter.Columns.Add("CityName","City Name");
            dataGridViewGetAirportIndexWithFilter.Columns.Add("ProductName","Product Name");
            dataGridViewGetAirportIndexWithFilter.Columns.Add("AirportTypeRcd","Airport Type");
            dataGridViewGetAirportIndexWithFilter.Columns.Add("CityId","City Id");
            dataGridViewGetAirportIndexWithFilter.Columns.Add("ProductId","Product Id");
            dataGridViewGetAirportIndexWithFilter.Columns.Add("UtcOffset","Utc Offset");
            dataGridViewGetAirportIndexWithFilter.Columns.Add("ElevationInMeters","Elevation In Meters");
            dataGridViewGetAirportIndexWithFilter.Columns.Add("RunwayInMeters","Runway In Meters");
            dataGridViewGetAirportIndexWithFilter.Columns.Add("Latitude","Latitude");
            dataGridViewGetAirportIndexWithFilter.Columns.Add("Longitude","Longitude");
            dataGridViewGetAirportIndexWithFilter.Columns.Add("TimezoneId","Timezone Id");
            dataGridViewGetAirportIndexWithFilter.Columns.Add("Variation","Variation");
            dataGridViewGetAirportIndexWithFilter.Columns.Add("Attendance","Attendance");
            dataGridViewGetAirportIndexWithFilter.Columns.Add("ControlTowerFlag","Control Tower Flag");
            dataGridViewGetAirportIndexWithFilter.Columns.Add("ActivationDateTime","Activation Date Time");
            dataGridViewGetAirportIndexWithFilter.Columns.Add("UserId","User Id");
            dataGridViewGetAirportIndexWithFilter.Columns.Add("DateTime","Date Time");
            dataGridViewGetAirportIndexWithFilter.Columns.Add("AirportId","Airport Id");
            dataGridViewGetAirportIndexWithFilter.Columns.Add("AirportTypeName","Airport Type Name");
            dataGridViewGetAirportIndexWithFilter.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewGetAirportIndexWithFilter.Columns.Add("ExtensionData", "");
            dataGridViewGetAirportIndexWithFilter.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewGetAirportIndexWithFilter.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewGetAirportIndexWithFilter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewGetAirportIndexWithFilter.AutoResizeColumns();
        }
    }
}
