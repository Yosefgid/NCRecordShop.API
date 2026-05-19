using NCRecordShop.Models;
namespace NCRecordShop.Data
{
    public class SeedData
    {
        public static void Initialize(AppDbContext context)
        {
            //skip if data is already exists
            if (context.Albums.Any()) return;
            context.Albums.AddRange(
            new Album
            {
                Title = "Thriller",
                Artist = "Michael Jackson",
                ReleaseYear = 1982,
                Genre = Genre.Pop,
                Quantity = 15,
                DateAdded = DateTime.UtcNow
            },
            new Album
            {
                Title = "Abbey Road",
                Artist = "The Beatles",
                ReleaseYear = 1969,
                Genre = Genre.Rock,
                Quantity = 8,
                DateAdded = DateTime.UtcNow
            },
            new Album
            {
                Id = 4,
                Title = "Purple Rain",
                Artist = "Prince & The Revolution",
                ReleaseYear = 1984,
                Genre = Genre.Rock,
                Quantity = 7,
                DateAdded = DateTime.UtcNow
            },
            new Album
            {
                Id = 5,
                Title = "Blonde",
                Artist = "Frank Ocean",
                ReleaseYear = 2016,
                Genre = Genre.Soul,
                Quantity = 12,
                DateAdded = DateTime.UtcNow
            });
            context.SaveChanges();
        }
    }
}
