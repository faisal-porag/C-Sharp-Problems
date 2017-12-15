using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndString
{
    class ProblemListFour
    {
        public void GetOddPositionElement()
        {
            var element = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.Write("[ ");
            foreach (var list in element)
            {
                Console.Write(list + " ");
            }
            Console.Write("]");
            Console.WriteLine("\n");

            int count = element.Count;
            Console.WriteLine("Odd Position Elements are ");
            Console.Write("[ ");
            for (int i = 0; i < count; i++)
            {
                if(i % 2 == 1)
                {
                    Console.Write(element[i] + " ");
                }

            }
            Console.WriteLine("]");


        }


        public List<int> GetOddPositionElement1()
        {
            var element = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var storeElement = new List<int>();

            Console.Write("[ ");
            foreach (var list in element)
            {
                Console.Write(list + " ");
            }
            Console.Write("]");
            Console.WriteLine("\n");

            int count = element.Count;
            Console.WriteLine("Odd Position Elements are ");
            for (int i = 0; i < count; i++)
            {
                if (i % 2 == 1)
                {
                    storeElement.Add(i);
                }

            }
            return storeElement;


        }


    }
}
