using Microsoft.EntityFrameworkCore;
using NCRecordShop.Data;
using NCRecordShop.Repositories;
using NCRecordShop.Services;
namespace NCRecordShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //Db
            var useInMemory = builder.Configuration.GetValue<bool>("UseInMemoryDatabase");
            if(useInMemory)
            {
                builder.Services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("RecordShopDb"));
            }
            else
            {
                builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            }

            builder.Services.AddScoped<IAlbumRepository, AlbumRepository>();
            builder.Services.AddScoped<IAlbumServices, AlbumServices>();
            
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
