using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.FluentMVCTesting;

namespace Langcademy.Web.Controllers.Tests.ManageControllerTests
{
    [TestFixture]
    public class SetPassword_Should
    {
        [Test]
        public void RenderDefaultView()
        {
            // Arrange
            var manageController = new ManageController();

            // Act & Assert
            manageController.WithCallTo(m => m.SetPassword()).ShouldRenderDefaultView();
        }
    }
}
