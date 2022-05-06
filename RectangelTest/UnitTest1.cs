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
            Quadrilateral rect = new Quadrilateral(point1, point2, point3, point4);
            Assert.AreEqual("Квадрат", rect.GetFigureType());
        }
        [TestMethod]
        public void RhombTest()
        {
            Point point1 = new Point(-1, 0);
            Point point2 = new Point(1, 0);
            Point point3 = new Point(0, 2);
            Point point4 = new Point(0, -2);
            Quadrilateral rect = new Quadrilateral(point1, point2, point3, point4);
            Assert.AreEqual("Ромб", rect.GetFigureType());
        }
        [TestMethod]
        public void RectangleTest()
        {
            Point point1 = new Point(-2, -1);
            Point point2 = new Point(-2, 1);
            Point point3 = new Point(2, 1);
            Point point4 = new Point(2, -1);
            Quadrilateral rect = new Quadrilateral(point1, point2, point3, point4);
            Assert.AreEqual("Прямоугольник", rect.GetFigureType());
        }
        [TestMethod]
        public void ParallelogramTest()
        {
            Point point1 = new Point(-2, -1);
            Point point2 = new Point(-1, 1);
            Point point3 = new Point(2, 1);
            Point point4 = new Point(1, -1);
            Quadrilateral rect = new Quadrilateral(point1, point2, point3, point4);
            Assert.AreEqual("Параллелограмм", rect.GetFigureType());
        }
        [TestMethod]
        public void IsoscelesTrapezoidTest()
        {
            Point point1 = new Point(1, 1);
            Point point2 = new Point(-1, 1);
            Point point3 = new Point(2, -1);
            Point point4 = new Point(-2, -1);
            Quadrilateral rect = new Quadrilateral(point1, point2, point3, point4);
            Assert.AreEqual("Равнобедренная трапеция", rect.GetFigureType());
        }
        [TestMethod]
        public void RectangularTrapezoidTest()
        {
            Point point1 = new Point(1, 1);
            Point point2 = new Point(-1, 1);
            Point point3 = new Point(2, -1);
            Point point4 = new Point(-1, -1);
            Quadrilateral rect = new Quadrilateral(point1, point2, point3, point4);
            Assert.AreEqual("Прямоугольная трапеция", rect.GetFigureType());
        }
        [TestMethod]
        public void CammonTrapezoidTest()
        {
            Point point1 = new Point(-2, 0);
            Point point2 = new Point(3, 0);
            Point point3 = new Point(1, 1);
            Point point4 = new Point(2, 1);
            Quadrilateral rect = new Quadrilateral(point1, point2, point3, point4);
            Assert.AreEqual("Трапеция общего вида", rect.GetFigureType());
        }
        [TestMethod]
        public void CommonQuadrilateralTest()
        {
            Point point1 = new Point(1, 0);
            Point point2 = new Point(0, 3);
            Point point3 = new Point(2, 6);
            Point point4 = new Point(7, 2);
            Quadrilateral rect = new Quadrilateral(point1, point2, point3, point4);
            Assert.AreEqual("Четырехугольник общего вида", rect.GetFigureType());
        }

        [TestMethod]
        public void TriangleTest()
        {
            Point point1 = new Point(1, 0);
            Point point2 = new Point(0, 0);
            Point point3 = new Point(-1, 0);
            Point point4 = new Point(0, 2);
            Quadrilateral rect = new Quadrilateral(point1, point2, point3, point4);
            Assert.AreEqual("Не четырехугольник", rect.GetFigureType());
        }
        [TestMethod]
        public void LineTest()
        {
            Point point1 = new Point(1, 0);
            Point point2 = new Point(2, 0);
            Point point3 = new Point(3, 0);
            Point point4 = new Point(4, 0);
            Quadrilateral rect = new Quadrilateral(point1, point2, point3, point4);
            Assert.AreEqual("Не четырехугольник", rect.GetFigureType());
        }

        [TestMethod]
        public void SamePointTest()
        {
            Point point1 = new Point(1, 1);
            Point point2 = new Point(-1, -1);
            Point point3 = new Point(-1, 1);
            Point point4 = new Point(1, 1);
            Quadrilateral rect = new Quadrilateral(point1, point2, point3, point4);
            Assert.AreEqual("Некоторые точки дублируются!", rect.GetFigureType());
        }
    }
}
