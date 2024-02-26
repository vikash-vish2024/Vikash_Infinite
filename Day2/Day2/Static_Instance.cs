using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Static_Instance
    {
        static void Main(string[] args)
        {
            Static_Instance program = new Static_Instance();
            Console.WriteLine("Sum of the Number : " + program.AddNos(4, 5));
            EvenNos_Genration(10);
            Console.WriteLine("___________________________");
            Test_Class.Method1();
            Console.ReadKey();
        }
        public int AddNos(int a, int b)//Instance method
        {
            return a + b;
        }
        public static void EvenNos_Genration(int num)//Static method
        {
            int i = 0;
            while (i <= num)
            {
                Console.WriteLine(i);
                i += 2;
            }
        }
    }
    class Test_Class
    {
        public static void Method1()
        {
            // int i = 0;
            Console.WriteLine("This is a static function of another class");

        }
    }
}
