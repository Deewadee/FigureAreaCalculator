using System;
using FigureAreaCalculatorLibrary.CalculatingServices;

namespace FigureAreaCalculatorLibrary.Figures
{
    internal class Triangle : Figure
    {
        private const string NO_TRIANGLE_EXCEPTION = "There is no triangle with such sides!";
        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0) throw new ArgumentOutOfRangeException(nameof(side1));
            if (side2 <= 0) throw new ArgumentOutOfRangeException(nameof(side2));
            if (side3 <= 0) throw new ArgumentOutOfRangeException(nameof(side3));

            if (side1 + side2 <= side3) throw new ArgumentOutOfRangeException(NO_TRIANGLE_EXCEPTION);
            if (side1 + side3 <= side2) throw new ArgumentOutOfRangeException(NO_TRIANGLE_EXCEPTION);
            if (side2 + side3 <= side1) throw new ArgumentOutOfRangeException(NO_TRIANGLE_EXCEPTION);

            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        internal double Side1 { get; }
        internal double Side2 { get; }
        internal double Side3 { get; }
        public bool IsRight
        {
            get
            {
                return TriangleAreaCalculator.IsRight(Side1, Side2, Side3);
            }
        }
        public override double Area
        {
            get
            {
                return TriangleAreaCalculator.CalculateArea(Side1, Side2, Side3);
            }
        }
    }
}