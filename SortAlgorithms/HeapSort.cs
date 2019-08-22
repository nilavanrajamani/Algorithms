using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    public class HeapSort
    {
        public void PerformSort()
        {
            int[] arr = {20, 80, 10, 30, 60, 50,
                     110, 100, 130, 170};

            ReturnSortedArray(arr);
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        private void ReturnSortedArray(int[] arr)
        {
            int lastParent = (arr.Length - 1) / 2;

            for (int k = lastParent; k >= 0; k--)
            {
                Heapify(arr, arr.Length, k);
            }

            for (int i = (arr.Length - 1); i >= 0; i--)
            {
                int firstIndex = arr[0];
                arr[0] = arr[i];
                arr[i] = firstIndex;

                Heapify(arr, i, 0);
            }
        }
        private void Heapify(int[] arr, int length, int i)
        {
            int leftIndex = (2 * i) + 1;
            int rightIndex = (2 * i) + 2;
            int largestIndex = i;

            if ((length - 1) >= leftIndex && arr[leftIndex] > arr[largestIndex])
            {
                largestIndex = leftIndex;
            }

            if ((length - 1) >= rightIndex && arr[rightIndex] > arr[largestIndex])
            {
                largestIndex = rightIndex;
            }

            if (i != largestIndex)
            {
                int temp = arr[i];
                arr[i] = arr[largestIndex];
                arr[largestIndex] = temp;

                Heapify(arr, length, largestIndex);
            }
        }
    }
}
