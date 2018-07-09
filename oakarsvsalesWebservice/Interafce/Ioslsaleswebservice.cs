using oakarsvsalesWebservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeoJSON.Net.Feature;

namespace oakarsvsalesWebservice.Interafce
{
   public  interface Ioslsaleswebservice
    {
        IEnumerable <So011t> FetchSales();

        FeatureCollection GetSalesData();

    }
}
