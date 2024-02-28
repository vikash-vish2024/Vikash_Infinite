using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    struct Struct_Enumrations
    {
        //enum is data type which is a value type that can be used to define named constants
        public static void Test_Structure_Class()
        {
            //object of structure
            //Customer cust1;//or
            Customer cust1 = new Customer();
            cust1.custrating = 10;
            // Console.WriteLine(cust1.custrating);

            Customer cust2 = new Customer();
            cust2 = cust1;//cust1 data get copied into cust2
            Console.WriteLine("Custmer 1 Rating-> " + cust1.custrating + " Customer 2 rating-> " + cust2.custrating);
            Console.WriteLine("After Change");
            cust2.custrating = 2;
            Console.WriteLine("Custmer 1 Rating-> " + cust1.custrating + " Customer 2 rating-> " + cust2.custrating);


        }
        public static void Enum_Cities()
        {
            foreach (int x in Enum.GetValues(typeof(cities)))
            {
                // Console.WriteLine(x);
                if (x == 1)
                    Console.WriteLine(Enum.GetName(typeof(cities), x) + " is a graden city");
                else if (x == 2)
                    Console.WriteLine(Enum.GetName(typeof(cities), x) + " is a temple city");
                else if (x == 3)
                    Console.WriteLine(Enum.GetName(typeof(cities), x) + " is a clothes city");
                else if (x == 4)
                    Console.WriteLine(Enum.GetName(typeof(cities), x) + " is a metro city");
                else
                    Console.WriteLine(Enum.GetName(typeof(cities), x));

                //Console.WriteLine("__________________________________");
                //foreach(string s in Enum.GetNames(typeof(cities)))
                //{
                //    Console.WriteLine(s);
                //}
            }
        }
        public static void Enum_Colors()
        {
            foreach (string s1 in Enum.GetNames(typeof(colors)))
            {
                Console.WriteLine(s1);
            }
        }
        enum colors { Red, Blue, Yellow, Black, Voilet }
        enum cities { Agra, Banglore, Chennai, Delhi, Hyderabad, Kolkata, Mumbai, Viazg }



        public static void Main()
        {
            //Struct_Enumrations.Test_Structure_Class();
            //Struct_Enumrations.Enum_Cities();
            //Struct_Enumrations.Enum_Colors();

        //var data type
            var myvar = 56;
            myvar = 'G';
            Console.WriteLine(myvar);

            //dynamic data type
            dynamic d;
            d = 8;
            d = 'u';
            Console.WriteLine(d);
            d = "hhhh";
            Console.WriteLine(d);
            d = 66.7f;
            d = 4567.87;
            d = true;
            Console.WriteLine(d);

            Console.Read();

        }
    }



    struct Customer
    {

        public int custrating;

        public void Give_customer_Rating()
        {
            Console.WriteLine("Enter the rating of the customer");
            custrating = Convert.ToInt32(Console.ReadLine());
        }

    }
}
