using System;
using System.Collections.Generic;
using FiguresCalculator;

namespace FiguresCalculatorComsoleUI
{
    class FiguresCalculatorConsoleUI
    {
        static void Main(string[] args)
        {
            int figureType = 0;
            SelectFigureTypeTextWrite();
            figureType = Convert.ToInt32(Console.ReadLine());
            FigureCalculator figuresCalculator = new FigureCalculator(figureType, EnterSideLengthes(figureType));
            Console.WriteLine();
            Console.WriteLine("Figure perimeter is " + figuresCalculator.CalculatePerimeter());
            Console.WriteLine("Figure area is " + figuresCalculator.CalculateArea());
            Console.ReadLine();
        }

        private static void SelectFigureTypeTextWrite()
        {
            Console.WriteLine("Please select Figure type");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Ellipse");
            Console.WriteLine("3. Triangle");
            Console.WriteLine("4. Square");
            Console.WriteLine("5. Rectangle");
            Console.WriteLine("6. Parallelogram");
            Console.WriteLine("7. Trapezoid");
        }

        private static List<double> EnterSideLengthes(int figureType)
        {
            List<double> sideLengthes = new List<double>();
            
            switch (figureType)
            {
                case 1:
                    Console.WriteLine("Please enter radius length");
                    sideLengthes.Add(Convert.ToDouble(Console.ReadLine()));
                    break;
                case 2:
                    Console.WriteLine("Please enter semi-major axis length");
                    sideLengthes.Add(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Please enter semi-minor axis length");
                    sideLengthes.Add(Convert.ToDouble(Console.ReadLine()));
                    break;
                case 3:
                    Console.WriteLine("Please enter side A length");
                    sideLengthes.Add(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Please enter side B length");
                    sideLengthes.Add(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Please enter side C length");
                    sideLengthes.Add(Convert.ToDouble(Console.ReadLine()));
                    break;
                case 4:
                    Console.WriteLine("Please enter side length");
                    sideLengthes.Add(Convert.ToDouble(Console.ReadLine()));
                    break;
                case 5:
                    Console.WriteLine("Please enter side A length");
                    sideLengthes.Add(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Please enter side B length");
                    sideLengthes.Add(Convert.ToDouble(Console.ReadLine()));
                    break;
                case 6:
                    Console.WriteLine("Please enter side A length");
                    sideLengthes.Add(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Please enter side B length");
                    sideLengthes.Add(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Please enter height length");
                    sideLengthes.Add(Convert.ToDouble(Console.ReadLine()));
                    break;
                case 7:
                    Console.WriteLine("Please enter side A length");
                    sideLengthes.Add(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Please enter side B length");
                    sideLengthes.Add(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Please enter side C length");
                    sideLengthes.Add(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Please enter side D length");
                    sideLengthes.Add(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("Please enter height length");
                    sideLengthes.Add(Convert.ToDouble(Console.ReadLine()));
                    break;
                default:
                    Console.WriteLine("Wrong Figure");
                    break;
            }
            return sideLengthes;
        }
    }
}
