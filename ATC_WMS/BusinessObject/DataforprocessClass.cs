using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATC_WMS.BusinessObject
{
   public  class DataforprocessClass
    {
      
    }
    public class AutoGetBatch
    {
        public string Code { get; set; }
        public List<AutoGetBatch> AutoGetBatchList { get; set; }
    }

    
    public class AutoMRPPrint
    {
        public string OrderType { get; set; }
        public string SAPDocNumbers { get; set; }
        public string TrolleyCode { get; set; }
        public int TrolleyId { get; set; }
        public int DCId { get; set; }
        public int OrderDetId { get; set; }
        public int DCDetId { get; set; }
        public string SAPDocNum { get; set; }
        public int SAPDCId { get; set; }
        public string cardcode { get; set; }
        public string DCMonth { get; set; }
        public string DCYear { get; set; }
        public DateTime SAPDCPostDate { get; set; }
        public string DocNum { get; set; }
        public int DocEntry { get; set; }
        public string ShipToCode { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Price { get; set; }
        public string CardName { get; set; }
        public string color { get; set; }
        public string colorcode { get; set; }
        public string PartyType { get; set; }
        public string U_State { get; set; }
        public string Style { get; set; }
        public string U_SalPriceCode { get; set; }
        public string treetype { get; set; }
        public string Symbol { get; set; }
        public int ItemId { get; set; }
        public string U_SRCode { get; set; }
        public string QULT { get; set; }
        public string Content { get; set; }
        public string TotalMRP { get; set; }
        public string SetMRP { get; set; }
        public string BomMRP { get; set; }
        public int Char1_ASCII { get; set; }
        public int Char2_ASCII { get; set; }
        public int Char3_ASCII { get; set; }
        public int Char1_Unicode { get; set; }
        public int Char2_Unicode { get; set; }
        public int Char3_Unicode { get; set; }
        public string Sizes { get; set; }
        public string Size { get; set; }
        public int boxQuantity { get; set; }
        public int LineNum { get; set; }
        public int quantity { get; set; }
        public string HankieDoubleMRPs { get; set; }
        public string Hankieqty { get; set; }
        public string Remark { get; set; }
        public int PurPackUn { get; set; }
        public int Pack_Qty { get; set; }
        public int Packstatus { get; set; }
        public int MinPack_Qty { get; set; }
        public string SAPDocNumP { get; set; }
        public int LabelTypeId { get; set; }
        public string LableTypeName { get; set; }
        public string PrinterName { get; set; }
        public int LabelTypeId1 { get; set; }
        public string LableTypeName1 { get; set; }
        public string PrinterName1 { get; set; }
        public string SizeRemark { get; set; }
        public List<AutoMRPPrint> AutoMRPPrintList { get; set; }
    }
    public class SaveResult
    {
        public string Msg { get; set; }

    }

}
public class TableMasters
{
    public int TabId { get; set; }
    public string TableCode { get; set; }
    public string ProcessName { get; set; }
    public int TeamId { get; set; }
    public int StatusId { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public string ModifiedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
}
