using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    public class MergeSort
    {
        public void PerformSort()
        {
            int[] arr = {20, 80, 10, 30, 60, 50,
                     110, 100, 130, 170};

            int[] returnArray = SplitArray(arr);
            foreach (int item in returnArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }

        private int[] SplitArray(int[] arr)
        {
            int midElementIndex = arr.Length / 2;
            int[] subArray1 = arr.Take(midElementIndex).ToArray();
            int[] subArray2 = arr.Skip(midElementIndex).ToArray();

            List<int> splittedArray1 = new List<int>();
            List<int> splittedArray2 = new List<int>();

            if (subArray1.Length > 1)
            {
                splittedArray1 = SplitArray(subArray1).ToList();
            }
            else
            {
                splittedArray1 = subArray1.ToList();
            }

            if (subArray2.Length > 1)
            {
                splittedArray2 = SplitArray(subArray2).ToList();
            }
            else
            {
                splittedArray2 = subArray2.ToList();
            }


            return MergeArray(splittedArray1.ToArray(), splittedArray2.ToArray());
        }

        private int[] MergeArray(int[] arr1, int[] arr2)
        {
            int arrayLength = arr1.Length + arr2.Length;
            int[] returnArray = new int[arrayLength];

            int indexToInsert = 0;

            int i = 0, j = 0;
            while (arr1.Length > 0 && arr2.Length > 0)
            {
                if (arr1[i] < arr2[j])
                {
                    returnArray[indexToInsert] = arr1[i];
                    indexToInsert++;
                    List<int> vs = arr1.ToList();
                    vs.RemoveAt(i);
                    arr1 = vs.ToArray();
                }
                else
                {
                    returnArray[indexToInsert] = arr2[j];
                    indexToInsert++;
                    List<int> vs = arr2.ToList();
                    vs.RemoveAt(j);
                    arr2 = vs.ToArray();
                }
            }

            if (arr1.Length > 0)
            {
                for (int k = 0; k < arr1.Length; k++)
                {
                    returnArray[indexToInsert] = arr1[k];
                    indexToInsert++;
                }                
            }


            if (arr2.Length > 0)
            {
                for (int k = 0; k < arr2.Length; k++)
                {
                    returnArray[indexToInsert] = arr2[k];
                    indexToInsert++;
                }               
            }

            return returnArray;
        }
    }
}
