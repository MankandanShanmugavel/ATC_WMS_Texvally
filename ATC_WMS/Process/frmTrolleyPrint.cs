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
using UIPShared;
using SharedLibrary;


namespace ATC_WMS.Process
{
    public partial class frmTrolleyPrint : Form
    {
        public frmTrolleyPrint()
        {
            
            InitializeComponent();
            LoadData();
            LoadSerialNo();
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
            using (ATCWMS_LIVEEntities scl = new ATCWMS_LIVEEntities())
            {
                    var check = (from c in scl.TrolleyMasters
                                 select new { c.TrolleyId, c.TrolleyCode }).ToList();
                    GVData.AutoGenerateColumns = false;
                    GVData.DataSource = check;
                    LoadSerialNo();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            LoadData();
            LoadSerialNo();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < GVData.Rows.Count; i++)
                {
                    string s = (GVData.Rows[i].Cells["Select"].EditedFormattedValue.ToString());
                    if (s == "True")
                    {
                        BarcodePrinting B = new BarcodePrinting();
                        string BinCode = GVData.Rows[i].Cells["TrolleyCode"].Value.ToString();
                        string BinId = GVData.Rows[i].Cells["TrolleyId"].Value.ToString();
                        B.TrolleyBarcodeSingle(BinCode, BinId);
                    }
                }
                Shared.DisplayInformation("Printed Successfully!");
            }
            catch (Exception e1)
            {
            }
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkAll.Checked == true)
                {
                    for (int i = 0; i < GVData.Rows.Count; i++)
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

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
