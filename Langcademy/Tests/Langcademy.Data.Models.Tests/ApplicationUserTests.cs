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

    }
}
