using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortJaggedArray;

namespace SortJaggedArrayTest
{
    class Program
    {

        static void Main(string[] args)
        {
            int[][] jaggArr = new int[4][];
            jaggArr[0] = new[] {1, 1, 1};
            jaggArr[1] = new[] {4, 4, 4, 4, 4};
            jaggArr[2] = new[] {9, 9};
            jaggArr[3] = new[] {6, 6, 6, 6};

            Console.WriteLine("Array before sorting: ");
            ShowArray(jaggArr);

            CompareByMinValue minComparer = new CompareByMinValue();
            SortJaggArr.SortArray(jaggArr, minComparer);
            Console.WriteLine("\nArray after sorting acording to the smallest value: ");
            ShowArray(jaggArr);

            SortJaggArr.SortArray(jaggArr);
            Console.WriteLine("\nArray after sorting acording to the greatest value: ");
            ShowArray(jaggArr);

            CompareBySum sumComparer = new CompareBySum();
            SortJaggArr.SortArray(jaggArr, sumComparer);
            Console.WriteLine("\nArray after sorting acording to the sum of elements of raw: ");
            ShowArray(jaggArr);

            Console.ReadLine();

        }
        /// <summary>
        /// Show jagged array at console window
        /// </summary>
        /// <param name="arr"></param>
        private static void ShowArray(int [][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
