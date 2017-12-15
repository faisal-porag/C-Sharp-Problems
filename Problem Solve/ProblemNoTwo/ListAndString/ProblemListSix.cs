using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndString
{
    class ProblemListSix
    {
        public void getStatus()
        {
            Console.WriteLine("Enter your word to check whether a string is palindrome or not ");
            string inputString = Console.ReadLine();
            string first = inputString.Substring(0, inputString.Length / 2);
            char[] arr = inputString.ToCharArray();
            Array.Reverse(arr);
            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);
            if (first.Equals(second))
            {
                Console.WriteLine("String is a palindrome");
            }
            else
            {
                Console.WriteLine("String is not palindrome");
            }
        }

        public bool getStatus1(string myString)
        {
            string first = myString.Substring(0, myString.Length / 2);
            char[] arr = myString.ToCharArray();
            Array.Reverse(arr);
            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);
            return first.Equals(second);
        }
    }
}
