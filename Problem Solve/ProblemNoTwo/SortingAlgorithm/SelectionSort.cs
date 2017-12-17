using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingAlgorithm.Utility;

namespace SortingAlgorithm
{
    class SelectionSort
    {

        // Selection sort with in array 
        public void selectionSortArray()
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

            PrintMethod.printArray("Selection Sort",arr);
        }
        
        // Selection sort with in List
        
        public void selectionSortList()
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
            PrintMethod.printList("Selection Sort", list);
        }

        


    }
}
