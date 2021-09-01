using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace FiguresCalculatorWPFUI.Models
{
    public class FigureModel : DependencyObject
    {
        public static DependencyProperty lengthAProperty;
        public static DependencyProperty lengthBProperty;
        public static DependencyProperty lengthCProperty;
        public static DependencyProperty lengthDProperty;
        public static DependencyProperty heightProperty;
        public static DependencyProperty perimeterProperty;
        public static DependencyProperty areaProperty;

        public double LengthA
        {
            get { return (double)GetValue(lengthAProperty); }
            set { SetValue(lengthAProperty, value); }
        }
        public double LengthB
        {
            get { return (double)GetValue(lengthBProperty); }
            set { SetValue(lengthBProperty, value); }
        }
        public double LengthC
        {
            get { return (double)GetValue(lengthCProperty); }
            set { SetValue(lengthCProperty, value); }
        }
        public double LengthD
        {
            get { return (double)GetValue(lengthDProperty); }
            set { SetValue(lengthDProperty, value); }
        }
        public double Height
        {
            get { return (double)GetValue(heightProperty); }
            set { SetValue(heightProperty, value); }
        }
        public double Perimeter
        {
            get { return (double)GetValue(perimeterProperty); }
            set { SetValue(perimeterProperty, value); }
        }
        public double Area
        {
            get { return (double)GetValue(areaProperty); }
            set { SetValue(areaProperty, value); }
        }

        static FigureModel()
        {
            lengthAProperty = DependencyProperty.Register("LengthA", typeof(double), typeof(FigureModel));
            lengthBProperty = DependencyProperty.Register("LengthB", typeof(double), typeof(FigureModel));
            lengthCProperty = DependencyProperty.Register("LengthC", typeof(double), typeof(FigureModel));
            lengthDProperty = DependencyProperty.Register("LengthD", typeof(double), typeof(FigureModel));
            heightProperty = DependencyProperty.Register("Height", typeof(double), typeof(FigureModel));
            perimeterProperty = DependencyProperty.Register("Perimeter", typeof(double), typeof(FigureModel));
            areaProperty = DependencyProperty.Register("Area", typeof(double), typeof(FigureModel));
        }

        public void Clean()
        {
            LengthA = 0;
            LengthB = 0;
            LengthC = 0;
            LengthD = 0;
            Height = 0;
            Perimeter = 0;
            Area = 0;
        }
    }
}
