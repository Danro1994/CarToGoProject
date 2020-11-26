using Car_To_Go.ApplicationService;
using Car_To_Go.DataContext;
using Car_To_Go.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_To_Go.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ModelController:ControllerBase
    {
        private readonly CarToGoDataContext _dataBase;
        private readonly ModelAppService _modelAppService;

        public ModelController(CarToGoDataContext _context, ModelAppService modelAppService)
        {
            _dataBase = _context;
            _modelAppService = modelAppService;


            if (_dataBase.Models.Count() == 0)
            {
                _dataBase.Models.Add(new Model { Name = "Creta", BrandId = 1});
                _dataBase.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<List<Model>>> GetModels()
        {
            return await _dataBase.Models.Include(q => q.Brand).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Model>> GetModel(int id)
        {
            var responseModelAppService = await _modelAppService.GetModelApplicationService(id);

            bool noErrorsOnTheValidations = responseModelAppService == null;
            if (noErrorsOnTheValidations)
            {
                return await _dataBase.Models.Include(q => q.Brand).FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(responseModelAppService);
        }

        [HttpPost]
        public async Task<ActionResult<Model>> PostEvento(Model model)
        {
            var responseModelAppService = await _modelAppService.PostModelApplicationService(model);

            bool noErrorsOnTheValidations = responseModelAppService == null;
            if (noErrorsOnTheValidations)
            {
                return CreatedAtAction(nameof(GetModel), new { id = model.Id }, model);
            }
            return BadRequest(responseModelAppService);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutModel(int id, Model model)
        {
            var responseModelAppService = await _modelAppService.PutModelApplicationService(id, model);

            bool noErrorsOnTheValidations = responseModelAppService == null;
            if (noErrorsOnTheValidations)
            {
                return NoContent();
            }
            return BadRequest(responseModelAppService);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletEvento(int id)
        {
            var responseModelAppService = await _modelAppService.DeleteModelApplicationService(id);

            bool noErrorsOnTheValidations = responseModelAppService == null;
            if (noErrorsOnTheValidations)
            {
                return NoContent();
            }
            return BadRequest(responseModelAppService);
        }
    }
}
