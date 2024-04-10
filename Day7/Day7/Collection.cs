using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Day7
{
    class Collection
    {
        static void Main()
        {
            //   ArrayList_Function();
            HashTableFunction();
         
            
        }
        public static void ArrayList_Function()
        {
            ArrayList array_list1 = new ArrayList();
            array_list1.Add(10);
            array_list1.Add("g");
            array_list1.Add("Hii");
            array_list1.Add("Hello");
            array_list1.Add(12.05f);
            array_list1.Add(true);
            array_list1.Add("Infinite");

            foreach (var x in array_list1)
            {
                Console.WriteLine(x);
            }
            //Console.WriteLine("-----------------");
            array_list1.Add("Basu");
            array_list1.Add(345.5f);
            array_list1.Add(false);

            array_list1.Insert(6, "Gita");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Adding a range of values");
            ArrayList arraylist2 = new ArrayList();
            arraylist2.Add(13);
            arraylist2.Add(61);
            arraylist2.Add(35);
            arraylist2.Add(23);
            arraylist2.Add(32);
            arraylist2.Add(38);
            Console.WriteLine("------------------");

            array_list1.AddRange(arraylist2);

            arraylist2.Sort();
            foreach(var x in array_list1)
            {
                Console.WriteLine(x);
            }
            // Console.WriteLine($" count is {}");
            Console.WriteLine("------------------");
           foreach(int x in arraylist2)
            {
                Console.WriteLine(x);
            }

        }
        public static void HashTableFunction()
        {
            Hashtable ht = new Hashtable();
            ht.Add("E001", "Samiya");
            ht.Add("E002", "Ramiya");
            ht.Add(null, "simran");
            ht.Add("E006", null);
            foreach(var x in ht.Keys)
            {
                Console.WriteLine(x);
            }
        }
    }
}