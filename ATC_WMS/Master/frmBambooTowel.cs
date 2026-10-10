using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharedLibrary;
using UIPShared;
using ATC_WMS.Model;

namespace ATC_WMS.Master
{
    public partial class frmBambooTowel : Form
    {
        public frmBambooTowel()
        {
            InitializeComponent();
        }

        private void lblMRP_Click(object sender, EventArgs e)
        {

        }
        private void PRINT()
        {
            try
            {
                int sk = Convert.ToInt32(txtQty.Text);
                if (sk != 0)
                {
                    BarcodePrinting bp = new BarcodePrinting();
                    bp.BambooTowel(sk);
                    MessageBox.Show("Printed Successfully!");
                    txtQty.Text = "";
                }
                else
                {
                    Shared.DisplayError("select Print Quantity!");
                }
            }
            catch
            {

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PRINT();
        }
    }
}
