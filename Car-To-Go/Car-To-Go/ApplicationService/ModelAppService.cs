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
    public class ModelAppService
    {
        private readonly CarToGoDataContext _dataBase;
        private readonly ModelDomainService _modelDomainService;

        public ModelAppService(CarToGoDataContext _context, ModelDomainService modelDomainService)
        {
            _dataBase = _context;
            _modelDomainService = modelDomainService;
        }

        private async Task<Purchase> DBCall(Model model)
        {
            Brand brand = await _dataBase.Brands.FirstOrDefaultAsync(q => q.Id == model.BrandId);

            var purchase = new Purchase(model, brand);
            return purchase;
        }

        public async Task<String> GetModelApplicationService(int id)
        {
            var model = await _dataBase.Models.Include(q => q.Brand).FirstOrDefaultAsync(q => q.Id == id);

            var responseDomainService = _modelDomainService.GetModelDomainService(id, model);

            bool errorInTheDomainService = responseDomainService != null;
            if (errorInTheDomainService)
            {
                return responseDomainService;
            }
            return null;
        }

        public async Task<String> PostModelApplicationService(Model model)
        {
            Purchase purchase = await DBCall(model);

            var responseDomainService = _modelDomainService.PostModelDomainService(purchase);

            bool errorInTheDomainService = responseDomainService != null;
            if (errorInTheDomainService)
            {
                return responseDomainService;
            }
            _dataBase.Models.Add(model);
            await _dataBase.SaveChangesAsync();

            return null;
        }

        public async Task<String> PutModelApplicationService(int id, Model model)
        {
            Purchase purchase= await DBCall(model);

            var responseDomainService = _modelDomainService.PutModelDomainService(id, purchase);

            bool errorInTheDomainService = responseDomainService != null;
            if (errorInTheDomainService)
            {
                return responseDomainService;
            }

            _dataBase.Entry(model).State = EntityState.Modified;
            await _dataBase.SaveChangesAsync();

            return null;
        }

        public async Task<String> DeleteModelApplicationService(int id)
        {
            var model = await _dataBase.Models.FindAsync(id);
            var responseDomainService = _modelDomainService.DeleteModelDomainService(id, model);

            bool errorInTheDomainService = responseDomainService != null;
            if (errorInTheDomainService)
            {
                return responseDomainService;
            }

            _dataBase.Models.Remove(model);
            await _dataBase.SaveChangesAsync();

            return null;
        }

    }
}
