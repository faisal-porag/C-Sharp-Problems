using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingAlgorithm.Utility;

namespace SortingAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            SelectionSort sSort = new SelectionSort();
            //sSort.selectionSortArray();
            //sSort.selectionSortList();

            InsertionSort iSort = new InsertionSort();
            //iSort.insertionSort();
            //iSort.insertionSortWithList();
            
            MargeSort mSort = new MargeSort();
            //mSort.printResult();

            QuickSort qSort = new QuickSort();
            //qSort.printResult();
            
            StoogeSort stSort = new StoogeSort();
            //stSort.printResult();

            BinarySearch bSearch = new BinarySearch();
            //bSearch.printResult();

            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.printResult();
            

        }
    }
}
