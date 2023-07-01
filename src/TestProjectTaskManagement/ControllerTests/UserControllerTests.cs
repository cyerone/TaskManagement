using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskManagement.Controllers;
using TaskManagement.Interfaces;
using Moq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskManagement.Models;

namespace TestProjectTaskManagement.ControllerTests
{
    [TestClass]
    public class UserControllerTests
    {
        [TestMethod]
        public async Task CreateUser_ReturnsOkObjectResult_WhenSuccessful()
        {
            // Arrange
            var mockRepo = new Mock<IRepository>();
            var user = new UserDTO();
            var expectedResult = "Success";
            mockRepo.Setup(repo => repo.CreateUser(user)).ReturnsAsync(expectedResult);
            var controller = new UserController(mockRepo.Object);

            // Act
            var result = await controller.CreateUser(user);

            // Assert
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
            var okResult = result as OkObjectResult;
            Assert.IsInstanceOfType(okResult.Value, typeof(string));
            Assert.AreEqual(expectedResult, okResult.Value as string);
        }

        [TestMethod]
        public async Task GetUserTasks_ReturnsOkObjectResult_WhenSuccessful()
        {
            // Arrange
            var mockRepo = new Mock<IRepository>();
            var userId = 1;
            var expectedResult = "Success";
            mockRepo.Setup(repo => repo.GetUserTasks(userId)).ReturnsAsync(expectedResult);
            var controller = new UserController(mockRepo.Object);

            // Act
            var result = await controller.GetUserTasks(userId);

            // Assert
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
            var okResult = result as OkObjectResult;
            Assert.IsInstanceOfType(okResult.Value, typeof(string));
            Assert.AreEqual(expectedResult, okResult.Value as string);
        }
    }
}
