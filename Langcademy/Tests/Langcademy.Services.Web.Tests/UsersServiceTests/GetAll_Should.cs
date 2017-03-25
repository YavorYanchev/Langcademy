using Langcademy.Data.Common;
using Langcademy.Data.Models;
using Langcademy.Services.Data;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Langcademy.Services.Web.Tests.UsersServiceTests
{
    [TestFixture]
    public class GetAll_Should
    {
        [Test]
        public void NotReturnNull()
        {
            // Arrange
            var mockedUserRepo = new Mock<IDbRepository<ApplicationUser>>();
            var usersService = new UsersService(mockedUserRepo.Object);

            // Act & Assert
            Assert.IsNotNull(usersService.GetAll());
        }

        [Test]
        public void ReturnIQueryableOfApplicationUser()
        {
            // Arrange
            var mockedUserRepo = new Mock<IDbRepository<ApplicationUser>>();
            var usersService = new UsersService(mockedUserRepo.Object);

            // Act
            var result = usersService.GetAll();

            // Assert
            Assert.IsInstanceOf<IQueryable<ApplicationUser>>(result);
        }

        [Test]
        public void CallAllOnce()
        {
            // Arrange
            var mockedUserRepo = new Mock<IDbRepository<ApplicationUser>>();
            var usersService = new UsersService(mockedUserRepo.Object);

            // Act
            var result = usersService.GetAll();

            // Assert
            mockedUserRepo.Verify(m => m.All(), Times.Once);
        }
    }
}
