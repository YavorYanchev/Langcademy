using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

namespace Langcademy.Data.Models.Tests
{
    [TestFixture]
    public class TopicTests
    {
        [TestCase("topicName")]
        public void NameShouldBeSetCorrectly(string text)
        {
            // Arrange
            var topic = new Topic();

            // Act
            topic.Name = text;

            // Assert
            Assert.AreEqual(text, topic.Name);

        }

        [TestCase("topicDescription")]
        public void DescriptionShouldBeSetCorrectly(string text)
        {
            // Arrange
            var topic = new Topic();

            // Act
            topic.Description = text;

            // Assert
            Assert.AreEqual(text, topic.Description);

        }

        [TestCase(97)]
        public void NumberOfWordsToTranslateShouldBeSetCorrectly(int number)
        {
            // Arrange
            var topic = new Topic();

            // Act
            topic.NumberOfWordsToTranslate = number;

            // Assert
            Assert.AreEqual(number, topic.NumberOfWordsToTranslate);

        }

        [TestCase("CreatorIdString")]
        public void CreatorIdShouldBeSetCorrectly(string text)
        {
            // Arrange
            var topic = new Topic();

            // Act
            topic.CreatorId = text;

            // Assert
            Assert.AreEqual(text, topic.CreatorId);

        }

        [Test]
        public void WordsToTranslateShouldReturnIListOfWordToTranslate()
        {
            // Arrange
            var topic = new Topic();

            //Act & Assert
            Assert.IsInstanceOf<IList<WordToTranslate>>(topic.WordsToTranslate);
        }

    }
}
