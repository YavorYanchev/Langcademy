using Langcademy.Web.ViewModels.Account;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Langcademy.Data.Models.Tests.ViewModelsTests
{
    [TestFixture]
    public class RegisterViewModel_Should
    {
        [Test]
        public void HasEmailWithRequiredAttribute()
        {
            //Arrange & Act
            var email = typeof(RegisterViewModel).GetProperty("Email");
            //using reflection
            var attribute = email.GetCustomAttribute(typeof(RequiredAttribute));

            //Assert
            Assert.IsNotNull(attribute);
        }

        [Test]
        public void HasEmailWithEmailAttribute()
        {
            //Arrange & Act
            var email = typeof(RegisterViewModel).GetProperty("Email");
            //using reflection
            var attribute = email.GetCustomAttribute(typeof(EmailAddressAttribute));

            //Assert
            Assert.IsNotNull(attribute);
        }

        [Test]
        public void HasPasswordWithRequiredAttribute()
        {
            //Arrange & Act
            var pass = typeof(RegisterViewModel).GetProperty("Password");
            //using reflection
            var attribute = pass.GetCustomAttribute(typeof(RequiredAttribute));

            //Assert
            Assert.IsNotNull(attribute);
        }


        [Test]
        public void HasUsernameWithRequiredAttribute()
        {
            //Arrange & Act
            var username = typeof(RegisterViewModel).GetProperty("UserName");
            //using reflection
            var attribute = username.GetCustomAttribute(typeof(RequiredAttribute));

            //Assert
            Assert.IsNotNull(attribute);
        }


        [Test]
        public void HasFirstNameWithRequiredAttribute()
        {
            //Arrange & Act
            var firstName = typeof(RegisterViewModel).GetProperty("FirstName");
            //using reflection
            var attribute = firstName.GetCustomAttribute(typeof(RequiredAttribute));

            //Assert
            Assert.IsNotNull(attribute);
        }

        [Test]
        public void HasLastNameWithRequiredAttribute()
        {
            //Arrange & Act
            var lastName = typeof(RegisterViewModel).GetProperty("LastName");
            //using reflection
            var attribute = lastName.GetCustomAttribute(typeof(RequiredAttribute));

            //Assert
            Assert.IsNotNull(attribute);
        }
    }

}
