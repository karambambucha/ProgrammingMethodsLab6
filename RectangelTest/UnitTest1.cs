using Microsoft.VisualStudio.TestTools.UnitTesting;
using RectangelTestInterface;
using System;

namespace RectangelTest
{
    [TestClass]
    public class RectangelTests1
    {
        [TestMethod]
        public void SquareTest()
        {
            Point point1 = new Point(-1, -1);
            Point point2 = new Point(1, 1);
            Point point3 = new Point(-1, 1);
            Point point4 = new Point(1, -1);
            Rectangle rect = new Rectangle(point1, point2, point3, point4);
            Assert.AreEqual("Квадрат", rect.BoxTest());
        }
        [TestMethod]
        public void RhombTest()
        {
            Point point1 = new Point(-1, 0);
            Point point2 = new Point(1, 0);
            Point point3 = new Point(0, 2);
            Point point4 = new Point(0, -2);
            Rectangle rect = new Rectangle(point1, point2, point3, point4);
            Assert.AreEqual("Ромб", rect.BoxTest());
        }
        [TestMethod]
        public void RectangleTest()
        {
            Point point1 = new Point(-2, -1);
            Point point2 = new Point(-2, 1);
            Point point3 = new Point(2, 1);
            Point point4 = new Point(2, -1);
            Rectangle rect = new Rectangle(point1, point2, point3, point4);
            Assert.AreEqual("Прямоугольник", rect.BoxTest());
        }
        [TestMethod]
        public void ParallelogramTest()
        {
            Point point1 = new Point(-2, -1);
            Point point2 = new Point(-1, 1);
            Point point3 = new Point(2, 1);
            Point point4 = new Point(1, -1);
            Rectangle rect = new Rectangle(point1, point2, point3, point4);
            Assert.AreEqual("Параллелограмм", rect.BoxTest());
        }
        [TestMethod]
        public void IsoscelesTrapezoidTest()
        {
            Point point1 = new Point(1, 1);
            Point point2 = new Point(-1, 1);
            Point point3 = new Point(2, -1);
            Point point4 = new Point(-2, -1);
            Rectangle rect = new Rectangle(point1, point2, point3, point4);
            Assert.AreEqual("Равнобедренная трапеция", rect.BoxTest());
        }
        [TestMethod]
        public void RectangularTrapezoidTest()
        {
            Point point1 = new Point(1, 1);
            Point point2 = new Point(-1, 1);
            Point point3 = new Point(2, -1);
            Point point4 = new Point(-1, -1);
            Rectangle rect = new Rectangle(point1, point2, point3, point4);
            Assert.AreEqual("Прямоугольная трапеция", rect.BoxTest());
        }
        [TestMethod]
        public void CammonTrapezoidTest()
        {
            Point point1 = new Point(-2, 0);
            Point point2 = new Point(3, 0);
            Point point3 = new Point(1, 1);
            Point point4 = new Point(2, 1);
            Rectangle rect = new Rectangle(point1, point2, point3, point4);
            Assert.AreEqual("Трапеция общего вида", rect.BoxTest());
        }
        [TestMethod]
        public void CommonQuadrilateralTest()
        {
            Point point1 = new Point(1, 0);
            Point point2 = new Point(0, 3);
            Point point3 = new Point(2, 6);
            Point point4 = new Point(7, 2);
            Rectangle rect = new Rectangle(point1, point2, point3, point4);
            Assert.AreEqual("Четырехугольник общего вида", rect.BoxTest());
        }

    }
    [TestClass]
    public class RectangelTests2
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
    }
}
