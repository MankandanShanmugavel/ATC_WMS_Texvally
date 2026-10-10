using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ATC_WMS.Model;
using UIPShared;
using SharedLibrary;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Printing;

namespace ATC_WMS.Master
{
    public partial class frmTrollyMRP : Form
    {
        public frmTrollyMRP()
        {
            InitializeComponent();
            DataGridViewTemplate(GVData);
           // LoadData();
        }
  
        public void DataGridViewTemplate(DataGridView control)
        {
            control.AllowUserToAddRows = false;
            control.AllowUserToDeleteRows = false;
            control.AllowUserToResizeColumns = false;
            control.AllowUserToResizeRows = false;
            //control.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(232, 254, 232);
            control.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            control.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            control.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(6, 105, 5);
            control.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 251, 49);
            control.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            control.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12F, FontStyle.Regular);
            control.ColumnHeadersHeight = 40;
            control.SelectionMode = DataGridViewSelectionMode.CellSelect;
            control.RowHeadersVisible = false;
            control.TabStop = false;
            control.BorderStyle = BorderStyle.FixedSingle;
            control.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            control.DefaultCellStyle.SelectionBackColor = Color.FromArgb(1, 29, 92);
            control.DefaultCellStyle.SelectionForeColor = Color.White;
            control.DefaultCellStyle.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            control.DefaultCellStyle.ForeColor = Color.Black;
            control.BackgroundColor = Color.White;
            control.DefaultCellStyle.BackColor = Color.White;
            control.EnableHeadersVisualStyles = false;
            // 
        }
        private void LoadSerialNo()
        {
            int i = 1;
            foreach (DataGridViewRow row in GVData.Rows)
            {
                row.Cells["SNO"].Value = i; i++;
            }
        }
        private void LoadData()
        {
            string trollycode = "";
            using (ATCWMS_LIVEEntities ram = new ATCWMS_LIVEEntities())
            {

                var Fdata = (from c in ram.TrollyDetail(trollycode) select c).ToList();
                GVData.AutoGenerateColumns = false;
                GVData.DataSource = Fdata;
            }
            LoadSerialNo();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
