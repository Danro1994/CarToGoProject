using Car_To_Go.Models;
using Car_To_Go.DataContext;
using Car_To_Go.ApplicationService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Car_To_Go.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class SellerController : ControllerBase
    {
        private readonly CarToGoDataContext _baseDatos;
        private readonly SellerAppService _sellerAppService;

        public SellerController(CarToGoDataContext _context, SellerAppService SellerAppService)
        {
            _baseDatos = _context;
            _sellerAppService = SellerAppService;

            if (_baseDatos.Sellers.Count() == 0)
            {
                _baseDatos.Sellers.Add(new Seller { Name = "Daniel Rodriguez" });
                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Seller>>> GetSellers()
        {
            return await _baseDatos.Sellers.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Seller>> GetSeller(int id)
        {
            var respuestaSellerAppService = await _sellerAppService.GetSellerApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaSellerAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.Sellers.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaSellerAppService);

        }

        [HttpPost]
        public async Task<ActionResult<Seller>> PostSeller(Seller Seller)
        {
            var respuestaSellerAppService = await _sellerAppService.PostSellerApplicationService(Seller);

            bool noHayErroresEnLasValidaciones = respuestaSellerAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetSeller), new { id = Seller.Id }, Seller);
            }
            return BadRequest(respuestaSellerAppService);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutSeller(int id, Seller Seller)
        {
            var respuestaSellerAppService = await _sellerAppService.PutSellerApplicationService(id, Seller);

            bool noHayErroresEnLasValidaciones = respuestaSellerAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaSellerAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSellers(int id)
        {
            var respuestaSellerAppService = await _sellerAppService.DeleteSellersApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaSellerAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaSellerAppService);
        }


    }
}
