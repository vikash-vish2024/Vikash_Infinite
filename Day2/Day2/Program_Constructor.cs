using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program_Constructor
    {
        static void Main(string[] args)
        {
            Program_Constructor pc = new Program_Constructor();
            pc.CheckGrades();
            pc.Grade_Check_With_Switch();
            Console.Read();
        }
        public void CheckGrades()
        {
            char grades;
            Console.WriteLine("enter your grades O/A/B/C/D");
            grades = Convert.ToChar(Console.ReadLine());
            if (grades == 'O')
            {
                Console.WriteLine("Excellent");
            }
            else if (grades == 'A')
            {
                Console.WriteLine("better");
            }
            else if (grades == 'B')
            {
                Console.WriteLine("good");
            }
            else if (grades == 'D')
            {
                Console.WriteLine("avarage");
            }
            else if (grades == 'D')
            {
                Console.WriteLine("Avarage");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
        public void Grade_Check_With_Switch()
        {
            char grade;
            Console.WriteLine("Enter your Grade A/B/C");
            grade = Convert.ToChar(Console.ReadLine());
            switch (grade)
            {
                case 'O':
                    Console.WriteLine("outstanding");
                    break;
                case 'A':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                    Console.WriteLine("Very Good");
                    break;
                case 'C':
                    Console.WriteLine("Good");
                    break;
                case 'D':
                    Console.WriteLine("Can Improve");
                    break;
                default:
                    Console.WriteLine("invalid Grade");
                    break;
            }
        }
    }
}
