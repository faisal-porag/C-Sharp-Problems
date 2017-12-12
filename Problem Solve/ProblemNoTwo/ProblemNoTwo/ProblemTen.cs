using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsProject
{
    class ProblemTen
    {
        public void PrintLeapYear()
        {
            int currentYear = 2017;
            int upToYear = 5050;
            int count = 1;
            Console.WriteLine("Next 20 Leap Years : ");
            for (int i = currentYear; i <= upToYear; i++)
            {
                if ((i % 4 == 0 && i % 100 != 0) || i % 400 == 0) {
                    Console.WriteLine(i + " Leap Year ");
                    count++;
                    if (count > 20)
                        break;
                }
                
            }
        }
    }
}
