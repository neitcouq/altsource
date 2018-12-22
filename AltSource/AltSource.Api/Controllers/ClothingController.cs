using AltSource.Domain;
using AltSource.Domain.Service;
using AltSource.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AltSource.Api.Controllers
{
    [Route("api/[controller]")]
    public class ClothingController: ControllerBase
    {
        private readonly ClothingService<ClothingViewModel, Clothing> _clothingService;
        public ClothingController(ClothingService<ClothingViewModel, Clothing> clothingService)
        {
            _clothingService = clothingService;
        }
        //add
        [HttpPut]
        public IActionResult Create([FromBody] ClothingViewModel clothing)
        {
            if (clothing == null)
                return BadRequest();

            var id = _clothingService.Add(clothing);
            return Created($"api/Clothing/{id}", id);  //HTTP201 Resource created
        }

        [HttpGet]
        public IEnumerable<ClothingViewModel> GetAll()
        {
            //Log.Information("Log: Log.Information");
            //Log.Warning("Log: Log.Warning");
            //Log.Error("Log: Log.Error");
            //Log.Fatal("Log: Log.Fatal");
            var items = _clothingService.GetAll();
            return items;
        }
    }
}
