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
    public class ResetPassword_Should
    {
        [TestCase("notNullString")]
        public void ReturnDefaultViewWhenCodeIsNotNull(string code)
        {
            // Arrange
            var accController = new AccountController();

            // Act & Assert
            accController.WithCallTo(a => a.ResetPassword(code)).ShouldRenderDefaultView();

        }

        [TestCase(null)]
        public void ReturnDefaultErrorViewWhenCodeIsNull(string code)
        {
            // Arrange
            var accController = new AccountController();

            // Act & Assert
            accController.WithCallTo(a => a.ResetPassword(code)).ShouldRenderView("Error");

        }
    }
}
