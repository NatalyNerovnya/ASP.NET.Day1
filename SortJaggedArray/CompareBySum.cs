using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortJaggedArray
{
    public class CompareBySum : IComparer<int []>
    {
        /// <summary>
        /// Compare arrays according to the sum of elements
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns>1/-1/0 if the sum of element is in the first array is smaller/bigger/equal to the sum of elements in the second array <</returns>
        public int Compare(int[] arr1, int[] arr2)
        {
            if (arr1 == null || arr2 == null)
                throw new ArgumentNullException();
            
            if (arr1.Sum() > arr2.Sum())
                return 1;
            else if (arr1.Sum() < arr2.Sum())
                return -1;
            else
                return 0;
        }
    }
}
