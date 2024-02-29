using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Shapes
    {
        protected float R, L, B;
        public virtual float Area()
        {
            return 3.14f * R * R;//area of circle
        }
    }
    class Rectangle : Shapes
    {
        //public virtual float Area()
        //{
        //    return L * B;
        //}
        public void GetLengthnBreadth()
        {
            Console.WriteLine("Enter the length -> ");
            L = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the Breadth -> ");
            B = float.Parse(Console.ReadLine());
        }

        //overriding the Area() of the Parent/base class
        public override float Area()
        {
            return L * B;
        }
    }
    class Circle : Shapes
    {
        public  void Get_Radius()
        {
            Console.WriteLine("Enter Radius");
            R = Convert.ToSingle(Console.ReadLine());

        }
    }
    class Override_Eg
    {
        public static void Main()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.GetLengthnBreadth();
            Console.WriteLine("Area of Rectangle is -> "+rectangle.Area());
            Console.WriteLine("______________________________");
            Circle circle = new Circle();
            circle.Get_Radius();
            Console.WriteLine("Area of Circle is ->"+circle.Area());
            
            //co variance
            //Shapes s = new Shapes();
            //Console.WriteLine(s.Area());
            //s = new Rectangle(); //co variance where parent class point to child class 
            //Console.WriteLine(s.Area());

            Console.ReadLine();
        }
    }
}
