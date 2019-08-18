using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    public class SelectionSort
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
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                //swap minIndex and i
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }
    }
}
