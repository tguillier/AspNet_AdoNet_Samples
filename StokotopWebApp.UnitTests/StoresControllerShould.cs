using Microsoft.AspNetCore.Mvc;
using Moq;
using StokotopWebApp.Controllers;
using StokotopWebApp.Data;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace StokotopWebApp.UnitTests
{
    public class StoresControllerShould
    {
        [Fact]
        public void ReturnIndexViewWithStoresList_WithActionIndex()
        {
            // Arrange
            IEnumerable<Store> storeList = new List<Store> { new Store { Id = 1, Name = "Auchan" } };
            Mock<IRepository<Store>> mockRepo = new Mock<IRepository<Store>>();
            mockRepo.Setup(repo => repo.FindAll()).Returns(storeList);

            StoresController sut = new StoresController(mockRepo.Object);

            // Act
            var result = sut.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<Store>>(viewResult.Model);

            Assert.Equal(storeList.Count(), model.Count());
        }
    }
}
