using Car_To_Go.DataContext;
using Car_To_Go.DomainService;
using Car_To_Go.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_To_Go.ApplicationService
{
    public class CarAppService
    {
        private readonly CarToGoDataContext _dataBase;
        private readonly CarDomainService _carDomainService;

        public CarAppService(CarToGoDataContext _context, CarDomainService carDomainService)
        {
            _dataBase = _context;
            _carDomainService = carDomainService;
        }

        private async Task<Purchase> DBCall(Car car)
        {
            Model model = await _dataBase.Models.FirstOrDefaultAsync(q => q.Id == car.ModelId);

            Photo photo = await _dataBase.Photos.FirstOrDefaultAsync(q => q.Id == car.PhotoId);
            Status status = await _dataBase.Statuses.FirstOrDefaultAsync(q => q.Id == car.StatusId);
            Seller seller = await _dataBase.Sellers.FirstOrDefaultAsync(q => q.Id == car.SellerId);
            Condition condition = await _dataBase.Conditions.FirstOrDefaultAsync(q => q.Id == car.ConditionId);

            var reservacion = new Purchase(car, model, photo, status, seller, condition);
            return reservacion;
        }

        public async Task<String> GetCarApplicationService(int id)
        {
            var car = await _dataBase.Cars.Include(q => q.Model).Include(q => q.Photo).Include(q => q.Status).Include(q => q.Seller).Include(q => q.Condition).FirstOrDefaultAsync(q => q.Id == id);

            var responseDomainService = _carDomainService.GetCarDomainService(car);

            bool anErrorOnTheDomainService = responseDomainService != null;
            if (anErrorOnTheDomainService)
            {
                return responseDomainService;
            }
            return null;
        }

        public async Task<String> PostCarApplicationService(Car car)
        {
            Purchase purchase = await DBCall(car);

            var responseDomainService = _carDomainService.PostCarDomainService(purchase);

            bool anErrorOnTheDomainService = responseDomainService != null;
            if (anErrorOnTheDomainService)
            {
                return responseDomainService;
            }

            _dataBase.Cars.Add(car);
            await _dataBase.SaveChangesAsync();

            return null;
        }

        public async Task<String> PutCarApplicationService(int id, Car car)
        {
            Purchase purchase = await DBCall(car);

            var responseDomainService = _carDomainService.PutCarDomainService(id, purchase);

            bool anErrorOnTheDomainService = responseDomainService != null;
            if (anErrorOnTheDomainService)
            {
                return responseDomainService;
            }

            _dataBase.Entry(car).State = EntityState.Modified;
            await _dataBase.SaveChangesAsync();

            return null;
        }

        public async Task<String> DeleteCarApplicationService(int id)
        {
            var car = await _dataBase.Cars.FindAsync(id);

            var responseDomainService = _carDomainService.DeleteCarDomainService(id, car);

            bool hayErrorEnElDomainService = responseDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return responseDomainService;
            }

            _dataBase.Cars.Remove(car);
            await _dataBase.SaveChangesAsync();

            return null;
        }
    }
}
