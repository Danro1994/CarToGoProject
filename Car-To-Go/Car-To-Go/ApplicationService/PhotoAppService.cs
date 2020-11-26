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
    public class PhotoAppService
    {
        private readonly CarToGoDataContext _baseDatos;
        private readonly PhotoDomainService _photoDomainService;

        public PhotoAppService(CarToGoDataContext _context, PhotoDomainService photoDomainService)
        {
            _baseDatos = _context;
            _photoDomainService = photoDomainService;
        }

        public async Task<String> GetPhotoApplicationService(int id)
        {
            var photo = await _baseDatos.Photos.FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _photoDomainService.GetPhotoDomainService(id, photo);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }
        public async Task<String> PostPhotoApplicationService(Photo photo)
        {

            var respuestaDomainService = _photoDomainService.PostPhotoDomainService(photo);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Photos.Add(photo);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
        public async Task<String> PutPhotoApplicationService(int id, Photo photo)
        {
            var respuestaDomainService = _photoDomainService.PutPhotoDomainService(id, photo);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(photo).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();

            return null;
        }
        public async Task<String> DeletePhotosApplicationService(int id)
        {
            var photo = await _baseDatos.Photos.FindAsync(id);
            var respuestaDomainService = _photoDomainService.DeletePhotoDomainService(id, photo);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Photos.Remove(photo);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
    }
}
