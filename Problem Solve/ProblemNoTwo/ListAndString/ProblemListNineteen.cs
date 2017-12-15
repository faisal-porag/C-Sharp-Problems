using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndString
{
    class ProblemListNineteen
    {
        public void Print()
        {
            List<string> list = new List<string> { "Hello", "World", "in", "a", "frame" };


            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        public void Print1()
        {
            List<string> list = new List<string> { "Hello", "World", "in", "a", "frame" };

            for (int i = 0; i < 9; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for(int i = 0; i < list.Count; i++)
            {
                if(i == 2)
                {
                    Console.WriteLine("* " + list[i] + "    *");
                }
                else if(i == 3)
                {
                    Console.WriteLine("* " + list[i] + "     *");
                }
                else
                {
                    Console.WriteLine("* " + list[i] + " *");
                }
                
            }
            for (int i = 0; i < 9; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("\n");
        }
    }
}
