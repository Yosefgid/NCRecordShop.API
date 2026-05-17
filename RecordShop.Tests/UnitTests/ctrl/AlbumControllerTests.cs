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

}
