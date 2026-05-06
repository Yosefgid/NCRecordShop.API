
using NCRecordShop.Models;

namespace NCRecordShop.Repositories
{
    public interface IAlbumRepository
    {
        List<Album> GetAllAlbums();
        Album GetAlbumById(int id);
        Album AddAlbum(Album album);
        Album UpdateAlbum(int id, Album album);
        bool DeleteAlbum(int id);
    }
}
