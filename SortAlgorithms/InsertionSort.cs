using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    public class InsertionSort
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
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (i == j)
                    {
                        //same index
                    }
                    else
                    {
                        if (arr[i] < arr[j])
                        {
                            var temp = arr[i];
                            for (int k = i; k > j; k--)
                            {
                                arr[k] = arr[k - 1];
                            }
                            arr[j] = temp;
                        }
                    }
                }
            }
        }
    }
}
