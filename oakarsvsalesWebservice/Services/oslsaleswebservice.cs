using GeoJSON.Net.Feature;
using Microsoft.EntityFrameworkCore;
using oakarsvsalesWebservice.Data;
using oakarsvsalesWebservice.Interafce;
using oakarsvsalesWebservice.Models;
using oakarsvsalesWebservice.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeoJSON.Net.Geometry;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace oakarsvsalesWebservice.Services
{
    public class oslsaleswebservice:Ioslsaleswebservice
    {
        private readonly OAKARDBContext _context;
        public oslsaleswebservice(OAKARDBContext context)
        {
            _context = context;
        }
        public IEnumerable <So011t> FetchSales()
        {
            var sales = _context.So011t
                    .FromSql("EXECUTE sp_SalesData")
                    .ToList();
            


            return sales;
        }

        public FeatureCollection GetSalesData()
        {
            var model = new FeatureCollection() { CRS = new GeoJSON.Net.CoordinateReferenceSystem.NamedCRS("urn:ogc:def:crs:OGC::CRS84") };
            var sales = _context.So011t
                    .FromSql("EXECUTE sp_SalesData")
                    .ToList();
            sales.ForEach(x =>
            {
                
                SO01TViewModel sale = new SO01TViewModel();
                sale.Client = x.Client;
                sale.AcMgr = x.AcMgr;
                sale.AddlDesc = x.AddlDesc;
                sale.Comments = x.Comments;
                sale.Country = x.Country;
                sale.Createdby = x.Createdby;
                sale.Createddate = x.Createddate;
                sale.Currency = x.Currency;
                sale.Description = x.Description;
                sale.Dnote = x.Dnote;
                sale.Invoice = x.Invoice;
                sale.Invoiced = x.Invoiced;
                sale.Modby = x.Modby;
                sale.Moddate = x.Moddate;
                sale.Orderby = x.Orderby;
                sale.Ordercode = x.Ordercode;
                sale.Orderid = x.Orderid;
                sale.Orderdate = x.Orderdate;
                sale.OrderItem = x.OrderItem;
                sale.OrderType = x.OrderItem;
                sale.OrderType = x.OrderType;
                sale.Ordid = x.Ordid;
                sale.Ponum = x.Ponum;
                sale.Price = x.Price;
                sale.ProductCateg = x.ProductCateg;
                sale.ProductGroup = x.ProductGroup;
                sale.ProductId= x.ProductId;
                sale.ProductName = x.ProductName;
                sale.Quantity = x.Quantity;
                sale.Quotedate = x.Quotedate;
                sale.QuoteNo = x.QuoteNo;
                sale.SoldBy = x.SoldBy;
                sale.Supplierproductid = x.Supplierproductid;
                sale.Tax= x.Tax;
                sale.Type = x.Type;
                sale.Version = x.Version;
                sale.Xrate = x.Xrate;
                var actualPolygon = JsonConvert.DeserializeObject<Polygon>(x.Wkt);
                var feature = new GeoJSON.Net.Feature.Feature(actualPolygon, sale);

                model.Features.Add(feature);
            });
            return model;
        }
    }
}
