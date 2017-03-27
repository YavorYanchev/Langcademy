using Langcademy.Data.Common;
using Langcademy.Data.Models;
using Langcademy.Services.Data;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Langcademy.Services.Web.Tests.TopicsServiceTests
{
    [TestFixture]
    public class GetById_Should
    {
        [TestCase(int.MinValue)]
        [TestCase(int.MaxValue)]

        public void ThrowArgumentNullExceptionWhenTopicIsNotFound(int invalidId)
        {
            // Arrange
            var mockedRepository = new Mock<IDbRepository<Topic>>();
            var mockedIdentifier = new Mock<IIdentifierProvider>();
            var topicService = new TopicsService(mockedRepository.Object, mockedIdentifier.Object);
            var mockedTopic = new Mock<Topic>();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => topicService.GetById(invalidId));
        }

        [TestCase(int.MinValue)]
        [TestCase(int.MaxValue)]

        public void ThrowArgumentNullExceptionWhenTopicIsNotFoundWithCorrectMessage(int invalidId)
        {
            // Arrange
            var mockedRepository = new Mock<IDbRepository<Topic>>();
            var mockedIdentifier = new Mock<IIdentifierProvider>();
            var topicService = new TopicsService(mockedRepository.Object, mockedIdentifier.Object);
            var mockedTopic = new Mock<Topic>();

            // Act & Assert
            var exc = Assert.Throws<ArgumentNullException>(() => topicService.GetById(invalidId));
            StringAssert.Contains("not found", exc.Message);
        }

        [Test]
        public void ReturnTopicInstance()
        {
            // Arrange
            var mockedRepository = new Mock<IDbRepository<Topic>>();
            var mockedIdentifier = new Mock<IIdentifierProvider>();
            var topicService = new TopicsService(mockedRepository.Object, mockedIdentifier.Object);
            var mockedTopic = new Mock<Topic>();
            mockedRepository.Setup(m => m.GetById(1)).Returns(mockedTopic.Object);
            // Act & Assert

            Assert.IsInstanceOf<Topic>(topicService.GetById(1));
        }

        [Test]
        public void ThrowArgumentNullExceptionWhenTopicIsNull()
        {
            // Arrange
            var mockedRepository = new Mock<IDbRepository<Topic>>();
            var mockedIdentifier = new Mock<IIdentifierProvider>();
            var topicService = new TopicsService(mockedRepository.Object, mockedIdentifier.Object);
            var mockedTopic = new Mock<Topic>();
            mockedRepository.Setup(m => m.GetById(1)).Returns((Topic)null);
            // Act & Assert

            Assert.Throws<ArgumentNullException>(()=>topicService.GetById(1));
           // Assert.IsInstanceOf<Topic>(topicService.GetById(1));
        }
    }
}
