using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program_Constructor
    {
        static void Main(string[] args)
        {
            Program_Constructor ps = new Program_Constructor();
            Loops loops = new Loops();
            loops.Do_While();
            loops.Whileloop();
            Loops.For_Loop();
            Console.Read();
        }
        public void CheckGrades()
        {
            char grades;
            int math;
            Console.WriteLine("enter your grades O/A/B/C/D");
            math = Convert.ToInt32(Console.ReadLine());
            grades = Convert.ToChar(Console.ReadLine().ToLower());
            if (grades == 'o' && math >= 90 && math <= 100)
            {
                Console.WriteLine("Excellent");
            }
            else if (grades == 'a' && math >= 70 && math < 90)
            {
                Console.WriteLine("better");
            }
            else if (grades == 'b' && math >= 50 && math < 70)
            {
                Console.WriteLine("good");
            }
            else if (grades == 'c' && math >= 40 && math < 70)
            {
                Console.WriteLine("avarage");
            }
            else if (grades == 'd' && math <= 33 && math < 40)
            {
                Console.WriteLine("Can Improve");
            }
            else if (grades == 'd' && math <= 1 && math < 33)
            {
                Console.WriteLine("Failed");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
        public void Grade_Check_With_Switch()
        {
            char grade;
            int math;
            Console.WriteLine("Enter your Grade A/B/C");
            grade = Convert.ToChar(Console.ReadLine().ToUpper());
            Console.WriteLine("Enter Your Marks");
            math = Convert.ToInt32(Console.ReadLine());
            switch (math)
            {
                case int marks when(math>90 && math <=100 && grade=='O'):
                
                    Console.WriteLine("outstanding");
                    break;
                case int marks when (math >=80 && math < 90 && grade == 'A'):
                    Console.WriteLine("Excellent");
                    break;
                case int marks when (math >= 70 && math <80 && grade == 'B'):
                    Console.WriteLine("Your Marks is : "+math);
                    Console.WriteLine("Your Grade is :" +grade);
                    Console.WriteLine("Very Good");
                    break;
                case int marks when (math >=60  && math <70 && grade == 'C'):
                    Console.WriteLine("Your Marks is : " + math);
                    Console.WriteLine("Your Grade is :" + grade);
                    Console.WriteLine("Good");
                    break;
                case int marks when (math >=50 && math <60 && grade == 'D'):
                    Console.WriteLine("Your Marks is : " + math);
                    Console.WriteLine("Your Grade is :" + grade);
                    Console.WriteLine("Can Improve");
                    break;
                case int marks when (math >= 33 && math < 50 && grade == 'E'):
                    Console.WriteLine("Your Marks is : " + math);
                    Console.WriteLine("Your Grade is :" + grade);
                    Console.WriteLine("Bad");
                    break;
                case int marks when (math >= 1 && math < 33 && grade == 'F'):
                    Console.WriteLine("Your Marks is : " + math);
                    Console.WriteLine("Your Grade is :" + grade);
                    Console.WriteLine("Failed");
                    break;


                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
        }
    }
    class Loops
    {

        public void Whileloop()
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine();
        }
        public void Do_While()
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);
        }
        public static void For_Loop()
        {
            int tot = 0;
            for (int i = 0; i <= 5; i++)
            {
                if (i == 3)
                    break;
                tot += i;
            }
            Console.WriteLine("sum of all numbers {0}", tot);
        }
        public void TwoDimension()
        {
            int[,] myarray = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine(myarray[1, 1]);
            //1st loop to iterate rows
            for (int i = 0; i < myarray.GetLength(0); i++)
            {
                //loop 2 for column values within the above row
                for (int j = 0; j < myarray.GetLength(1); j++)
                {
                    Console.Write(myarray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}