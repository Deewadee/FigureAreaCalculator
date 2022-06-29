using System;

namespace FigureAreaCalculatorLibrary.CalculatingServices
{
    internal class CircleAreaCalculator
    {
        internal static double CalculateArea(double radius)
        {
            if (radius <= 0) throw new ArgumentOutOfRangeException(nameof(radius));

            double circleArea = Math.PI * Math.Pow(radius, 2);

            return circleArea;
        }
    }
}