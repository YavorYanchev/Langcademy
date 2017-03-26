using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.FluentMVCTesting;

namespace Langcademy.Web.Controllers.Tests.AccountControllerTests
{
    [TestFixture]
    public class ConfirmEmail_Should
    {
        [TestCase(null, "valid")]
        [TestCase("validString", null)]
        [TestCase(null, null)]
        public void ReturnErrorViewWhePassedDataIsInvalid(string userId, string code)
        {
            // Arrange
            var accController = new AccountController();

            // Act & Assert
            accController.WithCallTo(a => a.ConfirmEmail(userId, code)).ShouldRenderView("Error");
        }
    }
}
