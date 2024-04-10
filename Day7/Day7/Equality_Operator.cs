using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    class Equality_Operator
    {
        public static void Main()
        {
            int a = 3;
            int b = 4;
            int c = 5;

            Console.WriteLine("------------Compare to fun------------");
            Console.WriteLine(a.CompareTo(b));
            Console.WriteLine(b.CompareTo(a));
            Console.WriteLine(c.CompareTo(a));

            Console.WriteLine("----------ReferenceEquals---------------");
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();



            Console.WriteLine("---------With String---------");

            string s1 = "b";
            string s2 = "b";

            Console.WriteLine(object.ReferenceEquals(s2,s1));
            s1 = s2;

        }
    }
}
