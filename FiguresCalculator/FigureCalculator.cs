using FiguresCalculator.Enum;
using FiguresCalculator.Figures;
using System;
using System.Collections.Generic;

namespace FiguresCalculator
{
    public class FigureCalculator
    {
        private FiguresTypes figureType;
        private IFigure figure;

        public FigureCalculator(int figuresType, List<double> sideLengthes)
        {
            try
            {
                this.figureType = (FiguresTypes)figuresType;
                SetFigure(sideLengthes);
            }
            catch (Exception e)
            { }
        }

        public FigureCalculator(FiguresTypes figuresType, List<double> sideLengthes)
        {
            try
            {
                this.figureType = figuresType;
                SetFigure(sideLengthes);
            }
            catch (Exception e)
            { }
        }

        private void SetFigure(List<double> sideLengthes)
        {
            switch (figureType)
            {
                case FiguresTypes.Circle:
                    figure = new Ellipse();
                    figure.SideLengthes = new List<double> { sideLengthes[0], sideLengthes[0] };
                    break;
                case FiguresTypes.Ellipse:
                    figure = new Ellipse();
                    figure.SideLengthes = sideLengthes;
                    break;
                case FiguresTypes.Triangle:
                    figure = new Triangle();
                    figure.SideLengthes = sideLengthes;
                    break;
                case FiguresTypes.Square:
                    figure = new Rectangle();
                    figure.SideLengthes = new List<double> { sideLengthes[0], sideLengthes[0] };
                    break;
                case FiguresTypes.Rectangle:
                    figure = new Rectangle();
                    figure.SideLengthes = sideLengthes;
                    break;
                case FiguresTypes.Parallelogram:
                    figure = new Parallelogram();
                    figure.SideLengthes = sideLengthes;
                    break;
                case FiguresTypes.Trapezoid:
                    figure = new Trapezoid();
                    figure.SideLengthes = sideLengthes;
                    break;
            }
        }
        public double CalculateArea()
        {
            return figure.CalculateArea();
        }
        public double CalculatePerimeter()
        {
            return figure.CalculatePerimeter();
        }

    }
}
