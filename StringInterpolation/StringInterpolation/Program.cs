using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            string computerName = "BeLi-vE MAstER Windows PC"; // defining a variable of type string
            Console.Write("This is My Computer Name: " + computerName + "\n");   //refering the variable like JAVA
            Console.Write($"This is My Computer Name: {computerName} \n");   //refering the variable in C#. In string interpolation $ sign is used and is must before writing the statement

            string mobileName = "Motrola G4+";
            Console.Write($"This is My Mobile Name: {mobileName} \n");
        }
    }
}
