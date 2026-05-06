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
            return _context.Albums.FirstOrDefault(a => a.Id == id);
        }
        public Album AddAlbum(Album album)
        {
            _context.Albums.Add(album);
            _context.SaveChanges();
            return album;
        }
        public Album UpdateAlbum(int id, Album album)
        {
            var currAlbum = GetAlbumById(id);
            album.Id = currAlbum.Id;
            _context.Entry(currAlbum).CurrentValues.SetValues(album);
            _context.SaveChanges();
            return currAlbum;
        }
       public bool DeleteAlbum(int id)
        {
            var currAlbum = GetAlbumById(id);
            _context.Albums.Remove(currAlbum);
            return true;
        }
    }
}
