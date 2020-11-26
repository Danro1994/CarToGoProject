using Car_To_Go.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_To_Go.DomainService
{
    public class PhotoDomainService
    {
        public string GetPhotoDomainService(int id, Photo photo)
        {
            if (photo == null)
            {
                return "No se encontraron las Fotografias";
            }

            return null;
        }

        public string PostPhotoDomainService(Photo photo)
        {
            return null;
        }

        public string PutPhotoDomainService(int id, Photo photo)
        {
            if (photo == null)
            {
                return "No se encontraron las Fotografias";
            }

            return null;
        }

        public string DeletePhotoDomainService(int id, Photo photo)
        {
            if (photo == null)
            {
                return "No se encontraron las Fotografias";
            }

            return null;
        }
    }
}
