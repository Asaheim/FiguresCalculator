using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresCalculator
{
    public interface IFigure
    {
        int CornerNumber { set; get; }
        List<double> SideLengthes { set; get; }
        double CalculateArea();
        double CalculatePerimeter();
    }
}
