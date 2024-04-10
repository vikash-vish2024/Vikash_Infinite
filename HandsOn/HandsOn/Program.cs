using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hands_On

{
    class Events
    {
        int data = 5;
        public delegate void NumberManipulator(int x);
        public event NumberManipulator ChangeNumberEvent;

        public Events(int n)
        {
            this.ChangeNumberEvent += new NumberManipulator(this.Cube); //registering an event with the delegate and hence a function
            setValue(n);
        }

        public void onChangeNum(int x)  // event handler
        {
            Console.WriteLine($"Event Raised and the value from {data} is being changed to {x}");
        }
        public void Square(int x)      // Event handler 2
        {
            Console.WriteLine($"Event Raised and the value from {data} is being chaned to {x * x}");
        }
        public void Cube(int x)   // Event Handler 3
        {
            Console.WriteLine($"Event Raised and the value from {data} is being changed to {x * x * x}");
        }
        public void setValue(int n)   //responsible for raising an event
        {
            if (data != n)   //when data's value and the input value are different
            {
                ChangeNumberEvent(n);
            }
            else
            {
                Console.WriteLine("No Changes in the Value .. hence no Event");
            }
        }
    }

    class TestEvent
    {
        static void Main()
        {
            Events eObj = new Events(5);
            eObj.setValue(15); // Event will be raised
                               //eObj.setValue(20); //""""
                               //eObj.setValue(5); // no event

            Console.Read();
        }
    }
}