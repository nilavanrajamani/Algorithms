using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    public class CountingSort
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

        private void ReturnSortedArray(int[] arr, int length)
        {
            throw new NotImplementedException();
        }
    }
}
