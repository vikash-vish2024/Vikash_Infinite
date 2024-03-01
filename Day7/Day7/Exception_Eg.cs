using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    class Exception_Eg
    {
        public static void Main()
        {
            int a, b, c;
            try
            {
                Console.WriteLine("Enter Two Numbers :");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = a / b;
                int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
               // raise an index out of bound exception
                Console.WriteLine(arr[8]);
                Console.WriteLine(c);
                Console.Read();

            }
            catch(FormatException fe)
            {
                Console.WriteLine("Please Enter the numbers only");
            }
            catch(DivideByZeroException de)
            {
                Console.WriteLine(de.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Something went wrong...");
            }

            finally
            {
                Console.WriteLine("Reached finally block");
                Console.Read();
            }
        }
    }
    
}
