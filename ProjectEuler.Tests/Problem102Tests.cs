// filepath: problems/Problem102Test.cs

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
                new Point(-340, 495),
                new Point(-153, -910),
                new Point(835, -947)
            );

            // Act
            var result = triangle.ContainsOrigin();

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ContainsOrigin_GivenTriangleWithSpecificCoordinates_ShouldReturnFalse()
        {
            // Arrange
            var triangle = new Triangle(
                new Point(-175, 41),
                new Point(-421, -714),
                new Point(574, -645)
            );

            // Act
            var result = triangle.ContainsOrigin();

            // Assert
            Assert.IsFalse(result);
        }
    }
}