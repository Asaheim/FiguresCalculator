using System;
using System.Collections.Generic;

namespace FiguresCalculator.Figures
{
    public class Triangle : IFigure
    {
        private List<double> sideLengthes;
        public int CornerNumber { get => 3; set => throw new NotImplementedException(); }
        public List<double> SideLengthes
        {
            get => sideLengthes;
            set
            {
               sideLengthes = value;
            }
        }

        public double CalculateArea()
        {
            double p = CalculatePerimeter() / 2;
            return Math.Sqrt(p * (p - sideLengthes[0]) * (p - sideLengthes[1]) * (p - sideLengthes[2]));
        }

        public double CalculatePerimeter()
        {
            double result = 0;
            foreach (double size in sideLengthes)
                result += size;

            return result;
        }
    }
}
