using System;
using FigureAreaCalculatorLibrary.Figures;

namespace FigureAreaCalculatorLibrary
{
    public class Calculator
    {
        public double CalculateTriangleArea(double side1, double side2, double side3)
        {
            if (side1 <= 0) throw new ArgumentOutOfRangeException(nameof(side1));
            if (side2 <= 0) throw new ArgumentOutOfRangeException(nameof(side2));
            if (side3 <= 0) throw new ArgumentOutOfRangeException(nameof(side3));

            Triangle triangle;

            try
            {
                triangle = new Triangle(side1, side2, side3);

                return triangle.Area;
            }
            catch
            {
                throw;
            }
        }

        public double CalculateCircleArea(double radius)
        {
            if (radius <= 0) throw new ArgumentOutOfRangeException(nameof(radius));

            Circle circle;

            try
            {
                circle = new Circle(radius);

                return circle.Area;
            }
            catch
            {
                throw;
            }
        }
    }
}
