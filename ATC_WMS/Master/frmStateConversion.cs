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

namespace ATC_WMS.Master
{
    public partial class frmStateConversion : Form
    {
        public frmStateConversion()
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
                // 
            }
            private void LoadSerialNo()
            {
                int i = 1;
                foreach (DataGridViewRow row in GVData.Rows)
                {
                    row.Cells["SNo"].Value = i; i++;
                }
            }
            private void LoadData()
            {
                using (ATCWMS_LIVEEntities ram = new ATCWMS_LIVEEntities())
                {
                    long ConversionId = Convert.ToInt64(txtConversionId.Text);
                    var print = (from c in ram.StateConversion(ConversionId) select c).ToList();

                    // var data = (from c in ram.SaleDCMRPPrintTrollyWise(txtDcNo.Text,txtTrlleyNo.Text) select c).ToList();
                    GVData.AutoGenerateColumns = false;
                    GVData.DataSource = print;
                }
               
            }
        private void Clear()
        {
            txtConversionId.Text = "";
            txtConversionId.Focus();
        }
        private void btnPrint_Click(object sender, EventArgs e)
            {
            using (ATCWMS_LIVEEntities Ram = new ATCWMS_LIVEEntities())
            {
                for (int i = 0; i < GVData.Rows.Count; i++)
                {
                    if (txtConversionId.Text != "")
                    {
                        long ConversionId = Convert.ToInt64(txtConversionId.Text);
                        BarcodePrinting pb = new BarcodePrinting();
                    }
                    else
                    {
                        MessageBox.Show("!!ENTER CONVERSION ID!!");
                    }
                }
            }
            }
        
        private void txtConversionId_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                using (ATCWMS_LIVEEntities ram = new ATCWMS_LIVEEntities())
                {
                    long ConversionId = Convert.ToInt64(txtConversionId.Text);
                    var print = (from c in ram.StateConversion(ConversionId) where c.PrinterName != "-" select c).ToList();
                    GVData.AutoGenerateColumns = false;
                    GVData.DataSource = print;
                    LoadSerialNo();
                }
            }
        }

       
    }
}
