// filepath: problems/Problem102Test.cs
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EulerTests
{
    [TestClass]
    public class Problem102Tests
    {
        [TestMethod]
        public void ContainsOrigin_GivenTriangleWithSpecificCoordinates_ShouldReturnTrue()
        {
            // Arrange
            var triangle = new Triangle(
                new Coordinate(-340, 495),
                new Coordinate(-153, -910),
                new Coordinate(835, -947)
            );

            // Act
            var result = triangle.ContainsOrigin();

            // Assert
            Assert.IsTrue(result);
        }
    }
}