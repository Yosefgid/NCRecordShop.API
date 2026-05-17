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
            throw new NotImplementedException();
        }
        [HttpPost]
        public IActionResult AddAlbum(Album album)
        {
            throw new NotImplementedException();
        }
        [HttpPut("{id}")]
        public IActionResult UpdateAlbum(int id, Album album)
        {
            throw new NotImplementedException();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteAlbum(int id)
        {
            throw new NotImplementedException();
        }
    }
}
