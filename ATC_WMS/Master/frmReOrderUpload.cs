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

namespace ATC_WMS
{
    public partial class frmReOrderUpload : Form
    {

        DataTable dtreg = new DataTable();
        public SqlConnection liveDB;
        public SqlDataAdapter cmd;
        public SqlDataReader odrF;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet dt = new DataSet();       
        public string livestr = ConfigurationSettings.AppSettings["LVDB"];
        DataSet ds = new DataSet();
        public frmReOrderUpload()
        {
            InitializeComponent();
        }

        private void frmReOrderUpload_Load(object sender, EventArgs e)
        {
            DbOPen(livestr, ref liveDB);
            String ssql = "select * from RegionMaster";
            adapter.SelectCommand = new SqlCommand(ssql, liveDB);
            adapter.Fill(dtreg);        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetData();

        }
        private void GetData()
        {          
           
            openFileDialog1.Title = "Find  Excel";
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
                                    for (int i =5; i < ds.Tables[0].Columns.Count; i++)
                                    {
                                        string[] sp = ds.Tables[0].Columns[i].ColumnName.Split('-');
                                        
                                        dtreg.DefaultView.RowFilter="RegionName='"+sp[0]+"'";
                                        if (dtreg.DefaultView.ToTable().Rows.Count == 0)
                                        {
                                            MessageBox.Show("Invalid Region Name" +sp[0]);
                                            return;
                                        }

                                    }
                                    gvData.DataSource = null;
                                    gvData.DataSource = ds.Tables[0];
                                    txtTotal.Text = ds.Tables[0].Rows.Count.ToString();
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



            if (ds.Tables[0].Rows.Count > 0)
            {
                      
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Save();
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
        private void Save()
        {
            try
            {

                int dTotal = ds.Tables[0].Rows.Count;
                DataTable dt = new DataTable();
                dt=ds.Tables[0];
                int itemReccount = 50;
                string xmldata = "";
                string delxml = "";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    try
                    {
                        if ((i + 1) % itemReccount == 0)
                        {
                            if (xmldata != "")
                            {
                                xmldata += "</d>";
                                delxml += "</d>";
                                xmldata = EscapeXml(xmldata);
                                DbOPen(livestr, ref liveDB);
                                String ssql1 = "ItemReorder_Save";
                                SqlCommand SelectCommand = new SqlCommand(ssql1, liveDB);
                                SelectCommand.CommandType = CommandType.StoredProcedure;
                                SelectCommand.Parameters.Add("@Datac", xmldata);
                                SelectCommand.Parameters.Add("@userid", 1);
                                SelectCommand.Parameters.Add("@Datar", delxml);                                
                                SelectCommand.ExecuteNonQuery();
                                xmldata = "";
                                delxml = "";
                                this.BeginInvoke(new printval(CuttingEmp), new object[] { (i + 1) + "/" + dTotal });
                            }
                        }
                        else
                        {
                            if (xmldata == "")
                            {
                                xmldata = "<d>";
                                delxml = "<d>";
                            }
                            string itemcode = dt.Rows[i][1].ToString();
                            decimal min = 0;
                            decimal max = 0;

                            if (dt.Rows[i][3].ToString() != "" && dt.Rows[i][4].ToString() != "")
                            {
                                min = Convert.ToDecimal(dt.Rows[i][3].ToString());
                                max = Convert.ToDecimal(dt.Rows[i][4].ToString());
                            }
                            
                            xmldata += "<da>";
                            xmldata += "<i>" + itemcode + "</i>";
                            xmldata += "<min>" + min + "</min>";
                            xmldata += "<max>" + max + "</max>";                                                
                            xmldata += "</da>";
                            for (int j = 5; j < ds.Tables[0].Columns.Count; j=j+2)
                            {
                                string[] sp = ds.Tables[0].Columns[j].ColumnName.Split('-');
                                dtreg.DefaultView.RowFilter = "RegionName='" + sp[0] + "'";
                                if (dtreg.DefaultView.ToTable().Rows.Count == 0)
                                {
                                    MessageBox.Show("Invalid Region Name" + sp[0]);
                                    return;
                                }
                                else
                                {
                                    if (dt.Rows[i][j].ToString() != "" && dt.Rows[i][j+1].ToString() != "")
                                    {
                                        min = Convert.ToDecimal(dt.Rows[i][j].ToString());
                                        max = Convert.ToDecimal(dt.Rows[i][j+1].ToString());
                                    }
                                    else
                                    {
                                        min = 0;
                                        max = 0;
                                    }
                                    delxml += "<da>";
                                    delxml += "<i>" + itemcode + "</i>";
                                    delxml += "<min>" + min + "</min>";
                                    delxml += "<max>" + max + "</max>";
                                    delxml += "<rid>" + dtreg.DefaultView.ToTable().Rows[0]["RegionId"].ToString() + "</rid>";
                                    delxml += "</da>";
                                }

                            }                   
                         
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
                    delxml += "</d>";
                    DbOPen(livestr, ref liveDB);
                    xmldata = EscapeXml(xmldata);
                    DbOPen(livestr, ref liveDB);
                    String ssql1 = "ItemReorder_Save";
                    SqlCommand SelectCommand = new SqlCommand(ssql1, liveDB);
                    SelectCommand.CommandType = CommandType.StoredProcedure;
                    SelectCommand.Parameters.Add("@Datac", xmldata);
                    SelectCommand.Parameters.Add("@userid", 1);
                    SelectCommand.Parameters.Add("@Datar", delxml);
                    SelectCommand.ExecuteNonQuery();         
                    xmldata = "";
                    delxml = "";
                   
                }         
                         



                
            }
            catch
            {
            }
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
        private delegate void printval(string msg);
        private void CuttingEmp(string msg)
        {
            lblcount.Text = msg;

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Updated Successfully!");
            pbbar.Value = 0;
            Clear();
        }

        private void Clear()
        {
            gvData.DataSource = null;

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbbar.Value = e.ProgressPercentage;

        }

        private void gvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblMRP_Click(object sender, EventArgs e)
        {

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
                File.Copy(sourcePath + "\\ReplenishmentTemplate.xlsx", saveFileDialog1.FileName);
                MessageBox.Show("Downloaded Successfully!");
            }
        }
    }
}
