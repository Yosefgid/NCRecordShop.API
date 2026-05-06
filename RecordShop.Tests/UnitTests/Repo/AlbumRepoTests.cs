using Microsoft.EntityFrameworkCore;
using NCRecordShop.Data;
using NCRecordShop.Repositories;
using NCRecordShop.Models;

namespace RecordShop.Tests;

public class AlbumRepoTests
{

    private AppDbContext _context;
    private AlbumRepository _repository;
    [SetUp]
    public void Setup()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase("RecordShopM")
            .Options;
        //create new context
        _context = new AppDbContext(options);
        _repository = new AlbumRepository(_context);
    }

    [TearDown]
    public void TearDown()
    {
        //After the test is done the context is disposed allowing us fresh start
        _context.Dispose();
    }

    [Test]
    public void GetAllAlbums_Returns_ListofAlbums()
    {
        //Arrange
        var album = new Album
        {
            Title = "Son of Spergy",
            Artist = "Daniel Caesar",
            ReleaseYear = 2025,
            Genre = Genre.RnB,
            Quantity = 4
        };

        _context.Albums.Add(album);
        _context.SaveChanges();
        //Act
        var result = _repository.GetAllAlbums();
        //Assert
        Assert.That(result, Is.Not.Empty);

    }

    [Test] 
    public void GetAlbumById_Returns_CorrectAlbum()
    {

        //Arrange
        var album = new Album
        {
            Title = "Son of Spergy",
            Artist = "Daniel Caesar",
            ReleaseYear = 2025,
            Genre = Genre.RnB,
            Quantity = 4
        };

        _context.Albums.Add(album);
        _context.SaveChanges();
        //Act
        var result = _repository.GetAlbumById(album.Id);
        //Assert
        Assert.That(result.Title, Is.EqualTo("Son of Spergy"));

    }
    [Test]
    public void AddAlbum_Returns_AlbumAdded()
    {
        //Arrange
        var album = new Album
        {
            Title = "Son of Spergy",
            Artist = "Daniel Caesar",
            ReleaseYear = 2025,
            Genre = Genre.RnB,
            Quantity = 4
        };

        //Act
        var result = _repository.AddAlbum(album);
        Assert.That(result.Title, Is.EqualTo("Son of Spergy"));
    }
    [Test]
    public void UpdateAlbum_Returns_UpdateAlbum()
    {

        //Arrange
        var album = new Album
        {
            Title = "Son of Spergy",
            Artist = "Daniel Caesar",
            ReleaseYear = 2025,
            Genre = Genre.RnB,
            Quantity = 4
        };

        _context.Albums.Add(album);
        _context.SaveChanges();
        var uAlbum = new Album
        {
            Title = "Freudian",
            Artist = "Daniel Caesar",
            ReleaseYear = 2017,
            Genre = Genre.RnB,
            Quantity = 4
        };
        //Act
        var result = _repository.UpdateAlbum(album.Id, uAlbum);
        Assert.That(result.Title, Is.EqualTo("Freudian"));

    }
    [Test]
    public void DeleteAlbum_ReturnsTrue()
    {

        //Arrange
        var album = new Album
        {
            Title = "Son of Spergy",
            Artist = "Daniel Caesar",
            ReleaseYear = 2025,
            Genre = Genre.RnB,
            Quantity = 4
        };

        _context.Albums.Add(album);
        _context.SaveChanges();
        //Act
        var result = _repository.DeleteAlbum(album.Id);
        Assert.That(result, Is.True);

    }
}
