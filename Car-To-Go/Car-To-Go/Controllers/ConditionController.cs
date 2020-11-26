using Car_To_Go.Models;
using Car_To_Go.DataContext;
using Car_To_Go.ApplicationService;
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
    public class ConditionController : ControllerBase
    {
        private readonly CarToGoDataContext _baseDatos;
        private readonly ConditionAppService _conditionAppService;

        public ConditionController(CarToGoDataContext _context, ConditionAppService ConditionAppService)
        {
            _baseDatos = _context;
            _conditionAppService = ConditionAppService;

            if (_baseDatos.Conditions.Count() == 0)
            {
                _baseDatos.Conditions.Add(new Condition { Name = "Usado" });
                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Condition>>> GetConditions()
        {
            return await _baseDatos.Conditions.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Condition>> GetCondition(int id)
        {
            var respuestaConditionAppService = await _conditionAppService.GetConditionApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaConditionAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.Conditions.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaConditionAppService);

        }

        [HttpPost]
        public async Task<ActionResult<Condition>> PostCondition(Condition Condition)
        {
            var respuestaConditionAppService = await _conditionAppService.PostConditionApplicationService(Condition);

            bool noHayErroresEnLasValidaciones = respuestaConditionAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetCondition), new { id = Condition.Id }, Condition);
            }
            return BadRequest(respuestaConditionAppService);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCondition(int id, Condition Condition)
        {
            var respuestaConditionAppService = await _conditionAppService.PutConditionApplicationService(id, Condition);

            bool noHayErroresEnLasValidaciones = respuestaConditionAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaConditionAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConditions(int id)
        {
            var respuestaConditionAppService = await _conditionAppService.DeleteConditionsApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaConditionAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaConditionAppService);
        }
    }
    
}
