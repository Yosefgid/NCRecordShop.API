using Microsoft.EntityFrameworkCore;
using NCRecordShop.Models;

namespace NCRecordShop.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Album> Albums { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {//Since genre is an enum with num values 
            //if this is not used it will put the nums in the database as opposed to the string
            modelBuilder.Entity<Album>(entity =>
            {
                entity.Property(album => album.Genre).HasConversion<string>();
            });
        }
    }
}
