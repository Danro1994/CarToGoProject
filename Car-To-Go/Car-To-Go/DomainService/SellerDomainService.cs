using Car_To_Go.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_To_Go.DomainService
{
    public class SellerDomainService
    {
        public string GetSellerDomainService(int id, Seller seller)
        {
            if (seller == null)
            {
                return "No se encontro el Vendedor";
            }

            return null;
        }

        public string PostSellerDomainService(Seller seller)
        {
            return null;
        }

        public string PutSellerDomainService(int id, Seller seller)
        {
            if (seller == null)
            {
                return "No se encontro el Vendedor";
            }

            return null;
        }

        public string DeleteSellerDomainService(int id, Seller seller)
        {
            if (seller == null)
            {
                return "No se encontro el Vendedor";
            }

            return null;
        }
    }
}
