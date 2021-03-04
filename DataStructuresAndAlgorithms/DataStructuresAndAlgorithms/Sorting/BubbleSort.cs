using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Sorting
{
    public class BubbleSort
    {
        public static void Sort(int[] array)
        {
            int temp;
            for (int outer = array.Length; outer >= 1; outer--)
            {
                for (int inner = 0; inner < array.Length - 1; inner++)
                {
                    if (array[inner] > array[inner + 1])
                    {
                        temp = array[inner];
                        array[inner] = array[inner + 1];
                        array[inner + 1] = temp;
                    }
                }
            }
        }
    }
}
