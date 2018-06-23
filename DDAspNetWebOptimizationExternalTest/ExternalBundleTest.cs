using System.Linq;
using System.Web.Optimization;
using NUnit.Framework;

namespace DDAspNetWebOptimizationExternalTest
{
    [TestFixture]
    public class ExternalBundleTest
    {
        [Test(Description = "Transformations of ExternalBundle should be empty")]
        public void TransformsListIsEmptyTest()
        {
            // Arrange
            var bundle = new ExternalBundle("~/bundle");

            // Act
            var hasTransformations = bundle.Transforms.Any();

            // Assert
            Assert.IsFalse(hasTransformations, "An external bundle includes a transformations");
        }
    }
}
