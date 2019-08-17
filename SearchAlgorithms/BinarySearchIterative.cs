using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    public class BinarySearchIterative
    {
        //Assume array is sorted
        //Recursive Implementation - Time complexity Big O notation - O(logN)
        public void PerformSearch()
        {
            int[] arr = { 10, 20, 30, 50, 60, 80, 100, 110, 130, 170, 180 };
            //int[] arr = { 100, 110 };

            Console.WriteLine(GetIndexThroughBinarySearch(arr, 10, 0, arr.Length));
            Console.WriteLine(GetIndexThroughBinarySearch(arr, 20, 0, arr.Length));
            Console.WriteLine(GetIndexThroughBinarySearch(arr, 30, 0, arr.Length));
            Console.WriteLine(GetIndexThroughBinarySearch(arr, 50, 0, arr.Length));
            Console.WriteLine(GetIndexThroughBinarySearch(arr, 60, 0, arr.Length));
            Console.WriteLine(GetIndexThroughBinarySearch(arr, 80, 0, arr.Length));
            Console.WriteLine(GetIndexThroughBinarySearch(arr, 100, 0, arr.Length));
            Console.WriteLine(GetIndexThroughBinarySearch(arr, 110, 0, arr.Length));
            Console.WriteLine(GetIndexThroughBinarySearch(arr, 130, 0, arr.Length));
            Console.WriteLine(GetIndexThroughBinarySearch(arr, 170, 0, arr.Length));
            Console.WriteLine(GetIndexThroughBinarySearch(arr, 180, 0, arr.Length));
            Console.ReadLine();
        }

        public int GetIndexThroughBinarySearch(int[] arr, int x, int startIndex, int endIndex)
        {
            while (startIndex <= endIndex)
            {
                int m = startIndex + ((endIndex - startIndex) / 2);

                if (arr[m] == x)
                {
                    return m;
                }

                if (arr[m] < x)
                {
                    startIndex = m + 1;
                }
                else
                {
                    endIndex = m - 1;
                }
            }

            return -1;
        }
    }
}

