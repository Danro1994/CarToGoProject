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
    public class StatusController : ControllerBase
    {
        private readonly CarToGoDataContext _baseDatos;
        private readonly StatusAppService _statusAppService;

        public StatusController(CarToGoDataContext _context, StatusAppService StatusAppService)
        {
            _baseDatos = _context;
            _statusAppService = StatusAppService;

            if (_baseDatos.Statuses.Count() == 0)
            {
                _baseDatos.Statuses.Add(new Status { Name = "Disponible" });
                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Status>>> GetStatuss()
        {
            return await _baseDatos.Statuses.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Status>> GetStatus(int id)
        {
            var respuestaStatusAppService = await _statusAppService.GetStatusApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaStatusAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.Statuses.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaStatusAppService);

        }

        [HttpPost]
        public async Task<ActionResult<Status>> PostStatus(Status Status)
        {
            var respuestaStatusAppService = await _statusAppService.PostStatusApplicationService(Status);

            bool noHayErroresEnLasValidaciones = respuestaStatusAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetStatus), new { id = Status.Id }, Status);
            }
            return BadRequest(respuestaStatusAppService);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutStatus(int id, Status Status)
        {
            var respuestaStatusAppService = await _statusAppService.PutStatusApplicationService(id, Status);

            bool noHayErroresEnLasValidaciones = respuestaStatusAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaStatusAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStatuss(int id)
        {
            var respuestaStatusAppService = await _statusAppService.DeleteStatussApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaStatusAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaStatusAppService);
        }


    }
}
