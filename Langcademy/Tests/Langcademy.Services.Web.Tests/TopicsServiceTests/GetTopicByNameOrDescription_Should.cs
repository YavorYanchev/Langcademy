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
    public class GetTopicByNameOrDescription_Should
    {
        [TestCase("searchTermString")]
        public void ReturnIEnumerableOfTopic(string searchTerm)
        {
            // Arrange
            var mockedRepository = new Mock<IDbRepository<Topic>>();
            var mockedIdentifier = new Mock<IIdentifierProvider>();
            var topicService = new TopicsService(mockedRepository.Object, mockedIdentifier.Object);
            var mockedTopic = new Mock<Topic>();

            // Act
            var result = topicService.GetTopicByNameOrDescription(searchTerm);

            // Assert
            Assert.IsInstanceOf<IEnumerable<Topic>>(result);

        }
    }
}
