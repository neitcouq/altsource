using AltSource.Domain;
using AltSource.Domain.Service;
using AltSource.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AltSource.Api.Controllers
{
    [Route("api/[controller]")]
    public class ClothingVendorController : ControllerBase
    {
        private readonly ClothingVendorService<ClothingVendorViewModel, ClothingVendor> _clothingVendorService;
        public ClothingVendorController(ClothingVendorService<ClothingVendorViewModel, ClothingVendor> clothingVendorService)
        {
            _clothingVendorService = clothingVendorService;
        }

        //add
        [HttpPut]
        public IActionResult Create([FromBody] ClothingVendorViewModel clothingVendor)
        {
            if (clothingVendor == null)
                return BadRequest();

            var id = _clothingVendorService.Add(clothingVendor);
            return Created($"api/ClotingVendor/{id}", id);  //HTTP201 Resource created
        }

        [HttpGet]
        public IEnumerable<ClothingVendorViewModel> GetAll()
        {
            //Log.Information("Log: Log.Information");
            //Log.Warning("Log: Log.Warning");
            //Log.Error("Log: Log.Error");
            //Log.Fatal("Log: Log.Fatal");
            var items = _clothingVendorService.GetAll();
            return items;
        }
    }
}
