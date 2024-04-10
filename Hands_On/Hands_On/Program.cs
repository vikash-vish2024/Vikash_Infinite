using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Hands_On
{
    class Program
    {
        public static char ch;
        public static void Student1()
        {
            Console.WriteLine("Student 2 is Presenting ");
            Console.WriteLine("Enter 'Y' if yor are ready to present 'N' not ready ");
            ch = Convert.ToChar(Console.ReadLine().ToUpper());
            if (ch == 'Y')
                Console.WriteLine("Hello! I'm student 1 ");
            else
            {
                Console.WriteLine("Not yet Ready");
                Thread.Sleep(10000);
            }
               
        }
        public static void Student2()
        {
            Console.WriteLine("Student 2 is Presenting ");
            Console.WriteLine("Enter 'Y' if yor are ready to present 'N' not ready ");
            char ch = Convert.ToChar(Console.ReadLine().ToUpper());
            if (ch == 'Y')
                Console.WriteLine("Hello! I'm student 2 ");
            else
            {
                Console.WriteLine("Not yet Ready");
                Thread.Sleep(10000);
            }
        }
        public static void Student3()
        {
            Console.WriteLine("Student 3 is Presenting ");
            Console.WriteLine("Enter 'Y' if yor are ready to present 'N' not ready ");
            char ch = Convert.ToChar(Console.ReadLine().ToUpper());
            if (ch == 'Y')
                Console.WriteLine("Hello! I'm student 3 ");
            else
            {
                Console.WriteLine("Not yet Ready");
                Thread.Sleep(10000);
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Student1) { Name = "T_Student_1" };
            t1.Start();
            Thread t2 = new Thread(Student2) { Name = "T_Student_2" };
            t2.Start();
            Thread t3 = new Thread(Student3) { Name = "T_Student_3" };
            t3.Start();
        }
    }
}
