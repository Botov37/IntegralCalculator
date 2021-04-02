using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateLibrary
{
    public interface ICalculator
    {
       double Calculate(double a, double b, long n, Func<double, double> f);
    }
}
