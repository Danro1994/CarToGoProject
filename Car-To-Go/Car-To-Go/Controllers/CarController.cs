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
    public class CarController:ControllerBase
    {
        private readonly CarToGoDataContext _dataBase;
        private readonly CarAppService _carAppService;

        public CarController(CarToGoDataContext _context, CarAppService carAppService)
        {
            _dataBase = _context;
            _carAppService = carAppService;

            if (_dataBase.Cars.Count() == 0)
            {
                _dataBase.Cars.Add(new Car { ModelId = 1, PhotoId = 1, Year = 2014, Color = "Black", StatusId = 1, SellerId = 1, ConditionId = 1 });
                _dataBase.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<List<Car>>> GetCars()
        {
            return await _dataBase.Cars.Include(q => q.Model).Include(q => q.Photo).Include(q => q.Status).Include(q => q.Seller).Include(q => q.Condition).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Car>> GetCompra(int id)
        {
            var responseCarAppService = await _carAppService.GetCarApplicationService(id);

            bool noErrorsInValidations = responseCarAppService == null;
            if (noErrorsInValidations)
            {
                return await _dataBase.Cars.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(responseCarAppService);
        }

        [HttpPost]
        public async Task<ActionResult<Car>> PostCar(Car car)
        {
            var responseCarAppService = await _carAppService.PostCarApplicationService(car);

            bool noErrorsInValidations = responseCarAppService == null;
            if (noErrorsInValidations)
            {
                return await _dataBase.Cars.FirstOrDefaultAsync(q => q.Id == car.Id);
            }
            return BadRequest(responseCarAppService);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCar(int id, Car car)
        {
            var responseCarAppService = await _carAppService.PutCarApplicationService(id, car);

            bool noErrorsInValidations = responseCarAppService == null;
            if (noErrorsInValidations)
            {
                return NoContent();
            }
            return BadRequest(responseCarAppService);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletCompra(int id)
        {
            var responseCarAppService = await _carAppService.DeleteCarApplicationService(id);

            bool noErrorsInValidations = responseCarAppService == null;
            if (noErrorsInValidations)
            {
                return NoContent();
            }
            return BadRequest(responseCarAppService);
        }

    }
}
