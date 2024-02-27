using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Employee
    {
        int EmpId=1003;
        string EmpName="Basavraj";
        double EmpSalary=290000.0;

       internal Employee()//private constructor , can't be called outside the class
        {
            EmpId = 100;
            EmpName = "Vikash";
            EmpSalary = 26000;

        }

        internal Employee(int eid,string ename)
        {
            EmpId = eid;
            EmpName = ename;
        }

        public Employee(int EmpId,string EmpName,double EmpSalary)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.EmpSalary = EmpSalary;
        }
        public void Display_Emp()
        {
            Console.WriteLine($"EmpId :{EmpId}, EmpName :{EmpName},EmpSalary :{EmpSalary}");
        }
        ~Employee()
        {
            Console.WriteLine("Bye");
            Console.Read();
        }
    }
}
