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
using System.Drawing.Printing;

namespace ATC_WMS.Master
{
    public partial class frmMRPBarcode : Form
    {
        private object mySessionData;
        DataTable dt = new DataTable();
        public frmMRPBarcode()
        {
            mySessionData = null;
            InitializeComponent();
            DataGridViewTemplate(GVData);
            LoadData();
        }





        //private bool GetPrinterList()
        //{
        //    bool retVal = false;

        //    RamrajWMSEntities PrinterDoc = new RamrajWMSEntities();

        //    //prt.PrinterSettings.PrinterName returns the name of the Default Printer
        //    string strDefaultPrinter = PrinterDoc.p; ;

        //    //this will loop through all the Installed printers and add the Printer Names to a ComboBox.
        //    foreach (String strPrinter in PrinterSettings.InstalledPrinters)
        //    {
        //      
        //        //This will set the ComboBox Index where the Default Printer Name matches with the current Printer Name returned by for loop
        //        //if (strPrinter.CompareTo(strDefaultPrinter) == 0)
        //        //{
        //        //    cmbPrinter.SelectedIndex = cmbPrinter.Items.IndexOf(strPrinter);

        //        //    retVal = true;
        //        //}
        //    }

        //    return retVal;
        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            Application.Exit();
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
            string soref = "";
            string deleveryno = "";
            string Invoiceref = "";
            string trollyref = "";
            string customer = "";
            string state = "";
            using (ATCWMS_LIVEEntities ram = new ATCWMS_LIVEEntities())

            {
                var Fdata = (from c in ram.MRPLabelPrintView(txtSORef.Text, txtDeliveryOrder.Text, txtInvoiceRef.Text, txtTrolleyRef.Text, txtCustomer.Text, cboState.Text.ToString()) select c).ToList();
                GVData.AutoGenerateColumns = false;
                GVData.DataSource = Fdata;
            }
            LoadSerialNo();
        }


        // Perform printing operation (code for printing goes here)

        //private void cboSelectPrinter_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cboSelectPrinter.SelectedIndex == 0)
        //    {
        //        GetPrinterList();
        //    }
        //}



        public bool DialOpen(Type f)
        {
            Form ddd = null;
            bool chk = false;
            foreach (Form OpenForm in Application.OpenForms)
            {
                if (OpenForm.GetType() == f)
                {
                    ddd = OpenForm;
                    chk = true;
                    break;
                }

            }
            if (chk == true)
            {
                ddd.Activate();
                ddd.BringToFront();
            }

            return chk;

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void GVData_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                // if (!UIPShared.Shared.IsConfirmed("Do You want to View PO Number?")) return;

                int DeliveryNo = Convert.ToInt32(GVData.Rows[e.RowIndex].Cells["DeliveryNo"].Value);
                if (!DialOpen(typeof(frmMRPDetails)))
                {
                    frmMRPDetails f = new frmMRPDetails(DeliveryNo);
                    f.ShowDialog();


                }
            }
        }

        private void frmMRPBarcode_Load(object sender, EventArgs e)
        {
            LoadSerialNo();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            frmRePrint FM = new frmRePrint();
            FM.ShowDialog();

        }
        public class RePrint
        {
            public int DeliveryNo { get; set; }
            public string InvoiceNo { get; set; }
            public int CustomerName { get; set; }
            public string Code { get; set; }
            public string State { get; set; }
            public string SaleOrder { get; set; }
            public string DoDocEntry { get; set; }
            public Decimal OutwardId { get; set; }
            public string PickId { get; set; }
            public string TrollyNo { get; set; }
            public string TrollyQuantity { get; set; }
            public List<MRPDetailView_Result> Reprint { get; set; }
        }
    }
}