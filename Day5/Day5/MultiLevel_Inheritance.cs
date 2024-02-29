using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Student
    {
        private string RollNo;
        string Name;
        string Class;
        public void Get_Data()
        {
            Console.WriteLine("------Student Information-----");
            Console.WriteLine("Enter the RollNo : ");
            RollNo = Console.ReadLine();
            Console.WriteLine("Enter the Name : ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the Class : ");
            Class = Console.ReadLine();
        }
        public void Put_Data()
        {
            Console.WriteLine("Name of the student is : "+Name);
            Console.WriteLine("Roll Number is : "+RollNo);
            Console.WriteLine("Class is : "+Class);
        }
    }
    class Marks : Student
    {
        protected int[] marks = new int[5];

        public void GetMarks()
        {
            for(int i = 0; i<marks.Length; i++)
            {
                Console.WriteLine("Enter Marks for "+(i+1)+" Subject");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void PutMarks()
        {
            for(int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(" Marks for " + (i + 1) + " Subject is -> "+marks[i]);
            }
        }
    }

    class Results : Marks
    {
        int Total_Marks = 0;

        public void Get_Result()
        {
            for(int i = 0; i < marks.Length; i++)
            {
                Total_Marks = Total_Marks + marks[i];
            }
        }

        public void ShowResults()
        {
            Console.WriteLine("======Show Result====");
            Put_Data();
            PutMarks();

            Console.WriteLine("Total Marks = "+Total_Marks);

        }
    }
    class MultiLevel_Inheritance
    {
        static void Main()
        {
            Results results = new Results();
            results.Get_Data();
            results.GetMarks();
            results.Get_Result();
            results.ShowResults();

            Console.ReadKey();

        }
    }
}
