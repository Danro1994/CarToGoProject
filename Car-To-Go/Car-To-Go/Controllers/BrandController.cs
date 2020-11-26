using Car_To_Go.Models;
using Car_To_Go.DataContext;
using Car_To_Go.ApplicationService;
using Car_To_Go.DomainService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Car_To_Go.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class BrandController:ControllerBase
    {
        private readonly CarToGoDataContext _baseDatos;
        private readonly BrandAppService _brandAppService;

        public BrandController(CarToGoDataContext _context, BrandAppService BrandAppService)
        {
            _baseDatos = _context;
            _brandAppService = BrandAppService;

            if (_baseDatos.Brands.Count() == 0)
            {
                _baseDatos.Brands.Add(new Brand { Name = "Hyundai" });
                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Brand>>> GetBrands()
        {
            return await _baseDatos.Brands.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Brand>> GetBrand(int id)
        {
            var respuestaBrandAppService = await _brandAppService.GetBrandApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaBrandAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.Brands.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaBrandAppService);

        }

        [HttpPost]
        public async Task<ActionResult<Brand>> PostBrand(Brand Brand)
        {
            var respuestaBrandAppService = await _brandAppService.PostBrandApplicationService(Brand);

            bool noHayErroresEnLasValidaciones = respuestaBrandAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetBrand), new { id = Brand.Id }, Brand);
            }
            return BadRequest(respuestaBrandAppService);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutBrand(int id, Brand Brand)
        {
            var respuestaBrandAppService = await _brandAppService.PutBrandApplicationService(id, Brand);

            bool noHayErroresEnLasValidaciones = respuestaBrandAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaBrandAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrands(int id)
        {
            var respuestaBrandAppService = await _brandAppService.DeleteBrandsApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaBrandAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaBrandAppService);
        }


    }
}
