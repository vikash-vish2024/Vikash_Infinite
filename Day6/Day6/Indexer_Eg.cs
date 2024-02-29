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
}
