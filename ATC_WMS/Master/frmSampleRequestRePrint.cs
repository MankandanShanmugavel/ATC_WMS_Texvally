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

namespace ATC_WMS.Master
{
    public partial class frmSampleRequestRePrint : Form
    {
        public frmSampleRequestRePrint()
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
            //control.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(232, 254, 232);
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
            control.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
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
        public void LoadData()
        {
            try
            {
                using (ATCWMS_LIVEEntities ram = new ATCWMS_LIVEEntities())
                {
                    int SAPDocNum = Convert.ToInt32(txtSAPDocNo.Text.ToString());
                    int Year = Convert.ToInt32(CBYear.Text.ToString());

                    var print = (from c in ram.SampleReq_Print(SAPDocNum, Year) where c.PrinterName != "-" select c).ToList();
                    if (print != null)
                    {
                        txtCode.Text = print.FirstOrDefault().STATE;

                    }
                    GVData.AutoGenerateColumns = false;
                    GVData.DataSource = print;
                }
                LoadSerialNo();
            }
            catch
            {

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (rbLargeSticker.Checked == true || rbMediumSticker.Checked == true || rbSmallSticker.Checked == true)
            {
                int SAPDocNum = Convert.ToInt32(txtSAPDocNo.Text.ToString());
                int Year = Convert.ToInt32(CBYear.Text.ToString());

                List<string> stickerNames = new List<string>();
                List<string> stickerTypes = new List<string>();
                if (rbMediumSticker.Checked)
                    stickerTypes.Add("MediumSticker");
                if (rbLargeSticker.Checked)
                    stickerTypes.Add("LargeSticker");
                if (rbSmallSticker.Checked)
                    stickerTypes.Add("SmallSticker");
                if (chkMRP.Checked)
                    stickerNames.Add("MRP");
                if (chkPercentage.Checked)
                    stickerNames.Add("Percentage");
                if (chkFR.Checked)
                    stickerNames.Add("FR");
                if (chkExport.Checked)
                    stickerNames.Add("Export");
                string stickerNamesString = string.Join(",", stickerNames);
                string stickerTypessString = string.Join(",", stickerTypes);
                BarcodePrinting pb = new BarcodePrinting();
                pb.SamPleRequest(SAPDocNum, Year, stickerNamesString, stickerTypessString);
            }
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
        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            ActiveStatus();
        }

        private void GVData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
