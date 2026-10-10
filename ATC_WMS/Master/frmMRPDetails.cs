using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;     
using ATC_WMS.Model;
using UIPShared;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Printing;
//using System.Printing;

namespace ATC_WMS.Master
{
    public partial class frmMRPDetails : Form 
    {
        long DCId = 0;
        int Linenum1 = 0;
        string Itemcode = "";
        private bool hasPrinted = false;
        private int loopCounter = 0;
        public frmMRPDetails(int DeliveryNo )
        {
            DCId = DeliveryNo;
            InitializeComponent();
            LoadData();
            DataGridViewTemplate(GVData);
            GetPrinterList();
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
            control.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(6, 105, 5);
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

        private void btnclose_Click(object sender, EventArgs e)
        {
           this.Close();
        }


        private bool GetPrinterList()
        {
            bool retVal = false;
            cboPrinterType.Items.Clear();
            PrintDocument prtdoc = new PrintDocument();

            //prt.PrinterSettings.PrinterName returns the name of the Default Printer
            string strDefaultPrinter = prtdoc.PrinterSettings.PrinterName;
            //this will loop through all the Installed printers and add the Printer Names to a ComboBox.
            foreach (String strPrinter in PrinterSettings.InstalledPrinters)
            {
            cboPrinterType.Items.Add(strPrinter);
                //This will set the ComboBox Index where the Default Printer Name matches with the current Printer Name returned by for loop
                //if (strPrinter.CompareTo(strDefaultPrinter) == 0)
                //{
                //    cmbPrinter.SelectedIndex = cmbPrinter.Items.IndexOf(strPrinter);

                //    retVal = true;
                //}
            }
            return retVal;
        }
        private void cboPrinterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
            using (ATCWMS_LIVEEntities ram = new ATCWMS_LIVEEntities())
            {

                var Fdata = (from c in ram.MRPDetailView(DCId) select c).ToList();
                GVData.AutoGenerateColumns = false;
                  GVData.DataSource = Fdata;

                  txtBillNo.Text =  DCId.ToString();
            }
        }

        private void frmMRPDetails_Load(object sender, EventArgs e)
        {
            LoadSerialNo();
            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidationLibrary.IsSelected("Template", cboTemplateId, true)) return;
            if (!ValidationLibrary.IsSelected("Barcode Type", cboBarcodeType, true)) return;
            if (!ValidationLibrary.IsSelected("Printer Name", cboPrinterType, true)) return;
   
            int sk=0;
            int KS = 0;
            for (int i = 0; i < GVData.Rows.Count; i++)
            {
                string s = GVData.Rows[i].Cells["Select"].EditedFormattedValue.ToString();
                if (s == "True")
                {
                    int ItemId = Convert.ToInt32(GVData.Rows[i].Cells["ItemId"].Value);
                    int PrintQuantity = Convert.ToInt32(GVData.Rows[i].Cells["Quantity"].Value);
                    int Linenum1 = Convert.ToInt32(GVData.Rows[i].Cells["LineNum"].Value);

                    // int Linenumber = Convert.ToInt32(GVData.Rows[i].Cells["Linenumber"].Value.ToString());
                        string TempalteId = cboTemplateId.SelectedItem.ToString();
                        string[] splitParts = TempalteId.Split('-');
                        sk = Convert.ToInt32(splitParts[0].ToString());
                        int TemplateId = sk;
                    string Sizes = cboBarcodeType.SelectedItem.ToString();
                    string[] splitPart = Sizes.Split('-');
                    KS = Convert.ToInt32(splitPart[0].ToString());
                    int Size = KS;

                    BarcodePrinting bp = new BarcodePrinting();
                    //bp.MRPLargeBarPrintingCustomer(DCId, TemplateId, Size, cboPrinterType.Text, PrintQuantity);
                    //bp.MRPPrint(DCId, TemplateId, Size, cboPrinterType.Text, PrintQuantity, Linenum1, ItemId);
                }
            }
            MessageBox.Show("Printed Successfully!");
            
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
      
        public void Clear()
        {
           
            chkSelectAll.Checked = false;
            cboBarcodeType.SelectedIndex = 0;
            //cboPrinterType.SelectedIndex = 0;
            cboTemplateId.SelectedIndex = 0;
        }
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnReprint_Click(object sender, EventArgs e)
        {
            if (!ValidationLibrary.IsSelected("Template", cboTemplateId, true)) return;
            if (!ValidationLibrary.IsSelected("Barcode Type", cboBarcodeType, true)) return;
            if (!ValidationLibrary.IsSelected("Printer Name", cboPrinterType, true)) return;

            int sk = 0;
            int KS = 0;
            for (int i = 0; i < 1; i++)
            {
                String s = GVData.Rows[i].Cells["Select"].EditedFormattedValue.ToString();
                if (s == "True")
                {
                    int ItemId = Convert.ToInt32(GVData.Rows[i].Cells["ItemId"].Value);
                    int PrintQuantity = Convert.ToInt32(GVData.Rows[i].Cells["Quantity"].Value);
                    int Linenum1 = Convert.ToInt32(GVData.Rows[i].Cells["LineNum"].Value);

                    // int Linenumber = Convert.ToInt32(GVData.Rows[i].Cells["Linenumber"].Value.ToString());
                    string TempalteId = cboTemplateId.SelectedItem.ToString();
                    string[] splitParts = TempalteId.Split('-');
                    sk = Convert.ToInt32(splitParts[0].ToString());
                    int TemplateId = sk;
                    string Sizes = cboBarcodeType.SelectedItem.ToString();
                    string[] splitPart = Sizes.Split('-');
                    KS = Convert.ToInt32(splitPart[0].ToString());
                    int Size = KS;

                    BarcodePrinting bp = new BarcodePrinting();
                   // bp.MRPPrint(DCId, TemplateId, Size, cboPrinterType.Text, PrintQuantity, Linenum1, ItemId);

                }
                if (chkSelectAll is CheckBox)
                {
                    ((CheckBox)chkSelectAll).Checked = false;
                }
            }
            MessageBox.Show("Printed Successfully!");
        }

        private void cboTemplateId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GVData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void btnReprint_Click(object sender, EventArgs e)
        //{
        //    if (!hasPrinted)
        //    {
        //        for (int i = 0; i < 1; i++) // Change the loop condition to control the number of iterations
        //        {
        //            // Perform the reprint action here
        //            Console.WriteLine("Printing...");

        //            // Increment the loop counter
        //            loopCounter++;
        //        }

        //        // Set the flag to true to indicate that printing has occurred
        //        hasPrinted = true;
        //    }
        //}

    }
}
