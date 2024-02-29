using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Program
    {
        public static void swap(int num1,int num2)
        {
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            Console.WriteLine($"Swapping of 2 interger number1 {num1} and number 2 {num2} ");
        }
        public static void swap(char ch1,char ch2)
        {
            char temp = ch1;
            ch2 = ch1;
            ch1 = temp;
            Console.WriteLine($"Swapping of 2 character char1 {ch1}, and character 2 {ch2}");

        }
        public static int add(int x,int y)
        {
            return x + y;

        }
        public static int add(int a,int b,int c)
        {
            return a + b + c;
        }
        static void Main(string[] args)
        {
            swap(5, 6);
            swap('a', 'z');
            Console.ReadKey();
        }
    }
}
