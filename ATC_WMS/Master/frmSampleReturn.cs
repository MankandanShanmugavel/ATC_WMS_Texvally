using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATC_WMS.Model;
using System;
using UIPShared;

namespace ATC_WMS.Master
{
    public partial class frmSampleReturn : Form
    {
        public frmSampleReturn()
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
        private void LoadData()
        {
            try
            {
                string trollycode = "";
                long DeleveryNo = 0;

                using (ATCWMS_LIVEEntities ram = new ATCWMS_LIVEEntities())
                {



                    int SAPDocNum = Convert.ToInt32(txtSampleReturnNo.Text.ToString());
                    var print = (from c in ram.SampleReturn_Print(SAPDocNum) select c).ToList();
                    if (print != null)
                    {
                        txtCardName.Text = print.FirstOrDefault().CardName;
                        //txtPartyType.Text = print.FirstOrDefault().Partytype;
                        //txtCode.Text = print.FirstOrDefault().U_SalPriceCode;
                        //txtState.Text = print.FirstOrDefault().U_State;
                        //dtpDCDate.Value = (DateTime)print.FirstOrDefault().SAPDCPostDate;
                    }
                    GVData.AutoGenerateColumns = false;
                    GVData.DataSource = print;
                }
                LoadSerialNo();
            }
            catch (Exception e)
            {
                Shared.DisplayError(e.Message);
            }
        }

      
        private void CLEAR()
        {
            txtSampleReturnNo.Text = "";
            txtSampleReturnNo.Focus();
            txtCardName.Text = "";
            GVData.DataSource = null;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (ATCWMS_LIVEEntities Ram = new ATCWMS_LIVEEntities())
            {
                if (txtSampleReturnNo.Text != "")
                {
                    long SAPdocNum = Convert.ToInt64(txtSampleReturnNo.Text);
                    for (int i = 0; i < GVData.Rows.Count; i++)
                    {
                        string ItemCode = (GVData.Rows[i].Cells["ItemCode"].Value.ToString());
                        string EmpNo = (GVData.Rows[i].Cells["EmpNo"].Value.ToString());
                        string ItemName = (GVData.Rows[i].Cells["dscription"].Value.ToString());
                        decimal Quantity = Convert.ToDecimal(GVData.Rows[i].Cells["quantity"].Value.ToString());
                        BarcodePrinting bp = new BarcodePrinting();
                        bp.SampleReturn(ItemCode, ItemName, EmpNo, Quantity);
                    }
                    UIPShared.Shared.DisplayInformation("Printed Successfully!");
                    CLEAR();
                }
                else
                {
                    MessageBox.Show("SampleReturnNo Empty!!");
                }
               
            }
        }

        private void btnRePrint_Click(object sender, EventArgs e)
        {
            Master.SampleReturnRePrint f= new Master.SampleReturnRePrint();
            f.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
