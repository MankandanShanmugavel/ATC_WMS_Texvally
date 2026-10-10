using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATC_WMS.Master
{
    public partial class frmHome : Form
    {
        private string _FolderLocation;
        public string FolderLocation
        {
            get { return _FolderLocation; }
            set { _FolderLocation = value; }
        }
        private string fileName = "RamrajBarcode.txt";
        bool HomeCollapse = true;
        public frmHome()
        {
            InitializeComponent();
            LoadForms();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            HomeCollapse = true;
            ProcessContainer.Height = ProcessContainer.MinimumSize.Height;
        }

        public void LoadForms()
        {
            if(UIPShared.Shared.Category=="User")
            {
               // btnReplishment.Visible = false;
            }else
            {
                templateUploadToolStripMenuItem.Visible = true;
            }
        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void btnMaximize_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSideBar_Click(object sender, EventArgs e)
        {
            if (MenuContainer.Width == 204)
            {
                MenuContainer.Width = 1;
            }
            else
                MenuContainer.Width = 204;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            ProcessTimer.Start();
        }

        private void ProcessTimer_Tick(object sender, EventArgs e)
        {
            if (HomeCollapse)
            {
                ProcessContainer.Height += 10;
                if (ProcessContainer.Height == ProcessContainer.MaximumSize.Height)
                {
                    HomeCollapse = false;
                    ProcessTimer.Stop();
                }
            }
            else
            {
                ProcessContainer.Height -= 10;
                if (ProcessContainer.Height == ProcessContainer.MinimumSize.Height)
                {
                    HomeCollapse = true;
                    ProcessTimer.Stop();
                }
            }
        }

     

        private void ProcessContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuContainer_Paint(object sender, PaintEventArgs e)
        {

        }

       
        

        private void btnMRPAuto_Click(object sender, EventArgs e)
        {
            frmMRPAuto f = new frmMRPAuto();
            f.ShowDialog();
        }

        private void btnRePrint_Click(object sender, EventArgs e)
        {
            frmWorkOrder f = new frmWorkOrder();
            f.ShowDialog();
        }
        private void lblUser_Click(object sender, EventArgs e)
        {
            UserTimer.Start();
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            frmLogin n = new frmLogin();
            this.Hide();
            n.ShowDialog();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            UserName.Text = UIPShared.Shared.UserName;
            timer1.Enabled = true;
            timer1.Interval = 3;
  
        }
        private void UserTimer_Tick(object sender, EventArgs e)
        {
            if (HomeCollapse)
            {
                UserContainer.Height += 10;
                if (UserContainer.Height == UserContainer.MaximumSize.Height)
                {
                    HomeCollapse = false;
                    UserTimer.Stop();
                }
            }
            else
            {
                UserContainer.Height -= 10;
                if (UserContainer.Height == UserContainer.MinimumSize.Height)
                {
                    HomeCollapse = true;
                    UserTimer.Stop();
                }
            }
        }

        private void lblLogOut_MouseEnter(object sender, EventArgs e)
        {
            this.lblLogOut.ForeColor = ColorTranslator.FromHtml("#ff0000");
        }

        private void lblLogOut_MouseLeave(object sender, EventArgs e)
        {
            this.lblLogOut.ForeColor = ColorTranslator.FromHtml("#008000");
        }

        private void btnMCPrint_Click(object sender, EventArgs e)
        {
            frmMCBatchBarcode n = new frmMCBatchBarcode();
            n.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           

        }

        private void btnReplishment_Click(object sender, EventArgs e)
        {
            frmReOrderUpload n = new frmReOrderUpload();
            n.ShowDialog();
        }

        private void btnItemConversion_Click(object sender, EventArgs e)
        {
          frmItemConversion f = new frmItemConversion();
            f.ShowDialog();
    }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (AGT.Left < 0 && (Math.Abs(AGT.Left) > label1.Width))
                AGT.Left = this.Width;
            if (Version.Left < 0 && (Math.Abs(Version.Left) > label1.Width))
                Version.Left = this.Width;
            if (pbLogo.Left < 0 && (Math.Abs(pbLogo.Left) > label1.Width))
                pbLogo.Left = this.Width;
            AGT.Left -= 1;
            Version.Left -= 1;
            pbLogo.Left -= 1;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnStateConversion_Click(object sender, EventArgs e)
        {
            frmStateConversion n = new frmStateConversion();
            n.ShowDialog();
        }

        private void btnBamboo_Click(object sender, EventArgs e)
        {
            frmBambooTowel H = new frmBambooTowel();
            H.ShowDialog();
        }

        private void btnBundle_Click(object sender, EventArgs e)
        {
            frmBundlePacking H = new frmBundlePacking();
            H.ShowDialog();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            FormLabelBarcode H = new FormLabelBarcode();
            H.ShowDialog();
        }
        private void btnProcess2_Click(object sender, EventArgs e)
        {
            ProcessTimer2.Start();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void printingProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mRPAutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!DialOpen(typeof(frmMRPAuto)))
            {
                frmMRPAuto f = new frmMRPAuto();
                f.Show();
            }
           
        }

        private void workORDERPRINTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!DialOpen(typeof(frmWorkOrder)))
            {
                frmWorkOrder f = new frmWorkOrder();
                f.Show();
            }
        }

        private void itemConversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!DialOpen(typeof(frmItemConversion)))
            {
                frmItemConversion f = new frmItemConversion();
                f.Show();
            }
        }

        private void stateConversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!DialOpen(typeof(frmStateConversion)))
            {
                frmStateConversion n = new frmStateConversion();
                n.Show();
            }
        }

        private void locationBarcodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!DialOpen(typeof(FormLabelBarcode)))
            {
                FormLabelBarcode H = new FormLabelBarcode();
                H.Show();
            }
        }

        private void bundleBarcodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!DialOpen(typeof(frmBundlePacking)))
            {
                frmBundlePacking H = new frmBundlePacking();
                H.Show();
            }
        }

        private void bambooBarcodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!DialOpen(typeof(frmBambooTowel)))
            {
                frmBambooTowel H = new frmBambooTowel();
                H.Show();
            }
        }

        private void templateUploadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void replenishmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReOrderUpload n = new frmReOrderUpload();
            n.ShowDialog();
        }

        private void itemLableTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.frmItemLableTypeAssign n = new Process.frmItemLableTypeAssign();
            n.ShowDialog();
        }

        private void bundleMCBarcodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMCBatchBarcode n = new frmMCBatchBarcode();
            n.ShowDialog();
        }

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

        private void stockCorrectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.frmStockUpload n = new Process.frmStockUpload();
            n.ShowDialog();
        }

        private void trolleyBarcodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.frmTrolleyPrint n = new Process.frmTrolleyPrint();
            n.ShowDialog();
        }

        private void annualInventoryUploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.frmAnnualInventoryUpload n = new Process.frmAnnualInventoryUpload();
            n.ShowDialog();
        }

        private void annualInventoryViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.frmAnnualInventoryView n = new Process.frmAnnualInventoryView();
            n.ShowDialog();
        }

        private void salesDCBunldePrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.frmDCBundleBarcodePrint n = new Process.frmDCBundleBarcodePrint();
            n.ShowDialog();
        }

        private void salesReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Master.SalesReturn  n = new Master.SalesReturn();
            n.ShowDialog();
        }

        private void samplReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Master.frmSampleReturn n = new Master.frmSampleReturn();
            n.ShowDialog();
        }

        private void sampleRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Master.frmSampleRequest n = new Master.frmSampleRequest();
            n.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }

}
