using Car_To_Go.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_To_Go.DomainService
{
    public class BrandDomainService
    {
        public string GetBrandDomainService(int id, Brand brand)
        {
            if (brand == null)
            {
                return "No se encontro la Marca";
            }

            return null;
        }

        public string PostBrandDomainService(Brand brand)
        {
            return null;
        }

        public string PutBrandDomainService(int id, Brand brand)
        {
            if (brand == null)
            {
                return "No se encontro la Marca";
            }

            return null;
        }

        public string DeleteBrandDomainService(int id, Brand brand)
        {
            if (brand == null)
            {
                return "No se encontro la Marca";
            }

            return null;
        }
    }
}
