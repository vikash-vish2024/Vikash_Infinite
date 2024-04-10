using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hands_On
{
    class Query_Expressions
    {
        static void Main()
        {
            int[] intVal = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Query Expression to find all odd numbers from the array
            IEnumerable<int> OddVal = from ov in intVal
                                      where (ov % 2) != 0
                                      select ov;

            foreach (int val in OddVal)
            {
                Console.WriteLine(val);
            }
            //Query to find even number 
            IEnumerable<int> even_val = from ev in intVal
                                        where (ev % 2) == 0
                                        select ev;
            foreach (int val in even_val)
                Console.WriteLine(val);

            //divisible by 3
            IEnumerable<int> divby = from dv in intVal
                                     where (dv % 3) == 0
                                     select dv;
            foreach (int val in divby)
                Console.WriteLine(val);

            int[] num = { 2, 4, 6, 4, 8, 9, 0, 12, 54, 67, 23, 1 };

            //only return number if its greater than given num
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            IEnumerable<int> GreaterThan = from gt in num
                                           where (gt > n)
                                           select gt;

            foreach(int val in GreaterThan)
                Console.WriteLine(val);

            //Literal Improvements

            Console.Read();
        }
    }
}