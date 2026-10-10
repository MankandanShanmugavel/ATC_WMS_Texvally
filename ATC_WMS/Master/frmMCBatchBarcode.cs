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
    public partial class frmMCBatchBarcode : Form
    {
        public frmMCBatchBarcode()
        {
            InitializeComponent();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PRINT();
        }

        private void PRINT()
        {
            try
            {
                int sk = Convert.ToInt32(txtQty.Text);
                if (sk != 0)
                {
                    BarcodePrinting bp = new BarcodePrinting();
                    bp.MCBarcode(sk);
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

        private void frmMCBatchBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                PRINT();
        }

        private void frmMCBatchBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
