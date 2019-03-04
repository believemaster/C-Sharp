using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesInCSharp
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(new Computer().GetComputerName());

            Computer myComputer = new Computer();
            //Console.WriteLine(myComputer.GetComputerName());
            myComputer.ComputerName = "AUKY";
            Console.WriteLine(myComputer.ComputerName);

            myComputer.ComputerPower = 100;
            Console.WriteLine(myComputer.ComputerPower);

        }
    }
}
