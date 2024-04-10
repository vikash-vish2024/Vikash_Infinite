using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRSystem.BusinessLayer_s.Admin
{
    class Admin_Fun
    {
        static RRSysDBEntities RRS = new RRSysDBEntities();
        static Train_Details td = new Train_Details();

        public static void Admin_Login()
        {
            Console.WriteLine("---Welcome Admin---");
            Validate_Admin();
        }
        static void Validate_Admin()
        {
            //for validating the existing user
            Console.Write("Enter Admin-ID: ");
            int uid = int.Parse(Console.ReadLine());
            Console.Write("Enter Admin Password: ");
            string pass = Console.ReadLine();
            var validate = Validate(uid, pass);

            if (validate)
            {
                Console.WriteLine("---Welcome Admin---");
                AdminOption();
            }
            else
            {
                Console.WriteLine("Invalid Admin-id or Password \n--------Try Again------");
                Validate_Admin();
            }
        }
        private static bool Validate(int admin_id, string passcode)
        {
            Admin_Details ad = new Admin_Details();
            var admin = RRS.Admin_Details.FirstOrDefault(a => a.Admin_id.Equals(admin_id) && a.passcode.Equals(passcode));
            return admin != null;
        }
        static void AdminOption()
        {
            Console.WriteLine("------Welcome To Admin Portal------");
            Console.WriteLine("1. Add Train Press '1'");
            Console.WriteLine("2. Modify Train Press '2'");
            Console.WriteLine("3. Delete Train Press '3'");
            Console.WriteLine("4. Exit... Press '4'");
            Console.Write("Your Choice: ");
            int inst = int.Parse(Console.ReadLine());
            if (inst == 1)
            {
                //Add Train
                Add_Train();
            }
            else if (inst == 2)
            {
                //Modify Train
                UpdateTrainName();
            }
            else if (inst == 3)
            {
                //delete train
                Delete_Train();

            }
            else if (inst == 4)
            {
                Environment.Exit(0);
            }
            else
                Console.WriteLine("Please Choose a valid option");
        }
        //add train into data table
        static void Add_Train()
        {
            Console.Write("Enter Train No: ");
            td.Train_No = int.Parse(Console.ReadLine());
            Console.Write("Enter Train Name: ");
            td.Train_Name = Console.ReadLine();
            Console.Write("Enter Source: ");
            td.Source = Console.ReadLine();
            Console.Write("Enter Destination: ");
            td.Destination = Console.ReadLine();
            RRS.Train_Details.Add(td);
            RRS.SaveChanges();
            User.User_Fun.Show_Train();
            AdminOption();
        }
        //delete train from data table
        static void Delete_Train()
        {
            User.User_Fun.Show_Train();
            Console.Write("Enter Train No you want to delete :");
            int trainno = int.Parse(Console.ReadLine());
            var TrainToRemove = RRS.Train_Details.SingleOrDefault(t => t.Train_No == trainno);
            if (TrainToRemove != null)
            {
                Console.Write("\nAre you sure you want to delete the Train 'Y/N': ");
                string ans = Console.ReadLine().ToUpper();
                if (ans == "Y")
                {
                    RRS.Train_Details.Remove(TrainToRemove);
                    RRS.SaveChanges();
                    Console.WriteLine("\n---Sucessfully Deleted---");
                    User.User_Fun.Show_Train();
                }
                else
                    AdminOption();
            }
            else
            {
                Console.WriteLine("\n ---Train can't be found please select a try form the list---");
                AdminOption();
            }

        }

        //update data into data table
        static void UpdateTrainName()
        {
            User.User_Fun.Show_Train();
            Console.Write("\nEnter the train No you Want to Modify:");
            int tno = int.Parse(Console.ReadLine());
            var modified = RRS.Train_Details.FirstOrDefault(t => t.Train_No == tno);

            if (modified != null)
            {
                Console.Write("You Sure you want to update Y/N: ");
                string ans = Console.ReadLine().ToUpper();
                if (ans == "Y")
                {
                    Console.WriteLine($"Enter Train New Name For Train No: {tno} : ");
                    string tname = Console.ReadLine();
                    modified.Train_Name = tname;
                    RRS.SaveChanges();
                    Console.WriteLine("Train data has been modified");
                    User.User_Fun.Show_Train();
                }
                else
                    AdminOption();
            }
            else
            {
                Console.WriteLine("----Selected Train can't be Found----");
                AdminOption();
            }

        }
    }
}
