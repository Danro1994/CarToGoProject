using Car_To_Go.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_To_Go.DomainService
{
    public class StatusDomainService
    {
        public string GetStatusDomainService(int id, Status status)
        {
            if (status == null)
            {
                return "No se encontro este Estado";
            }

            return null;
        }

        public string PostStatusDomainService(Status status)
        {
            return null;
        }

        public string PutStatusDomainService(int id, Status status)
        {
            if (status == null)
            {
                return "No se encontro este Estado";
            }

            return null;
        }

        public string DeleteStatusDomainService(int id, Status status)
        {
            if (status == null)
            {
                return "No se encontro este Estado";
            }

            return null;
        }
    }
}
