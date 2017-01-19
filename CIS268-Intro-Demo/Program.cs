using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS268_Intro_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name. ");

            string name = Console.ReadLine();

            Console.WriteLine("Enter your age in years. ");
            int age = int.Parse( Console.ReadLine() );

            Console.WriteLine("Hello, " + name);
            Console.WriteLine("You are {0} months old.", age*12 );

            Console.ReadKey();

        }
    }
}
