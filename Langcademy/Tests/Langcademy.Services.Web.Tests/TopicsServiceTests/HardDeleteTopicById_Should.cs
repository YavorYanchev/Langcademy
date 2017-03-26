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
    public class HardDeleteTopicById_Should
    {
        [TestCase(int.MinValue)]
        [TestCase(int.MaxValue)]

        public void CallHardDeleteTopicByIdOnce(int id)
        {
            // Arrange
            var mockedRepository = new Mock<IDbRepository<Topic>>();
            var mockedIdentifier = new Mock<IIdentifierProvider>();
            var topicService = new TopicsService(mockedRepository.Object, mockedIdentifier.Object);
            var mockedTopic = new Mock<Topic>();

            // Act
            topicService.HardDeleteTopicById(id);

            // Assert
            mockedRepository.Verify(m => m.HardDeleteById(id), Times.Once);

        }

        [TestCase(int.MaxValue)]

        public void CallSaveOnTheRepository(int id)
        {
            // Arrange
            var mockedRepository = new Mock<IDbRepository<Topic>>();
            var mockedIdentifier = new Mock<IIdentifierProvider>();
            var topicService = new TopicsService(mockedRepository.Object, mockedIdentifier.Object);
            var mockedTopic = new Mock<Topic>();

            // Act
            topicService.HardDeleteTopicById(id);

            // Assert
            mockedRepository.Verify(m => m.Save(), Times.Once);

        }
    }
    }
