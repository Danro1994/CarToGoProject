using Car_To_Go.Models;
using Car_To_Go.DataContext;
using Car_To_Go.DomainService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Car_To_Go.ApplicationService
{
    public class BrandAppService
    {
        private readonly CarToGoDataContext _baseDatos;
        private readonly BrandDomainService _brandDomainService;

        public BrandAppService(CarToGoDataContext _context, BrandDomainService brandDomainService)
        {
            _baseDatos = _context;
            _brandDomainService = brandDomainService;
        }

        public async Task<String> GetBrandApplicationService(int id)
        {
            var brand = await _baseDatos.Brands.FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _brandDomainService.GetBrandDomainService(id, brand);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }
        public async Task<String> PostBrandApplicationService(Brand brand)
        {

            var respuestaDomainService = _brandDomainService.PostBrandDomainService(brand);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Brands.Add(brand);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
        public async Task<String> PutBrandApplicationService(int id, Brand brand)
        {
            var respuestaDomainService = _brandDomainService.PutBrandDomainService(id, brand);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(brand).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();

            return null;
        }
        public async Task<String> DeleteBrandsApplicationService(int id)
        {
            var brand = await _baseDatos.Brands.FindAsync(id);
            var respuestaDomainService = _brandDomainService.DeleteBrandDomainService(id, brand);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Brands.Remove(brand);
            await _baseDatos.SaveChangesAsync();

            return null;
        }

    }
}
