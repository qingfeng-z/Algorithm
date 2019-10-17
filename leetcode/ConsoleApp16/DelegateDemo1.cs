using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp16
{
    public delegate string DelegateOne(int x);

    public class DelegateDemo1
    {
        // Defines an instance method.
        public string myStringMethod(int myInt)
        {
            if (myInt > 0)
                return ("positive");
            if (myInt < 0)
                return ("negative");
            return ("zero");
        }

        // Defines a static method.
        public static string mySignMethod(int myInt)
        {
            if (myInt > 0)
                return ("+");
            if (myInt < 0)
                return ("-");
            return ("");
        }
    }
}
