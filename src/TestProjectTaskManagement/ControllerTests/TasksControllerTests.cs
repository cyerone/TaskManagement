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
    public class TasksControllerTests
    {
        [TestMethod]
        public async Task GetTasks_ReturnsOkObjectResult_WhenSuccessful()
        {
            // Arrange
            var mockRepo = new Mock<IRepository>();
            var expectedResult = "Success";
            mockRepo.Setup(repo => repo.GetTasks()).ReturnsAsync(expectedResult);
            var controller = new TasksController(mockRepo.Object);

            // Act
            var result = await controller.GetTasks();

            // Assert
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
            var okResult = result as OkObjectResult;
            Assert.IsInstanceOfType(okResult.Value, typeof(string));
            Assert.AreEqual(expectedResult, okResult.Value as string);
        }

        [TestMethod]
        public async Task GetTask_ReturnsOkObjectResult_WhenSuccessful()
        {
            // Arrange
            var mockRepo = new Mock<IRepository>();
            var taskId = 1;
            var expectedResult = "Success";
            mockRepo.Setup(repo => repo.GetTask(taskId)).ReturnsAsync(expectedResult);
            var controller = new TasksController(mockRepo.Object);

            // Act
            var result = await controller.GetTask(taskId);

            // Assert
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
            var okResult = result as OkObjectResult;
            Assert.IsInstanceOfType(okResult.Value, typeof(string));
            Assert.AreEqual(expectedResult, okResult.Value as string);
        }

        [TestMethod]
        public async Task CreateTask_ReturnsOkObjectResult_WhenSuccessful()
        {
            // Arrange
            var mockRepo = new Mock<IRepository>();
            var task = new TaskDTO();
            var expectedResult = "Success";
            mockRepo.Setup(repo => repo.CreateTask(task)).ReturnsAsync(expectedResult);
            var controller = new TasksController(mockRepo.Object);

            // Act
            var result = await controller.CreateTask(task);

            // Assert
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
            var okResult = result as OkObjectResult;
            Assert.IsInstanceOfType(okResult.Value, typeof(string));
            Assert.AreEqual(expectedResult, okResult.Value as string);
        }

        [TestMethod]
        public async Task EditTask_ReturnsOkObjectResult_WhenSuccessful()
        {
            // Arrange
            var mockRepo = new Mock<IRepository>();
            var task = new TaskDTO();
            var taskId = 1;
            var expectedResult = "Success";
            mockRepo.Setup(repo => repo.EditTask(task, taskId)).ReturnsAsync(expectedResult);
            var controller = new TasksController(mockRepo.Object);

            // Act
            var result = await controller.EditTask(task, taskId);

            // Assert
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
            var okResult = result as OkObjectResult;
            Assert.IsInstanceOfType(okResult.Value, typeof(string));
            Assert.AreEqual(expectedResult, okResult.Value as string);
        }

        [TestMethod]
        public async Task DeleteTask_ReturnsOkObjectResult_WhenSuccessful()
        {
            // Arrange
            var mockRepo = new Mock<IRepository>();
            var taskId = 1;
            var expectedResult = "Success";
            mockRepo.Setup(repo => repo.DeleteTask(taskId)).ReturnsAsync(expectedResult);
            var controller = new TasksController(mockRepo.Object);

            // Act
            var result = await controller.DeleteTask(taskId);

            // Assert
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
            var okResult = result as OkObjectResult;
            Assert.IsInstanceOfType(okResult.Value, typeof(string));
            Assert.AreEqual(expectedResult, okResult.Value as string);
        }

        [TestMethod]
        public async Task CompleteTask_ReturnsOkObjectResult_WhenSuccessful()
        {
            // Arrange
            var mockRepo = new Mock<IRepository>();
            var taskId = 1;
            var expectedResult = "Success";
            mockRepo.Setup(repo => repo.CompleteTask(taskId)).ReturnsAsync(expectedResult);
            var controller = new TasksController(mockRepo.Object);

            // Act
            var result = await controller.CompleteTask(taskId);

            // Assert
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
            var okResult = result as OkObjectResult;
            Assert.IsInstanceOfType(okResult.Value, typeof(string));
            Assert.AreEqual(expectedResult, okResult.Value as string);
        }
    }
}
