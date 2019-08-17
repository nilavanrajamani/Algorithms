using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    //Assume array is sorted
    //Time complexity - O(SqrtN)
    //Auxiliary space - O(1)
    public class JumpSearch
    {
        public void PerformSearch()
        {
            int[] arr = { 10, 20, 30, 50, 60, 80, 100, 110, 130, 170 };
            Console.WriteLine(Search(arr, 10));
            Console.WriteLine(Search(arr, 20));
            Console.WriteLine(Search(arr, 30));
            Console.WriteLine(Search(arr, 50));
            Console.WriteLine(Search(arr, 60));
            Console.WriteLine(Search(arr, 80));
            Console.WriteLine(Search(arr, 100));
            Console.WriteLine(Search(arr, 110));
            Console.WriteLine(Search(arr, 130));
            Console.WriteLine(Search(arr, 170));
            Console.WriteLine(Search(arr, 190));
            Console.ReadLine();
        }

        private static int Search(int[] arr, int x)
        {
            int elementToReturn = -1;

            //Find skip constant
            int skipConstant = Convert.ToInt32(Math.Sqrt(arr.Length));

            //perform skip and search
            int linearSearchElementIndex = SearchInSkipConstantSteps(arr, skipConstant, x);

            //perform linear search
            elementToReturn =
                GetIndexOfElementLinear(arr, skipConstant, linearSearchElementIndex, x);

            return elementToReturn;
        }

        private static int GetIndexOfElementLinear(int[] arr, int skipConstant, int linearSearchElementIndex, int x)
        {
            int indexOfElement = -1;

            for (int i = 0; i <= skipConstant; i++)
            {
                if ((i + linearSearchElementIndex) <= (arr.Length - 1))
                {
                    if (arr[i + linearSearchElementIndex] == x)
                    {
                        return (i + linearSearchElementIndex);
                    }
                }
            }

            return indexOfElement;
        }

        private static int SearchInSkipConstantSteps(int[] arr, int skipConstant, int elementToFind)
        {
            int i = 0;
            int previousIndex = 0;
            while (i < arr.Length)
            {
                if (elementToFind < arr[i])
                {
                    return previousIndex;
                }
                else if (elementToFind == arr[i])
                {
                    return i;
                }
                previousIndex = i;
                i = i + skipConstant;
            }
            return (previousIndex);
        }
    }
}
