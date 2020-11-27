using Car_To_Go.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_To_Go.DomainService
{
    public class ModelDomainService
    {
        public string GetModelDomainService(int id, Model model)
        {
            if (model == null)
            {
                return "No se encuentra el Modelo";
            }
            return null;
        }

        public string PostModelDomainService(Purchase purchase)
        {
            if (purchase.Brand == null)
            {
                return "No se encuentra la Marca";
            }
            return null;
        }

        public string PutModelDomainService(int id, Purchase purchase)
        {
            if (purchase.Model == null)
            {
                return "No se encuentra el Modelo";
            }
            if (purchase.Brand == null)
            {
                return "No se encuentra la Marca";
            }
            return null;
        }

        public string DeleteModelDomainService(int id, Model model)
        {
            if (model== null)
            {
                return "No se encuentra el Modelo";
            }
            return null;
        }
    }
}
