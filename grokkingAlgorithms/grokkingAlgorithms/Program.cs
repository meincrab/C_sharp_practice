using System;
using System.Collections.Generic;

namespace grokkingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] values = { 10, 20, 30, 33, 35, 50, 60, 77, 81, 98 };
            var result = BinarySearch.binarySearch(values, 123);
            Console.WriteLine("result of search");
            Console.WriteLine(result);
            List<int> mixedValues = new List<int>() { 11, 15, 4, 9, 1, 20, 40, 54, 23, 19, 31};
            List<int> sortedValues = SelectionSort.selectionSort(mixedValues);
            foreach (int i in sortedValues)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\nFactorial:" + Recursion.factorial(3));

            mixedValues = new List<int>() { 11, 15, 4, 9, 1, 20, 40, 54, 23, 19, 31 };
            Console.WriteLine("QuickSort:");
            List<int> quickSorted = QuickSort.quickSort(mixedValues);
            foreach (int i in quickSorted)
            {
                Console.WriteLine(i);
            }


        }
    }
}
