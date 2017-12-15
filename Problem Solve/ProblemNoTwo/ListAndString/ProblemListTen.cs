using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndString
{
    class ProblemListTen
    {

        public  List<char> combineList(List<char> a1, List<char> a2)
        {

            int len = a1.Count + a2.Count;
            List<char> result = new List<char>(len);
            int j = 0, k = 0;

            for (int i = 0; i < len; i++)
            {
                if (i % 2 == 0)
                    result[i] = a1[j++];
                else
                    result[i] = a2[k++];
            }

            return result;
        }

        public void combineList1()
        {
            List<char> a1 = new List<char> { 'a', 'b', 'c' };
            List<char> a2 = new List<char> { '1', '2', '3' };
            int len = a1.Count + a2.Count;
            List<char> result = new List<char>(len);
            //Console.WriteLine(len);

            int j = 0, k = 0;

            for (int i = 0; i < len; i++)
            {
                if (i % 2 == 0)
                {
                    result[i] = a1[j++];
                }
                    
                else{
                    result[i] = a2[k++];
                }
                    
            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
        
    }
}
