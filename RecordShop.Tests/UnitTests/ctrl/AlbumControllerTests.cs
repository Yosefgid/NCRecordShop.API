using Microsoft.AspNetCore.Mvc;
using Moq;
using NCRecordShop.Controllers;
using NCRecordShop.Models;
using NCRecordShop.Services;
using NUnit.Framework;

namespace RecordShop.Tests;

public class AlbumControllerTests
{
    private Mock<IAlbumServices> _mockServices;
    private AlbumController _controller;

    [SetUp]
    public void Setup()
    {
        _mockServices = new Mock<IAlbumServices>();
        _controller = new AlbumController(_mockServices.Object);
    }

    [Test]
    public void GetAll_Albums_Returns_OK()
    {
        //arrange
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

        _mockServices.Setup(s => s.GetAllAlbums()).Returns(album);


        //act
        var result = _controller.GetAllAlbum();
        //assert
        Assert.That(result, Is.InstanceOf<OkObjectResult>());


    }
    [Test]
    public void GetAllAlbums_By_Id_Returns_OkResult()
    {
        var album = new Album
        {
            Id =1,
            Title = "Son of Spergy",
            Artist = "Daniel Caesar",
            ReleaseYear = 2025,
            Genre = Genre.RnB,
            Quantity = 4
        
        };

        _mockServices.Setup(s => s.GetAlbumById(1)).Returns(album);

        var result = _controller.GetAlbumById(1);
        Assert.That(result, Is.InstanceOf<OkObjectResult>());
    }

    [Test]
    public void AddAlbum_Returns_CreateAtActionResult()
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

        _mockServices.Setup(s => s.AddAlbum(album)).Returns(album);

        var result = _controller.AddAlbum(album);

        Assert.That(result, Is.InstanceOf<CreatedAtActionResult>());


    }
    [Test]
    public void UpdateAlbum_Returns_OkResult()
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

        _mockServices.Setup(s => s.UpdateAlbum(1, album)).Returns(album);

        var result = _controller.UpdateAlbum(1, album);

        Assert.That(result, Is.InstanceOf<OkObjectResult>());


    }

    [Test]
    public void Delete_Album_Returns_NoContent()
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

        _mockServices.Setup(s => s.DeleteAlbum(1)).Returns(true);

        var result = _controller.DeleteAlbum(1);

        Assert.That(result, Is.InstanceOf<NoContentResult>());


    }


}
