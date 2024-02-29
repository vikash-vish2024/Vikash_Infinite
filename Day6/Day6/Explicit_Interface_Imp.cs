using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    interface IMyInterface1
    {
         void Show(string s);
    }
    interface IMyInterface2
    {
         void Show(string s);
    }
    class Explicit_Interface_Imp :IMyInterface1,IMyInterface2
    {
        public void Show(string s)
        {
            Console.WriteLine("This is the class function ->"+s);
        }
         void IMyInterface1.Show(string s)
        {
            Console.WriteLine("Parent 1 show "+s);
        }
        void IMyInterface2.Show(string s)
        {
            Console.WriteLine("Parent 2 show "+s);
        }
        //public void IMyInterface1.Show(string s)//Can't be public if its inherited from interface
        //{
        //}
        public static void Main()
        {
            // Using reference type
            Explicit_Interface_Imp explicit_Interface_Imp = new Explicit_Interface_Imp();
            ((IMyInterface1)explicit_Interface_Imp).Show("Using parent 1 reference typecast");
            ((IMyInterface2)explicit_Interface_Imp).Show("Using parent 2 reference typecast");
            explicit_Interface_Imp.Show("Hello!");

            //Second option
            IMyInterface1 im1 = new Explicit_Interface_Imp();
            IMyInterface2 im2 = new Explicit_Interface_Imp();
            im1.Show("Interface1");
            im2.Show("Interface 2");
        }
    }
    
}
