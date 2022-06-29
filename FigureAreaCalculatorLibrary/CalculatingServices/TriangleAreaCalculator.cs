using System;

namespace FigureAreaCalculatorLibrary.CalculatingServices
{
    internal class TriangleAreaCalculator
    {
        private const string NO_TRIANGLE_EXCEPTION = "There is no triangle with such sides!";

        internal static bool IsRight(double side1, double side2, double side3)
        {
            if (side1 <= 0) throw new ArgumentOutOfRangeException(nameof(side1));
            if (side2 <= 0) throw new ArgumentOutOfRangeException(nameof(side2));
            if (side3 <= 0) throw new ArgumentOutOfRangeException(nameof(side3));

            if (side1 + side2 <= side3) throw new ArgumentOutOfRangeException(NO_TRIANGLE_EXCEPTION);
            if (side1 + side3 <= side2) throw new ArgumentOutOfRangeException(NO_TRIANGLE_EXCEPTION);
            if (side2 + side3 <= side1) throw new ArgumentOutOfRangeException(NO_TRIANGLE_EXCEPTION);


            if (Math.Pow(side1, 2) == Math.Pow(side2, 2) + Math.Pow(side3, 2)) return true;
            if (Math.Pow(side2, 2) == Math.Pow(side1, 2) + Math.Pow(side3, 2)) return true;
            if (Math.Pow(side3, 2) == Math.Pow(side1, 2) + Math.Pow(side2, 2)) return true;

            return false;
        }

        internal static double CalculateArea(double side1, double side2, double side3)
        {
            if (side1 <= 0) throw new ArgumentOutOfRangeException(nameof(side1));
            if (side2 <= 0) throw new ArgumentOutOfRangeException(nameof(side2));
            if (side3 <= 0) throw new ArgumentOutOfRangeException(nameof(side3));

            if (side1 + side2 <= side3) throw new ArgumentOutOfRangeException(NO_TRIANGLE_EXCEPTION);
            if (side1 + side3 <= side2) throw new ArgumentOutOfRangeException(NO_TRIANGLE_EXCEPTION);
            if (side2 + side3 <= side1) throw new ArgumentOutOfRangeException(NO_TRIANGLE_EXCEPTION);

            double semiperimeter = (side1 + side2 + side3) / 2;

            double triangleArea = Math.Sqrt(
                semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));

            return triangleArea;
        }
    }
}