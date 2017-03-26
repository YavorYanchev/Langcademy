using Langcademy.Data.Models;
using Langcademy.Services.Data.Contracts;
using Moq;
using NUnit.Framework;
using System;
using System.Reflection;
using System.Web.Mvc;
using TestStack.FluentMVCTesting;

namespace Langcademy.Web.Controllers.Tests.TopicsControllerTests
{
    [TestFixture]
    public class Create_Should
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
                .WithCallTo(t => t.Create())
                .ShouldRenderDefaultView();
        }

        [Test]
        public void HasAuthorizeAttribute()
        {
            // Arrange & Act
            var createMethod = typeof(TopicsController).GetMethod("Create", new Type[0]);

            // using reflection
            var attribute = createMethod.GetCustomAttribute(typeof(AuthorizeAttribute));

            // Assert
            Assert.IsNotNull(attribute);
        }

      
    }
}
