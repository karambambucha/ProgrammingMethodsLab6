using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquationTestInterface;
using System;

namespace EquationTest
{
    [TestClass]
    public class EquationUnitTest1
    {
        [TestMethod]
        public void EllipseTest()
        {
            Equation equation = new Equation(5,0,5,4,9,8);
            Assert.AreEqual("эллипс", equation.GetEquationType());
        }
        [TestMethod]
        public void ParabolaTest()
        {
            Equation equation = new Equation(1, 1, 1, 4, 6, 7);
            Assert.AreEqual("парабола", equation.GetEquationType());
        }
        [TestMethod]
        public void HyperbolaTest()
        {
            Equation equation = new Equation(2, 3, 0, 5, 6, 9);
            Assert.AreEqual("гипербола", equation.GetEquationType());
        }
        [TestMethod]
        public void PointTest()
        {
            Equation equation = new Equation(5, 2, 4, 4, 8, 16);
            Assert.AreEqual("пересекающиеся мнимые прямые (точка)", equation.GetEquationType());
        }
        [TestMethod]
        public void ParallelLinesTest()
        {
            Equation equation = new Equation(1, 2, 4, 3, 6, 1);
            Assert.AreEqual("две параллельные прямые", equation.GetEquationType());
        }
        [TestMethod]
        public void CrossingLinesTest()
        {
            Equation equation = new Equation(0, 2, 4, 4, 8, 16);
            Assert.AreEqual("две пересекающиеся действительные прямые", equation.GetEquationType());
        }

    }
}
