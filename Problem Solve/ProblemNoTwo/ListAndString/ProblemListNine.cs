using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndString
{
    class ProblemListNine
    {
        public void ConcatenationOfList()
        {
            List<string> list1 = new List<string> { "a", "b", "c" };
            List<string> list2 = new List<string> { "1", "2", "3", };

            list1 = list1.Concat(list2).ToList();
            Console.Write("[");
           
            foreach (var item in list1)
            {
                Console.Write(item + ",");
            }
            Console.Write("]");
            Console.WriteLine("\n");

        }
    }
}
