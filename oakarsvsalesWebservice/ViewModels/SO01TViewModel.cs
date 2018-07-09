using BAMCIS.GeoJSON;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Spatial;
using System.Threading.Tasks;


namespace oakarsvsalesWebservice.ViewModels
{
    public class SO01TViewModel
    {
        public string Wkt { get; set; }
        public long Ordid { get; set; }
        public int? Orderid { get; set; }
        public DateTime? Orderdate { get; set; }
        public string Ponum { get; set; }
        public int? Orgid { get; set; }
        public string Orgn { get; set; }
        public string Client { get; set; }
        public string ProductId { get; set; }
        public string Supplierproductid { get; set; }
        public int? ProductCateg { get; set; }
        public string ProductGroup { get; set; }
        public string ProductName { get; set; }
        public string OrderItem { get; set; }
        public string Version { get; set; }
        public string AddlDesc { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public decimal? Tax { get; set; }
        public string Currency { get; set; }
        public string Invoiced { get; set; }
        public string InvoiceNo { get; set; }
        public string Dnote { get; set; }
        public string Description { get; set; }
        public decimal? Xrate { get; set; }
        public int? Type { get; set; }
        public string Comments { get; set; }
        public string Invoice { get; set; }
        public string AcMgr { get; set; }
        public string Orderby { get; set; }
        public int? Ordercode { get; set; }
        public string OrderType { get; set; }
        public string QuoteNo { get; set; }
        public DateTime Quotedate { get; set; }
        public string SoldBy { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createddate { get; set; }
        public string Modby { get; set; }
        public DateTime? Moddate { get; set; }
        public int Id1 { get; set; }
        public string Country { get; set; }
    }
}
