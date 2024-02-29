using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Program
    {
        //readonly variable
        public readonly int myvariable1; //declaratio
        public readonly int myvariable2 = 10; //declare & initialize


        internal Program(int a,int b)
        {
            myvariable1 = a;
            //myvariable2 = b;
            Console.WriteLine($" my variable first  :{myvariable1}, Second variable is : {myvariable2}");
            int x = 100;



        }
        public void readOnlyChange()
        {
           // myvariable1 = 100;
        }

        static void Main(string[] args)
        {
            //Program program = new Program(100,200);
            //Console.WriteLine("--------------------");
            //Program pro2 = new Program(120,300);

            Y my_y=new Y();

            Console.Read();
        }
    }
}
