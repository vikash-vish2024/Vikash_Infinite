using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    class Voting_Exception :ApplicationException
    {
        public Voting_Exception(string msg) : base(msg)
        {

        }
    }
    class Vote
    {
        int age;
        public void AcceptAge()
        {
            Console.WriteLine("Enter your age : ");
            age = Convert.ToInt32(Console.ReadLine());

            if (age <= 18)
            {
                throw (new Voting_Exception("Under Age for voting"));
            }
            else
            {
                Console.WriteLine("Thank you for voting");
            }
        }
    }
    class User_Define_Exception
    {
        static void Main()
        {
            Vote vote = new Vote();
            try { vote.AcceptAge(); }
            catch(Voting_Exception v)
            {
                Console.WriteLine(v.Message);
            }
            
        }
    }
}
