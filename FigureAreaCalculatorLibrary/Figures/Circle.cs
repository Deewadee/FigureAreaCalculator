using System;
using FigureAreaCalculatorLibrary.CalculatingServices;

namespace FigureAreaCalculatorLibrary.Figures
{
    internal class Circle : Figure
    {
        public Circle(double radius)
        {
            if (radius <= 0) throw new ArgumentOutOfRangeException(nameof(radius));

            Radius = radius;
        }

        internal double Radius { get; }
        public override double Area 
        {
            get
            {
                return CircleAreaCalculator.CalculateArea(Radius);
            }
        }
    }
}