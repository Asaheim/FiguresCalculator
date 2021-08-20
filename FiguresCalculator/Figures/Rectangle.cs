using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresCalculator.Figures
{
    public class Rectangle: IFigure
    {
        private List<double> sideLengthes;
        public int CornerNumber { get => 4; set => throw new NotImplementedException(); }
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
            return sideLengthes[0] * sideLengthes[1];
        }

        public double CalculatePerimeter()
        {
            double result = 0;
            foreach (double size in sideLengthes)
                result += size;

            return result * 2;
        }
    }
}
