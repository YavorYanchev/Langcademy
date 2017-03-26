using NUnit.Framework;
using TestStack.FluentMVCTesting;

namespace Langcademy.Web.Controllers.Tests.ManageControllerTests
{
    [TestFixture]
    public class AddPhoneNumber_Should
    {
        [Test]
        public void RenderDefaultView()
        {
            // Arrange
            var manageController = new ManageController();

            // Act & Assert
            manageController.WithCallTo(m => m.AddPhoneNumber()).ShouldRenderDefaultView();
        }
    }
}
