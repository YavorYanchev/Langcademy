﻿using Langcademy.Data.Common;
using Langcademy.Data.Common.Models;
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
    public class Add_Should
    {
        [Test]
        public void ThrowArgumentNullExceptionWhenTopicIsNull()
        {
            // Arrange
            var mockedRepository = new Mock<IDbRepository<Topic>>();
            var mockedIdentifier = new Mock<IIdentifierProvider>();
            var topicService = new TopicsService(mockedRepository.Object, mockedIdentifier.Object);
            var mockedTopic = (Topic)null;

            // Act & Arrange
            Assert.Throws<ArgumentNullException>(() => topicService.Add(mockedTopic));

        }

        [Test]
        public void ThrowArgumentNullExceptionWithMessageThatShouldNotBeBullWhenTopicIsNull()
        {
            // Arrange
            var mockedRepository = new Mock<IDbRepository<Topic>>();
            var mockedIdentifier = new Mock<IIdentifierProvider>();
            var topicService = new TopicsService(mockedRepository.Object, mockedIdentifier.Object);
            var mockedTopic = (Topic)null;

            // Act & Arrange
            var exc = Assert.Throws<ArgumentNullException>(() => topicService.Add(mockedTopic));
            StringAssert.Contains("should not be null", exc.Message);
        }


        [Test]
        public void CallAddMethodOnDbRepositoryOnlyOnce()
        {
            // Arrange
            var mockedRepository = new Mock<IDbRepository<Topic>>();
            var mockedIdentifier = new Mock<IIdentifierProvider>();
            var topicService = new TopicsService(mockedRepository.Object, mockedIdentifier.Object);
            var mockedTopic = new Mock<Topic>();

            // Act
            topicService.Add(mockedTopic.Object);

            // Assert
            mockedRepository.Verify(m => m.Add(mockedTopic.Object), Times.Once);

        }

        [Test]
        public void CallSaveMethodOnDbRepositoryOnlyOnce()
        {
            // Arrange
            var mockedRepository = new Mock<IDbRepository<Topic>>();
            var mockedIdentifier = new Mock<IIdentifierProvider>();
            var topicService = new TopicsService(mockedRepository.Object, mockedIdentifier.Object);
            var mockedTopic = new Mock<Topic>();

            // Act
            topicService.Add(mockedTopic.Object);

            // Assert
            mockedRepository.Verify(m => m.Save(), Times.Once);

        }

        //[Test]
        //public void IncrementTheAmountOfTopicsWhenCorrectValuesArePassed()
        //{
        //    // Arrange
        //    var mockedRepository = new Mock<IDbRepository<Topic>>();
        //    var mockedIdentifier = new Mock<IIdentifierProvider>();
        //    var topicService = new TopicsService(mockedRepository.Object, mockedIdentifier.Object);
        //    var mockedTopic = new Mock<Topic>();
        //    //var emptyList = new List<Topic>() { };
        //    //mockedRepository.Setup(m => m.All()).Returns(emptyList);
        //    //mockedRepository.Setup(m => m.All().Count()).Returns(0);
        //    //mockedRepository.Setup(m=>m.All().Count)
        //    var mockedRepoObject = mockedRepository.Object;

        //    // Act
        //    topicService.Add(mockedTopic.Object);

        //    // Assert
        //    Assert.AreEqual(1,mockedRepoObject.All().Count());
        //}
    }
}
