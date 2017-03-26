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
    public class ExternalLoginFailure_Should
    {
        [Test]
        public void ReturnDefaultView()
        {
            // Arrange
            var accController = new AccountController();

            // Act & Assert
            accController.WithCallTo(a => a.ExternalLoginFailure()).ShouldRenderDefaultView();

        }
    }
}
