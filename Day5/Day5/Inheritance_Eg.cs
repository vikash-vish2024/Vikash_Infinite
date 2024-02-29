using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class X
    {
        float secret;
        public int ID;
        protected string xname;
        internal DateTime DOJ;


        public X(int id,string name,DateTime doj)
        {
            ID = id;
            xname = name;
            DOJ = doj;
        }

        public X()
        {
            Console.WriteLine("Hey? from X");
        }
    }


    class Y : X
    {
        public static void Main()
        {
            //Y y1 = new Y();//child class/derived class object
            //y1.ID = 1034317;
            //y1.xname = "Infinite";
            //y1.DOJ = Convert.ToDateTime("15/02/2024");
            //Console.WriteLine(y1.ID+" "+y1.xname+" "+y1.DOJ);
            Derived derived = new Derived(5,15);
            Console.Read();
        }

        public Y(int id_y,string name_y,DateTime doj_y):base(id_y, name_y, doj_y)
        {
            Console.WriteLine("Base class created with data");
        }
        public Y()
        {
            Console.WriteLine("Hey? from Y");
        }
    }
    
    class Derived : Inheritance_Eg
    {
        new int data1; //hiding
        public Derived(int var):base(var)
        {
            Console.WriteLine(data1);
        }
        public Derived(int mynum,int number):base(number)
        {
            data1 = mynum;
            Console.WriteLine(data1);
        }
    }

    class Inheritance_Eg
    {
        public int data1;

        public Inheritance_Eg(int n)
        {
            data1 = n;
            Console.WriteLine(data1);
        }

    }
}
