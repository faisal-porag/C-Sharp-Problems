using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsProject
{
    class ProblemTwo
    {
        public void PrintName()
        {
            Console.WriteLine("Please enter your name");
            var input = Console.ReadLine();
            Console.WriteLine("Welcome Mr./Mrs. " + input);
        }
    }
}
