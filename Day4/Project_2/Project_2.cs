using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day4;

namespace Project_2
{
    class Project_2 : Access_Specifier_Eg
    {
        static void Main(string[] args)
        {
            Access_Specifier_Eg access_specifier2 = new Access_Specifier_Eg();
            access_specifier2.publicdata = 10;

            Project_2 pj2 = new Project_2();
            pj2.publicdata = 1;
            pj2.intprodata = 2;
            pj2.protectedData = 3;
        }
    }
}
