using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ATC_WMS.Model;
using UIPShared;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Printing;

namespace ATC_WMS.Master
{
    public partial class frmWorkOrder : Form
    {
        DataTable dt = new DataTable();
        public frmWorkOrder()
        {
            InitializeComponent();
            DataGridViewTemplate(GVData);
        }
        public void DataGridViewTemplate(DataGridView control)
        {
            control.AllowUserToAddRows = false;
            control.AllowUserToDeleteRows = false;
            control.AllowUserToResizeColumns = false;
            control.AllowUserToResizeRows = false;
            control.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            control.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            control.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 62, 0);
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
            using (ATCWMS_LIVEEntities ram = new ATCWMS_LIVEEntities())
            {
                long WorkOrderId = Convert.ToInt64(txtWorkOrderID.Text);
                var Fdata = (from c in ram.MRPWorkOrderDetailView(WorkOrderId) select c).ToList();
                GVData.AutoGenerateColumns = false;
                GVData.DataSource = Fdata;
                lblWONo.Text = Fdata.FirstOrDefault().WorkOrderId.ToString();
                lblWOType.Text = Fdata.FirstOrDefault().WOType.ToString();
                txtWorkOrderID.Text = "";
                txtWorkOrderID.Focus();
            }
        }

        private void Clear()
        {
            txtWorkOrderID.Text = "";
            txtWorkOrderID.Focus();
            lblWONo.Text = "";
            lblWOType.Text = "";
            GVData.DataSource = null;
        }
        
        private void BtnSave_Click(object sender, EventArgs e)
        {
            LoadData();
            LoadSerialNo();
        }

        private void btnRePrint_Click(object sender, EventArgs e)
        {
            WOReprint f = new WOReprint();
            f.Show();
        }

        private void cboBrand_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void GVData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void ActiveStatus()
        {
            if (chkSelectAll.Checked == true)
            {
                for (int i = 0; i < GVData.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)GVData.Rows[i].Cells["Select"];
                    chk.Value = true;
                }
            }
            else
            {
                for (int i = 0; i < GVData.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)GVData.Rows[i].Cells["Select"];
                    chk.Value = false;
                }
            }
        }

        private void cbSelect_CheckedChanged(object sender, EventArgs e)
        {
            ActiveStatus();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GVData.Rows.Count; i++)
            {
                String s = GVData.Rows[i].Cells["Select"].EditedFormattedValue.ToString();
                if (s == "True")
                {
                    if (lblWONo.Text != "")
                    {
                        long WorkOrderID = Convert.ToInt64(GVData.Rows[i].Cells["WorkOrderId"].Value.ToString());
                        string Brand = GVData.Rows[i].Cells["Brand"].Value.ToString();

                        BarcodePrinting pb = new BarcodePrinting();
                        pb.AutomationMRPWOPrinting(WorkOrderID, Brand);
                    }
                    else
                    {
                        MessageBox.Show("WO-ID EMPTY !!");
                    }
                }
            }
            MessageBox.Show("Printed Successfully");
            Clear();
        }

        private void txtWorkOrderID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                LoadData();
                LoadSerialNo();
            }
        }

        private void txtWorkOrderID_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtWorkOrderID.Text== "WO Number")
            {
                txtWorkOrderID.Text = "";
            }
        }
    }
}
