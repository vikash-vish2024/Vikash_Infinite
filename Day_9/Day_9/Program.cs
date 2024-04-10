using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9
{
    public delegate int Calculator(int num1,int num2);
    

    class Delegate_Calulator
    {
        static int temp;
        static int Addition(int n1,int n2)
        {
            Console.WriteLine("Addition of the Given number -> " + (n1 + n2));
            return temp;
        }
        static int Subtraction(int n1,int n2)
        {
            Console.WriteLine("Subtraction -> "+(n1-n2));
            return temp;
        }
        static int Multiplication(int n1,int n2)
        {
            Console.WriteLine("Multiplication -> "+(n1*n2));
            return temp;
        }
        static int Division(int n1,int n2)
        {
            return n1 / n2;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Delegate_Calulator del_cal = new Delegate_Calulator();
            Calculator cal=
        }
    }
}
