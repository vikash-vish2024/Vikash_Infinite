using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Employee
    {
        string _code = "N.A";
        string _Name = "Missing";
        int _Age = 0;
        //Autometic property implementation
        //public double _Salary { protected get; set; } = 26000;
        public double _Salary { get; } = 26000;

        // override the object.tostring fun to show all the fun in one go
        public override string ToString()
        {
            return "Employee code ->" + Code+ " Name->"+Name+", Age is - "+Age+", Salary is ->"+_Salary;
        }
        //declare properties of private field
        public string Code
        {
            get { return _code; } //reads the values og the field
            set { _code = value; } //for setting the value from the field
        }
        public string Name
        {
            get { return _Name; }
            //setting the value using condition
            set
            { if (value != " ")
                    _Name = value;
              else
                    Console.WriteLine("Invalid Data");

            }
        }
        public int Age
        {
            get { return _Age; } //only Display the value no changes are allowed
        }
    }
    class Properties_eg
    {
        public static void Main()
        {
            Employee emp = new Employee();
            Console.WriteLine(emp.Code+" "+emp.Name+" "+emp.Age);
            emp.Code = "E01"; //setter
            //Console.WriteLine(emp.Code);//getter
            //Console.WriteLine(emp.Age);
            emp.Name = "Vikash";
            //Console.WriteLine(emp.Name);
            Console.WriteLine("----Employee Details---- \n{0}",emp.ToString());
            Console.Read();
            
        }
        
    }
}
