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
    public class StatusAppService
    {
        private readonly CarToGoDataContext _baseDatos;
        private readonly StatusDomainService _statusDomainService;

        public StatusAppService(CarToGoDataContext _context, StatusDomainService statusDomainService)
        {
            _baseDatos = _context;
            _statusDomainService = statusDomainService;
        }

        public async Task<String> GetStatusApplicationService(int id)
        {
            var status = await _baseDatos.Statuses.FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _statusDomainService.GetStatusDomainService(id, status);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }
        public async Task<String> PostStatusApplicationService(Status status)
        {

            var respuestaDomainService = _statusDomainService.PostStatusDomainService(status);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Statuses.Add(status);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
        public async Task<String> PutStatusApplicationService(int id, Status status)
        {
            var respuestaDomainService = _statusDomainService.PutStatusDomainService(id, status);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(status).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();

            return null;
        }
        public async Task<String> DeleteStatussApplicationService(int id)
        {
            var status = await _baseDatos.Statuses.FindAsync(id);
            var respuestaDomainService = _statusDomainService.DeleteStatusDomainService(id, status);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Statuses.Remove(status);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
    }
}
