using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Project_1
    {
        public static void Main(String[] args)
        {
            //Student student = new Student(); //Calling the default constructor
            //student.Accept_Student();
            //student.Display_Student();
            //Console.WriteLine(Student.Wishes("Hello!"));
            //Console.WriteLine("__________________________________");
            //Student stud = new Student();
            //stud.Accept_Student();
            //stud.Display_Student();
            //Console.WriteLine(Student.Wishes("Hey?"));
            Employee emp = new Employee(1001,"Vikash",26000.0);
            emp.Display_Emp();
            Employee emp1 = new Employee(1002, "vikky");
            emp1.Display_Emp();
            Employee emp2 = new Employee();
            emp2 = null;//Setting an object to null
            GC.Collect();
            Console.Read();
        }
    }
    class Student
    {
        int RollNo;
        string Name;
        string Dept;
        float TotalMarks;

        public void Accept_Student()
        {
            Console.WriteLine("Enter the Student RollNo,Name,Dept and Marks");
            RollNo = Convert.ToInt32(Console.ReadLine());
            Name = Console.ReadLine();
            Dept = Console.ReadLine();
            TotalMarks = Convert.ToSingle(Console.ReadLine());
        }

        public void Display_Student()
        {
            Console.WriteLine($" Roll No: {RollNo}, Name : {Name}, Dept : {Dept}, Total Marks : {TotalMarks}");
        }
        public static String Wishes(string s)
        {
            return s;
        }
    }
}
