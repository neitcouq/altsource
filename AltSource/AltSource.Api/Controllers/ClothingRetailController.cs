using AltSource.Domain;
using AltSource.Domain.Service;
using AltSource.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AltSource.Api.Controllers
{
    [Route("api/[controller]")]
    public class ClothingRetailController : ControllerBase
    {
        private readonly ClothingRetailService<ClothingRetailViewModel, ClothingRetail> _clothingRetailService;
        public ClothingRetailController(ClothingRetailService<ClothingRetailViewModel, ClothingRetail> clothingRetailService)
        {
            _clothingRetailService = clothingRetailService;
        }

        //add
        [HttpPut]
        public IActionResult Create([FromBody] ClothingRetailViewModel clothingRetail)
        {
            if (clothingRetail == null)
                return BadRequest();

            var id = _clothingRetailService.Add(clothingRetail);
            return Created($"api/ClotingRetail/{id}", id);  //HTTP201 Resource created
        }

        [HttpGet]
        public IEnumerable<ClothingRetailViewModel> GetAll()
        {
            //Log.Information("Log: Log.Information");
            //Log.Warning("Log: Log.Warning");
            //Log.Error("Log: Log.Error");
            //Log.Fatal("Log: Log.Fatal");
            var items = _clothingRetailService.GetAll();
            return items;
        }
    }
}
