using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndString
{
    class ProblemListSeven
    {
        //Using for loop
        public int forLoopMethod(int counter, int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < counter; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        public int forLoopMethod1(int counter, List<int> list)
        {
            int sum = 0;
            for (int i = 0; i < counter; i++)
            {
                sum += list[i];
            }

            return sum;
        }

        //Using while loop 
        public int whileLoopMethod(int counter, int[] arr)
        {
            int sum = 0;
            int i = 0;
            while (i < counter)
            {
                sum += arr[i];
                i++;
            }

            return sum;
        }

        public int whileLoopMethod1(int counter, List<int> list)
        {
            int sum = 0;
            int i = 0;
            while (i < counter)
            {
                sum += list[i];
                i++;
            }

            return sum;
        }

        //Using recursion
        public int recursiveMethod(int sum, int counter, int[] arr)
        {
            if (counter == 0)
                return sum;

            sum += arr[counter - 1];

            return recursiveMethod(sum, --counter, arr);

        }

        public int recursiveMethod1(int sum, int counter, List<int> list)
        {
            if (counter == 0)
                return sum;

            sum += list[counter - 1];

            return recursiveMethod(sum, --counter, list.ToArray());

        }

    }
}
