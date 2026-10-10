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
    public partial class frmRePrint : Form
    {


        DataTable dt = new DataTable();
        DataProcess.CommonDB CMBC = new DataProcess.CommonDB();
        public frmRePrint()
        {
            InitializeComponent();
            DataGridViewTemplate(GVData);
            LoadYearsIntoComboBox();
            txtDcNo.Focus();
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
            control.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0,64,0);
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
      
        private void LoadSerialNo
            ()
        {
            int i = 1;
            foreach (DataGridViewRow row in GVData.Rows)
            {
                row.Cells["SNo"].Value = i; i++;
            }
        }

        private void LoadData()
        {
            try
            {

                long DeleveryNo;

                using (ATCWMS_LIVEEntities ram = new ATCWMS_LIVEEntities())
                {
                    long SAPDocNum = Convert.ToInt64(txtDcNo.Text);
                    int Year = Convert.ToInt32(CBYear.Text.ToString());
                    var GetMRP = CMBC.GetAutoMRPREPrint(SAPDocNum, Year).Result;
                    var print = (from c in GetMRP.AutoMRPPrintList where c.PrinterName != "-" select c).ToList();

                    //long SAPDocN0 = Convert.ToInt64(txtDcNo.Text);
                    //var print1 = (from c in ram.AutomatedMRPRePrintingDCIDWise(SAPDocN0) where c.PrinterName != "-" select new { c.CardName, c.Partytype, c.U_SalPriceCode, c.STATE, c.SAPDCPostDate }).AsEnumerable().FirstOrDefault();
                    if (print != null)
                    {
                        txtCardName.Text = print.FirstOrDefault().CardName;
                        txtPartyType.Text = print.FirstOrDefault().PartyType;
                        txtCode.Text = print.FirstOrDefault().U_SalPriceCode;
                        txtState.Text = print.FirstOrDefault().U_State;
                        txtOrderType.Text = print.FirstOrDefault().OrderType;
                        txtDCNum.Text = print.FirstOrDefault().SAPDocNumbers;
                        dtpDCDate.Value = (DateTime)print.FirstOrDefault().SAPDCPostDate;
                    }
                    // var data = (from c in ram.SaleDCMRPPrintTrollyWise(txtDcNo.Text,txtTrlleyNo.Text) select c).ToList();
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                using (ATCWMS_LIVEEntities Ram = new ATCWMS_LIVEEntities())
                {

                    for (int i = 0; i < GVData.Rows.Count; i++)
                    {
                        String s = GVData.Rows[i].Cells["Select"].EditedFormattedValue.ToString();
                        if (s == "True")
                        {

                            if (txtDcNo.Text != "")
                            {


                                int PrintQuantity = Convert.ToInt32(GVData.Rows[i].Cells["PrintQuantity"].Value);
                                //int PackQuantity = Convert.ToInt32(GVData.Rows[i].Cells["PackQuantity"].Value);
                                if (PrintQuantity != 0 && cbExport.Checked != true)
                                {
                                    int Linenumber = Convert.ToInt32(GVData.Rows[i].Cells["LineNum"].Value);
                                    int OrderDetId = Convert.ToInt32(GVData.Rows[i].Cells["OrderDetId"].Value);
                                    long SAPdocNum = Convert.ToInt64(txtDcNo.Text);
                                    string TrolloyNo = ("0");
                                    int Year = Convert.ToInt32(CBYear.Text);
                                    BarcodePrinting bp = new BarcodePrinting();
                                    if (rbNormal.Checked)
                                    {
                                        bp.MRPAutomationReNormalPrint(SAPdocNum, OrderDetId, PrintQuantity, Year, dtpDCDate.Value);
                                    }
                                    else if (rbBox.Checked)
                                    {
                                        bp.MRPAutomationReBoxPrint(SAPdocNum, OrderDetId, PrintQuantity, Year, dtpDCDate.Value);
                                    }
                                    else if (rbPackBarcode.Checked)
                                    {
                                        int OPackQuantity = Convert.ToInt32(GVData.Rows[i].Cells["Pack_Qty"].Value);
                                        int PackQuantity = Convert.ToInt32(GVData.Rows[i].Cells["PackQuantity"].Value);
                                        if (PackQuantity != 0)
                                        {
                                            if ((PackQuantity <= OPackQuantity && PackQuantity >= 5))
                                            {
                                                bp.MRPAutomationRePackPrint(SAPdocNum, Linenumber, PrintQuantity, PackQuantity, Year, dtpDCDate.Value);
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
                                        if (cbExport.Checked == true)
                                        {

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

                                if (cbExport.Checked == true)
                                {
                                    int Linenumber = Convert.ToInt32(GVData.Rows[i].Cells["LineNum"].Value);
                                    long SAPdocNum = Convert.ToInt64(txtDcNo.Text);
                                    int Year = Convert.ToInt32(CBYear.Text);
                                    BarcodePrinting bp = new BarcodePrinting();

                                    if (rbNormal.Checked)
                                    {
                                        bp.ExportMRPAutomationReNormalPrint(SAPdocNum, Linenumber, PrintQuantity, Year, dtpDCDate.Value);
                                    }
                                    else if (rbBox.Checked)
                                    {
                                        bp.ExportMRPAutomationReBoxPrint(SAPdocNum, Linenumber, PrintQuantity, Year, dtpDCDate.Value);
                                    }
                                    else if (rbPackBarcode.Checked)
                                    {
                                        int OPackQuantity = Convert.ToInt32(GVData.Rows[i].Cells["Pack_Qty"].Value);
                                        int PackQuantity = Convert.ToInt32(GVData.Rows[i].Cells["PackQuantity"].Value);
                                        if (PackQuantity != 0)
                                        {
                                            if ((PackQuantity <= OPackQuantity && PackQuantity >= 5))
                                            {
                                                bp.ExportMRPAutomationRePackPrint(SAPdocNum, Linenumber, PrintQuantity, PackQuantity, Year, dtpDCDate.Value);
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
            }
            catch (Exception ex ) {

                UIPShared.Shared.DisplayError(ex.Message);
            }
        }




        private void Clear()
        {
            //rbNormal.Checked = true;
            GVData.DataSource = null;
            GVData.DataSource = null;
            rbNormal.Checked = true;
            txtCardName.Text = "";
            txtCode.Text = "";
            txtPartyType.Text = "";
            txtState.Text = "";
            txtDcNo.Text = "";
            chkSelectAll.Checked = false;
            txtDcNo.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
            LoadSerialNo();
        }
    
        private void frmRePrint_Load(object sender, EventArgs e)
        {
            txtDcNo.Text = "";
        }


        private void cbExport_CheckedChanged(object sender, EventArgs e)
        {
            if (cbExport.Checked == true)
            {
                for (int i = 0; i < GVData.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)GVData.Rows[i].Cells["Select"];
                    chk.Value = true;
                }
            }
            else
            {
                //for (int i = 0; i < GVData.Rows.Count; i++)
                //{
                //    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)GVData.Rows[i].Cells["Select"];
                //    chk.Value = false;
                //}
            }
        }

        private void txtDcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                LoadData();
                LoadSerialNo();
            }
        }
        private void LoadYearsIntoComboBox()
        {
            int currentYear = DateTime.Now.Year;
            for (int i = 0; i < 10; i++)
            {
                CBYear.Items.Add(currentYear - i);
            }

            // Optionally, set the default selected item
            CBYear.SelectedIndex = 0;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void GVData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
