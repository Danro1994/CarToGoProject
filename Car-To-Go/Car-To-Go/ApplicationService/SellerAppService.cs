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
    public class SellerAppService
    {
        private readonly CarToGoDataContext _baseDatos;
        private readonly SellerDomainService _sellerDomainService;

        public SellerAppService(CarToGoDataContext _context, SellerDomainService sellerDomainService)
        {
            _baseDatos = _context;
            _sellerDomainService = sellerDomainService;
        }

        public async Task<String> GetSellerApplicationService(int id)
        {
            var seller = await _baseDatos.Sellers.FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _sellerDomainService.GetSellerDomainService(id, seller);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }
        public async Task<String> PostSellerApplicationService(Seller seller)
        {

            var respuestaDomainService = _sellerDomainService.PostSellerDomainService(seller);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Sellers.Add(seller);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
        public async Task<String> PutSellerApplicationService(int id, Seller seller)
        {
            var respuestaDomainService = _sellerDomainService.PutSellerDomainService(id, seller);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(seller).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();

            return null;
        }
        public async Task<String> DeleteSellersApplicationService(int id)
        {
            var seller = await _baseDatos.Sellers.FindAsync(id);
            var respuestaDomainService = _sellerDomainService.DeleteSellerDomainService(id, seller);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Sellers.Remove(seller);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
    }
}
