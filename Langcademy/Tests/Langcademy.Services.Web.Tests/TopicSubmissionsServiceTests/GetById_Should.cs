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
    public class GetById_Should
    {
        [TestCase(int.MinValue)]
        [TestCase(int.MaxValue)]
        public void ThrowArgumentNullExceptionWhenSubmissionIsNotFound(int invalidId)
        {
            // Arrange
            var mockedRepository = new Mock<IDbRepository<TopicSubmission>>();
            var mockedIdentifier = new Mock<IIdentifierProvider>();
            var submissionService = new TopicSubmissionsService(mockedRepository.Object, mockedIdentifier.Object);


            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => submissionService.GetById(invalidId));
        }

        [TestCase(int.MinValue)]
        [TestCase(int.MaxValue)]

        public void ThrowArgumentNullExceptionWhenSubmissionIsNotFoundWithCorrectMessage(int invalidId)
        {
            // Arrange
            var mockedRepository = new Mock<IDbRepository<TopicSubmission>>();
            var mockedIdentifier = new Mock<IIdentifierProvider>();
            var submissionService = new TopicSubmissionsService(mockedRepository.Object, mockedIdentifier.Object);

            // Act & Assert
            var exc = Assert.Throws<ArgumentNullException>(() => submissionService.GetById(invalidId));
            StringAssert.Contains("not found", exc.Message);
        }
    }
}
