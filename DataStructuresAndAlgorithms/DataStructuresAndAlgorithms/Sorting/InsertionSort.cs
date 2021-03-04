using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Sorting
{
    public class InsertionSort
    {
        public static void Sort(int[] array)
        {
            int inner, temp;
            for (int outer = 1; outer < array.Length; outer++)
            {
                temp = array[outer];
                for (inner = outer; inner > 0; inner--)
                {
                    if (array[inner] < array[inner - 1])
                        array[inner] = array[inner - 1];
                }
                array[inner] = temp;
            }
        }
    }
}
