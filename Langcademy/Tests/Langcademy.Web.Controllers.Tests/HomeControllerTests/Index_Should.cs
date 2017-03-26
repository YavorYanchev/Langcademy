using NUnit.Framework;
using TestStack.FluentMVCTesting;

namespace Langcademy.Web.Controllers.Tests.HomeControllerTests
{
    [TestFixture]
    public class Index_Should
    {
        [Test]
        public void RenderDefaultView()
        {
            // Arrange
            var homeController = new HomeController();

            // Act & Assert
            homeController.WithCallTo(h => h.Index()).ShouldRenderDefaultView();

        }
    }
}
