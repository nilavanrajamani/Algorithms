using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    public class ExponentialSearch
    {

        public void PerformSearch()
        {
            int[] arr = { 10, 20, 30, 50, 60, 80, 100, 110, 130, 170, 180 };

            Console.WriteLine(GetIndexThroughExpSearch(arr, 10, 0, arr.Length));
            Console.WriteLine(GetIndexThroughExpSearch(arr, 20, 0, arr.Length));
            Console.WriteLine(GetIndexThroughExpSearch(arr, 30, 0, arr.Length));
            Console.WriteLine(GetIndexThroughExpSearch(arr, 50, 0, arr.Length));
            Console.WriteLine(GetIndexThroughExpSearch(arr, 60, 0, arr.Length));
            Console.WriteLine(GetIndexThroughExpSearch(arr, 80, 0, arr.Length));
            Console.WriteLine(GetIndexThroughExpSearch(arr, 100, 0, arr.Length));
            Console.WriteLine(GetIndexThroughExpSearch(arr, 110, 0, arr.Length));
            Console.WriteLine(GetIndexThroughExpSearch(arr, 130, 0, arr.Length));
            Console.WriteLine(GetIndexThroughExpSearch(arr, 170, 0, arr.Length));
            Console.WriteLine(GetIndexThroughExpSearch(arr, 180, 0, arr.Length));
            Console.ReadLine();
        }


        public int GetIndexThroughExpSearch(int[] arr, int elementToFind, int startIndex, int endIndex)
        {
            //Get 2^n th index value            
            int expIndex = 1;

            if(arr[expIndex] == elementToFind)
            {
                return expIndex;
            }

            while (expIndex <= arr.Length) //2^n index is still within array limits                 
            {
                if (arr[expIndex] < elementToFind)//if 2nth value is lesser than elementToFind
                {
                    expIndex = expIndex * 2; //set next compare value to 2^n * 2
                }
                else
                {
                    break;
                }
            }

            //PerformBinarySearch with start index as 2^n/2 and endIndex as 2^n       
            BinarySearchIterative bs = new BinarySearchIterative();
            return bs.GetIndexThroughBinarySearch(arr, elementToFind, (expIndex / 2), Math.Min(expIndex, arr.Length));
        }
    }
}
