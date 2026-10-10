using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace ATC_WMS.Process
{
    public partial class frmStockUpload : Form
    {
        DataTable dtItem = new DataTable();
        DataTable dtBin = new DataTable();
        DataTable dtreg = new DataTable();
        public SqlConnection liveDB;
        public SqlDataAdapter cmd;
        public SqlDataReader odrF;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet dt = new DataSet();
        public string livestr = ConfigurationSettings.AppSettings["LVDB"];
        DataSet ds = new DataSet();
        public frmStockUpload()
        {
            InitializeComponent();

        }

        private void LoadItemData()
        {
            DbOPen(livestr, ref liveDB);
            String ssql = "SELECT * FROM ItemMaster";
            adapter.SelectCommand = new SqlCommand(ssql, liveDB);
            adapter.Fill(dtItem);
        }

        private void LoadBINData()
        {
            DbOPen(livestr, ref liveDB);
            String ssql = "SELECT * FROM Bin_View";
            adapter.SelectCommand = new SqlCommand(ssql, liveDB);
            adapter.Fill(dtBin);
        }


        private Boolean DbOPen(string datac, ref SqlConnection ConDB)
        {
            ConDB = new SqlConnection(datac.ToString());
            if (ConDB.State == ConnectionState.Closed)
            {
                ConDB.Open();
                return true;
            }
            else
            {
                return true;
            }
        }
        private void Clear()
        {
            gvData.DataSource = null;
        }

        private delegate void printval(string msg);
        private void CuttingEmp(string msg)
        {
            lblcount.Text = msg;
        }

        public string EscapeXml(string s)
        {
            string toxml = s;
            if (!string.IsNullOrEmpty(toxml))
            {
                // replace literal values with entities
                toxml = toxml.Replace("&", "&amp;");
                toxml = toxml.Replace("'", "&apos;");
                toxml = toxml.Replace("\"", "&quot;");
            }
            return toxml;
        }

        private void lblTemplate_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Excel file (*.xlsx)|*.xlsx";
            saveFileDialog1.DefaultExt = "xlsx";
            saveFileDialog1.Title = "Select path to save File";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string sourcePath = Application.StartupPath;
                File.Copy(sourcePath + "\\StockUploadTemplate.xlsx", saveFileDialog1.FileName);
                MessageBox.Show("Downloaded Successfully!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            decimal TQty = 0;
            openFileDialog1.Title = "Stock Upload";
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
                        fileLocation + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=2\"";
                        if (fileExtension == ".xls")
                        {
                            excelConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                            fileLocation + ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=2\"";
                        }
                        else if (fileExtension == ".xlsx")
                        {
                            excelConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                            fileLocation + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=2\"";
                        }
                        OleDbConnection excelConnection = new OleDbConnection(excelConnectionString);
                        excelConnection.Open();
                        DataTable dt1 = new DataTable();
                        dt1 = excelConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                        if (dt1 == null)
                        {
                            return;
                        }
                        foreach (DataRow row in dt1.Rows)
                        {
                            ds = new DataSet();
                            OleDbConnection excelConnection1 = new OleDbConnection(excelConnectionString);
                            string query = string.Format("Select * from [{0}]", row["TABLE_NAME"].ToString());
                            using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, excelConnection1))
                            {
                                dataAdapter.Fill(ds);
                                if (ds.Tables[0].Rows.Count > 0)
                                {
                                    ds.Tables[0].Columns.Add("Error");

                                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                                    {
                                        string ErrorMsg = "Ok";
                                        string ItemCode = ds.Tables[0].Rows[i][1].ToString();
                                        string Bin = ds.Tables[0].Rows[i][3].ToString();

                                        //Item Validation
                                        dtItem.DefaultView.RowFilter = "ItemCode = '" + ItemCode + "'";
                                        if (dtItem.DefaultView.ToTable().Rows.Count == 0)
                                        {
                                            if (ErrorMsg == "Ok")
                                            {
                                                ErrorMsg = "Invalid Item";
                                            }
                                        }

                                        //BIN Validation
                                        dtBin.DefaultView.RowFilter = "BinBarcode  = '" + Bin + "'";
                                        if (dtBin.DefaultView.ToTable().Rows.Count == 0)
                                        {
                                            if (ErrorMsg == "Ok")
                                            {
                                                ErrorMsg = "Invalid Bin";
                                            }
                                        }

                                        //BIN Type Validation
                                        dtBin.DefaultView.RowFilter = "BinBarcode  = '" + Bin + "'";
                                        if (dtBin.DefaultView.ToTable().Rows.Count > 0)
                                        {
                                            if (dtBin.Rows[i][9].ToString() == "0")
                                            {
                                                if (ErrorMsg == "Ok")
                                                {
                                                    ErrorMsg = "Invalid Bin Type";
                                                }
                                            }
                                        }


                                        //Qty Validation
                                        try
                                        {
                                            decimal Quantity = Convert.ToDecimal(ds.Tables[0].Rows[i][4].ToString());
                                            ds.Tables[0].Rows[i]["Error"] = "Ok";
                                            TQty = TQty + Quantity;
                                        }
                                        catch
                                        {
                                            if (ErrorMsg == "Ok")
                                            {
                                                ErrorMsg = "Invalid Qty";
                                            }
                                        }
                                        ds.Tables[0].Rows[i]["Error"] = ErrorMsg;
                                    }

                                    gvData.DataSource = null;
                                    gvData.DataSource = ds.Tables[0];
                                    txtTotal.Text = TQty.ToString();
                                    ttlItem.Text = ds.Tables[0].Rows.Count.ToString();
                                    ttlBin.Text = ds.Tables[0].Rows.Count.ToString();
                                   // int distinctCount = ds.Tables[0].Select(dd => dd.Field<string>("Id")).Distinct().Count();
                                }
                                else
                                {
                                }
                            }
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid File Format");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            string Msg = "";
            try
            {
                int dTotal = ds.Tables[0].Rows.Count;
                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                bool containsValue = !dt.AsEnumerable()
                                     .Any(row => row.Field<string>("Error") != "Ok");
                if (containsValue)
                {
                    int itemReccount = 301;
                    string xmldata = "";
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        try
                        {
                            if ((i + 1) % itemReccount == 0)
                            {
                                if (xmldata != "")
                                {
                                    string itemcode = dt.Rows[i][1].ToString();
                                    string Bin = dt.Rows[i][3].ToString();
                                    decimal Qty = Convert.ToDecimal(dt.Rows[i][4].ToString());

                                    xmldata += "<da>";
                                    xmldata += "<Itemcode>" + itemcode + "</Itemcode>";
                                    xmldata += "<BinLocation>" + Bin + "</BinLocation>";
                                    xmldata += "<Qty>" + Qty + "</Qty>";
                                    xmldata += "</da>";
                                    xmldata += "</d>";

                                    xmldata = EscapeXml(xmldata);
                                    DbOPen(livestr, ref liveDB);
                                    String ssql1 = "GRN_Stock_BulkSave";
                                    SqlCommand SelectCommand = new SqlCommand(ssql1, liveDB);
                                    SelectCommand.CommandType = CommandType.StoredProcedure;
                                    SelectCommand.Parameters.Add("@Datac", xmldata);
                                    SelectCommand.Parameters.Add("@userid", UIPShared.Shared.UserId);
                                    SelectCommand.ExecuteNonQuery();
                                    xmldata = "";
                                    this.BeginInvoke(new printval(CuttingEmp), new object[] { (i + 1) + "/" + dTotal });
                                }
                            }
                            else
                            {
                                if (xmldata == "")
                                {
                                    xmldata = "<d>";
                                }
                                string itemcode = dt.Rows[i][1].ToString();
                                string Bin = dt.Rows[i][3].ToString();
                                decimal Qty = Convert.ToDecimal(dt.Rows[i][4].ToString());

                                xmldata += "<da>";
                                xmldata += "<Itemcode>" + itemcode + "</Itemcode>";
                                xmldata += "<BinLocation>" + Bin + "</BinLocation>";
                                xmldata += "<Qty>" + Qty + "</Qty>";
                                xmldata += "</da>";
                            }
                            this.BeginInvoke(new printval(CuttingEmp), new object[] { (i + 1) + "/" + dTotal });
                            double dIndex = (double)(i) + 1;
                            double dProgressPercentage = (dIndex / dTotal);
                            int iProgressPercentage = (int)(dProgressPercentage * 100);
                            backgroundWorker1.ReportProgress(iProgressPercentage);
                        }
                        catch (Exception e)
                        {
                        }
                    }
                    if (xmldata != "")
                    {
                        xmldata += "</d>";
                        DbOPen(livestr, ref liveDB);
                        xmldata = EscapeXml(xmldata);
                        DbOPen(livestr, ref liveDB);
                        String ssql1 = "GRN_Stock_BulkSave";
                        SqlCommand SelectCommand = new SqlCommand(ssql1, liveDB);
                        SelectCommand.CommandType = CommandType.StoredProcedure;
                        SelectCommand.Parameters.Add("@Datac", xmldata);
                        SelectCommand.Parameters.Add("@userid", 1);
                        //SelectCommand.ExecuteNonQuery();
                        xmldata = "";
                        using (SqlDataReader reader = SelectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Msg = reader[0].ToString();
                                if(Msg=="0")
                                {
                                    gvData.DataSource = null;
                                    ttlBin.Text = "0";
                                    ttlItem.Text = "0";
                                    txtTotal.Text = "0";
                                }
                                else
                                {
                                    MessageBox.Show(Msg);
                                    return;
                                }
                               
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Excel contains some invalid fields");
                }
            }
            catch
            {
            }
        }

        private void frmStockUpload_Load(object sender, EventArgs e)
        {
            LoadBINData();
            LoadItemData();
        }
    }
}
