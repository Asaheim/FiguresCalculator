using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FiguresCalculator;

namespace FiguresCalculatorWPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private FiguresTypes figuresType;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RbFigure_Checked(object sender, RoutedEventArgs e)
        {
            Clean();
            RadioButton pressed = (RadioButton)sender;
            lbWaitingFigure.Visibility = Visibility.Collapsed;
            btnCalculate.Visibility = Visibility.Visible;
            switch (pressed.Name)
            {
                case "rbCircle":
                    lbEnterSizeA.Visibility = Visibility.Visible;
                    lbEnterSizeA.Content = "Radius";
                    tbSizeA.Visibility = Visibility.Visible;
                    figuresType = FiguresTypes.Circle;
                    break;
                case "rbEllipse":
                    lbEnterSizeA.Visibility = Visibility.Visible;
                    lbEnterSizeA.Content = "Semi-major axis";
                    lbEnterSizeB.Visibility = Visibility.Visible;
                    lbEnterSizeB.Content = "Semi-minor axis";
                    tbSizeA.Visibility = Visibility.Visible;
                    tbSizeB.Visibility = Visibility.Visible;
                    figuresType = FiguresTypes.Ellipse;
                    break;
                case "rbTriangle":
                    lbEnterSizeA.Visibility = Visibility.Visible;
                    lbEnterSizeB.Visibility = Visibility.Visible;
                    lbEnterSizeC.Visibility = Visibility.Visible;
                    tbSizeA.Visibility = Visibility.Visible;
                    tbSizeB.Visibility = Visibility.Visible;
                    tbSizeC.Visibility = Visibility.Visible;
                    figuresType = FiguresTypes.Triangle;
                    break;
                case "rbSquare":
                    lbEnterSizeA.Visibility = Visibility.Visible;
                    lbEnterSizeB.Visibility = Visibility.Visible;
                    tbSizeA.Visibility = Visibility.Visible;
                    tbSizeB.Visibility = Visibility.Visible;
                    figuresType = FiguresTypes.Square;
                    break;
                case "rbRectangle":
                    lbEnterSizeA.Visibility = Visibility.Visible;
                    lbEnterSizeB.Visibility = Visibility.Visible;
                    tbSizeA.Visibility = Visibility.Visible;
                    tbSizeB.Visibility = Visibility.Visible;
                    figuresType = FiguresTypes.Rectangle;
                    break;
                case "rbParallelogram":
                    lbEnterSizeA.Visibility = Visibility.Visible;
                    lbEnterSizeB.Visibility = Visibility.Visible;
                    lbEnterSizeH.Visibility = Visibility.Visible;
                    tbSizeA.Visibility = Visibility.Visible;
                    tbSizeB.Visibility = Visibility.Visible;
                    tbSizeH.Visibility = Visibility.Visible;
                    figuresType = FiguresTypes.Parallelogram;
                    break;
                case "rbTrapezoid":
                    lbEnterSizeA.Visibility = Visibility.Visible;
                    lbEnterSizeB.Visibility = Visibility.Visible;
                    lbEnterSizeC.Visibility = Visibility.Visible;
                    lbEnterSizeD.Visibility = Visibility.Visible;
                    lbEnterSizeH.Visibility = Visibility.Visible;
                    tbSizeA.Visibility = Visibility.Visible;
                    tbSizeB.Visibility = Visibility.Visible;
                    tbSizeC.Visibility = Visibility.Visible;
                    tbSizeD.Visibility = Visibility.Visible;
                    tbSizeH.Visibility = Visibility.Visible;
                    figuresType = FiguresTypes.Trapezoid;
                    break;
                default:
                    lbWaitingFigure.Visibility = Visibility.Visible;
                    lbWaitingFigure.Content = "Wrong Figure";
                    break;
            }
           
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            grdResults.Visibility = Visibility.Visible;
            List<double> sideLengthes = new List<double>();
            switch (figuresType)
            {
                case FiguresTypes.Circle:                   
                    sideLengthes.Add(Convert.ToDouble(tbSizeA.Text));
                    break;
                case FiguresTypes.Ellipse:                    
                    sideLengthes.Add(Convert.ToDouble(tbSizeA.Text));
                    sideLengthes.Add(Convert.ToDouble(tbSizeB.Text));
                    break;
                case FiguresTypes.Triangle:
                    sideLengthes.Add(Convert.ToDouble(tbSizeA.Text));
                    sideLengthes.Add(Convert.ToDouble(tbSizeB.Text));
                    sideLengthes.Add(Convert.ToDouble(tbSizeC.Text));
                    break;
                case FiguresTypes.Square:
                    sideLengthes.Add(Convert.ToDouble(tbSizeA.Text));
                    sideLengthes.Add(Convert.ToDouble(tbSizeB.Text));
                    break;
                case FiguresTypes.Rectangle:
                    sideLengthes.Add(Convert.ToDouble(tbSizeA.Text));
                    sideLengthes.Add(Convert.ToDouble(tbSizeB.Text));
                    break;
                case FiguresTypes.Parallelogram:
                    sideLengthes.Add(Convert.ToDouble(tbSizeA.Text));
                    sideLengthes.Add(Convert.ToDouble(tbSizeB.Text));
                    sideLengthes.Add(Convert.ToDouble(tbSizeH.Text));
                    break;
                case FiguresTypes.Trapezoid:
                    sideLengthes.Add(Convert.ToDouble(tbSizeA.Text));
                    sideLengthes.Add(Convert.ToDouble(tbSizeB.Text));
                    sideLengthes.Add(Convert.ToDouble(tbSizeC.Text));
                    sideLengthes.Add(Convert.ToDouble(tbSizeD.Text));
                    sideLengthes.Add(Convert.ToDouble(tbSizeH.Text));
                    break;
                default:
                    lbWaitingFigure.Visibility = Visibility.Visible;
                    lbWaitingFigure.Content = "Wrong Figure";
                    break;
            }
            FigureCalculator figuresCalculator = new FigureCalculator(figuresType, sideLengthes);
            tbPerimeter.Text = figuresCalculator.CalculatePerimeter().ToString();
            tbArea.Text = figuresCalculator.CalculateArea().ToString();
        }

        private void Clean()
        {
            lbWaitingFigure.Visibility = Visibility.Visible;
            lbEnterSizeA.Visibility = Visibility.Collapsed;
            lbEnterSizeA.Content = "Size A";
            lbEnterSizeB.Visibility = Visibility.Collapsed;
            lbEnterSizeB.Content = "Size B";
            lbEnterSizeC.Visibility = Visibility.Collapsed;
            lbEnterSizeC.Content = "Size C";
            lbEnterSizeD.Visibility = Visibility.Collapsed;
            lbEnterSizeD.Content = "Size D";
            lbEnterSizeH.Visibility = Visibility.Collapsed;
            tbSizeA.Visibility = Visibility.Collapsed;
            tbSizeA.Text = "";
            tbSizeB.Visibility = Visibility.Collapsed;
            tbSizeB.Text = "";
            tbSizeC.Visibility = Visibility.Collapsed;
            tbSizeC.Text = "";
            tbSizeD.Visibility = Visibility.Collapsed;
            tbSizeD.Text = "";
            tbSizeH.Visibility = Visibility.Collapsed;
            tbSizeH.Text = "";
            grdResults.Visibility = Visibility.Collapsed;
            tbArea.Text = "";
            tbPerimeter.Text = "";
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
