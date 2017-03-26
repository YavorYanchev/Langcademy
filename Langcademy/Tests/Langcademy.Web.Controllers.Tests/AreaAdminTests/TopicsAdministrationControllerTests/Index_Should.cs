using Langcademy.Services.Data.Contracts;
using Langcademy.Web.Areas.Admin.Controllers;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.FluentMVCTesting;

namespace Langcademy.Web.Controllers.Tests.AreaAdminTests.TopicsAdministrationControllerTests
{
    [TestFixture]
    public class Index_Should
    {
        [Test]
        public void ReturnDefaultView()
        {
            // Arrange
            var topicServiceMock = new Mock<ITopicsService>();
            var topicAdministrationController = new TopicsAdministrationController(
                topicServiceMock.Object);

            // Act & Assert
            topicAdministrationController
                .WithCallTo(t => t.Index())
                .ShouldRenderDefaultView();
        }

        [Test]
        public void CallGetAllTopicsOnce()
        {
            // Arrange
            var topicServiceMock = new Mock<ITopicsService>();
            var topicAdministrationController = new TopicsAdministrationController(
                topicServiceMock.Object);

            // Act
            topicAdministrationController.Index();

            // Assert
            topicServiceMock.Verify(t => t.GetAllTopics(), Times.Once);
        }

    }
}
