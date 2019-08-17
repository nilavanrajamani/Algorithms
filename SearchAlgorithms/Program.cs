using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinearSearch linearSearch = new LinearSearch();
            //linearSearch.PerformSearch();

            //BinarySearch binarySearch = new BinarySearch();
            //binarySearch.PerformSearch();

            //JumpSearch jumpSearch = new JumpSearch();
            //jumpSearch.PerformSearch();

            //BinarySearchIterative binarySearch = new BinarySearchIterative();
            //binarySearch.PerformSearch();

            //InterpolationSearch interpolationSearch = new InterpolationSearch();
            //interpolationSearch.PerformSearch();

            //ExponentialSearch exponentialSearch = new ExponentialSearch();
            //exponentialSearch.PerformSearch();

            TernarySearch ternarySearch = new TernarySearch();
            ternarySearch.PerformSearch();
        }
    }
}
