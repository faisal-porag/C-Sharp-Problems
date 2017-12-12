using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsProject
{
    class ProblemSeven
    {
        public void multiplicationTable()
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.Write("\t" + i);
            }
            Console.WriteLine();
            for (int i = 1; i <= 12; i++)
            {
                Console.Write(i + "\t");
                for (int j = 1; j <= 12; j++)
                {
                    Console.Write(i*j + "\t");
                }
                Console.WriteLine();
            }
        }

    }
}
