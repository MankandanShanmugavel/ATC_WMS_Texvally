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
    public partial class WOReprint : Form
    {
        public WOReprint()
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
                using (ATCWMS_LIVEEntities ram = new ATCWMS_LIVEEntities())
                {
                    //int WorkOrderId = Convert.ToInt32(txtWorkOrderID.Text);

                    long WorkOrderId = Convert.ToInt64(txtWorkOrderID.Text);
                    var Fdata = (from c in ram.MRPWorkOrderDetailView(WorkOrderId) select c).ToList();
                    GVData.AutoGenerateColumns = false;
                    GVData.DataSource = Fdata;

                }
              
            }
            catch
            {

            }
        }
        private void Clear()
        {
            txtWorkOrderID.Text = "";
            txtWorkOrderID.Focus();
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
      
            using (ATCWMS_LIVEEntities Ram = new ATCWMS_LIVEEntities())
            {

                for (int i = 0; i < GVData.Rows.Count; i++)
                {
                    String s = GVData.Rows[i].Cells["Select"].EditedFormattedValue.ToString();
                    if (s == "True")
                    {
                        if (txtWorkOrderID.Text != "")
                        {
                            int PrintQuantity = Convert.ToInt32(GVData.Rows[i].Cells["PrintQuantity"].Value);
                            if (PrintQuantity != 0 )
                            {

                                //int Linenumber = Convert.ToInt32(GVData.Rows[i].Cells["LineNum"].Value);
                                long SAPdocNum = Convert.ToInt64(txtWorkOrderID.Text);
                                BarcodePrinting bp = new BarcodePrinting();

                                if (rbNormal.Checked)
                                {
                                    bp.MRPWOAutomationReNormalPrint(SAPdocNum,  PrintQuantity);
                                }
                                else if (rbBox.Checked)
                                {
                                    bp.MRPWOAutomationReBoxPrint(SAPdocNum, PrintQuantity);
                                }
                                else if (rbPackBarcode.Checked)
                                {
                                    int PackQuantity = Convert.ToInt32(GVData.Rows[i].Cells["PackQuantity"].Value);
                                    if (PackQuantity != 0)
                                    {
                                        if ((PackQuantity <= 10 && PackQuantity >= 5))
                                        {
                                            bp.MRPWOAutomationRePackPrint(SAPdocNum, PrintQuantity, PackQuantity);
                                        }
                                        else
                                        {
                                            MessageBox.Show("!!Enter Pack Quantity Correctly!!");

                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("!!Enter Pack Quantity!!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("!!Select Lable Type!!");
                                }
                                /*   bp.MRPLargeBarPrintingCustomer(DCId, TemplateId, Size, cboPrinterType.Text, PrintQuantity);
                                   bp.MRPAutomationRePrint(SAPdocNum, Linenumber, PrintQuantity); */
                            }
                            else
                            {
                                // MessageBox.Show("Enter The Print Qty!");
                            }

                         

                        }

                        else
                        {
                            MessageBox.Show("Enter The DC_No!");
                        }
                    }

                }
            }

            MessageBox.Show("RePrinted Successfully!");
            Clear();
        

    }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
            LoadSerialNo();
        }
    }
}
