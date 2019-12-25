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

            for(int i = 0; i<array.Count ; i++)
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
            int length = array.Count;
            for (int y = 0; y < length; y++)
            {
                smallest = findSmallest(array);
                newArray.Add(array[smallest]);
                array.RemoveAt(smallest);
            }
            return newArray;
        }
    }
}