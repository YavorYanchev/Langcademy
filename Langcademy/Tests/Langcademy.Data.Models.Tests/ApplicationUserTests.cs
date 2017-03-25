using Langcademy.Data.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Langcademy.Data.Models.Tests
{

    [TestFixture]
    public class ApplicationUserTests
    {
        [Test]
        public void ApplicationUser_ShouldNotBeNull()
        {

            var appUser = new ApplicationUser();


            Assert.IsNotNull(appUser);

        }

        [Test]
        public void ApplicationUser_ShouldBeInstanceOfApplicationUser()
        {

            var appUser = new ApplicationUser();


            Assert.IsInstanceOf<ApplicationUser>(appUser);

        }

        [Test]
        public void ApplicationUser_FirstNameShouldBeRequiredAndShouldNotBeNull()
        {
            //Arrange & Act
            var appUser = new ApplicationUser();
            var firstName = typeof(ApplicationUser).GetProperty("FirstName");
            //using reflection
            var attribute = firstName.GetCustomAttribute(typeof(RequiredAttribute));

            //Assert
            Assert.IsNotNull(attribute);

        }
        [Test]
        public void ApplicationUser_FirstNameShouldHasMaxLengthAttributeAndShouldNotBeNull()
        {
            //Arrange & Act
            var appUser = new ApplicationUser();
            var firstName = typeof(ApplicationUser).GetProperty("FirstName");
            //using reflection
            var attribute = firstName.GetCustomAttribute(typeof(MaxLengthAttribute));

            //Assert
            Assert.IsNotNull(attribute);
        }

        [Test]
        public void ApplicationUser_FirstNameShouldHasMinLengthAttributeAndShouldNotBeNull()
        {
            //Arrange & Act
            var appUser = new ApplicationUser();
            var firstName = typeof(ApplicationUser).GetProperty("FirstName");
            //using reflection
            var attribute = firstName.GetCustomAttribute(typeof(MinLengthAttribute));

            //Assert
            Assert.IsNotNull(attribute);
        }

        [Test]
        public void ApplicationUser_LastNameShouldBeRequiredAndShouldNotBeNull()
        {

            //Arrange & Act
            var appUser = new ApplicationUser();
            var lastName = typeof(ApplicationUser).GetProperty("LastName");
            //using reflection
            var attribute = lastName.GetCustomAttribute(typeof(RequiredAttribute));

            //Assert
            Assert.IsNotNull(attribute);

        }

        [Test]
        public void ApplicationUser_LastNameShouldHasMaxLengthAttributeAndShouldNotBeNull()
        {
            //Arrange & Act
            var appUser = new ApplicationUser();
            var lastName = typeof(ApplicationUser).GetProperty("LastName");
            //using reflection
            var attribute = lastName.GetCustomAttribute(typeof(MaxLengthAttribute));

            //Assert
            Assert.IsNotNull(attribute);
        }

        [Test]
        public void ApplicationUser_LastNameShouldHasMinLengthAttributeAndShouldNotBeNull()
        {
            //Arrange & Act
            var appUser = new ApplicationUser();
            var lastName = typeof(ApplicationUser).GetProperty("LastName");
            //using reflection
            var attribute = lastName.GetCustomAttribute(typeof(MinLengthAttribute));

            //Assert
            Assert.IsNotNull(attribute);
        }

        [Test]
        public void ApplicationUser_AvatarImageUrlShouldHasMaxLengthAttributeAndShouldNotBeNull()
        {
            //Arrange & Act
            var appUser = new ApplicationUser();
            var avatarUrl = typeof(ApplicationUser).GetProperty("AvatarImageUrl");
            //using reflection
            var attribute = avatarUrl.GetCustomAttribute(typeof(MaxLengthAttribute));

            //Assert
            Assert.IsNotNull(attribute);
        }
        [Test]
        public void ApplicationUser_LevelShouldInitializeCorrectly()
        {
            //Arrange
            var appUser = new ApplicationUser();
            var level = 1;
            
            //Act
            appUser.Level = level;

            //Assert
            Assert.AreEqual(level, appUser.Level);

        }
        [TestCase(true)]
        [TestCase(false)]
        public void ApplicationUser_IsDeletedShouldInitializeCorrectly(bool check)
        {
            //Arrange
            var appUser = new ApplicationUser();

            //Act
            appUser.IsDeleted = check;

            //Assert
            Assert.AreEqual(check, appUser.IsDeleted);

        }
        [TestCase("03/26/2017")]
        [TestCase("12/29/2000")]
        [TestCase("12/12/2012")]
        [TestCase(null)]

        public void ApplicationUser_DeletedOnShouldInitializeCorrectly(DateTime date)
        {
            //Arrange
            var appUser = new ApplicationUser();

            //Act
            appUser.DeletedOn = date;

            //Assert
            Assert.AreEqual(date, appUser.DeletedOn);
           
        }

        [TestCase("03/30/2017")]
        [TestCase("12/23/2000")]
        [TestCase("12/11/2012")]
        public void ApplicationUser_CreatedOnShouldInitializeCorrectly(DateTime date)
        {
            //Arrange
            var appUser = new ApplicationUser();

            //Act
            appUser.CreatedOn = date;

            //Assert
            Assert.AreEqual(date, appUser.CreatedOn);

        }

        [TestCase("03/10/2017")]
        [TestCase("12/10/2000")]
        [TestCase("12/09/2012")]
        [TestCase(null)]
        public void ApplicationUser_ModifiedOnShouldInitializeCorrectly(DateTime date)
        {
            //Arrange
            var appUser = new ApplicationUser();

            //Act
            appUser.CreatedOn = date;

            //Assert
            Assert.AreEqual(date, appUser.CreatedOn);

        }

    }
}
