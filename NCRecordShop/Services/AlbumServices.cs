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
            throw new NotImplementedException();
        }
        public Album UpdateAlbum(int id, Album album)
        {
            throw new NotImplementedException();
        }
        public bool DeleteAlbum(int id)
        {
            throw new NotImplementedException();
        }
    }
}
