using Moq;
using NCRecordShop.Repositories;
using NCRecordShop.Services;
using NCRecordShop.Models;

namespace RecordShop.Tests;

public class AlbumServiceTests
{
    private Mock<IAlbumRepository> _mockRepo;
    private AlbumServices _service;
    [SetUp]
    public void Setup()
    {
        _mockRepo = new Mock<IAlbumRepository>();
        _service = new AlbumServices(_mockRepo.Object);
    }

    [Test]
    public void GetAllAlbum_ReturnsAllAlbum()
    {
        var album = new List<Album>
        {
            new Album
            {
            Title = "Son of Spergy",
            Artist = "Daniel Caesar",
            ReleaseYear = 2025,
            Genre = Genre.RnB,
            Quantity = 4
            }
        };
        _mockRepo.Setup(r => r.GetAllAlbums()).Returns(album);
        //Act
        var result = _service.GetAllAlbums();
        Assert.That(result, Is.EqualTo(album));
    }
    [Test]
    public void GetAlbumById_returnsCorrectAlbum()
    {
        var album = new Album

        {
            Id = 1,
            Title = "Son of Spergy",
            Artist = "Daniel Caesar",
            ReleaseYear = 2025,
            Genre = Genre.RnB,
            Quantity = 4
        };
    
        _mockRepo.Setup(r => r.GetAlbumById(1)).Returns(album);
        //act
        var result = _service.GetAlbumById(1);
        Assert.That(result.Title, Is.EqualTo("Son of Spergy"));

    }
    [Test]
    public void AddAlbum_Returns_AlbumAdded()
    {
        var album = new Album

        {
            Id = 1,
            Title = "Son of Spergy",
            Artist = "Daniel Caesar",
            ReleaseYear = 2025,
            Genre = Genre.RnB,
            Quantity = 4
        };
        _mockRepo.Setup(r => r.AddAlbum(album)).Returns(album);
        //act
         var result = _service.AddAlbum(album);
        //assert
        Assert.That(result, Is.EqualTo(album));
    }
    [Test]
    public void UpdateAlbum_Returns_UpdatedAlbum()
    {
        var Ualbum = new Album

        {
            Id = 1,
            Title = "Son of Spergy",
            Artist = "Daniel Caesar",
            ReleaseYear = 2025,
            Genre = Genre.RnB,
            Quantity = 3
        };
        _mockRepo.Setup(r => r.UpdateAlbum(1, Ualbum)).Returns(Ualbum);
        //act
        var result = _service.UpdateAlbum(1,Ualbum);
        //assert
        Assert.That(result.Title, Is.EqualTo("Son of Spergy"));
    }
    [Test]
    public void DeleteAlbum_Returns_True()
    {
        var album = new Album

        {
            Id = 1,
            Title = "Son of Spergy",
            Artist = "Daniel Caesar",
            ReleaseYear = 2025,
            Genre = Genre.RnB,
            Quantity = 4
        };
        _mockRepo.Setup(r => r.DeleteAlbum(1)).Returns(true);
        //act
        var result = _service.DeleteAlbum(1);
        //assert
        Assert.That(result, Is.True);
    }

}

