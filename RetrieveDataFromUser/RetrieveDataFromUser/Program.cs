using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetrieveDataFromUser
{
    class Program
    {
        static void Main(string[] args)
        {   // you can check data types in documentation in microsoft website for c# just like C, C++ 
            string firstName;
            string lastName;    //initialising same as c, c++

            Console.WriteLine("Enter Your First Name: ");
                firstName = Console.ReadLine(); // to read text from user ReadLine Method is called and remember readline is a method so () is must
            Console.WriteLine("Enter YOur Last Name: ");
                lastName = Console.ReadLine();
            Console.WriteLine($"Welcome Master {firstName} {lastName}\n");
            // line of code is from top to bottom in C#
            /*multiline comment*/

            //int firstNumber = "XYZ";    // this is false
            int firstNumber;
            int secondNumber;
            int multiply;
            Console.WriteLine("Enter First Number");
            firstNumber = int.Parse(Console.ReadLine()); //int.parse converts string type to integer
            Console.WriteLine("Enter Second Number");
            secondNumber = int.Parse(Console.ReadLine());
            multiply = firstNumber * secondNumber;
            Console.WriteLine($"Result of multiply: {multiply}");
        }
    }
}
