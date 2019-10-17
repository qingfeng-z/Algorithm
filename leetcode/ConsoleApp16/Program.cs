using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            var delegateDemo1 = new DelegateDemo1();

            var delegateOne = new DelegateOne(delegateDemo1.myStringMethod);

            var delegateTwo = new DelegateOne(DelegateDemo1.mySignMethod);

            Console.WriteLine("{0} is {1}; use the sign \"{2}\".", 5, delegateOne(5), delegateTwo(5));
            Console.WriteLine("{0} is {1}; use the sign \"{2}\".", -3, delegateOne(-3), delegateTwo(-3));
            Console.WriteLine("{0} is {1}; use the sign \"{2}\".", 0, delegateOne(0), delegateTwo(0));

            Console.WriteLine("Hello World!");
        }
    }
}
