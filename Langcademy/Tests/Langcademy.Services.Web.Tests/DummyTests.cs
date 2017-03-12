using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Langcademy.Services.Web.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void DummyTest1()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void DummyTest2()
        {
            Assert.IsFalse(false);
        }

        [Test]
        public void DummyTest3()
        {
            Assert.AreEqual(2, 5 - 3);
        }

        [Test]
        public void DummyTest4()
        {
            Assert.AreEqual(3, 5 - 2);
        }

    }
}
