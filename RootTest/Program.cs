using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Root;

namespace RootTest
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 16;
            int n = 3;
            
            Console.WriteLine("16 ^ 1/3: \nMath.Pow: {0} \nRoot: {1}", Math.Pow(x, (double)1 / n), CountRoot.CustomRoot(x, n));
            Console.ReadLine();
        }
    }
}
