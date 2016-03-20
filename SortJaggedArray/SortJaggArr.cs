using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortJaggedArray
{
    /// <summary>
    /// Class for sorting jagged array
    /// </summary>
    public class SortJaggArr
    {
        #region  Public Methods
        /// <summary>
        /// Sorting method with users' comparer
        /// </summary>
        /// <param name="arr">Array for sorting</param>
        /// <param name="comparer">Comparer according to which array will be sorted</param>

        public static void SortArray(int[][] arr, IComparer<int[]> comparer)
        {
            
            if (comparer == null || arr == null)
                throw new ArgumentNullException();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (comparer.Compare(arr[i], arr[j]) == 1)
                    {
                        Swap(ref arr[i], ref arr[j]);
                    }
                }
            }
        }
        /// <summary>
        /// Sorting according the greatest element in the raw
       /// </summary>
        /// <param name="arr">Array for sorting</param>
        public static void SortArray(int[][] arr)
        {
            CompareDefault comp = new CompareDefault();
            SortArray(arr, comp);
        }
        #endregion

        #region Private Method
        /// <summary>
        /// Swap integer arrays
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private static void Swap(ref int[] a, ref int[] b)
        {
            if (a == null || b == null)
                throw new ArgumentNullException();
            int[] temp = a;
            a = b;
            b = temp;
        }
#endregion
    }
}
