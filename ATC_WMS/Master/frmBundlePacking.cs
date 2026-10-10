using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATC_WMS.Master
{
    public partial class frmBundlePacking : Form
    {
        Model.CommanDB CMBC = new Model.CommanDB();
        private string Barcode;
        public frmBundlePacking()
        {
            InitializeComponent();
            DataGridViewTemplate(dataGridView1);
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
           
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


        private void PrintBundlePackSticker()
        {
            if (txtBarcode.Text != "")
            {
                DataSet ds = CMBC.CheckSerail(txtBarcode.Text.Trim());
                if (ds.Tables[0].Rows.Count != 0)
                {
                    lblCardName.Text = ds.Tables[0].Rows[0]["CardName"].ToString();
                    lblDCNo.Text = ds.Tables[0].Rows[0]["SAPInvDocNum"].ToString();
                    lblTransport.Text = ds.Tables[0].Rows[0]["U_TransporterName"].ToString();
                    lblBundleBarcode.Text = ds.Tables[0].Rows[0]["BundleBarcode"].ToString();
                    lblBundleNo.Text = ds.Tables[0].Rows[0]["LineNum"].ToString() + "/" + ds.Tables[0].Rows[0]["TotalBundle"].ToString();
                    lblDstination.Text = ds.Tables[0].Rows[0]["U_Dsnation"].ToString();
                    lblTotal.Text = ds.Tables[0].Rows[0]["Qty"].ToString();
                    lblStatus.Text = "Last Readed Barcode " + txtBarcode.Text;
                    lblStatus.ForeColor = Color.FromArgb(0, 64, 0);
                   
                    if (ds.Tables[1].Rows.Count != 0)
                    {
                        Barcode = txtBarcode.Text;
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = ds.Tables[1];
                        txtBarcode.Text = "";
                    }
                }
                else
                {
                    lblStatus.Text = "Invalid Barcode " + txtBarcode.Text;
                    lblStatus.ForeColor = Color.Red;
                    lblCardName.Text = "";
                    lblDCNo.Text = "";
                    lblTransport.Text = "";
                    lblBundleBarcode.Text = "";
                    lblBundleNo.Text = "";
                    lblDstination.Text = "";
                    dataGridView1.DataSource = null;
                    txtBarcode.Text = "";
                }
            }
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PrintBundlePackSticker();
            }
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            decimal Weight = 0;
            try
            {
                Weight = Convert.ToDecimal(txtWeight.Text);
            }
            catch { }
            BarcodePrinting bp = new BarcodePrinting();
            bp.BunldePackBarcodeNew(Barcode, Weight);
        }
    }
}
