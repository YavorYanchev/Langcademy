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

namespace Langcademy.Services.Web.Tests.UsersServiceTests
{
    [TestFixture]
    public class GetById_Should
    {
        [TestCase("interesting-id")]
        [TestCase("interesting-id123")]
        [TestCase("1231425356353")]

        public void NotReturnNull(string id)
        {
            // Arrange
            var mockedUserRepo = new Mock<IDbRepository<ApplicationUser>>();
            var usersService = new UsersService(mockedUserRepo.Object);

            // Act & Assert
            Assert.IsNotNull(usersService.GetById(id));
        }

        [TestCase("1")]
        [TestCase("interesting-id")]
        [TestCase("1231425356353")]
        public void ReturnIQueryableOfApplicationUser(string id)
        {
            // Arrange
            var mockedUserRepo = new Mock<IDbRepository<ApplicationUser>>();
            var usersService = new UsersService(mockedUserRepo.Object);

            // Act
            var result = usersService.GetById(id);

            // Assert
            Assert.IsInstanceOf<IQueryable<ApplicationUser>>(result);
        }

        [TestCase("1231425356353")]
        [TestCase("1")]
        [TestCase("interesting-id")]
        public void CallGetByIdOnce(string id)
        {
            // Arrange
            var mockedUserRepo = new Mock<IDbRepository<ApplicationUser>>();
            var usersService = new UsersService(mockedUserRepo.Object);

            // Act
            var result = usersService.GetById(id);

            // Assert
            mockedUserRepo.Verify(m => m.All(), Times.Once);
        }
    }
}
