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
    public class Delete_Should
    {
        [TestCase(1)]
        [TestCase(64937)]
        public void ReturnDefaultView(int id)
        {
            // Arrange
            var topicServiceMock = new Mock<ITopicsService>();
            var topicAdministrationController = new TopicsAdministrationController(
                topicServiceMock.Object);

            // Act & Assert
            topicAdministrationController
                .WithCallTo(t => t.Delete(id))
                .ShouldRedirectTo(t => t.Index());
        }

        [TestCase(64937)]
        public void CallHardDeleteTopicByIdOnce(int id)
        {
            // Arrange
            var topicServiceMock = new Mock<ITopicsService>();
            var topicAdministrationController = new TopicsAdministrationController(
                topicServiceMock.Object);

            // Act
            topicAdministrationController.Delete(id);

            // Assert
            topicServiceMock.Verify(t => t.HardDeleteTopicById(id), Times.Once);
        }
    }
}
