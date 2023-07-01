using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Threading.Tasks;
using TaskManagement.Controllers;
using TaskManagement.Interfaces;
using TaskManagement.Models;

namespace TestProjectTaskManagement.ControllerTests
{
    [TestClass]
    public class CommentControllerTests
    {
        [TestMethod]
        public async Task CreateComment_ReturnsOkObjectResult_WhenSuccessful()
        {
            // Arrange
            var mockRepo = new Mock<IRepository>();
            var comment = new CommentDTO();
            var expectedResult = "Success";
            mockRepo.Setup(repo => repo.CreateComment(comment)).ReturnsAsync(expectedResult);
            var controller = new CommentController(mockRepo.Object);

            // Act
            var result = await controller.CreateComment(comment);

            // Assert
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
            var okResult = result as OkObjectResult;
            Assert.IsInstanceOfType(okResult.Value, typeof(string));
            Assert.AreEqual(expectedResult, okResult.Value as string);
        }

        [TestMethod]
        public async Task GetComments_ReturnsOkObjectResult_WhenSuccessful()
        {
            // Arrange
            var mockRepo = new Mock<IRepository>();
            var taskId = 1;
            var expectedResult = "Success";
            mockRepo.Setup(repo => repo.GetComments(taskId)).ReturnsAsync(expectedResult);
            var controller = new CommentController(mockRepo.Object);

            // Act
            var result = await controller.GetComments(taskId);

            // Assert
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
            var okResult = result as OkObjectResult;
            Assert.IsInstanceOfType(okResult.Value, typeof(string));
            Assert.AreEqual(expectedResult, okResult.Value as string);
        }
    }
}
