using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ATC_WMS.Model;
using UIPShared;
using System.Runtime.InteropServices;


namespace ATC_WMS
{
    public partial class FormLabelBarcode : Form
    {
        DataTable dt = new DataTable();
        AssetDetail assetlist = new AssetDetail();
        public FormLabelBarcode()
        {
            InitializeComponent();
            LoadComboData();
            DataGridViewTemplate(GVData);
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void LoadComboData()
        {
            using (ATCWMS_LIVEEntities RR = new ATCWMS_LIVEEntities())
            {
                var Bdata = (from c in RR.LevelMasters select new { c.LevelId, c.LevelCode }).AsEnumerable().ToList();
                dt = UIPShared.Shared.ConvertToDataTable(Bdata);
                UIPShared.Shared.BindComboxsource(cboLevel, dt, "LevelId", "LevelCode");
                assetlist.LevelList = new List<AssetDetail>();
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                int Fid = 0;
                using (ATCWMS_LIVEEntities ram = new ATCWMS_LIVEEntities())
                {
                    if (cboLevel.SelectedIndex != 0)
                    {
                        Fid = Convert.ToInt32(cboLevel.SelectedValue);
                    }
                    var FData = (from c in ram.RackMasters where c.LevelId == Fid select c).AsEnumerable().Select(cc => new { cc.RackId, cc.RackCode }).ToList();
                    dt = UIPShared.Shared.ConvertToDataTable(FData);
                    UIPShared.Shared.BindComboxsource(cboRack, dt, "RackId", "RackCode");
                }
            }
            catch
            {
            }

        }


       


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbRack_Click(object sender, EventArgs e)
        {
            try
            {
                AssetDetail ad = new AssetDetail();

                int Rid = 0;
                using (ATCWMS_LIVEEntities ram = new ATCWMS_LIVEEntities())
                {
                    if (cboRack.SelectedIndex != 0)
                    {
                        Rid = Convert.ToInt32(cboRack.SelectedValue);
                    }
                    var FData = (from c in ram.ColumnMasters where c.RackId == Rid select c).AsEnumerable().Select(cc => new { cc.ColumnId, cc.ColumnCode }).ToList();
                    dt = UIPShared.Shared.ConvertToDataTable(FData);
                    UIPShared.Shared.BindComboxsource(cbocolumn, dt, "ColumnId", "ColumnCode");
                }
              
            }

            catch
            {
            }

        }

        private void lbColumn_Click(object sender, EventArgs e)
        {

        }
       
        private void cboLevel_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                int Fid = 0;
                using (ATCWMS_LIVEEntities ram = new ATCWMS_LIVEEntities())
                {
                    if (cboLevel.SelectedIndex != 0)
                    {
                        Fid = Convert.ToInt32(cboLevel.SelectedValue);
                    }
                    var FData = (from c in ram.RackMasters where c.LevelId == Fid select c).AsEnumerable().Select(cc => new { cc.RackId, cc.RackCode }).ToList();
                    dt = UIPShared.Shared.ConvertToDataTable(FData);
                    UIPShared.Shared.BindComboxsource(cboRack, dt, "RackId", "RackCode");
                    Search();
                }
            }
            catch
            {
            }


        }

        private void cboRack_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                AssetDetail ad = new AssetDetail();

                int Rid = 0;
                using (ATCWMS_LIVEEntities ram = new ATCWMS_LIVEEntities())
                {
                    if (cboRack.SelectedIndex != 0)
                    {
                        Rid = Convert.ToInt32(cboRack.SelectedValue);
                    }
                    var FData = (from c in ram.ColumnMasters where c.RackId == Rid select c).AsEnumerable().Select(cc => new { cc.ColumnId, cc.ColumnCode }).ToList();
                    dt = UIPShared.Shared.ConvertToDataTable(FData);
                    UIPShared.Shared.BindComboxsource(cbocolumn, dt, "ColumnId", "ColumnCode");
                    Search();
                }
              

            }

            catch
            {
            }

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
            control.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 80, 41);
            control.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(238, 211, 2);
            control.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            control.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            control.ColumnHeadersHeight = 40;
            control.SelectionMode = DataGridViewSelectionMode.CellSelect;
            control.RowHeadersVisible = false;
            control.TabStop = false;
            control.BorderStyle = BorderStyle.FixedSingle;
            control.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            control.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 80, 41);
            control.DefaultCellStyle.SelectionForeColor = Color.FromArgb(238, 211, 2);
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
        private void clear()
        {
            cbocolumn.SelectedIndex = 0;
            cboLevel.SelectedIndex = 0;
            cboRack.SelectedIndex = 0;
        }

        private void Search()
        {
            using (ATCWMS_LIVEEntities scl = new ATCWMS_LIVEEntities())
            {
                if (cbocolumn.SelectedIndex != 0)
                {
                    int ColumnId = 0;
                    ColumnId = Convert.ToInt32(cbocolumn.SelectedValue);
                    var check = (from c in scl.BinMasters
                                 join c1 in scl.ColumnMasters on c.ColumnId equals c1.ColumnId
                                 join c2 in scl.RackMasters on c1.RackId equals c2.RackId
                                 join c3 in scl.LevelMasters on c2.LevelId equals c3.LevelId
                                 where c.ColumnId == ColumnId
                                 select new { c.BinId, c.BinBarcode, c.OrderId, c1.ColumnCode, c2.RackCode, c3.LevelCode }).ToList();
                    GVData.AutoGenerateColumns = false;
                    GVData.DataSource = check;
                    LoadSerialNo();
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            using (ATCWMS_LIVEEntities ram = new ATCWMS_LIVEEntities())
            {

                try
                {
                    for (int i = 0; i < GVData.Rows.Count; i++)
                    {
                        string s = (GVData.Rows[i].Cells["Select"].EditedFormattedValue.ToString());
                        if (s == "True")
                        {
                            BarcodePrinting B = new BarcodePrinting();
                            int BinId=Convert.ToInt32(GVData.Rows[i].Cells["BinId"].Value.ToString());
                            B.LocationBarPrinting(BinId);
                        }
                    }
                    Shared.DisplayInformation("Printed Successfully!");
                }
                catch (Exception e1)
                {
                }
            }
        }

        private void cbocolumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkAll.Checked == true)
                {
                    for(int i=0;i<GVData.Rows.Count;i++)
                    {
                        GVData.Rows[i].Cells[1].Value = true;
                    }
                }
                else
                {
                    for (int i = 0; i < GVData.Rows.Count; i++)
                    {
                        GVData.Rows[i].Cells[1].Value = false;
                    }
                }
            }
            catch
            {
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnmax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void lbLevel_Click(object sender, EventArgs e)
        {

        }

        private void label9_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormLabelBarcode_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GVData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnclear1_Click(object sender, EventArgs e)
        {
            cboLevel.SelectedIndex = 0;
            GVData.DataSource = null;
            chkAll.Checked = false;
            cboLevel.Focus();

        }
    }
    public class AssetDetail
    {

        // public List<AssetDetail> AssetList { get; set; }
        public int levelid { get; set; }
        public String Level { get; set; }
        public int RACKD { get; set; }
        public String Rack { get; set; }
        public int columnid { get; set; }
        public string Column { get; set; }
        public List<AssetDetail> LevelList { get; set; }
    }

}
