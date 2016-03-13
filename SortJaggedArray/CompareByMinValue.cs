using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortJaggedArray
{
    public class CompareByMinValue : IComparer<int []>
    {
        /// <summary>
        /// Compare arrays according to the smallest value
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns>1/-1/0 if the smallest element is in the first/second/both arrays</returns>
        public int Compare(int[] arr1, int[] arr2)
        {
            if (arr1 == null || arr2 == null)
                throw new ArgumentNullException();

            if (arr1.Min() > arr2.Min())
                return 1;
            else if (arr1.Min() < arr2.Min())
                return -1;
            else
                return 0;
            
        }
    }
}
