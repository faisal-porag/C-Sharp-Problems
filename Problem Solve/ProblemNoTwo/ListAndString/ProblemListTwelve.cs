using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndString
{
    class ProblemListTwelve
    {

        //Without loop
        public void SwapListElement()
        {                                   
                                            //0  1  2  3  4  5
            List<int> list1 = new List<int> { 1, 2, 3, 4, 5, 6 };
            int listLength = list1.Count;

            Console.WriteLine("List before swap ");
            foreach (var item in list1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            int temp = list1[0];
            int temp1 = list1[1];

            list1[0] = list1[2];
            list1[1] = list1[3];
            list1[2] = list1[4];
            list1[3] = list1[5];
            list1[4] = temp;
            list1[5] = temp1;

            Console.WriteLine("List after swap ");
            foreach (var item in list1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }



        // Loopint Process using array 
        public void RotateWiithArray(int k)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int length = arr.Length;

            Console.WriteLine("Before rotated ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            
            for (int i = 0; i < k; i++)
            {
                int j,temp;
                temp = arr[0];
                for (j = 0; j < length - 1; j++)
                {
                    arr[j] = arr[j + 1];
                } 
                arr[j] = temp;
            }
            Console.WriteLine("After rotated ");
            for (int i = 0; i < length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        // Loopint Process using array 
        public void RotateWithList(int k)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            int length = list.Count;

            Console.WriteLine("Before rotated ");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            int swapCount = 0;
            for (int i = 0; i < k; i++)
            {
                int j, temp;
                temp = list[0];
                for (j = 0; j < length - 1; j++)
                {
                    list[j] = list[j + 1];
                    swapCount++;
                }
                list[j] = temp;
            }
            Console.WriteLine("After rotated ");
            for (int i = 0; i < length; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Total swap or move is " + swapCount);
            
        }

    }
}
