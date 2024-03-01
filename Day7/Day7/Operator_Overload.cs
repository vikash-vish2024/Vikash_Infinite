using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day7
{
    class Travel_Time
    {
        public float timeTaken { get; set; }
        public static Travel_Time operator +(Travel_Time tr1, Travel_Time tr2)
        {
            Travel_Time temp = new Travel_Time();
            temp.timeTaken = tr1.timeTaken + tr2.timeTaken;
            return temp;
        }

    }
    class Travel
    {
        public int Dist { get; set; }
        public DateTime Traveldate { get; set; }

        //overload a '+' operator in order to be able to add 2 distances
        //some rules to be followed
        public static Travel operator +(Travel tr1, Travel tr2)
        {
            Travel temp = new Travel();
            temp.Dist = tr1.Dist + tr2.Dist;
            return temp;
        }
       

    }
    class Operator_Overload
    {
        public static void Main()
        {
            Travel t1 = new Travel();
            Travel t2 = new Travel();
            t1.Dist = 45;
            t2.Dist = 20;
            Travel t3 = t1 + t2;
            Console.WriteLine("The total Distance To Travel is : " + t3.Dist);

            Travel_Time time1 = new Travel_Time();
            Travel_Time time2 = new Travel_Time();
            time1.timeTaken = 1.5f;
            time2.timeTaken = 2.5f;
            Travel_Time travel_Time3 = time2 + time1;
            Console.WriteLine($"The time taken for travel is : {travel_Time3}");

            Console.Read();
        }
    }
}
