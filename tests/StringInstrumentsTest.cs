using ecommerce_music_back.data;
using ecommerce_music_back.Models;
using ecommerce_music_back.Services;
using Microsoft.EntityFrameworkCore;
using Xunit;
using Moq;
using ecommerce_music_back.Repository;
using ecommerce_music_back.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit.Sdk;

namespace ecommerce_music_back.tests
{
    public class StringInstrumentsTest
    {
        [Fact]
        public async Task TestTrueToFindById()
        {
          //
          var mockRepository = new Mock<IStringInstrumentsRepository>();
          var expectedInstrument = new StringInstrument { Id = 1 };
          mockRepository.Setup(repo => repo.FindByIdAsync(1)).ReturnsAsync(expectedInstrument);
          var controller = new StringInstrumentController(mockRepository.Object);
          
          var result = await controller.FindById(1);

          var okResult = Assert.IsType<OkObjectResult>(result);
          var actualInstrument = Assert.IsAssignableFrom<StringInstrument>(okResult.Value);
          Assert.Equal(expectedInstrument, actualInstrument);
        }

        [Fact]
        public async Task TestFindByIdIsFalse()
        {
          //arrange
          var mockRepository = new Mock<IStringInstrumentsRepository>();
          var expectedInstrument = new StringInstrument { Id = 100 };
          mockRepository.Setup(repo => repo.FindByIdAsync(100)).ReturnsAsync((StringInstrument)null);
          var controller = new StringInstrumentController(mockRepository.Object);

          //act
          var actFindById = await controller.FindById(100);

          //Assert
          var notFoundId = Assert.IsType<NotFoundObjectResult>(actFindById);
          Assert.Equal("Not Found Id",notFoundId.Value);

        }
    }
}