using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SolutionNorSolutionPort.BusinessLogicLayer;

namespace SolutionNorSolutionPort.UserInterface {

    public partial class GetClientWithFilterDurian : UserControl {
        
        public GetClientWithFilterDurian() {
           InitializeComponent();
           InitializeGridGetClientWithFilter();
        }
        
        public virtual string FirstName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetClientWithFilter.CurrentRow.Cells["FirstName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string MiddleName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetClientWithFilter.CurrentRow.Cells["MiddleName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string LastName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetClientWithFilter.CurrentRow.Cells["LastName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string PassengerTypeRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetClientWithFilter.CurrentRow.Cells["PassengerTypeRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string PassengerTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetClientWithFilter.CurrentRow.Cells["PassengerTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string NationalityRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetClientWithFilter.CurrentRow.Cells["NationalityRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string NationalityName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetClientWithFilter.CurrentRow.Cells["NationalityName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string GenderRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetClientWithFilter.CurrentRow.Cells["GenderRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string GenderName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetClientWithFilter.CurrentRow.Cells["GenderName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string TitleRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetClientWithFilter.CurrentRow.Cells["TitleRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string TitleName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetClientWithFilter.CurrentRow.Cells["TitleName"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ClientTypeRcd {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetClientWithFilter.CurrentRow.Cells["ClientTypeRcd"].Value; else return String.Empty;;
            }
        }
        
        public virtual string ClientTypeName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetClientWithFilter.CurrentRow.Cells["ClientTypeName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.Guid UserId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetClientWithFilter.CurrentRow.Cells["UserId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual string DefaultUserName {
            get {
                if (!DesignMode) return (System.String) dataGridViewGetClientWithFilter.CurrentRow.Cells["DefaultUserName"].Value; else return String.Empty;;
            }
        }
        
        public virtual System.DateTime DateTime {
            get {
                if (!DesignMode) return (System.DateTime) dataGridViewGetClientWithFilter.CurrentRow.Cells["DateTime"].Value; else return DateTime.MinValue;;
            }
        }
        
        public virtual System.Guid ClientId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetClientWithFilter.CurrentRow.Cells["ClientId"].Value; else return Guid.Empty;;
            }
        }
        
        public virtual System.Guid DefaultUserId {
            get {
                if (!DesignMode) return (System.Guid) dataGridViewGetClientWithFilter.CurrentRow.Cells["DefaultUserId"].Value; else return Guid.Empty;;
            }
        }
        
        public int Count {
            get {
                if (!DesignMode) return dataGridViewGetClientWithFilter.Rows.Count; else return 0;;
            }
        }
        
        public event EventHandler Picked;
        
        private void dataGridViewGetClientWithFilter_Click(object sender, EventArgs e) {
            if (this.Picked != null)
                this.Picked(new object(), new EventArgs());
        }
        
        public void RefreshGetClientWithFilter(string lastName, string clientTypeRcd) {
            try {
                // remember selected row
                int position = 0;
                if (dataGridViewGetClientWithFilter.CurrentRow != null)
                    position = dataGridViewGetClientWithFilter.CurrentRow.Index;

                // fetch new dataset
                var bindingSource = new BindingSource();
                bindingSource.DataSource =  new ClientSearchService().GetClientWithFilter(lastName,clientTypeRcd);
                dataGridViewGetClientWithFilter.AutoGenerateColumns = true;
                dataGridViewGetClientWithFilter.DataSource = bindingSource;
                dataGridViewGetClientWithFilter.AutoResizeColumns();

                // position to previous row
                if (dataGridViewGetClientWithFilter.Rows.Count > 0) { 
                    dataGridViewGetClientWithFilter.CurrentCell = 
                        dataGridViewGetClientWithFilter.Rows[position].Cells[1];
                    dataGridViewGetClientWithFilter.Rows[position].Selected = true;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void InitializeGridGetClientWithFilter() {
            dataGridViewGetClientWithFilter.Columns.Clear();
            dataGridViewGetClientWithFilter.AutoGenerateColumns = false;
            dataGridViewGetClientWithFilter.Columns.Add("FirstName","First Name");
            dataGridViewGetClientWithFilter.Columns.Add("MiddleName","Middle Name");
            dataGridViewGetClientWithFilter.Columns.Add("LastName","Last Name");
            dataGridViewGetClientWithFilter.Columns.Add("PassengerTypeRcd","Passenger Type");
            dataGridViewGetClientWithFilter.Columns.Add("PassengerTypeName","Passenger Type Name");
            dataGridViewGetClientWithFilter.Columns.Add("NationalityRcd","Nationality");
            dataGridViewGetClientWithFilter.Columns.Add("NationalityName","Nationality Name");
            dataGridViewGetClientWithFilter.Columns.Add("GenderRcd","Gender");
            dataGridViewGetClientWithFilter.Columns.Add("GenderName","Gender Name");
            dataGridViewGetClientWithFilter.Columns.Add("TitleRcd","Title");
            dataGridViewGetClientWithFilter.Columns.Add("TitleName","Title Name");
            dataGridViewGetClientWithFilter.Columns.Add("ClientTypeRcd","Client Type");
            dataGridViewGetClientWithFilter.Columns.Add("ClientTypeName","Client Type Name");
            dataGridViewGetClientWithFilter.Columns.Add("UserId","User Id");
            dataGridViewGetClientWithFilter.Columns.Add("DefaultUserName","Default User Name");
            dataGridViewGetClientWithFilter.Columns.Add("DateTime","Date Time");
            dataGridViewGetClientWithFilter.Columns.Add("ClientId","Client Id");
            dataGridViewGetClientWithFilter.Columns.Add("DefaultUserId","Default User Id");
            dataGridViewGetClientWithFilter.Columns.Add("ExtensionData", "");
            dataGridViewGetClientWithFilter.Columns["ExtensionData"].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewGetClientWithFilter.Columns) {
                column.DataPropertyName = column.Name;
                if (column.Name.EndsWith("Id"))
                    column.Visible = false;
            }

            dataGridViewGetClientWithFilter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewGetClientWithFilter.AutoResizeColumns();
        }
    }
}
