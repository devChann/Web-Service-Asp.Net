using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using oakarsvsalesWebservice.Interafce;

namespace oakarsvsalesWebservice.Controllers
{
    [Produces("application/json")]
    [Route("api/oslsaleswebservice")]
    public class oslsaleswebserviceController : Controller
    {
        private readonly Ioslsaleswebservice _ioslsaleswebservice;
        public oslsaleswebserviceController(Ioslsaleswebservice ioslsaleswebservice)
        {
            _ioslsaleswebservice = ioslsaleswebservice;
        }

        [HttpGet]
        [Route("sales")]
        public IActionResult List()
        {
            return Ok(_ioslsaleswebservice.GetSalesData());
        }
    }
}