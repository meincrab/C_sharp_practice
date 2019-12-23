using System;

namespace grokkingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] values = { 10, 20, 30, 33, 35, 50, 60, 77, 81, 98 };
            var result = BinarySearch.binarySearch(values, 123);
            Console.WriteLine(result);
        }
    }
}
