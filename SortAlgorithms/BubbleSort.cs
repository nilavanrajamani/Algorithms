using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    public class BubbleSort
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
            bool isSwapComplete = false;

            while (!isSwapComplete)
            {
                isSwapComplete = true;
                int i = 0, j = i + 1;
                while (j < arr.Length)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                        isSwapComplete = false;
                    }
                    i++;
                    j++;
                }
            }            
        }
    }
}
