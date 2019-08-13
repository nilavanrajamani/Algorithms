using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    public class BinarySearch
    {
        //Assume array is sorted
        //Recursive Implementation - Time complexity Big O notation - O(logN)
        public void PerformSearch()
        {
            int[] arr = { 10, 20, 30, 50, 60, 80, 100, 110, 130, 170, 180 };
            int x = 130;
            Console.WriteLine(Search(arr, x, 0));
            Console.ReadLine();
        }

        private int Search(int[] inputArray, int elementToFind, int skippedCount)
        {
            var midElementIndex = (inputArray.Length / 2);
            if (inputArray[midElementIndex] == elementToFind)
            {
                return midElementIndex + skippedCount;
            }
            else if (inputArray.Length == 1)
            {
                return -1;
            }

            if (inputArray[midElementIndex] < elementToFind)
            {
                return Search(inputArray.Skip(midElementIndex).ToArray(), elementToFind, skippedCount + midElementIndex);
            }
            else if (inputArray[midElementIndex] > elementToFind)
            {
                return Search(inputArray.Take(midElementIndex).ToArray(), elementToFind, skippedCount);
            }

            return -1;
        }
    }
}
