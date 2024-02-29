using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Parent
    {
        public float data;

        public void Method_Hide(string s)
        {
            Console.WriteLine("This is a message from Parent Class{0}",s);
        }
    }
    class Child : Parent
    {
        //Name hiding
        new float data; // member float data here hides the parent float
        public Child(float f1,float f2)
        {
            Console.WriteLine(base.data);
            base.data = f1;//data in parent class
            data = f2;//data in child class
            Console.WriteLine(base.data+" "+data);
        }
        public new void Method_Hide(string s)
        {
            Console.WriteLine("This is a message from Child Class{0}", s);
        }
    }
    class NameAndMethodHiding
    {
        static void Main()
        {
            Child child = new Child(3.5f,6.7f);
            child.Method_Hide(" Hello!");
            Parent parent = new Parent();
            parent.Method_Hide(" Hey?");
            Console.ReadKey();
        }
    }
}
