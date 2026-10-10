using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC_WMS.Model
{
    public class CommanDB
    {
        string conString = ConfigurationManager.AppSettings["LVDB"];

        internal DataSet CheckSerail(string Barcode)
        {
            using (var newConnection = new SqlConnection(conString))
            using (var mySQLAdapter = new SqlDataAdapter("SalesDC_BundleBarcode_View", newConnection))
            {
                mySQLAdapter.SelectCommand.Parameters.AddWithValue("@BundleBarcode", Barcode);
                mySQLAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet myDataSet = new DataSet();
                mySQLAdapter.Fill(myDataSet);
                return myDataSet;
            }
        }

        public Task<Dash_Tablewise_PerforVBO> GetDCBunldeData(string DCNumber)
        {
            return Task.Run(() =>
            {
                Dash_Tablewise_PerforVBO DataList = new Dash_Tablewise_PerforVBO();
                using (var newConnection = new SqlConnection(conString))
                using (var mySQLAdapter = new SqlDataAdapter("SalesDC_BundleBarcodeGet_byDCId", newConnection))
                {
                mySQLAdapter.SelectCommand.Parameters.AddWithValue("@DCNumber", DCNumber);
                    mySQLAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet myDataSet = new DataSet();
                    mySQLAdapter.Fill(myDataSet);
                    if (myDataSet.Tables[0].Rows.Count > 0)
                    {
                        DataList.msg = (from DataRow dr in myDataSet.Tables[0].Rows
                                        select new Dash_Tablewise_PerforVBO()
                                        {
                                            msg = dr["msg"].ToString()
                                        }).Select(c => c.msg).FirstOrDefault().ToString();

                        DataList.tabdet = (from DataRow dr in myDataSet.Tables[1].Rows
                                           select new DCBundleDet()
                                           {
                                               DCNumber = dr["DCNumber"].ToString(),
                                               BundleBarcode = dr["BundleBarcode"].ToString(),
                                               Date = dr["Date"].ToString(),
                                               Time = dr["Time"].ToString(),
                                               Qty = Convert.ToDecimal(dr["Qty"].ToString()),
                                               LineNum = dr["LineNum"].ToString()
                                           }).ToList();
                    }
                    else
                    {
                        DataList.msg = "Invalid DCId";
                        DataList.tabdet = new List<DCBundleDet>();
                    }
                    return DataList;
                }
            });
        }

        internal DataSet GetDCBunldeDataNew(string DCNumber)
        {
            using (var newConnection = new SqlConnection(conString))
            using (var mySQLAdapter = new SqlDataAdapter("SalesDC_BundleBarcodeGet_byDCId_withJoint", newConnection))
            {
                mySQLAdapter.SelectCommand.Parameters.AddWithValue("@DCNumber", DCNumber);
                mySQLAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet myDataSet = new DataSet();
                mySQLAdapter.Fill(myDataSet);
                return myDataSet;
            }
        }

    }

    public class Dash_Tablewise_PerforVBO
    {
        public string  msg { get; set; }
        public List<DCBundleDet> tabdet { get; set; }
    }

    public class DCBundleDet
    {
        public string DCNumber  { get; set; }
        public string BundleBarcode  { get; set; }
        public string Date   { get; set; }
        public string Time { get; set; }
        public decimal Qty   { get; set; }
        public string LineNum  { get; set; }
    }



    }
