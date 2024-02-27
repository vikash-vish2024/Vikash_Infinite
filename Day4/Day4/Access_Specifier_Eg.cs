using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public class Access_Specifier_Eg
    {
        int privatedata; //private by default
        public int publicdata;
        internal int internaldata;
        protected int protectedData;

        internal protected int intprodata;

        public void Test_Private()
        {
            privatedata = 10;
            
            
        }
       
    }
    class Driver : Access_Specifier_Eg
    {
        public void Testing_Access()
        {
            Access_Specifier_Eg access_Specifier = new Access_Specifier_Eg();

            access_Specifier.publicdata = 23;
            access_Specifier.Test_Private();
            access_Specifier.internaldata = 32;
            access_Specifier.intprodata = 80;

            Driver d = new Driver();
            d.publicdata = 1;
            d.internaldata = 2;
            d.protectedData = 3;
            d.intprodata = 4;
            
            
        }
    }
    class Test
    {
        public void Tester()
        {
            Access_Specifier_Eg access_Specifier1 = new Access_Specifier_Eg();
            access_Specifier1.internaldata = 1;
            access_Specifier1.intprodata = 2;
            access_Specifier1.publicdata = 3;
        }
    }
}
