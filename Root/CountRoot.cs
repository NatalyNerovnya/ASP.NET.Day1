using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Root
{
    /// <summary>
    /// Сalculates the root of the n-th degree of the value by Newton's method with the specified accuracy
    /// </summary>
    public class CountRoot
    {
        /// <summary>
        /// Сalculates the root of the n-th degree of the value by Newton's method with the specified accuracy
        /// </summary>
        /// <param name="val">The base</param>
        /// <param name="deg">Degree of root</param>
        /// <param name="acc">Accuracy</param>
        /// <returns></returns>
        public static double CustomRoot(double val, int deg, double acc = 0.0001)
        {
            if (val == 0.0 || deg == 0 || acc == 0 || val == Double.NaN)
                throw new ArgumentException();
            if (val < 0)
                throw new ArgumentException();
            if (deg < 0)
                return (double)1 / CustomRoot(val, Module(deg), acc);

            double x = 1;
            double xNext = 0;

            while (true)
            {
                xNext = ((double)1 / deg) * ((deg - 1) * x + val / Power(x, deg - 1));
                if (Module(Power(xNext, deg) - val) < acc)
                    return xNext;
                x = xNext;
            }
        }
        /// <summary>
        /// Count the power of the number
        /// </summary>
        /// <param name="x">base</param>
        /// <param name="n">degree</param>
        /// <returns>The power of number</returns>
        private static double Power(double x, int n)
        {
            if (x == Double.NaN)
                return Double.NaN;
            if (x == 0 && n > 0 || x == Double.NegativeInfinity && n < 0 || x == Double.PositiveInfinity && n < 0)
                return 0;
            if (n == 0 || x == 1)
                return 1;
            if (x == Double.NegativeInfinity && n > 0 && n % 2 != 0)
                return Double.NegativeInfinity;
            if (x == Double.NegativeInfinity && n > 0 && n % 2 == 0 || x == 0 && n < 0 || x == Double.PositiveInfinity && n > 0)
                return Double.PositiveInfinity;

            double result = 1;
            for (int i = 0; i < n; i++)
            {
                result *= x;
            }
            return result;
        }

        /// <summary>
        /// Count module of double number
        /// </summary>
        /// <param name="x">Number</param>
        /// <returns>Positive number</returns>
        private static double Module(double x)
        {
            if(x == Double.NaN)
                return Double.NaN;
            if(x == Double.PositiveInfinity || x == Double.NegativeInfinity)
                return Double.PositiveInfinity;

            return x >= 0 ? x : -x;
        }

        /// <summary>
        /// Count module of integer number
        /// </summary>
        /// <param name="x">Number</param>
        /// <returns>Positive number</returns>
        private static int Module(int x)
        {
            return (int) Module((double)x);
        }
    }
}
