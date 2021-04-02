using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
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
using CalculateLibrary;
using OxyPlot;

namespace IntegralSolution
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btCalculate_Click(object sender, RoutedEventArgs e)
        {
            var time = Calculate();
            DrawGraph(time);
        }

        private void DrawGraph(ICollection<(double Time, int PointCount)> times)
        {
            var model = DataContext as MainViewModel;
            model.Points.Clear();
            graph.InvalidatePlot(true);

            foreach (var (time, count) in times)
            {
                model.Points.Add(new DataPoint(count, time));
            }

            graph.InvalidatePlot(true);
        }

        private void ClearGraph()
        {
            var model = DataContext as MainViewModel;
            model.Points.Clear();
            graph.InvalidatePlot(true);
        }

        private ICollection<(double Time, int PointCount)> Calculate()
        {
            var a = Convert.ToDouble(tbLowerBound.Text);
            var b = Convert.ToDouble(tbUpperBound.Text);
            var n = Convert.ToInt64(tbN.Text);

            var calculator = GetCalculator();
            var time = new List<(double, int)>();

            double result = 0.0;
            for (var i = 1000; i < n; i += 1000)
            {
                var timeStart = DateTime.Now;
                result = calculator.Calculate(a, b, i, x => 7 * x - Math.Log(7 * x) + 8);
                var timeStop = DateTime.Now;
                time.Add(((timeStop - timeStart).TotalMilliseconds, i));
            }

            tbResult.Text = Convert.ToString(result);

            return time;
        }

        private ICalculator GetCalculator()
        {
            switch (cbmMethod.SelectedIndex)
            {
                case 0:
                    {
                        return new RectangleCalculator();
                    }
                case 1:
                    {
                        return new TrapCalculator();
                    }
                default:
                    {
                        return new RectangleCalculator();
                    }
            }
        }
        private void btClear_Click(object sender, RoutedEventArgs e)
        {
            ClearGraph();
        }
    }
}
