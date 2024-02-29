using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Indexer_Eg
    {
        private string[] names = new string[3];
        
        //indexer declaration
        public string this[int f]
        {
            get { return names[f]; }

            set { names[f] = value; }

        }
        public static void Main()
        {
            Indexer_Eg indexer_Eg = new Indexer_Eg();// its has virtual array inside it
            indexer_Eg[0] = "Vikash";// setting the value of names of 0
            indexer_Eg[1] = "Avinash";
            indexer_Eg[2] = "Basavraj";
            Console.WriteLine($"{indexer_Eg[0]} -> {indexer_Eg[1]} -> {indexer_Eg[2]}");
        }
    }
    class Indexer_Eg1
    {
        string[] days = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
        int Get_Day(string day)
        {
            for (int i = 0; i < days.Length; i++)
            {
                if (days[i] == day)
                {
                    return i;
                }
            }
            Console.WriteLine("Arguments must be like \"Sun\",\"Mon\",etc.");
            return -1;
        }
        public int this[string d]
        {
            get { return (Get_Day(d)); }

        }

        static void main()
        {
            Indexer_Eg1 indexer_Eg1 = new Indexer_Eg1();
            Console.WriteLine(indexer_Eg1["Thu"]);
            Console.WriteLine(indexer_Eg1["My day"]);

            Console.Read();

        }
    }
}
