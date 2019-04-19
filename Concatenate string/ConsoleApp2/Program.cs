using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Character");
            string first = Console.ReadLine();
            Console.WriteLine("Enter Last Character:");
            string last = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Concatenate String: " + first + " " + last);
            Console.Read();
        }
    }
}
