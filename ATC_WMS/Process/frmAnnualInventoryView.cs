using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATC_WMS.Model;
using System.Data.OleDb;
using UIPShared;

namespace ATC_WMS.Process
{
    public partial class frmAnnualInventoryView : Form
    {
        DataTable dt = new DataTable();
        public frmAnnualInventoryView()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            DataGridViewTemplate(GVData);
            LoadComboData();
            LoadGVData();
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
            control.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            // 
        }

        private void LoadComboData()
        {
            try
            {
                using (ATCWMS_LIVEEntities ram = new ATCWMS_LIVEEntities())
                {
                    var bdata = (from c in ram.PackingTypeMasters select new { c.PTypeId, c.PTName, }).Distinct().ToList();
                    dt = UIPShared.Shared.ConvertToDataTable(bdata);
                    UIPShared.Shared.BindComboxsource(cboType, dt, "PTypeId", "PTName");

                    var pdata = (from c in ram.Combo_ProcessMaster_Get(0) select new { c.StockTypeId, c.Process, }).Distinct().ToList();
                    dt = UIPShared.Shared.ConvertToDataTable(pdata);
                    UIPShared.Shared.BindComboxsource(cboProcess, dt, "StockTypeId", "Process");
                }
            }
            catch (Exception ed)
            {
            }
        }

        private void LoadGVData()
        {
            try
            {
                using (ATCWMS_LIVEEntities ram = new ATCWMS_LIVEEntities())
                {
                    int ProcessId = 0;
                    int TypeId = 0;
                    ProcessId = Convert.ToInt32(cboProcess.SelectedValue);
                    try { 
                    TypeId = Convert.ToInt32(cboType.SelectedValue);
                    }
                    catch { }
                    var print = (from c in ram.AnnualInventory_WMSStock_View(txtFilter.Text, TypeId, ProcessId) select c).ToList();
                    int ItemCount = print.Select(c => c.ItemId).Distinct().Count();
                    int BinCount = print.Where(c => c.StockTypeId == 2).Select(c => c.Location).Distinct().Count();
                    decimal TotalQty = (decimal)print.Sum(c => c.Qty);
                    txtTotal.Text = TotalQty.ToString();
                    ttlBin.Text = BinCount.ToString();
                    ttlItem.Text = ItemCount.ToString();
                    GVData.AutoGenerateColumns = false;
                    GVData.DataSource = print;
                }
            }
            catch (Exception ed)
            {
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cboProcess_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cboProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGVData();
        }

        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoadGVData();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportExcelFile.GridExportToExcel(GVData);
        }

        private void GVData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTable_Click(object sender, EventArgs e)
        {

        }
    }
}
