using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    public class InterpolationSearch
    {
        //Assume array is sorted
        //Iterative Implementation - Time complexity Big O notation - O(log log N)
        public void PerformSearch()
        {
            int[] arr = { 10, 20, 30, 50, 60, 80, 100, 110, 130, 170, 180 };
            //int[] arr = { 100, 110 };

            Console.WriteLine(GetIndexOfSearchElement(arr, 10));
            Console.WriteLine(GetIndexOfSearchElement(arr, 20));
            Console.WriteLine(GetIndexOfSearchElement(arr, 30));
            Console.WriteLine(GetIndexOfSearchElement(arr, 50));
            Console.WriteLine(GetIndexOfSearchElement(arr, 60));
            Console.WriteLine(GetIndexOfSearchElement(arr, 80));
            Console.WriteLine(GetIndexOfSearchElement(arr, 100));
            Console.WriteLine(GetIndexOfSearchElement(arr, 110));
            Console.WriteLine(GetIndexOfSearchElement(arr, 130));
            Console.WriteLine(GetIndexOfSearchElement(arr, 170));
            Console.WriteLine(GetIndexOfSearchElement(arr, 180));
            Console.ReadLine();
        }

        private int GetIndexOfSearchElement(int[] arr, int x)
        {
            //Get center element
            int l = 0;
            int r = arr.Length - 1;

            while (l <= r)
            {

                if (l == r)
                {
                    if(arr[l] == x)
                    {
                        return l;
                    }
                }
                int m = l + (((r - l) / (arr[r] - arr[l])) * (x - arr[l]));

                if (arr[m] == x)
                {
                    return m;
                }

                if (arr[m] < x)
                {
                    l = m + 1;
                }
                else
                {
                    r = m - 1;
                }
            }

            return -1;
        }
    }
}
