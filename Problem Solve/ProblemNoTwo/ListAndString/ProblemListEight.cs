using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndString
{
    class ProblemListEight
    {
        public void perfectSquare()
        {
            List<int> list = new List<int>
                    { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int count = list.Count;
            Console.WriteLine("List before perfect square :");
            foreach (var item in list)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();
            Console.WriteLine("List after perfect square : ");
            for (int i = 0; i < count; i++)
            {
                Console.Write(list[i]*list[i] + "  ");
            }
            Console.WriteLine();
        }
    }
}

/*
Write a function on_all that applies a function to every element of a list. Use it to print the first twenty perfect squares 
(a natural number n is a perfect square if it can be written as n=m*m for some other natural number m. 1,4,9,16,25 are the first 5).
*/
