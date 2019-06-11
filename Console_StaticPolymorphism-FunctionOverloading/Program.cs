using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_StaticPolymorphism_FunctionOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Enter a digit:");
                string strinput = Console.ReadLine();

                int input = strinput.IndexOf(".");   //look for "." on the text and return indexof(location)

            if (input == -1)   // means the entered number doesn't include "."
                PrintClass.Print(int.Parse(strinput));
            else
                PrintClass.Print(double.Parse(strinput));

            Console.ReadKey();
        }
    }

    // static polymorphism - Function Overloading (Methods with same name ; different signiture) - compile-Time
    public class PrintClass
    {
        public static void Print(int x)     
        {
            Console.WriteLine("You entered integer digit: {0}",x);
        }
        public static void Print(double x)
        {
            Console.WriteLine("You entered a double digit: {0}", x);
        }
    }

}
