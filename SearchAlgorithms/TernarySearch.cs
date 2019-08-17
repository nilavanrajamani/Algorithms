using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    public class TernarySearch
    {
        public void PerformSearch()
        {
            int[] arr = { 10, 20, 30, 50, 60, 80, 100, 110, 130, 170, 180 };

            Console.WriteLine(GetIndexThroughTerSearch(arr, 10, 0, arr.Length));
            Console.WriteLine(GetIndexThroughTerSearch(arr, 20, 0, arr.Length));
            Console.WriteLine(GetIndexThroughTerSearch(arr, 30, 0, arr.Length));
            Console.WriteLine(GetIndexThroughTerSearch(arr, 50, 0, arr.Length));
            Console.WriteLine(GetIndexThroughTerSearch(arr, 60, 0, arr.Length));
            Console.WriteLine(GetIndexThroughTerSearch(arr, 80, 0, arr.Length));
            Console.WriteLine(GetIndexThroughTerSearch(arr, 100, 0, arr.Length));
            Console.WriteLine(GetIndexThroughTerSearch(arr, 110, 0, arr.Length));
            Console.WriteLine(GetIndexThroughTerSearch(arr, 130, 0, arr.Length));
            Console.WriteLine(GetIndexThroughTerSearch(arr, 170, 0, arr.Length));
            Console.WriteLine(GetIndexThroughTerSearch(arr, 180, 0, arr.Length));
            Console.ReadLine();
        }

        public int GetIndexThroughTerSearch(int[] arr, int elementToFind, int startIndex, int endIndex)
        {
            //check if endIndex and startIndex is within arr.length limits
            if (endIndex > startIndex)
            {
                //get 2 indexes by splitting array into 3 - index1 & index2
                int index1 = startIndex + (endIndex - startIndex) / 3;
                int index2 = index1 + ((endIndex - startIndex) / 3);

                //check if index1 element is elementToFind and return the index
                if (arr[index1] == elementToFind)
                {
                    return index1;
                }

                //check if index2 element is elementToFind and return the index
                if (arr[index2] == elementToFind)
                {
                    return index2;
                }

                //check if elementToFind is in first 1/3 of array and if within the limits perform ternary search within here
                if (elementToFind > startIndex && elementToFind < arr[index1])
                {
                    return GetIndexThroughTerSearch(arr, elementToFind, startIndex, index1);
                }
                //check if elementToFind is in second 1/3 of array and if within the limits perform ternary search within here
                else if (elementToFind > arr[index1] && elementToFind < arr[index2])
                {
                    return GetIndexThroughTerSearch(arr, elementToFind, index1, index2);
                }
                //check if elementToFind is in last 1/3 of array and if within the limits perform ternary search within here
                else
                {
                    return GetIndexThroughTerSearch(arr, elementToFind, index2, endIndex);
                }
            }
            return -1;
        }
    }
}
