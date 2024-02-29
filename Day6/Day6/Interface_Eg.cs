using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public interface ICustomer
    {
         void Print_Cust_Rating(); //only declare ,and no implementation   
    }
    //one interface can implement other interfaces
    interface ICustomer1
    {
        int getRating();
    }
    class  Customer : ICustomer,ICustomer1
    {
        public void Print_Cust_Rating()
        {
        Console.WriteLine("This is the ICustomer Rating");
        }
        public int getRating()
        {
            return 0;
        }
}
    class Interface_Eg : ICustomer,ICustomer1
    {
        public int getRating()
        {
            return 2;
        }
        public void Print_Cust_Rating()
        {
            Console.WriteLine("Rating");
        }

        public static void Main()
        {
           // ICustomer ic;//creating an interface object
          //  ic = new ICustomer();//can not instantiate an interface

            Customer customer = new Customer();
            customer.Print_Cust_Rating();

            Interface_Eg int_eg = new Interface_Eg();
            int_eg.getRating();
            
            Console.Read();
        }
    }
}
