using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndString
{
    class ProblemListForteen
    {
        public void StrintToList()
        {
            Console.WriteLine("Enter a number ");
            int input = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>();
            while (input > 0)
            {
                list.Add(input % 10);
                input = input / 10;
            }
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

        }


        public List<int> NumberToList()
        {
            Console.WriteLine("Enter a number ");
            int input = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>();
            while (input > 0)
            {
                list.Add(input % 10);
                input = input / 10;
            }

            return list;

        }
    }
}
