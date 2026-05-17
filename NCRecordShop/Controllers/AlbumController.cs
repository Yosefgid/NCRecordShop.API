using Microsoft.AspNetCore.Mvc;
using NCRecordShop.Models;
using NCRecordShop.Services;

namespace NCRecordShop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlbumController : ControllerBase
    {
        private readonly IAlbumServices _service;
        public AlbumController(IAlbumServices service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetAllAlbum()
        {
            var albums = _service.GetAllAlbums;
            return Ok(albums);
        }
        [HttpGet("{id}")]
        public IActionResult GetAlbumById(int id)
        {
            var albumById = _service.GetAlbumById(id);
            return Ok(albumById);
        }
        [HttpPost]
        public IActionResult AddAlbum(Album album)
        {
            var newAlbum = _service.AddAlbum(album);
            return CreatedAtAction(nameof(GetAlbumById), new { newAlbum.Id, newAlbum });
        }
        [HttpPut("{id}")]
        public IActionResult UpdateAlbum(int id, Album album)
        {
            var updateAlbum = _service.UpdateAlbum(id, album);
            return Ok(UpdateAlbum);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteAlbum(int id)
        {
            var deletedAlbum = _service.DeleteAlbum(id);
            return NoContent();
        }
    }
}
