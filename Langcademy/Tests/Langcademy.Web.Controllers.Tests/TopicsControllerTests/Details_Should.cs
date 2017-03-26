using Langcademy.Services.Data.Contracts;
using Langcademy.Web.ViewModels.Topics;
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
    public class Details_Should
    {
        [TestCase(1)]
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

            // Act & Assert
            topicController
                .WithCallTo(t => t.Details(id))
                .ShouldRenderDefaultView();
        }

        [TestCase(9876)]
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

            // Act
            topicController.Details(id);

            // Assert
            topicServiceMock.Verify(t => t.GetById(id), Times.Once);
        }

        [TestCase(9876)]
        public void UseTopicDetailViewModel(int id)
        {
            // Arrange
            var topicServiceMock = new Mock<ITopicsService>();
            var usersServiceMock = new Mock<IUsersService>();
            var submissionsServiceMock = new Mock<ITopicSubmissionsService>();
            var topicController = new TopicsController(
                topicServiceMock.Object,
                usersServiceMock.Object,
                submissionsServiceMock.Object);

            topicController.WithCallTo(t => t.Details(id))
                .ShouldRenderDefaultView().WithModel<TopicDetailsViewModel>();
        }
    }
}
