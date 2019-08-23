using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //SelectionSort selectionSort = new SelectionSort();
            //selectionSort.PerformSort();

            //BubbleSort bubbleSort = new BubbleSort();
            //bubbleSort.PerformSort();

            //InsertionSort insertionSort = new InsertionSort();
            //insertionSort.PerformSort();

            //MergeSort mergeSort = new MergeSort();
            //mergeSort.PerformSort();

            //HeapSort heapSort = new HeapSort();
            //heapSort.PerformSort();

            QuickSort quickSort = new QuickSort();
            quickSort.PerformSort();
        }
    }
}
