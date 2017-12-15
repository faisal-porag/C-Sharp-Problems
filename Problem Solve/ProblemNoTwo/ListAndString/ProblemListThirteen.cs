using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndString
{
    class ProblemListThirteen
    {
        public void GetFibonacci()
        {
            int a = 0, b = 0, c = 1;
            Console.WriteLine("Fibonacci Series:");
            for (int i = 1; i <= 100; i++)
            {
                a = b;
                b = c;
                c = a + b;
                Console.WriteLine(a + " ");
            }
        }

    }
}
