using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm.Utility
{
    class PrintMethod
    {
        //Prints the Array 
        public static void printArray(string sortName, int[] arr)
        {
            Console.WriteLine("After appling "+sortName + " :");
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.Write((arr[i] + " "));
            }

            Console.WriteLine();
        }

        public static void printArray1(string sortName, int[] arr)
        {
            Console.WriteLine("Before appling " + sortName + " :");
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.Write((arr[i] + " "));
            }

            Console.WriteLine();
        }

        // Prints the List
        public static void printList(string sortName, List<int> list)
        {
            Console.WriteLine("After appling " + sortName + " :");
            for (int i = 0; i < list.Count; ++i)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
