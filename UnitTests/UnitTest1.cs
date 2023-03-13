using CodingTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShapeConstructs()
        {
            // Arrange
            string expectedColor = "Red";
            string expectedName = "Square";

            // Act
            var shape = new Shape(expectedColor, expectedName);

            // Assert
            Assert.AreEqual(expectedColor, shape.Color);
            Assert.AreEqual(expectedName, shape.Name);
            Assert.IsNotNull(shape.Children);
        }
    }
}