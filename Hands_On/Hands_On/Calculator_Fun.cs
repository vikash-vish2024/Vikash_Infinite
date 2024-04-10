using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hands_On
{
    class Calculator_Fun
    {

        public int calcOps(int a,int b)=>((a+b)+(a-b)+(a*b)+(a/b));


            static void Main()
        {
            //calling calcOps
            Calculator_Fun calculator_Fun = new Calculator_Fun();
            Console.Write("Enter the first Value -> ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Enter the Second value -> ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The Result is -> {calculator_Fun.calcOps(a, b)}");
            Console.Read();
        }
    }
    class Expression_Bodies_Eg
    {
       // public int Square
    }
}
