using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using ATC_WMS.BusinessObject;
using System.Windows.Forms;

namespace ATC_WMS.DataProcess
{
    class CommonDB
    {
        public string Constring = ConfigurationManager.ConnectionStrings["ATCWMS_LIVE"].ConnectionString;
        //public Task<List<TableMasters>> GetTableMasters()
        //{
        //    try { 
        //    var taskCompletionSource = new TaskCompletionSource<List<TableMasters>>();
        //    List<TableMasters> GetTableDlt = new List<TableMasters>();
        //    string query = "SELECT * FROM TableMaster";

        //    using (var newConnection = new SqlConnection(Constring))
        //    using (var mySQLAdapter = new SqlDataAdapter(query, newConnection))
        //    {
        //        mySQLAdapter.SelectCommand.CommandType = CommandType.Text;
        //        DataSet myDataSet = new DataSet();
        //        mySQLAdapter.Fill(myDataSet);

        //        if (myDataSet.Tables[0].Rows.Count > 0)
        //        {
        //            GetTableDlt = (from DataRow dr in myDataSet.Tables[0].Rows
        //                           select new TableMasters()
        //                           {
        //                               TabId = dr["TabId"] == DBNull.Value ? 0 : Convert.ToInt32(dr["TabId"]),
        //                               TableCode = dr["TableCode"] == DBNull.Value ? null : dr["TableCode"].ToString(),
        //                               ProcessName = dr["ProcessName"] == DBNull.Value ? null : dr["ProcessName"].ToString(),
        //                               TeamId = dr["TeamId"] == DBNull.Value ? 0 : Convert.ToInt32(dr["TeamId"]),
        //                               StatusId = dr["StatusId"] == DBNull.Value ? 0 : Convert.ToInt32(dr["StatusId"]),
        //                               CreatedBy = dr["CreatedBy"] == DBNull.Value ? null : dr["CreatedBy"].ToString(),
        //                               CreatedOn = dr["CreatedOn"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr["CreatedOn"]),
        //                               ModifiedBy = dr["ModifiedBy"] == DBNull.Value ? null : dr["ModifiedBy"].ToString(),
        //                               ModifiedOn = dr["ModifiedOn"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["ModifiedOn"])


        //                           }).ToList();
        //        }

        //        taskCompletionSource.SetResult(GetTableDlt);
        //    }

        //    return taskCompletionSource.Task;
        //    }
        //    catch (Exception ex)
        //    {
        //        // Show error in a MessageBox
        //        System.Windows.Forms.MessageBox.Show("Error occurred: " + ex.Message);
        //    }
        //}
        public Task<List<TableMasters>> GetTableMasters()
        {
            var taskCompletionSource = new TaskCompletionSource<List<TableMasters>>();
            List<TableMasters> GetTableDlt = new List<TableMasters>();
            string query = "SELECT * FROM TableMaster order by TabId DESC ";

            try
            {
                using (var newConnection = new SqlConnection(Constring))
                using (var mySQLAdapter = new SqlDataAdapter(query, newConnection))
                {
                    mySQLAdapter.SelectCommand.CommandType = CommandType.Text;
                    DataSet myDataSet = new DataSet();
                    mySQLAdapter.Fill(myDataSet);

                    if (myDataSet.Tables.Count > 0 && myDataSet.Tables[0].Rows.Count > 0)
                    {
                        GetTableDlt = (from DataRow dr in myDataSet.Tables[0].Rows
                                       select new TableMasters()
                                       {
                                           TabId = dr["TabId"] == DBNull.Value ? 0 : Convert.ToInt32(dr["TabId"]),
                                           TableCode = dr["TableCode"] == DBNull.Value ? null : dr["TableCode"].ToString(),
                                           ProcessName = dr["ProcessName"] == DBNull.Value ? null : dr["ProcessName"].ToString(),
                                           TeamId = dr["TeamId"] == DBNull.Value ? 0 : Convert.ToInt32(dr["TeamId"]),
                                           StatusId = dr["StatusId"] == DBNull.Value ? 0 : Convert.ToInt32(dr["StatusId"]),
                                           CreatedBy = dr["CreatedBy"] == DBNull.Value ? null : dr["CreatedBy"].ToString(),
                                           CreatedOn = dr["CreatedOn"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(dr["CreatedOn"]),
                                           ModifiedBy = dr["ModifiedBy"] == DBNull.Value ? null : dr["ModifiedBy"].ToString(),
                                           ModifiedOn = dr["ModifiedOn"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dr["ModifiedOn"])
                                       }).ToList();
                    }

                    taskCompletionSource.SetResult(GetTableDlt);
                    newConnection.Close();
                }
            }
            catch (Exception ex)
            {
                // Show error message box
                System.Windows.Forms.MessageBox.Show("Error occurred: " + ex.Message, "Database Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                taskCompletionSource.SetResult(new List<TableMasters>()); // ensure a result is always returned
            }

           
            return taskCompletionSource.Task;
        }

        public Task<AutoMRPPrint> GetAutoMRPPrint(long SAPDocNum, string trolly, int Year)
        {
            AutoMRPPrint mk = new AutoMRPPrint();
            var taskCompletionSource = new TaskCompletionSource<AutoMRPPrint>();

            try
            {
                using (var newConnection = new SqlConnection(Constring))
                using (var mySQLAdapter = new SqlDataAdapter("AutoMRP_Print", newConnection))
                {
                    mySQLAdapter.SelectCommand.CommandTimeout =0;
                    mySQLAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    mySQLAdapter.SelectCommand.Parameters.AddWithValue("@SAPDCNum", SAPDocNum);
                    mySQLAdapter.SelectCommand.Parameters.AddWithValue("@TrolleyCode", trolly);
                    mySQLAdapter.SelectCommand.Parameters.AddWithValue("@YearId", Year);
                   


                    DataSet myDataSet = new DataSet();
                    mySQLAdapter.Fill(myDataSet);

                    mk.AutoMRPPrintList =
                        (from DataRow dr in myDataSet.Tables[0].Rows
                         select new AutoMRPPrint()
                         {
                             OrderType = dr["OrderType"].ToString(),
                             SAPDocNumbers = dr["SAPDocNumbers"].ToString(),
                             TrolleyCode = dr["TrolleyCode"].ToString(),
                             TrolleyId = Convert.ToInt32(dr["TrolleyId"]),
                             DCId = Convert.ToInt32(dr["DCId"]),
                             OrderDetId = Convert.ToInt32(dr["OrderDetId"]),
                             DCDetId = Convert.ToInt32(dr["DCDetId"]),
                             SAPDocNum = dr["SAPDocNum"].ToString(),
                             SAPDCId = Convert.ToInt32(dr["SAPDCId"]),
                             cardcode = dr["CardCode"].ToString(),
                             DCMonth = dr["DCMonth"].ToString(),
                             DCYear = dr["DCYear"].ToString(),
                             SAPDCPostDate = Convert.ToDateTime(dr["SAPDCPostDate"]),
                             DocNum = dr["DocNum"].ToString(),
                             DocEntry = Convert.ToInt32(dr["DocEntry"]),
                             ItemCode = dr["ItemCode"].ToString(),
                             ShipToCode = dr["ShipToCode"].ToString(),
                             ItemName = dr["ItemName"].ToString(),
                             Price = dr["Price"].ToString(),
                             CardName = dr["CardName"].ToString(),
                             PartyType = dr["PartyType"].ToString(),
                             U_State = dr["U_State"].ToString(),
                             U_SalPriceCode = dr["U_SalPriceCode"].ToString(),
                             treetype = dr["TreeType"].ToString(),
                             Symbol = dr["Symbol"].ToString(),
                             ItemId = Convert.ToInt32(dr["ItemId"]),
                             U_SRCode = dr["U_SRCode"].ToString(),
                             QULT = dr["QULT"].ToString(),
                             Content = dr["Content"].ToString(),
                             color = dr["color"].ToString(),
                             colorcode = dr["colorcode"].ToString(),
                             TotalMRP = dr["TotalMRP"].ToString(),
                             SetMRP = dr["SetMRP"].ToString(),
                            // BomMRP = dr["Bom_MRP"].ToString(),
                             Char1_ASCII = Convert.ToInt32(dr["Char1_ASCII"]),
                             Char2_ASCII = Convert.ToInt32(dr["Char2_ASCII"]),
                             Char3_ASCII = Convert.ToInt32(dr["Char3_ASCII"]),
                             Char1_Unicode = Convert.ToInt32(dr["Char1_Unicode"]),
                             Char2_Unicode = Convert.ToInt32(dr["Char2_Unicode"]),
                             Char3_Unicode = Convert.ToInt32(dr["Char3_Unicode"]),
                             Sizes = dr["Sizes"].ToString(),
                             Style = dr["Style"].ToString(),
                             Size = dr["Size"].ToString(),
                             boxQuantity = Convert.ToInt32(dr["BoxQuantity"]),
                             LineNum = Convert.ToInt32(dr["LineNum"]),
                             quantity = Convert.ToInt32(dr["Quantity"]),
                             HankieDoubleMRPs = dr["HankieDoubleMRPs"].ToString(),
                             Hankieqty = dr["HankieQty"].ToString(),
                             Remark = dr["Remark"].ToString(),
                             PurPackUn = Convert.ToInt32(dr["PurPackUn"]),
                             Pack_Qty = Convert.ToInt32(dr["Pack_Qty"]),
                             Packstatus = Convert.ToInt32(dr["PackStatus"]),
                             MinPack_Qty = Convert.ToInt32(dr["MinPack_Qty"]),
                             SAPDocNumP = dr["SAPDocNumP"].ToString(),
                             LabelTypeId = Convert.ToInt32(dr["LabelTypeId"]),
                             LableTypeName = dr["LableTypeName"].ToString(),
                             PrinterName = dr["PrinterName"].ToString(),
                             LabelTypeId1 = Convert.ToInt32(dr["LabelTypeId1"]),
                             LableTypeName1 = dr["LableTypeName1"].ToString(),
                             PrinterName1 = dr["PrinterName1"].ToString(),
                             SizeRemark = dr["SizeRemark"].ToString()
                         }).ToList();

                    taskCompletionSource.SetResult(mk);
                    newConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                taskCompletionSource.SetException(ex);
            }

            return taskCompletionSource.Task;
        }




        public Task<AutoMRPPrint> GetAutoMRPREPrint(long SAPDocNum, int Year)
        {
            AutoMRPPrint mk = new AutoMRPPrint();
           // var result = new List<AutoMRPPrint>();
            var taskCompletionSource = new TaskCompletionSource<AutoMRPPrint>();

            using (var newConnection = new SqlConnection(Constring))
            using (var mySQLAdapter = new SqlDataAdapter("AutoMRP_RePrint", newConnection))
            {
                mySQLAdapter.SelectCommand.CommandTimeout = 0;
                mySQLAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                mySQLAdapter.SelectCommand.Parameters.AddWithValue("@SAPDCNum", SAPDocNum);
                mySQLAdapter.SelectCommand.Parameters.AddWithValue("@YearId", Year);

                DataSet myDataSet = new DataSet();
                mySQLAdapter.Fill(myDataSet);

                mk.AutoMRPPrintList =
                        (from DataRow dr in myDataSet.Tables[0].Rows
                         select new AutoMRPPrint()
                         {
                             OrderType = dr["OrderType"].ToString(),
                             SAPDocNumbers = dr["SAPDocNumbers"].ToString(),

                             TrolleyCode = dr["TrolleyCode"].ToString(),
                             TrolleyId = Convert.ToInt32(dr["TrolleyId"]),
                             DCId = Convert.ToInt32(dr["DCId"]),
                             OrderDetId = Convert.ToInt32(dr["OrderDetId"]),
                             DCDetId = Convert.ToInt32(dr["DCDetId"]),
                             SAPDocNum = dr["SAPDocNum"].ToString(),
                             SAPDCId = Convert.ToInt32(dr["SAPDCId"]),
                             cardcode = dr["CardCode"].ToString(),
                             DCMonth = dr["DCMonth"].ToString(),
                             DCYear = dr["DCYear"].ToString(),
                             SAPDCPostDate = Convert.ToDateTime(dr["SAPDCPostDate"]),
                             DocNum = dr["DocNum"].ToString(),
                             DocEntry = Convert.ToInt32(dr["DocEntry"]),
                             ShipToCode = dr["ShipToCode"].ToString(),
                             ItemCode = dr["ItemCode"].ToString(),
                             ItemName = dr["ItemName"].ToString(),
                             Price = dr["Price"].ToString(),
                             CardName = dr["CardName"].ToString(),
                             PartyType = dr["PartyType"].ToString(),
                             U_State = dr["U_State"].ToString(),
                             U_SalPriceCode = dr["U_SalPriceCode"].ToString(),
                             treetype = dr["TreeType"].ToString(),
                             Symbol = dr["Symbol"].ToString(),
                             ItemId = Convert.ToInt32(dr["ItemId"]),
                             U_SRCode = dr["U_SRCode"].ToString(),
                             Style = dr["Style"].ToString(),
                             QULT = dr["QULT"].ToString(),
                             Content = dr["Content"].ToString(),
                             color = dr["color"].ToString(),
                             colorcode = dr["colorcode"].ToString(),
                             TotalMRP = dr["TotalMRP"].ToString(),
                             SetMRP = dr["SetMRP"].ToString(),
                             //BomMRP = dr["Bom_MRP"].ToString(),
                             //Char1_ASCII = Convert.ToInt32(dr["Char1_ASCII"]),
                             //Char2_ASCII = Convert.ToInt32(dr["Char2_ASCII"]),
                             //Char3_ASCII = Convert.ToInt32(dr["Char3_ASCII"]),
                             //Char1_Unicode = Convert.ToInt32(dr["Char1_Unicode"]),
                             //Char2_Unicode = Convert.ToInt32(dr["Char2_Unicode"]),
                             //Char3_Unicode = Convert.ToInt32(dr["Char3_Unicode"]),
                             Sizes = dr["Sizes"].ToString(),
                             Size = dr["Size"].ToString(),
                             //Colour = dr["color"].ToString(),
                             boxQuantity = Convert.ToInt32(dr["BoxQuantity"]),
                             LineNum = Convert.ToInt32(dr["LineNum"]),
                             quantity = Convert.ToInt32(dr["Quantity"]),
                             HankieDoubleMRPs = dr["HankieDoubleMRPs"].ToString(),
                             Hankieqty = dr["HankieQty"].ToString(),
                             Remark = dr["Remark"].ToString(),
                             PurPackUn = Convert.ToInt32(dr["PurPackUn"]),
                             Pack_Qty = Convert.ToInt32(dr["Pack_Qty"]),
                             Packstatus = Convert.ToInt32(dr["PackStatus"]),
                             MinPack_Qty = Convert.ToInt32(dr["MinPack_Qty"]),
                             SAPDocNumP = dr["SAPDocNumP"].ToString(),
                             LabelTypeId = Convert.ToInt32(dr["LabelTypeId"]),
                             LableTypeName = dr["LableTypeName"].ToString(),
                             PrinterName = dr["PrinterName"].ToString(),
                             LabelTypeId1 = Convert.ToInt32(dr["LabelTypeId1"]),
                             LableTypeName1 = dr["LableTypeName1"].ToString(),
                             PrinterName1 = dr["PrinterName1"].ToString(),
                             SizeRemark = dr["SizeRemark"].ToString()
                         }).ToList();

                taskCompletionSource.SetResult(mk);
                newConnection.Close();
                return taskCompletionSource.Task;
            }
        }



        /*
        public Task<AutoMRPPrint> GetAutoMRPREPrint(long SAPDocNum, int Year)
        {
            AutoMRPPrint mk = new AutoMRPPrint();
            var taskCompletionSource = new TaskCompletionSource<AutoMRPPrint>();

            using (var newConnection = new SqlConnection(Constring))
            using (var mySQLAdapter = new SqlDataAdapter(@"
            SELECT *
            FROM AutoMRP_Print_Log
            WHERE SAPDocNum = @SAPDCNum
            AND DCYear = @YearId", newConnection))
            {
                mySQLAdapter.SelectCommand.CommandType = CommandType.Text;
                mySQLAdapter.SelectCommand.Parameters.AddWithValue("@SAPDCNum", SAPDocNum);
                mySQLAdapter.SelectCommand.Parameters.AddWithValue("@YearId", Year.ToString());
                mySQLAdapter.SelectCommand.CommandTimeout = 0;

                DataSet myDataSet = new DataSet();
                mySQLAdapter.Fill(myDataSet);

                mk.AutoMRPPrintList =
                    (from DataRow dr in myDataSet.Tables[0].Rows
                     select new AutoMRPPrint()
                     {
                         TrolleyCode = dr["TrolleyCode"]?.ToString(),
                         TrolleyId = dr["TrolleyId"] == DBNull.Value ? 0 : Convert.ToInt32(dr["TrolleyId"]),
                         DCId = dr["DCId"] == DBNull.Value ? 0 : Convert.ToInt32(dr["DCId"]),
                         OrderDetId = dr["OrderDetId"] == DBNull.Value ? 0 : Convert.ToInt32(dr["OrderDetId"]),
                         DCDetId = dr["DCDetId"] == DBNull.Value ? 0 : Convert.ToInt32(dr["DCDetId"]),

                         SAPDocNum = dr["SAPDocNum"]?.ToString(),
                         SAPDCId = dr["SAPDCId"] == DBNull.Value ? 0 : Convert.ToInt32(dr["SAPDCId"]),

                         cardcode = dr["cardcode"]?.ToString(),
                         DCMonth = dr["DCMonth"]?.ToString(),
                         DCYear = dr["DCYear"]?.ToString(),

                         SAPDCPostDate = dr["SAPDCPostDate"] == DBNull.Value
                                            ? DateTime.MinValue
                                            : Convert.ToDateTime(dr["SAPDCPostDate"]),

                         DocNum = dr["DocNum"]?.ToString(),
                         DocEntry = dr["DocEntry"] == DBNull.Value ? 0 : Convert.ToInt32(dr["DocEntry"]),

                         ShipToCode = dr["ShipToCode"]?.ToString(),
                         ItemCode = dr["ItemCode"]?.ToString(),
                         ItemName = dr["ItemName"]?.ToString(),

                         //Price = string.IsNullOrWhiteSpace(dr["Price"]?.ToString())
                         //           ? 0
                         //           : Convert.ToDecimal(dr["Price"]),

                         CardName = dr["CardName"]?.ToString(),
                         PartyType = dr["Partytype"]?.ToString(),
                         U_State = dr["U_State"]?.ToString(),
                         U_SalPriceCode = dr["U_SalPriceCode"]?.ToString(),

                         treetype = dr["treetype"]?.ToString(),
                         Symbol = dr["Symbol"]?.ToString(),

                         ItemId = dr["ItemId"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ItemId"]),

                         U_SRCode = dr["U_SRCode"]?.ToString(),
                         QULT = dr["QULT"]?.ToString(),
                         Content = dr["Content"]?.ToString(),
                         TotalMRP = dr["TotalMRP"]?.ToString(),
                         SetMRP = dr["SetMRP"]?.ToString(),

                         Sizes = dr["Sizes"]?.ToString(),
                         Size = dr["Size"]?.ToString(),

                     //    Colour = dr["color"]?.ToString(),

                         boxQuantity = dr["boxQuantity"] == DBNull.Value ? 0 : Convert.ToInt32(dr["boxQuantity"]),
                         LineNum = dr["LineNum"] == DBNull.Value ? 0 : Convert.ToInt32(dr["LineNum"]),
                         quantity = dr["quantity"] == DBNull.Value ? 0 : Convert.ToInt32(dr["quantity"]),

                         HankieDoubleMRPs = dr["HankieDoubleMRPs"]?.ToString(),
                         Hankieqty = dr["Hankieqty"]?.ToString(),

                         Remark = dr["Remark"]?.ToString(),

                         PurPackUn = dr["PurPackUn"] == DBNull.Value ? 0 : Convert.ToInt32(dr["PurPackUn"]),
                         Pack_Qty = dr["Pack_Qty"] == DBNull.Value ? 0 : Convert.ToInt32(dr["Pack_Qty"]),

                         Packstatus = dr["Packstatus"] == DBNull.Value
                                        ? 0
                                        : Convert.ToBoolean(dr["Packstatus"]) ? 1 : 0,

                         MinPack_Qty = dr["MinPack_Qty"] == DBNull.Value ? 0 : Convert.ToInt32(dr["MinPack_Qty"]),

                         SAPDocNumP = dr["SAPDocNumP"]?.ToString(),

                         LabelTypeId = dr["LabelTypeId"] == DBNull.Value ? 0 : Convert.ToInt32(dr["LabelTypeId"]),
                         LableTypeName = dr["LableTypeName"]?.ToString(),
                         PrinterName = dr["PrinterName"]?.ToString(),

                         LabelTypeId1 = dr["LabelTypeId1"] == DBNull.Value ? 0 : Convert.ToInt32(dr["LabelTypeId1"]),
                         LableTypeName1 = dr["LableTypeName1"]?.ToString(),
                         PrinterName1 = dr["PrinterName1"]?.ToString(),

                         SizeRemark = dr["SizeRemark"]?.ToString()

                         // Removed because these columns do not exist
                         // u_style
                         // mrp
                         // HSYDiscountMrp
                     }).ToList();

                taskCompletionSource.SetResult(mk);
            }

            return taskCompletionSource.Task;
        }
        */


        public Task<AutoGetBatch> AutoGet_MRPBatchBatch(long BUId, long ItemId)
        {
            AutoGetBatch mk = new AutoGetBatch();
            // var result = new List<AutoMRPPrint>();
            var taskCompletionSource = new TaskCompletionSource<AutoGetBatch>();

            using (var newConnection = new SqlConnection(Constring))
            using (var mySQLAdapter = new SqlDataAdapter("AutoGet_MRPBatchBatch", newConnection))
            {
                mySQLAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                mySQLAdapter.SelectCommand.Parameters.AddWithValue("@BUId", @BUId);
                mySQLAdapter.SelectCommand.Parameters.AddWithValue("@ItemId", @ItemId);

                DataSet myDataSet = new DataSet();
                mySQLAdapter.Fill(myDataSet);

                mk.AutoGetBatchList =
                        (from DataRow dr in myDataSet.Tables[0].Rows
                         select new AutoGetBatch()
                         {
                             Code = dr["Code"].ToString(),
                             
                         }).ToList();

                taskCompletionSource.SetResult(mk);
                newConnection.Close();
                return taskCompletionSource.Task;
            }
        }
        public Task<SaveResult> AutoMRP_ItemCompleteSave(long DCId1, long ItemId, int LineNum, string xmlb)
        {
            var taskCompletionSource = new TaskCompletionSource<SaveResult>();

            try
            {
                using (var newconnection = new SqlConnection(Constring))
                using (var sqlCommand = new SqlCommand("AutoMRP_ItemCompleteSaveNew", newconnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@DCId", DCId1);
                    sqlCommand.Parameters.AddWithValue("@ItemId", ItemId);
                    sqlCommand.Parameters.AddWithValue("@LineNum", LineNum);
                    sqlCommand.Parameters.AddWithValue("@Data", xmlb);
                   
                    newconnection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);

                        // Assuming that your stored procedure returns a single row
                        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            DataRow row = ds.Tables[0].Rows[0];
                            var result = new SaveResult
                            {
                                Msg = row["msg"].ToString(),
                              
                            };
                            taskCompletionSource.SetResult(result);
                        }
                        else
                        {
                            taskCompletionSource.SetResult(null);
                        }
                    }

                    newconnection.Close();
                }
            }
            catch (Exception e)
            {
                taskCompletionSource.SetException(e);
            }

            return taskCompletionSource.Task;
        }
        public Task<SaveResult> SalesDCBundle_TableSave(int UserId, long DCNum, string TableCode)
        {
            var taskCompletionSource = new TaskCompletionSource<SaveResult>();

            try
            {
                using (var newconnection = new SqlConnection(Constring))
                using (var sqlCommand = new SqlCommand("SalesDCBundle_TableSave", newconnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@UserId", UserId);
                    sqlCommand.Parameters.AddWithValue("@DCNum", DCNum);
                    sqlCommand.Parameters.AddWithValue("@TableCode", TableCode);

                    newconnection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);

                        // Assuming that your stored procedure returns a single row
                        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            DataRow row = ds.Tables[0].Rows[0];
                            var result = new SaveResult
                            {
                                Msg = row["msg"].ToString(),

                            };
                            taskCompletionSource.SetResult(result);
                        }
                        else
                        {
                            taskCompletionSource.SetResult(null);
                        }
                    }

                    newconnection.Close();
                }
            }
            catch (Exception e)
            {
                taskCompletionSource.SetException(e);
            }

            return taskCompletionSource.Task;
        }


    }
}
