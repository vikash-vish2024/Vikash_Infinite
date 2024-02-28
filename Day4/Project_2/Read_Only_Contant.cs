using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    public class Read_Only_Contant
    {
        readonly bool flag = true; //initializing at the time of declaring
        readonly int ronly;
        //private constructor
        internal Read_Only_Contant()
        {
            Console.WriteLine(flag +"  "+ronly);
            flag = false;
            ronly = 100; // initilaizing the readonly variable in the constructor
            Console.WriteLine("____________________________________");
            Console.WriteLine(flag+" "+ronly);
        }
    }
    class Trail
    {
        public void trailFunc()
        {
            //can not create the instance of class because it is private
            // Read_Only_Contant read_Only_Contant = new Read_Only_Contant();
            
        }
        public static void Main()
        {
            Read_Only_Contant rc = new Read_Only_Contant();
            Console.WriteLine("Hey?");
            Console.Read();
        }

       
    }
}
