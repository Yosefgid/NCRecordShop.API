using Microsoft.EntityFrameworkCore;
using NCRecordShop.Data;
using NCRecordShop.Models;
using NCRecordShop.Repositories;
namespace NCRecordShop.Services
{
    public class AlbumServices : IAlbumServices

    {
        private readonly IAlbumRepository _repository;
        public AlbumServices(IAlbumRepository repository)
        {
            _repository = repository;
        }

        public List<Album> GetAllAlbums()
        {
            return _repository.GetAllAlbums();
        }
        public Album GetAlbumById(int id)
        {
            return _repository.GetAlbumById(id);
        }
        public Album AddAlbum(Album album)
        {
            return _repository.AddAlbum(album);
        }
        public Album UpdateAlbum(int id, Album album)
        {
            return _repository.UpdateAlbum(id, album);
        }
        public bool DeleteAlbum(int id)
        {
            return _repository.DeleteAlbum(id);
        }
    }
}
