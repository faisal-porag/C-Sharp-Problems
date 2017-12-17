using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndString
{
    class SelectionSort
    {

        // Selection sort with in array 
        public void sortArray()
        {
            int[] arr = { 64, 25, 12, 22, 11 };
            int countLength = arr.Length;
            Console.WriteLine("Before appling Selection Sort : ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");

            // One by one move boundary of unsorted subarray
            for (int i = 0; i < countLength - 1; i++)
            {
                // Find the minimum element in unsorted array
                int minIndex = i;
                for (int j = i + 1; j < countLength; j++) {
                    if (arr[j] < arr[minIndex]) {
                        minIndex = j;
                    }
                        
                }
                // Swap the found minimum element with the first
                // element
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }

            printArray(arr);
        }

        // Prints the array
        public void printArray(int[] arr)
        {
            Console.WriteLine("After appling Selection Sort : ");
            for (int i = 0; i < arr.Length; ++i) {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }


        // Selection sort with in List
        
        public void sortList()
        {
            List<int> list = new List<int> { 64, 25, 12, 22, 11 };
            int length = list.Count;
            Console.WriteLine("Before appling Selection Sort :");
            foreach (var item in list)
            {
                Console.Write(item  + " ");
            }
            Console.WriteLine("\n");

            for (int i = 0; i < length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1 ; j < length; j++)
                {
                    if(list[j] < list[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = list[minIndex];
                list[minIndex] = list[i];
                list[i] = temp; 
            }
            printList(list);
        }

        // Prints the array
        public void printList(List<int> list)
        {
            Console.WriteLine("After appling Selection Sort : ");
            for (int i = 0; i < list.Count; ++i)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }


    }
}
