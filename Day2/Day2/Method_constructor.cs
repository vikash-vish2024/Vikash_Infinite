using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Method_constructor
    {
        public static void Main(String[] Args)
        {
            Method_constructor ms = new Method_constructor();
            ms.Factorial(5);
            Console.WriteLine(ms.Difference(8, 4));
            Console.WriteLine(Add(45,12));
            Console.WriteLine(Division(15, 3));
            Console.WriteLine(Product(5,4));

            Console.ReadKey();
        }
        
        public int Factorial(int num)
        {
            int prod=1;
            for(int i = 1; i <= num; i++)
            {
                prod *= i;
            }
            return prod;
        }
        public int Difference(int num1,int num2)
        {
            return num1 - num2;
        }
        static int Product(int num1, int num2)
        {
            return num1 * num2;
        }
        static int Division(int num1, int num2)
        {
            return num1 / num2;
        }
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        

    }
}
