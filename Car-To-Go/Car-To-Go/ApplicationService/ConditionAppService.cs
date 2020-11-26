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
    public class ConditionAppService
    {
        private readonly CarToGoDataContext _baseDatos;
        private readonly ConditionDomainService _conditionDomainService;

        public ConditionAppService(CarToGoDataContext _context, ConditionDomainService conditionDomainService)
        {
            _baseDatos = _context;
            _conditionDomainService = conditionDomainService;
        }

        public async Task<String> GetConditionApplicationService(int id)
        {
            var condition = await _baseDatos.Conditions.FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _conditionDomainService.GetConditionDomainService(id, condition);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }
        public async Task<String> PostConditionApplicationService(Condition condition)
        {

            var respuestaDomainService = _conditionDomainService.PostConditionDomainService(condition);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Conditions.Add(condition);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
        public async Task<String> PutConditionApplicationService(int id, Condition condition)
        {
            var respuestaDomainService = _conditionDomainService.PutConditionDomainService(id, condition);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(condition).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();

            return null;
        }
        public async Task<String> DeleteConditionsApplicationService(int id)
        {
            var condition = await _baseDatos.Conditions.FindAsync(id);
            var respuestaDomainService = _conditionDomainService.DeleteConditionDomainService(id, condition);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Conditions.Remove(condition);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
    }
}
