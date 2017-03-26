using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Langcademy.Data.Models.Tests
{
    [TestFixture]
    public class WordToTranslateTests
    {
        [TestCase("textForTheWord")]
        public void TextShouldBeSetCorrectly(string text)
        {
            // Arrange 
            var word = new WordToTranslate();

            //Act
            word.Text = text;

            //Assert
            Assert.AreEqual(text, word.Text);
            
        }

        [TestCase("TranslationForTheWord")]
        public void TranslationShouldBeSetCorrectly(string translation)
        {
            // Arrange 
            var word = new WordToTranslate();

            //Act
            word.Translation = translation;

            //Assert
            Assert.AreEqual(translation, word.Translation);

        }

        [TestCase(198)]
        public void TopicIdShouldBeSetCorrectly(int topicId)
        {
            // Arrange 
            var word = new WordToTranslate();

            //Act
            word.TopicId = topicId;

            //Assert
            Assert.AreEqual(topicId, word.TopicId);

        }
    }
}
