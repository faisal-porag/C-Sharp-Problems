using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsProject
{
    class ProblemThree
    {
        string user1 = "Alice";
        string user2 = "Bob";

        public void getGreet()
        {
            Console.WriteLine("Please enter your name");
            var input = Console.ReadLine();
            if (input == user1 || input == user2)
                Console.WriteLine("Welcome");
            else
                Console.WriteLine("Invalid Name");
        }
    }
}
