using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingInCSharp
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Boxer myBoxer = new Boxer();

            Console.WriteLine(myBoxer.GetPunchPower());     //default value is 0 as its int type in calss boxer

            int number = int.Parse(Console.ReadLine());

            myBoxer.SetPunchPower(80);

            Console.WriteLine(myBoxer.GetPunchPower());
        }
    }
}
