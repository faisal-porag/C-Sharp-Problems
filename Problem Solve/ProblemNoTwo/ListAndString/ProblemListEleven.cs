using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndString
{
    class ProblemListEleven
    {
        public void MargeSortedList()
        {
            List<int> list1 = new List<int> { 1, 6, 4 };
            List<int> list2 = new List<int> { 5, 3, 2 };

            list1.Sort();
            list2.Sort();
            Console.WriteLine("Sorted List1 is ");
            foreach (var item in list1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Sorted List2 is ");
            foreach (var item in list2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            Console.WriteLine("Two sorted lists into a new sorted list is ");
            var resList = list1.Concat(list2).ToList();
            resList.Sort();
            foreach (var item in resList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }
    }
}
