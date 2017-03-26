using Langcademy.Data.Models;
using Langcademy.Services.Data.Contracts;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.FluentMVCTesting;

namespace Langcademy.Web.Controllers.Tests.TopicsControllerTests
{
    [TestFixture]
    public class Solve_Should
    {
        [TestCase(9876)]
        public void ReturnDefaulView(int id)
        {
            var topicServiceMock = new Mock<ITopicsService>();
            var usersServiceMock = new Mock<IUsersService>();
            var submissionsServiceMock = new Mock<ITopicSubmissionsService>();
            var topicController = new TopicsController(
                topicServiceMock.Object,
                usersServiceMock.Object,
                submissionsServiceMock.Object);

            topicServiceMock.Setup(t => t.GetById(id)).Returns(new Topic() { NumberOfWordsToTranslate = 3 });

            // Act & Assert
            topicController
                .WithCallTo(t => t.Solve(id))
                .ShouldRenderDefaultView();
        }

        [TestCase(9876)]
        [TestCase(1)]
        public void CallTopicsGetByIdOnce(int id)
        {
            // Arrange
            var topicServiceMock = new Mock<ITopicsService>();
            var usersServiceMock = new Mock<IUsersService>();
            var submissionsServiceMock = new Mock<ITopicSubmissionsService>();
            var topicController = new TopicsController(
                topicServiceMock.Object,
                usersServiceMock.Object,
                submissionsServiceMock.Object);

            topicServiceMock.Setup(t => t.GetById(id)).Returns(new Topic() { NumberOfWordsToTranslate = 3 });
            // Act
            topicController.Solve(id);

            // Assert
            topicServiceMock.Verify(t => t.GetById(id), Times.Once);
        }
    }
}
