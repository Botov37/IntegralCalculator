using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateLibrary
{
    public class Simpson : ICalculator
    {
        public double Calculate(double a, double b, long n, Func<double, double> f)
        {
            if (n <= 0)
            {
                throw new ArgumentException();
            }
            var h = (b - a) / n;
            var sum = 0d;
            var sum2 = 0d;
            for (var k = 1; k <= n; k++)
            {
                var xk = a + k * h;
                if (k <= n - 1)
                {
                    sum += f(xk);
                }

                var xk_1 = a + (k - 1) * h;
                sum2 += f((xk + xk_1) / 2);

            }

            var result = h / 3d * (1d / 2d * f(a) + sum + 2 * sum2 + 1d / 2d * f(b));
            return result;

        }



    }
}
