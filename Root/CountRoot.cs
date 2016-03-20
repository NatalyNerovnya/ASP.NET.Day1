using System;
using System.Collections.Generic;
using System.Linq;
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
            if(val == 0.0 || deg == 0 || acc == 0 || val == Double.NaN)
                throw new ArgumentException();
            if(val < 0)
                throw new ArgumentException();
            if (deg < 0)
                return (double)1 / CustomRoot(val, Math.Abs(deg), acc);
            
            double x = 1;
            double xNext = 0;

            while (true)
            {
                xNext = ((double) 1/deg)*((deg - 1)*x + val/Math.Pow(x, deg - 1));
                if(Math.Abs(Math.Pow(xNext, deg)-val) < acc)
                    return xNext;
                x = xNext;
            }
        }
}
}
