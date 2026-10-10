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
using System.Data.OleDb;
using UIPShared;
using System.Threading;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.Configuration;

namespace ATC_WMS.Process
{
    public partial class frmAnnualInventoryUpload : Form
    {
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        string connectionString = ConfigurationManager.AppSettings["LVDB"];
        public frmAnnualInventoryUpload()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            DataGridViewTemplate(GVData);
        }

        public void DataGridViewTemplate(DataGridView control)
        {
            control.AllowUserToAddRows = false;
            control.AllowUserToDeleteRows = false;
            control.AllowUserToResizeColumns = false;
            control.AllowUserToResizeRows = false;
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
            control.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            // 
        }

        //private void LoadSerialNo()
        //{
        //    int i = 1;
        //    foreach (DataGridViewRow row in GVData.Rows)
        //    {
        //        row.Cells["SNO"].Value = i; i++;
        //    }
        //}

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportExcelFile.GridExportToExcel(GVData);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            CreateTable();
            UploadStock();
            timer1.Enabled = true;

        }
        private void UploadStock()
        {
          
            openFileDialog1.Title = "Find Stock Excel";
            openFileDialog1.Filter = "Excel files|*.xls;*.xlsx";
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    string fileExtension = System.IO.Path.GetExtension(openFileDialog1.FileName);
                    if (fileExtension == ".xls" || fileExtension == ".xlsx")
                    {
                        string fileLocation = openFileDialog1.FileName;
                        string excelConnectionString = string.Empty;
                        excelConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                       fileLocation + ";Extended Properties=\"Excel 12.0;IMEX=1;HDR=NO;TypeGuessRows=1;ImportMixedTypes=Text\"";

                        if (fileExtension == ".xls")
                        {
                            excelConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                            fileLocation + ";Extended Properties=\"Excel 8.0;IMEX=1;HDR=NO;TypeGuessRows=1;ImportMixedTypes=Text\"";
                        }

                        OleDbConnection excelConnection = new OleDbConnection(excelConnectionString);
                        try
                        {
                            excelConnection.Open();
                        }
                        catch
                        {
                            excelConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                       fileLocation + ";Extended Properties=\"Excel 12.0;IMEX=1;HDR=NO;TypeGuessRows=1;ImportMixedTypes=Text\"";
                            excelConnection = new OleDbConnection(excelConnectionString);
                            excelConnection.Open();
                        }
                        DataTable dt1 = new DataTable();
                        dt1 = excelConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                        if (dt1 == null)
                        {
                            return;
                        }

                        foreach (DataRow row1 in dt1.Rows)
                        {
                            ds = new DataSet();
                            OleDbConnection excelConnection1 = new OleDbConnection(excelConnectionString);
                            string query = string.Format("Select * from [{0}]", row1["TABLE_NAME"].ToString());
                            using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, excelConnection1))
                            {
                                dataAdapter.Fill(ds);
                                string jsonString = JsonConvert.SerializeObject(ds);
                                excelConnection.Close();
                                break;
                            }
                        }
                    }
                    else
                    {
                        Shared.DisplayInformation("Invalid File Format");
                    }
                }
                catch (Exception ex)
                {
                    Shared.DisplayInformation(ex.Message);
                }
            }
           

        }

        private void UpdateProgressBar(int value)
        {
            if (prgBar.InvokeRequired)
            {
                prgBar.Invoke(new Action<int>(UpdateProgressBar), value);
            }
            else
            {
                prgBar.Value = value;
                lblPercentage.Text = value.ToString();

            }
        }

        private void LoadGV()
        {
            using (ATCWMS_LIVEEntities btr = new ATCWMS_LIVEEntities())
            {
                int count = ds.Tables[0].Rows.Count;
                int current = 0;
                decimal SQty = 0;
                decimal SOQty = 0;
                for (int i = 1; i < ds.Tables[0].Rows.Count; i++)
                {
                    current++;
                    int PGBV = 0;
                    PGBV = (int)((current / (double)count) * 100);
                    UpdateProgressBar(PGBV);
                    int PTypeId = 0;
                    long ItemId = 0;
                    long BinId = 0;
                    decimal OldQty = 0;
                    decimal StockQty = 0;
                    int flag = 0;

                    string ItemCode = Convert.ToString(ds.Tables[0].Rows[i][1].ToString());
                    string ItemName = Convert.ToString(ds.Tables[0].Rows[i][2].ToString());
                    string TypeName = Convert.ToString(ds.Tables[0].Rows[i][3].ToString());
                    string BinBarcode = ds.Tables[0].Rows[i][6].ToString();
                    string Process = Convert.ToString(ds.Tables[0].Rows[i][4].ToString());

                    string Remarks = "OK";


                    var IID = btr.ItemMasters.Where(c => c.ItemCode == ItemCode).FirstOrDefault();
                    if (IID == null)
                    {
                        ItemId = 0;
                        if (Remarks == "OK")
                        {
                            Remarks = "Invalid ItemCode!";
                        }
                        flag = 1;
                    }
                    else
                    {
                        ItemId = IID.ItemId;
                    }


                    //var pid = btr.PackingTypeMasters.Where(c => c.PTName == TypeName).FirstOrDefault();
                    //if (pid == null)
                    //{
                    //    PTypeId = 0;
                    //    if (Remarks == "OK")
                    //    {
                    //        Remarks = "Invalid TypeName!";
                    //    }
                    //    flag = 1;
                    //}
                    //else
                    //{
                    //    PTypeId = pid.PTypeId;
                    //}

                    var bid = btr.BinMasters.Where(c => c.BinBarcode == BinBarcode).FirstOrDefault();
                    if (bid == null)
                    {
                        BinId = 0;
                        if (Remarks == "OK")
                        {
                            Remarks = "Invalid Bin!";
                        }
                        flag = 1;
                    }
                    else
                    {
                        if (bid.PTypeId == 0)
                        {
                            if (Remarks == "OK")
                            {
                                Remarks = "Invalid Packing Type!";
                            }
                            flag = 1;
                        }
                        else
                        {
                            BinId = bid.BinId;
                            PTypeId = (int)bid.PTypeId;
                        }
                    }


                    try
                    {
                        OldQty = Convert.ToDecimal(ds.Tables[0].Rows[i][7].ToString());
                    }
                    catch
                    {
                        if (Remarks == "OK")
                        {
                            Remarks = "Invalid Old Quantity!";
                        }
                        flag = 1;
                    }

                    try
                    {
                        StockQty = Convert.ToDecimal(ds.Tables[0].Rows[i][8].ToString());
                        if (StockQty < 0)
                        {
                            if (Remarks == "OK")
                            {
                                Remarks = "Invalid Physical Stock!";
                            }
                            flag = 1;
                        }
                    }
                    catch
                    {
                        if (Remarks == "OK")
                        {
                            Remarks = "Invalid Physical Stock!";
                        }
                        flag = 1;
                    }
                    SQty = SQty + StockQty;
                    SOQty = SOQty + OldQty;
                    DataRow row = dt.NewRow();
                    row["SNo"] = i;
                    row["ItemId"] = ItemId;
                    row["ItemCode"] = ItemCode;
                    row["ItemName"] = ItemName;
                    row["PTypeId"] = PTypeId;
                    row["TypeName"] = TypeName;
                    row["BinId"] = BinId;
                    row["BinBarcode"] = BinBarcode;
                    row["OldQty"] = Convert.ToDecimal(OldQty);
                    row["StockQty"] = Convert.ToDecimal(StockQty); ;
                    row["Remarks"] = Remarks;
                    row["flag"] = flag;
                    dt.Rows.Add(row);
                }
               
                int uniqueItemCodeCount = dt.AsEnumerable()
                                            .Select(row => row.Field<string>("ItemId"))
                                            .Distinct()
                                            .Count();
                int uniqueBinIdCodeCount = dt.AsEnumerable()
                                           .Select(row => row.Field<string>("BinId"))
                                           .Distinct()
                                           .Count();
                this.BeginInvoke(new printval(CuttingEmp1), new object[] { uniqueItemCodeCount.ToString() });
                this.BeginInvoke(new printval(CuttingEmp2), new object[] { uniqueBinIdCodeCount.ToString() });
                this.BeginInvoke(new printval(CuttingEmp3), new object[] { SOQty.ToString() });
                this.BeginInvoke(new printval(CuttingEmp4), new object[] { SQty.ToString() });
            }

        }

        private delegate void printval(string msg);
        private void CuttingEmp1(string ttlItem1)
        {
            ttlItem.Text = ttlItem1;
        }

        private void CuttingEmp2(string ttlBin1)
        {
            ttlBin.Text = ttlBin1;
        }

        private void CuttingEmp3( string txtTotal1)
        {
            txtTotal.Text = txtTotal1;
        }

        private void CuttingEmp4(string txtNewQty1)
        {
            txtNewQty.Text = txtNewQty1;
        }

        private void CreateTable()
        {
            dt = new DataTable();
            dt.Columns.Add("SNo");
            dt.Columns.Add("ItemId");
            dt.Columns.Add("ItemCode");
            dt.Columns.Add("ItemName");
            dt.Columns.Add("PTypeId");
            dt.Columns.Add("TypeName");
            dt.Columns.Add("BinId");
            dt.Columns.Add("BinBarcode");
            dt.Columns.Add("OldQty");
            dt.Columns.Add("StockQty");
            dt.Columns.Add("Remarks");
            dt.Columns.Add("flag");
        }


        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            btnSave.Enabled = false;
            btnBrowse.Enabled = false;
            Thread t = new Thread(LoadGV);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            timer1.Stop();
            timer1.Enabled = false;
            GVData.DataSource = null;
            GVData.AutoGenerateColumns = false;
            GVData.DataSource = dt;
            UpdateProgressBar(100);
            btnSave.Enabled = true;
            btnBrowse.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CallFun();
        }

        private void CallFun()
        {
            timer1.Stop();
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string msg = "";
            string columnToCheck = "Remarks";
            bool allContainOK = dt.AsEnumerable()
                                  .All(row => row.Field<string>(columnToCheck) == "OK");
            if (allContainOK)
            {
                string columnName = "ItemId";

                var distinctValues = dt.AsEnumerable()
                                       .Select(row => row.Field<string>(columnName))
                                       .Distinct();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    foreach (var value in distinctValues)
                    {

                        var UPList = dt.AsEnumerable()
                   .Where(row => row.Field<string>(columnName) == value)
                   .Select(row => new
                   {
                       BinId = row.Field<string>("BinId"),
                       PTypeId = row.Field<string>("PTypeId"),
                       StockQty = row.Field<string>("StockQty")
                   });
                        var xmlc = "<d>";
                        foreach (var item in UPList)
                        {
                            xmlc += "<da>";
                            xmlc += "<BinId>" + item.BinId + "</BinId>";
                            xmlc += "<PTypeId>" + item.PTypeId + "</PTypeId>";
                            xmlc += "<StockQty>" + item.StockQty + "</StockQty>";
                            xmlc += "</da>";
                        }
                        xmlc += "</d>";

                        using (SqlCommand command = connection.CreateCommand())
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.CommandText = "AnnualInventory_WMSStock_Save";
                            command.Parameters.AddWithValue("@ItemId", value);
                            command.Parameters.AddWithValue("@UserId", 1);
                            command.Parameters.AddWithValue("@xmlb", xmlc);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    msg = reader.GetString(0);
                                    msg = (msg == "0") ? "" : msg;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Shared.DisplayError("Some data has Error!");
            }
            Shared.DisplayInformation("Uploaded Successfully!");
            GVData.DataSource = null;
            prgBar.Value = 0;
            lblPercentage.Text = "";

        }
    }
}
