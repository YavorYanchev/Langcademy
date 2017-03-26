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

namespace Langcademy.Services.Web.Tests.TopicSubmissionsServiceTests
{
    [TestFixture]
    public class GetAllTopicSubmissions_Should
    {
        [Test]
        public void ReturnIQuerableOfSubmission()
        {
            // Arrange
            var mockedRepository = new Mock<IDbRepository<TopicSubmission>>();
            var mockedIdentifier = new Mock<IIdentifierProvider>();
            var submissionService = new TopicSubmissionsService(mockedRepository.Object, mockedIdentifier.Object);

            // Act
            var submissions = submissionService.GetAllTopicSubmissions();

            // Assert
            Assert.IsInstanceOf<IQueryable<TopicSubmission>>(submissions);
        }
    }
}
