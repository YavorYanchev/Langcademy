using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Langcademy.Data.Models.Tests
{
    [TestFixture]
    public class TopicSubmissionsTests
    {
        [TestCase(167)]
        public void ForTopicIdShouldBeSetCorrectly(int number)
        {
            // Arrange
            var submission = new TopicSubmission();

            // Act
            submission.ForTopicId = number;

            // Assert
            Assert.AreEqual(number, submission.ForTopicId);

        }

        [TestCase("userId")]
        public void ByUserIdShouldBeSetCorrectly(string text)
        {
            // Arrange
            var submission = new TopicSubmission();

            // Act
            submission.ByUserId = text;

            // Assert
            Assert.AreEqual(text, submission.ByUserId);

        }

        [TestCase("elapsedTimeString")]
        public void TImeElapsedShouldBeSetCorrectly(string time)
        {
            // Arrange
            var submission = new TopicSubmission();

            // Act
            submission.TimeElapsed = time;

            // Assert
            Assert.AreEqual(time, submission.TimeElapsed);

        }


        [TestCase(16734)]
        public void TimeElapsedInSecondsShouldBeSetCorrectly(int number)
        {
            // Arrange
            var submission = new TopicSubmission();

            // Act
            submission.TimeElapsedInSeconds = number;

            // Assert
            Assert.AreEqual(number, submission.TimeElapsedInSeconds);

        }

        [TestCase(34.2)]
        public void PercentageCorrectTranslationsShouldBeSetCorrectly(double percent)
        {
            // Arrange
            var submission = new TopicSubmission();

            // Act
            submission.PercentageCorrectTranslations = percent;

            // Assert
            Assert.AreEqual(percent, submission.PercentageCorrectTranslations);

        }
    }
}
