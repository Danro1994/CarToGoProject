using Car_To_Go.Models;
using Car_To_Go.DataContext;
using Car_To_Go.ApplicationService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_To_Go.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PhotoController : ControllerBase
    {
        private readonly CarToGoDataContext _baseDatos;
        private readonly PhotoAppService _photoAppService;

        public PhotoController(CarToGoDataContext _context, PhotoAppService PhotoAppService)
        {
            _baseDatos = _context;
            _photoAppService = PhotoAppService;

            if (_baseDatos.Photos.Count() == 0)
            {
                _baseDatos.Photos.Add(new Photo { Front = "Foto de Frente" });
                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Photo>>> GetPhotos()
        {
            return await _baseDatos.Photos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Photo>> GetPhoto(int id)
        {
            var respuestaPhotoAppService = await _photoAppService.GetPhotoApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaPhotoAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.Photos.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaPhotoAppService);

        }

        [HttpPost]
        public async Task<ActionResult<Photo>> PostPhoto(Photo Photo)
        {
            var respuestaPhotoAppService = await _photoAppService.PostPhotoApplicationService(Photo);

            bool noHayErroresEnLasValidaciones = respuestaPhotoAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetPhoto), new { id = Photo.Id }, Photo);
            }
            return BadRequest(respuestaPhotoAppService);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPhoto(int id, Photo Photo)
        {
            var respuestaPhotoAppService = await _photoAppService.PutPhotoApplicationService(id, Photo);

            bool noHayErroresEnLasValidaciones = respuestaPhotoAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaPhotoAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePhotos(int id)
        {
            var respuestaPhotoAppService = await _photoAppService.DeletePhotosApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaPhotoAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaPhotoAppService);
        }


    }
}
