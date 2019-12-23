using System;
using System.Collections.Generic;
using System.Text;

namespace grokkingAlgorithms
{
    static class BinarySearch
    {
        public static object binarySearch(int[] array, int item)
        {
            int low = 0;
            int high = array.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int guess = array[mid];
                if (guess == item)
                {
                    return guess;
                }
                else if (guess > item)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return "Not Found";
        }
    }
}
