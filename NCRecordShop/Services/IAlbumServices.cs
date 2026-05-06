using NCRecordShop.Models;

namespace NCRecordShop.Services
{

    public interface IAlbumServices
    {
        List<Album> GetAllAlbums();
        Album GetAlbumById(int id);
        Album AddAlbum(Album album);
        Album UpdateAlbum(int id, Album album);
        bool DeleteAlbum(int id);
    }
}
