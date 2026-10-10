using Newtonsoft.Json;
using ATC_WMS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATC_WMS.Process
{
    public partial class frmDCBundleBarcodePrint : Form
    {
        Model.CommanDB CMBC = new Model.CommanDB();
        private string Barcode;
        public frmDCBundleBarcodePrint()
        {
            InitializeComponent();
            DataGridViewTemplate(gvData);
        }

        public void DataGridViewTemplate(DataGridView control)
        {
            control.AllowUserToAddRows = false;
            control.AllowUserToDeleteRows = false;
            control.AllowUserToResizeColumns = false;
            control.AllowUserToResizeRows = false;
            control.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            control.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            control.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 64, 0);
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

        private void txtDCNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDCNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                LoadData();
            }
        }

        private void LoadSerialNo()
        {
            int i = 1;
            foreach (DataGridViewRow row in gvData.Rows)
            {
                row.Cells["SNo"].Value = i; i++;
            }
        }

        private void LoadData()
        {
            try
            {
                long SAPDocNum = Convert.ToInt64(txtDCNum.Text);
                DataSet ds = CMBC.GetDCBunldeDataNew(txtDCNum.Text);
                if (ds.Tables[0].Rows[0][0].ToString() == "0")
                {
                    lblDCNo.Text = ds.Tables[1].Rows[0]["SAPDocNum"].ToString();
                    lblCardName.Text = ds.Tables[1].Rows[0]["CardName"].ToString();
                    lblTotal.Text = ds.Tables[1].Rows[0]["DCQty"].ToString();
                    lblTransport.Text = ds.Tables[1].Rows[0]["U_TransporterName"].ToString();
                    lblDstination.Text = ds.Tables[1].Rows[0]["U_Dsnation"].ToString();
                    txtTable.Text = ds.Tables[1].Rows[0]["TableCode"].ToString();

                    lblStatus.Text = SAPDocNum.ToString();
                    lblStatus.ForeColor = Color.Green;
                    gvData.DataSource = null;
                    gvData.AutoGenerateColumns = false;
                    gvData.DataSource = ds.Tables[2];
                    LoadSerialNo();
                    txtDCNum.Text = "";
                    lblStatusNew.Text = "";
                }
                else
                {
                    lblStatusNew.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtDCNum.Text = "";

                }
            }
            catch (Exception e)
            {
                lblStatusNew.Text = e.Message;
                txtDCNum.Text = "";
            }
        }

        private void gvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (lblDCNo.Text != "")
            {
                BarcodePrinting bp = new BarcodePrinting();
                bp.MCBarcodebyDC(lblDCNo.Text);
                MessageBox.Show("Printed Successfully!");
                Clear();
            }
        }

        public void Clear()
        {
            lblDCNo.Text = "";
            txtTable.Text = "";
            lblNoOfBundle.Text = "";
            lblTransport.Text = "";
            lblDstination.Text = "";
            lblTotal.Text = "";
            lblCardName.Text = "";
            gvData.DataSource = null;
            txtDCNum.Focus();
        }
    }
}
