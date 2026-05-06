using NCRecordShop.Data;
using NCRecordShop.Models;

namespace NCRecordShop.Repositories
{
    public class AlbumRepository : IAlbumRepository
    {
        public readonly AppDbContext _context;
        public AlbumRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Album> GetAllAlbums()
        {
            return _context.Albums.ToList();
        }
        public  Album GetAlbumById(int id)
        {
            throw new NotImplementedException();
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
