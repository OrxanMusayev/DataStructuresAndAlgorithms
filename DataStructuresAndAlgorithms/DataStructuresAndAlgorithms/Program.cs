using DataStructuresAndAlgorithms.Sorting;
using System;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] MyArray = { 101, 1, 20, 50, 9, 98, 27, 153, 35, 899 };
            RadixSort.Sort(MyArray, MyArray.Length);
        }
    }
}
