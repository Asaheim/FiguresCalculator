using NUnit.Framework;
using FiguresCalculator;
using FiguresCalculator.Figures;
using System.Collections.Generic;
using System;

namespace FiguresCalculatorTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CircleCalculatePerimeter()
        {
            IFigure ellipse = new Ellipse { SideLengthes = new List<double> { 5, 5 } };
            double result = Math.Round(ellipse.CalculatePerimeter(), 2);
            Assert.AreEqual(31.42, result);
        }

        [Test]
        public void CirlceCalculateArea()
        {
            IFigure ellipse = new Ellipse { SideLengthes = new List<double> { 5, 5 } };
            double result = Math.Round(ellipse.CalculateArea(), 2);
            Assert.AreEqual(78.54, result);
        }

        [Test]
        public void EllipseCalculatePerimeter()
        {
            IFigure ellipse = new Ellipse { SideLengthes = new List<double> { 5, 8 } };
            double result = Math.Round(ellipse.CalculatePerimeter(),2);
            Assert.AreEqual(41.39, result);
        }

        [Test]
        public void EllipseCalculateArea()
        {
            IFigure ellipse = new Ellipse { SideLengthes = new List<double> { 5, 8 } };
            double result = Math.Round(ellipse.CalculateArea(), 2);
            Assert.AreEqual(125.66, result);
        }

        [Test]
        public void TriangleCalculatePerimeter()
        {
            IFigure triangle = new Triangle { SideLengthes = new List<double> { 5, 8, 10 } };
            double result = Math.Round(triangle.CalculatePerimeter(), 2);
            Assert.AreEqual(23, result);
        }

        [Test]
        public void TriangleCalculateArea()
        {
            IFigure triangle = new Triangle { SideLengthes = new List<double> { 5, 8, 10 } };
            double result = Math.Round(triangle.CalculateArea(), 2);
            Assert.AreEqual(19.81, result);
        }

        [Test]
        public void RectangleCalculatePerimeter()
        {
            IFigure rectangle = new Rectangle { SideLengthes = new List<double> { 8, 10 } };
            double result = Math.Round(rectangle.CalculatePerimeter(), 2);
            Assert.AreEqual(36, result);
        }

        [Test]
        public void RectangleCalculateArea()
        {
            IFigure rectangle = new Rectangle { SideLengthes = new List<double> { 8, 10 } };
            double result = Math.Round(rectangle.CalculateArea(), 2);
            Assert.AreEqual(80, result);
        }

        [Test]
        public void ParallelogramCalculatePerimeter()
        {
            IFigure parallelogram = new Parallelogram { SideLengthes = new List<double> { 8, 10, 9 } };
            double result = Math.Round(parallelogram.CalculatePerimeter(), 2);
            Assert.AreEqual(36, result);
        }

        [Test]
        public void ParallelogramCalculateArea()
        {
            IFigure parallelogram = new Parallelogram { SideLengthes = new List<double> { 8, 10, 9 } };
            double result = Math.Round(parallelogram.CalculateArea(), 2);
            Assert.AreEqual(72, result);
        }

        [Test]
        public void TrapezoidCalculatePerimeter()
        {
            IFigure trapezoid = new Trapezoid { SideLengthes = new List<double> { 8, 10, 9, 11, 7 } };
            double result = Math.Round(trapezoid.CalculatePerimeter(), 2);
            Assert.AreEqual(38, result);
        }

        [Test]
        public void TrapezoidCalculateArea()
        {
            IFigure trapezoid = new Trapezoid { SideLengthes = new List<double> { 8, 10, 9, 11, 7 } };
            double result = Math.Round(trapezoid.CalculateArea(), 2);
            Assert.AreEqual(63, result);
        }
    }
}