using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Sorting
{
    public class SelectionSort
    {
        public static void Sort(int[] array)
        {
            int smallestValueIndex, temp;
            for (int outer = 0; outer < array.Length; outer++)
            {
                smallestValueIndex = outer;
                for (int inner = outer + 1; inner < array.Length; inner++)
                {
                    if (array[smallestValueIndex] > array[inner])
                        smallestValueIndex = inner;
                }
                temp = array[outer];
                array[outer] = array[smallestValueIndex];
                array[smallestValueIndex] = temp;
            }
        }
    }
}
