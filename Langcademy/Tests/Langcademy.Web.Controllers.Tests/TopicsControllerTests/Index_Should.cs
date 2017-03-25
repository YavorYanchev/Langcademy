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
    public class Index_Should
    {
        [Test]
        public void ReturnDefaultView()
        {
            // Arrange
            var topicServiceMock = new Mock<ITopicsService>();
            var usersServiceMock = new Mock<IUsersService>();
            var submissionsServiceMock = new Mock<ITopicSubmissionsService>();
            var topicController = new TopicsController(
                topicServiceMock.Object,
                usersServiceMock.Object,
                submissionsServiceMock.Object);

            // Act & Assert
            topicController
                .WithCallTo(t => t.Index())
                .ShouldRenderDefaultView();
        }
    }
}
