using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string fullname = Console.ReadLine();

            string greeting = "Welcome " + fullname;
            Console.WriteLine(greeting);

            Console.ReadLine();
        }
    }
}
