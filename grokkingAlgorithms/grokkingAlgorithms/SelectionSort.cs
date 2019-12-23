using System;
using System.Collections.Generic;
using System.Text;

namespace grokkingAlgorithms
{
    class SelectionSort
    {
        private static int findSmallest(List<int> array)
        {
            int smallest = array[0];
            int smallest_index = 0;

            foreach (int i in array)
            {
                if (array[i] < smallest)
                {
                    smallest = array[i];
                    smallest_index = i;
                }
            }
            return smallest_index;
        }

        public static List<int> selectionSort(List<int> array)
        {
            List<int> newArray = new List<int>();
            int smallest = 0;
            foreach (int i in array)
            {
                smallest = findSmallest(array);
                newArray.Add(array[smallest]);
                array.RemoveAt(smallest);
            }
            return newArray;
        }
    }
}