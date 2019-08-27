using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    public class RadixSort
    {
        public void PerformSort()
        {
            int[] arr = {29, 88, 16, 36, 64, 54,
                     113, 102, 132, 170};

            ReturnSortedArray(arr, arr.Length);
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        private void ReturnSortedArray(int[] arr, int n)
        {
            //Get max element in the array
            int maxElement = GetMaxElement(arr);

            //Find the number of digits for the element
            for (int exp = 1; (maxElement / exp) > 0; exp *= 10)
            {
                ReorderElements(exp, arr, n);
            }
            //For each base of iteration reorder the element in ascending order
        }
        private void ReorderElements(int exp, int[] arr, int n)
        {
            int[] outputArray = new int[n];
            int[] count = new int[10];

            for (int i = 0; i < count.Length; i++)
            {
                count[i] = 0;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                int currentIterationConstant = (arr[i] / exp) % (10);
                count[currentIterationConstant]++;
            }

            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = (arr.Length - 1); i >= 0; i--)
            {
                outputArray[count[(arr[i] / exp) % (10)] - 1] = arr[i];
                count[(arr[i] / exp) % (10)]--;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = outputArray[i];
            }
        }
        public int GetMaxElement(int[] arr)
        {
            int maxElement = arr[0];
            foreach (int item in arr)
            {
                if (item > maxElement)
                {
                    maxElement = item;
                }
            }
            return maxElement;
        }
    }
}
