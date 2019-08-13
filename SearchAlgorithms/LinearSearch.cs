using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    public class LinearSearch
    {

        //Time complexity = O(N) - O(N) means in proportion to the number of items
        public void PerformSearch()
        {
            int[] arr = {10, 20, 80, 30, 60, 50,
                     110, 100, 130, 170};
            int x = 175;
            Console.WriteLine(Search(arr, x));
            Console.ReadLine();
        }

        private static int Search(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (x == arr[i])
                {
                    return i;                    
                }
            }
            return -1;
        }
    }
}
