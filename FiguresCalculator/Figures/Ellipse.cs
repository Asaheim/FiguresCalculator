using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresCalculator.Figures
{
    public class Ellipse : IFigure
    {
        private List<double> sideLengthes;
        public int CornerNumber { get => 0; set => throw new NotImplementedException(); }
        public List<double> SideLengthes { 
            get => sideLengthes;
            set
            {
                sideLengthes = value;
            } 
        }

        public double CalculateArea()
        {
            return Math.PI * sideLengthes[0] * sideLengthes[1];
        }

        public double CalculatePerimeter()
        {            
            return Math.PI * (3 * (sideLengthes[0] + sideLengthes[1]) - Math.Sqrt((3 * sideLengthes[0] + sideLengthes[1]) * (sideLengthes[0] + 3 * sideLengthes[1])));
        }
    }
}
