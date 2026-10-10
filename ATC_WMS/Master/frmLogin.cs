using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ATC_WMS.Model;

namespace ATC_WMS
{
    public partial class frmLogin : Form
    {
        ATCWMS_LIVEEntities ent = new ATCWMS_LIVEEntities();
        public frmLogin()

        {

            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static string EncodePasswordToBase64(string password)
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }

        public void CheckUser()
        {
            
        
            if (txtUser.Text != "" && txtPassword.Text != "")
            {
               // string Pass = EncodePasswordToBase64(txtPassword.Text.ToString());
                var check = (from t in ent.UserMasters where t.UserName == txtUser.Text && t.Password == txtPassword.Text select t).FirstOrDefault();

                if (check != null)
                {
                    //var check1 = (from t in ent.RoleDetails where t.RoleId == check.RoleId select t).FirstOrDefault();
                    if (check.StatusId == 1)
                    {
                        UIPShared.Shared.UserId = (int)check.UserId;
                        UIPShared.Shared.UserName = check.UserName;
                        UIPShared.Shared.Category ="Admin";
                        //UIPShared.Shared.BUId = check.BUnitId;

                        //var rol = (from c in ent.RoleActions join c1 in ent.FormDetails on c.FormId equals c1.FormId where c.RoleId == check.RoleId select new { c1.FormControl }).ToList();

                       // UIPShared.Shared.RoleActionDt = UIPShared.Shared.ConvertToDataTable(rol);

                        Master.frmHome n = new Master.frmHome();
                        this.Hide();
                        n.ShowDialog();
                    }
                    else
                    {
                        UIPShared.Shared.DisplayInformation("User Blocked!");
                    }
                }
                else
                {
                    MessageBox.Show("UserName or Password wrong!");
                }
            }
            else
            {
                MessageBox.Show("UserName or Password Cannot be blank!");
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            CheckUser();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPassword.Text = "";
            txtUser.Focus();
        }

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            this.lblClose.ForeColor = ColorTranslator.FromHtml("#ff0000");
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            this.lblClose.ForeColor = ColorTranslator.FromHtml("#000000");
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.label1.ForeColor = ColorTranslator.FromHtml("#0000FF");
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.label1.ForeColor = ColorTranslator.FromHtml("#000000");
        }

        private void btnLogOn_Click(object sender, EventArgs e)
        {
            UIPShared.Shared.Category = "User";
            Master.frmHome n = new Master.frmHome();
            this.Hide();
            n.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BarcodePrinting S = new BarcodePrinting();
            //S.GenxtLargePrintTest();
        }
    }
}
