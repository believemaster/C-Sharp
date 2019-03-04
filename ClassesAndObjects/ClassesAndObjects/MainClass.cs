using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// namespace in other words name of project
    class MainClass
    {
        static void Main(string[] args)
        {
        Animal lion = new Animal(); // assigning objects just like java

        Console.WriteLine(lion.GetAnimalName());

        lion.SetAnimalName("LION");     //pass arguments(real values are called argument)

        Console.WriteLine(lion.GetAnimalName());

        Animal tiger = new Animal();

        Console.WriteLine(tiger.GetAnimalName());

        tiger.SetAnimalName("TIGER");

        Console.WriteLine(tiger.GetAnimalName());
        }
    }
