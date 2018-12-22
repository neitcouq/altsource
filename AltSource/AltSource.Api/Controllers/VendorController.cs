using AltSource.Domain;
using AltSource.Domain.Service;
using AltSource.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AltSource.Api.Controllers
{
    [Route("api/[controller]")]
    public class VendorController : ControllerBase
    {
        private readonly VendorService<VendorViewModel, Vendor> _vendorService;
        public VendorController(VendorService<VendorViewModel, Vendor> vendorService)
        {
            _vendorService = vendorService;
        }

        //add
        [HttpPut]
        public IActionResult Create([FromBody] VendorViewModel vendor)
        {
            if (vendor == null)
                return BadRequest();

            var id = _vendorService.Add(vendor);
            return Created($"api/Vendor/{id}", id);  //HTTP201 Resource created
        }

        [HttpGet]
        public IEnumerable<VendorViewModel> GetAll()
        {
            //Log.Information("Log: Log.Information");
            //Log.Warning("Log: Log.Warning");
            //Log.Error("Log: Log.Error");
            //Log.Fatal("Log: Log.Fatal");
            var items = _vendorService.GetAll();
            return items;
        }
    }
}
