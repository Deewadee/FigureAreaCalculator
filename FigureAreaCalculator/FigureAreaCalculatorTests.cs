using System;
using Xunit;
using FigureAreaCalculatorLibrary;
using FigureAreaCalculatorLibrary.Figures;

namespace FigureAreaCalculatorTests
{
    public class FigureAreaCalculatorTests
    {
        [Fact]
        public void Library_ShouldNotCreate_ImpossibleTriangle()
        {
            int side1 = 3;
            int side2 = 4;
            int side3 = 7;

            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(side1, side2, side3));
        }

        [Fact]
        public void Library_ShouldNotCreate_ImpossibleCircle()
        {
            int radius = 0;

            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
        }

        [Fact]
        public void Calculator_ShouldNotCalculate_AreaOfImpossibleTriangle_V1()
        {
            int side1 = 3;
            int side2 = 4;
            int side3 = 7;

            Calculator calculator = new Calculator();

            Assert.Throws<ArgumentOutOfRangeException>(() => calculator.CalculateTriangleArea(side1, side2, side3));
        }

        [Fact]
        public void Calculator_ShouldNotCalculate_AreaOfImpossibleTriangle_V2()
        {
            int side1 = 3;
            int side2 = 0;
            int side3 = -3;

            Calculator calculator = new Calculator();

            Assert.Throws<ArgumentOutOfRangeException>(() => calculator.CalculateTriangleArea(side1, side2, side3));
        }

        [Fact]
        public void Calculator_ShouldNotCalculate_AreaOfImpossibleCircle_V1()
        {
            int radius = 0;

            Calculator calculator = new Calculator();

            Assert.Throws<ArgumentOutOfRangeException>(() => calculator.CalculateCircleArea(radius));
        }

        [Fact]
        public void Calculator_ShouldNotCalculate_AreaOfImpossibleCircle_V2()
        {
            int radius = -3;

            Calculator calculator = new Calculator();

            Assert.Throws<ArgumentOutOfRangeException>(() => calculator.CalculateCircleArea(radius));
        }

        [Fact]
        public void Calculator_ShouldCalculate_TriangleAreaBySides()
        {
            int side1 = 3;
            int side2 = 4;
            int side3 = 3;

            double semiperimeter = (side1 + side2 + side3) / 2;

            double expectedAreaValue = Math.Sqrt(
                semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));

            Calculator calculator = new Calculator();

            double result = calculator.CalculateTriangleArea(side1, side2, side3);

            Assert.Equal(expectedAreaValue, result);
        }

        [Fact]
        public void Calculator_ShouldCalculateArea_CircleAreaByRadius()
        {
            int radius = 3;

            double expectedAreaValue = Math.PI * Math.Pow(radius, 2);

            Calculator calculator = new Calculator();

            double result = calculator.CalculateCircleArea(radius);

            Assert.Equal(expectedAreaValue, result);
        }

        [Fact]
        public void Triangle_IsNotRight()
        {
            int side1 = 4;
            int side2 = 4;
            int side3 = 2;

            Triangle triangle = new Triangle(side1, side2, side3);

            Assert.False(triangle.IsRight);
        }

        [Fact]
        public void Triangle_IsRight()
        {
            int side1 = 3;
            int side2 = 4;
            int side3 = 5;

            Triangle triangle = new Triangle(side1, side2, side3);

            Assert.True(triangle.IsRight);
        }
    }
}
