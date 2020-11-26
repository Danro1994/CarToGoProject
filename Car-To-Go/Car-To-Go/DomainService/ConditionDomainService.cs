using Car_To_Go.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_To_Go.DomainService
{
    public class ConditionDomainService
    {
        public string GetConditionDomainService(int id, Condition condition)
        {
            if (condition == null)
            {
                return "No se encontro la Condicion";
            }

            return null;
        }

        public string PostConditionDomainService(Condition condition)
        {
            return null;
        }

        public string PutConditionDomainService(int id, Condition condition)
        {
            if (condition == null)
            {
                return "No se encontro la Condicion";
            }

            return null;
        }

        public string DeleteConditionDomainService(int id, Condition condition)
        {
            if (condition == null)
            {
                return "No se encontro la Condicion";
            }

            return null;
        }
    }
}
