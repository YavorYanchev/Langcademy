using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Langcademy.Web.Controllers.Tests
{
    [TestFixture]
    public class DummyTestsForController
    {
        [Test]
        public void FirstDummyTest()
        {
            Assert.AreEqual(10, 30 - 20);
        }

        [Test]
        public void SecondDummyTest()
        {
            Assert.AreEqual(20, 30 - 10);
        }

        
    }
}
