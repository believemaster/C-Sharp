using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatementInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;

            Console.WriteLine("Enter first integer valule");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second integer valule");
            secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumber},{secondNumber}");

            if (firstNumber == secondNumber)
            {
                Console.WriteLine($"True! {firstNumber} is the same as {secondNumber}");
            }
            else if (firstNumber > secondNumber )   // >= <= != same operators as C++
            {
                Console.WriteLine($"{firstNumber} is greater than {secondNumber}");
            }
            else
            {
                Console.WriteLine($"{firstNumber} is smaller than {secondNumber}");
            }
            if (firstNumber != secondNumber)
            {
                Console.WriteLine($"{firstNumber} not equal to {secondNumber}");
            }
            /* else
            {
                Console.WriteLine($"False! {firstNumber} is not same as {secondNumber}");
            } */
                
        }
    }
}
