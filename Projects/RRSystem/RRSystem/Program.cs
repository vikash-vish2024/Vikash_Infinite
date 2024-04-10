using System;
using System.Collections.Generic;
using RRSystem.BusinessLayer_s.User;
using RRSystem.BusinessLayer_s.Admin;

namespace RRSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Welcome to Railway Resevation System------");
            Console.WriteLine("Press Enter/Tab to Continue....");
            Console.ReadKey();
            Console.WriteLine("\n1. Admin Login Press '1'\n2. User Login Press '2':");
            Console.Write("your Choice :");
            int inst = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (inst == 1)
            {
                Console.WriteLine(DateTime.Now);
                Admin_Fun.Admin_Login();
            }
            else if (inst == 2)
            {
                Console.WriteLine("---Welcome User To Railway Reservation System---");
                User_Fun.User_Login();
            }
            else
                Console.WriteLine("Please Choose a valid Option");

            Console.Read();
        }
    }
}
