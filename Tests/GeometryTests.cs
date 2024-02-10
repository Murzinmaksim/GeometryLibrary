using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryLibrary.Tests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void CircleAreaTest()
        {
            Circle circle = new Circle(5);

            Assert.AreEqual(78.54, circle.GetArea(), 0.01);
        }

        [TestMethod]
        public void TriangleAreaTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            Assert.AreEqual(6, triangle.GetArea());
        }

        [TestMethod]
        public void RightAngleTriangleTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            Assert.IsTrue(triangle.IsRightAngleTriangle());
        }
    }
}
