using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRSystem.BusinessLayer_s.User
{
    class User_Fun
    {
        static RRSysDBEntities RRS = new RRSysDBEntities();
        Train_Details td = new Train_Details();
        static User_details ud = new User_details();
        static Booked_Ticket bt = new Booked_Ticket();
        static int uid;
        public static void User_Login()
        {
            Console.WriteLine("Existing User Press '1'");
            Console.WriteLine("New User Press '2'");
            Console.WriteLine("For Exiting From the Console App Press '3'");
            Console.Write("Your Choice : ");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x == 1)
            {
                Console.WriteLine("\n---Wwelcome User---");
                Validate_User();
            }
            else if (x == 2)
            {
                Console.WriteLine("----Welcome To Registration Portal----");
                User_details();
                User_Option();
            }
            else if (x == 3)
            {
                Environment.Exit(0);
            }

        }
        //for Diplaying all trains
        public static void Show_Train()
        {
            Console.WriteLine("\n---Train Details---");
            var trains = RRS.Train_Details.ToList();
            int cnt = 1;
            Console.WriteLine($"->\tTrain-No\t\tTrain-Name\t\tSource\t\tDestination");
            foreach (var train in trains)
            {
                Console.WriteLine($"{cnt}\t{train.Train_No}\t\t\t{train.Train_Name}\t\t{train.Source}\t{train.Destination}");
                cnt++;
            }
        }
        //for ticket booking
        public static void BookTicket(int uid,int trainno)
        {
            Random r = new Random();
            int pnr = r.Next(11111, 99999);
            bt.PNR_No = pnr;
            bt.User_id = uid;
            bt.Train_No = trainno;
            Console.Write("\nEnter Passenger Name: ");
            string pname = Console.ReadLine();
            bt.Passenger_Name = pname;
            Console.Write("\nPassenger Age: ");
            int age = int.Parse(Console.ReadLine());
            bt.Passenger_Age = age;
            Console.Write("For First class Press '1'\nSecond Class '2'\nThird Class '3'\nSleeper Class '4'\nYour Choice:");
            int input = int.Parse(Console.ReadLine());
            double totfare=0;
            switch (input)
            {
                case 1:
                    totfare = CalcFare(trainno, "First");
                    break;
                case 2:
                    totfare = CalcFare(trainno, "Second");
                    break;
                case 3:
                    totfare = CalcFare(trainno, "Third");
                    break;
                case 4:
                    totfare = CalcFare(trainno, "Sleeper");
                    break;
                default:
                    Console.WriteLine("Please Choose a Valid option");
                    break;
            }
            bt.TotalFare = totfare + 70;
            bt.Booking_Date_Time = DateTime.Now;
            RRS.Booked_Ticket.Add(bt);
            RRS.SaveChanges();
            Console.WriteLine("Booking Confirm...");
            RRS.SeatManageProc(trainno,input);   // calling procedure
            User_Option();
        }
        //calculate fair
        static double CalcFare(int trno, string cls)
        {
            var totalFare = RRS.Class_Fare.Where(f => f.Train_No == trno).Select(f => f.C1_A).FirstOrDefault();
            if (cls == "Second")
                totalFare = RRS.Class_Fare.Where(f => f.Train_No == trno).Select(f => f.C2_A).FirstOrDefault();
            else if (cls == "Third")
                totalFare = RRS.Class_Fare.Where(f => f.Train_No == trno).Select(f => f.C3_A).FirstOrDefault();
            else if (cls == "Sleeper")
                totalFare = RRS.Class_Fare.Where(f => f.Train_No == trno).Select(f => f.SL).FirstOrDefault();

            return totalFare;
        }
        public void CancelTicket()
        {
            //Cancle Ticket
        }
        //for showing the existing booked ticket for the user
        static void ShowBookedTicket(int uid)
        {
            var booked_tkt = RRS.Booked_Ticket.Where(bt => bt.User_id == uid);
            foreach(var bt in booked_tkt)
            {
                Console.WriteLine("\n----------------------");
                Console.WriteLine($"PNR No: {bt.PNR_No}\tTrain No: {bt.Train_No}\tBooking Date&Time :{bt.Booking_Date_Time}\nPassenger Name: {bt.Passenger_Name}" +
                    $"\tAge: {bt.Passenger_Age}\tSource: {bt.Train_Details.Source}\tDestination: {bt.Train_Details.Destination}\nTotal Fare: {bt.TotalFare}");
                Console.WriteLine("70-Rs Extra for platform Charges..");
                Console.WriteLine("----------------------\n");
            }
        }
        //for getting the and seeting the user details into database
        static void User_details()
        {
            Console.Write("Enter User-id : ");
            uid= int.Parse(Console.ReadLine());
            ud.User_id = uid;
            Console.Write("\nEnter Name : ");
            ud.User_Name = Console.ReadLine();
            Console.Write("\nEnter Age : ");
            ud.Age = int.Parse(Console.ReadLine());
            Console.Write("\nEnter Passcode : ");
            ud.Passcode = Console.ReadLine();
            RRS.User_details.Add(ud);
            RRS.SaveChanges();
        }
        //what user can do with his level of permission
        static void User_Option()
        {
            Console.WriteLine("\n----Ticket Booking and cancellation Portal----");
            Console.WriteLine("1. Book Ticket Press '1'");
            Console.WriteLine("2. Show Booked Ticket Press '2'");
            Console.WriteLine("3. Cancel Ticket Press '3'");
            Console.WriteLine("4. Exit... Press '4'");
            Console.Write("Your Choice : ");
            int inst = Convert.ToInt32(Console.ReadLine());
           
            if (inst == 1)
            {
                Console.WriteLine("\n---Welcome to Ticket Booking Portal---");
                Show_Train();
                Console.Write("\nEnter Train Number of Train you want to book ticket for:");
                int trainno = int.Parse(Console.ReadLine());
                ShowFare_Seat(trainno);
                BookTicket(uid, trainno);

            }
            else if (inst == 2)
            {
                Console.WriteLine("---Booked Ticket---");
                ShowBookedTicket(uid);
            }
            else if (inst == 3)
            {
                //cancel ticket
                Console.WriteLine("Cancel ticket");
            }
            else if (inst == 4)
            {
                Environment.Exit(0);
            }
            else
                Console.WriteLine("Please Choose a valid option");
        }

        //showing avl seats and price for different classes
        static void ShowFare_Seat(int tno)
        {
            var fare = RRS.Class_Fare.Where(t => t.Train_No == tno).SingleOrDefault();
            var seat = RRS.Seat_Availability.Where(s => s.Train_No == tno).SingleOrDefault();
            Console.WriteLine("\n---Prices and Available Seats for Different Train Classes---");
            Console.WriteLine("Train No\tFirstAC\tSeats\t\tSecondACSeats\t\tThirdAc\tSeats\t\tSL\tSeats");

            Console.WriteLine($"{fare.Train_No}\t\t{fare.C1_A}Rs\t{seat.C1_A}\t\t{fare.C2_A}Rs\t{seat.C2_A}\t\t{fare.C3_A}Rs\t{seat.C3_A}\t\t{fare.SL}Rs\t{seat.SL}");
            
        }
        //validating id and pass while log in
        static void Validate_User()
        {
            //for validating the existing user
            Console.Write("Enter User-ID: ");
            uid = int.Parse(Console.ReadLine());
            Console.Write("Enter User Password: ");
            string pass = Console.ReadLine();
            var validate = Validate(uid, pass);

            if (validate)
            {
                User_Option();
            }
            else
            {
                Console.WriteLine("Invalid User-id or Password \n--------Try Again------");
                User_Login();
            }
        }
        private static bool Validate(int user_id, string passcode)
        {
            var user = RRS.User_details.FirstOrDefault(u => u.User_id == user_id && u.Passcode == passcode);
            return user != null;
        }

       
    }
}

