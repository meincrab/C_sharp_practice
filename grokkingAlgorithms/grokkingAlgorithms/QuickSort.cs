using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace grokkingAlgorithms
{
    static class QuickSort
    {
        public static List<int> quickSort(List<int> array)
        {
            if(array.Count < 2)
            {
                return array;
            }

            else
            {
                int pivot = array[0];
                List<int> less = new List<int>();
                foreach(int i in array.Skip(1))
                {
                    if(i < pivot)
                    {
                        less.Add(i);
                    }
                }
                List<int> greater = new List<int>();
                foreach(int i in array.Skip(1))
                {
                    if(i > pivot)
                    {
                        greater.Add(i);
                    }
                }

                List<int> sortedList = quickSort(less);
                sortedList.Add(pivot);
                sortedList.AddRange(quickSort(greater));      
                return sortedList;
            }
        }
    }
}
