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

namespace Langcademy.Web.Controllers.Tests.AreaAdminTests.SubmissionsAdministrationControllerTests
{
    [TestFixture]
    public class Index_Should
    {
        [Test]
        public void ReturnDefaultView()
        {
            // Arrange
            var submissionsServiceMock = new Mock<ITopicSubmissionsService>();
            var submissionsAdministrationController = new SubmissionsAdministrationController(
                submissionsServiceMock.Object);

            // Act & Assert
            submissionsAdministrationController
                .WithCallTo(t => t.Index())
                .ShouldRenderDefaultView();
        }

        [Test]
        public void CallGetAllTopicSubmissionsOnce()
        {
            // Arrange
            var submissionsServiceMock = new Mock<ITopicSubmissionsService>();
            var submissionsAdministrationController = new SubmissionsAdministrationController(
                submissionsServiceMock.Object);

            // Act
            submissionsAdministrationController.Index();

            // Assert
            submissionsServiceMock.Verify(t => t.GetAllTopicSubmissions(), Times.Once);
        }
    }
}
