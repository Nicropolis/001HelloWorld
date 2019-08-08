using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}");
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
