using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    public class QuickSort
    {
        public void PerformSort()
        {
            //int[] arr = {20, 80, 10, 30, 60, 50,
            //         110, 100, 130, 170};
            int[] arr = { 20, 80, 10, 30, 60, 50 };

            int[] sortedArray = ReturnSortedArray(arr);
            foreach (int item in sortedArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }

        private int[] ReturnSortedArray(int[] arr)
        {
            return DoQuickSort(arr);
        }

        private int[] DoQuickSort(int[] arr)
        {
            if (arr.Length == 1 || arr.Length == 0)
            {
                return arr;
            }

            int pivotIndex = arr.Length - 1;
            int j = -1;
            for (int i = 0; i < pivotIndex; i++)
            {
                if (arr[i] < arr[pivotIndex])
                {
                    j++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            j++;
            if (j >= 0 && j < arr.Length - 1)
            {
                int temp = arr[pivotIndex];
                arr[pivotIndex] = arr[j];
                arr[j] = temp;
            }

            int[] arr1 = DoQuickSort(arr.Take(j).ToArray());
            int[] arr2 = DoQuickSort(arr.Skip(j).ToArray());
            int[] arr3 = (arr1).Concat(arr2).ToArray();
            return arr3.ToArray();
        }
    }
}
