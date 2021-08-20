using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresCalculator.Figures
{
    public class Parallelogram : IFigure
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
            return sideLengthes[0] * sideLengthes[2];
        }

        public double CalculatePerimeter()
        {
            return 2 * (sideLengthes[0] + sideLengthes[1]);
        }
    }
}
