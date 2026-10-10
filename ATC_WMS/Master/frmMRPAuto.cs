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
    public partial class frmMRPAuto : Form
    {
        DataTable dt = new DataTable();
        DataProcess.CommonDB CMBC = new DataProcess.CommonDB();
        public frmMRPAuto()
        {
            InitializeComponent();
            DataGridViewTemplate(GVData);
            //LoadData();
            LoadYearsIntoComboBox();
            //LoadTabel();
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
                    var newdata = CMBC.GetTableMasters().Result;
                   // var bdata= (from c in newdata select new { c.TableCode, c.TabId, }).Select(c => new { Tableid = c.TabId.ToString(), tblename = c.TableCode }).Distinct().ToList();
                    var bdata = (from c in newdata select new { c.TableCode, c.TabId, }).Select(c => new { Tableid = c.TabId.ToString(), tblename = c.TableCode }).Distinct().ToList();
                    dt = UIPShared.Shared.ConvertToDataTable(bdata);
                    UIPShared.Shared.BindComboxsource(cboTableAssign, dt, "Tableid", "tblename");


                    string trolly = cboTrolley.Text.ToString();
                    long SAPDocNum = Convert.ToInt64(txtDcNo.Text.ToString());
                    int Year = Convert.ToInt32(CBYear.Text.ToString());

                    //  var print = (from c in ram.AutomatedMRPPrintingTrollyWiseNew(SAPDocNum, trolly) where c.PrinterName != "-" select c).ToList();
                    var GetMRP = CMBC.GetAutoMRPPrint(SAPDocNum, trolly, Year).Result;
                    var print = (from c in GetMRP.AutoMRPPrintList where c.PrinterName != "-" select c).ToList();
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
                    GVData.AutoGenerateColumns = false;
                    GVData.DataSource = print;
                }
                LoadSerialNo();
            }
            catch (Exception ed)
            {

            }
        }
        private void Clear()
        {
            txtDcNo.Text = "";
            cboTrolley.Text = "";
            txtDcNo.Focus();
            cboTableAssign.SelectedIndex = 0;
        }
         
        private void LoadSerial()
        {
            int i = 1;
            foreach (DataGridViewRow row in GVData.Rows)
            {
                row.Cells["SNO"].Value = i; i++;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
            {
            LoadData();
            LoadSerial();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (ATCWMS_LIVEEntities Ram = new ATCWMS_LIVEEntities())
            {
               if (cboTableAssign.SelectedIndex != 0)
                    {
                        if (txtDcNo.Text != "")
                        {
                            if (cbExport.Checked == true)
                            {
                            long SAPdocNumb = Convert.ToInt64(txtDcNo.Text);
                            string TrolleyCodee = cboTrolley.Text.ToString();
                            int Year = Convert.ToInt32(CBYear.Text.ToString());
                            BarcodePrinting pb = new BarcodePrinting();
                            //bp.MRPLargeBarPrintingCustomer(DCId, TemplateId, Size, cboPrinterType.Text, PrintQuantity);
                            pb.ExportAutomationMRPPrinting(SAPdocNumb, TrolleyCodee, Year, dtpDCDate.Value);
                            for (int i = 0; i < GVData.Rows.Count; i++)
                            {

                                string isChecked = GVData.Rows[i].Cells["BoxPrintSelect"].EditedFormattedValue.ToString();
                                int Linenumber = Convert.ToInt32(GVData.Rows[i].Cells["LineNum"].Value);
                                int Quantity = Convert.ToInt32(GVData.Rows[i].Cells["Quantity"].Value);
                                int PurPackUn = Convert.ToInt32(GVData.Rows[i].Cells["PurPackUn"].Value);
                                var Quanti = Quantity / (PurPackUn);
                                //bp.MRPLargeBarPrintingCustomer(DCId, TemplateId, Size, cboPrinterType.Text, PrintQuantity);
                                // bp.AutomationMRPPrinting(SAPdocNum, TrolleyCode, Year, dtpDCDate.Value);
                                if (isChecked == "True")
                                {
                                    pb.ExportMRPAutomationReBoxPrint(SAPdocNumb, Linenumber, Quanti, Year, dtpDCDate.Value);
                                }
                            }

                        }
                            if (cboTrolley.Items.Count != 0 && cbExport.Checked != true)
                            {
                            long SAPdocNum = Convert.ToInt64(txtDcNo.Text);
                            string TrolleyCode = cboTrolley.Text.ToString();
                            int Year = Convert.ToInt32(CBYear.Text.ToString());
                            BarcodePrinting bp = new BarcodePrinting();
                            //bp.MRPLargeBarPrintingCustomer(DCId, TemplateId, Size, cboPrinterType.Text, PrintQuantity);
                            bp.AutomationMRPPrinting(SAPdocNum, TrolleyCode, Year, dtpDCDate.Value);
                            //for (int i = 0; i < GVData.Rows.Count; i++)
                            //{

                            //    string isChecked = GVData.Rows[i].Cells["BoxPrintSelect"].EditedFormattedValue.ToString();
                            //    int Linenumber = Convert.ToInt32(GVData.Rows[i].Cells["LineNum"].Value);
                            //    int Quantity = Convert.ToInt32(GVData.Rows[i].Cells["Quantity"].Value);
                            //    //bp.MRPargeBarPrintingCustomer(DCId, TemplateId, Size, cboPrinterType.Text, PrintQuantity);
                            //    // bp.AutomationMRPPrinting(SAPdocNum, TrolleyCode, Year, dtpDCDate.Value);
                            //    if (isChecked == "True")
                            //    {
                            //        bp.MRPAutomationReBoxPrint(SAPdocNum, Linenumber, Quantity, Year, dtpDCDate.Value);
                            //    }
                            //}
                            var checkedRows = GVData.Rows
    .Cast<DataGridViewRow>()
    .Where(r => Convert.ToBoolean((r.Cells["BoxPrintSelect"].EditedFormattedValue)))
    .ToList();

                            foreach (var row in checkedRows)
                            {
                                int lineNumber = Convert.ToInt32(row.Cells["LineNum"].Value);
                                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);

                                bp.MRPAutomationReBoxPrint(SAPdocNum, lineNumber, quantity, Year, dtpDCDate.Value);
                            }

                        }
                        //else
                        //    {
                        //        MessageBox.Show("TrolleyCode Empty!!");
                        //    }
                        }

                        int UserId = 0;
                        int DCNum = Convert.ToInt32(txtDcNo.Text);

                        string TableCode = cboTableAssign.Text;
                        try
                        {
                            var Bundle = CMBC.SalesDCBundle_TableSave(UserId, DCNum, TableCode).Result;
                        }
                        catch
                        {

                        }

                        MessageBox.Show("Printed Successfully!");
                        Clear();
                    }

                    else
                    {
                        MessageBox.Show("Please Select Table NO!!");
                    }
                
            }
        }
        
        private void txtTrlleyNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true; 
            }
        }

        private void txtDcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                using (ATCWMS_LIVEEntities Ram = new ATCWMS_LIVEEntities())
                {
                    cboTrolley.Items.Clear();
                    int Year = Convert.ToInt32(CBYear.Text);
                    int DC = Convert.ToInt32(txtDcNo.Text);
                    var Fdata = (from c in Ram.GetTrolleyForMRPAutoPrint(DC, Year) select c.TrolleyCode).ToList().Distinct();
                    foreach (string strPrinter in Fdata)
                    {
                        cboTrolley.Items.Add(strPrinter);
                    }
                    if(Fdata.Count()==1)
                    {
                        cboTrolley.SelectedIndex = 0;
                        btnSearch.PerformClick();
                    }
                 
                    //string trolly = cboTrolley.Text;
                    //long SAPDocNum = Convert.ToInt64(txtDcNo.Text);
                    //var FData = (from c in Ram.AutomatedMRPPrintingTrollyWiseNew(SAPDocNum, trolly) where c.FactoryId == Fid select c).AsEnumerable().Select(cc => new { cc.PlantId, cc.PlantName }).ToList();
                    //dt = UIPShared.Shared.ConvertToDataTable(FData);
                    //UIPShared.Shared.BindComboxsource(CboPlant, dt, "PlantId", "PlantName");
                }
                if (cboTrolley.Items.Count > 0)
                {
                    cboTrolley.Focus();
                }
            }
        }

        private void btnRePrint_Click(object sender, EventArgs e)
        {
            frmRePrint f = new frmRePrint();
            f.Show();
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

        private void CBYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                using (ATCWMS_LIVEEntities Ram = new ATCWMS_LIVEEntities())
                {
                    cboTrolley.Items.Clear();
                    int Year = Convert.ToInt32(CBYear.Text);
                    int DC = Convert.ToInt32(txtDcNo.Text);
                    var Fdata = (from c in Ram.GetTrolleyForMRPAutoPrint(DC, Year) select c.TrolleyCode).ToList().Distinct();
                    foreach (string strPrinter in Fdata)
                    {
                        cboTrolley.Items.Add(strPrinter);
                    }
                    if (Fdata.Count() == 1)
                    {
                        cboTrolley.SelectedIndex = 0;
                        btnSearch.PerformClick();
                    }
                    else
                    {
                        if (cboTrolley.Items.Count > 0)
                        {
                            cboTrolley.Focus();
                        }
                    }
                 
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbExport_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtState_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbBoxSTSelect_CheckedChanged(object sender, EventArgs e)
        {
            ActiveStatus();
        }
        private void ActiveStatus()
        {
            if (cbBoxSTSelect.Checked == true)
            {
                for (int i = 0; i < GVData.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)GVData.Rows[i].Cells["BoxPrintSelect"];
                    chk.Value = true;
                }
            }
            else
            {
                for (int i = 0; i < GVData.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)GVData.Rows[i].Cells["BoxPrintSelect"];
                    chk.Value = false;
                }
            }
        }
    }
}
