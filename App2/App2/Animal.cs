using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Animal
    {
        public string Name { get; set; }
        private int age;    //instance variable
        private decimal power;  //instance variable
        private decimal speed;  //instance variable

        public Animal(string nameValue, int ageValue, decimal powerValue, decimal speedValue)
        {
            Name = nameValue;
            Age = ageValue;
            Power = powerValue;
            Speed = speedValue;
            
        }

        public int Age
        {
            get
            {
                return age;
            }
            private set     //we can set access specifier in get or set
            {
                if (value > 0)
                {
                    age = value;
                }
            }
        }

        public decimal Power
        {
            get
            {
                return power;
            }
            private set
            {
                if (value > 0)
                {
                    power = value;
                }
            }
        }
        public decimal Speed
        {
            get
            {
                return speed;
            }
            private set
            {
                if (value > 0)
                {
                    speed = value;
                }
            }
        }

        public void IncreaseAge(int ageValue)
        {
            if (ageValue > 0)
            {
                Age = Age + ageValue;
            }
        }

        public void IncreasePower(decimal powerValue)
        {
            if (powerValue > 0)
            {
                Power = Power + powerValue;
            }
        }

        public void IncreaseSpeed(decimal speedValue)
        {
            if (speedValue > 0)
            {
                Speed = Speed + speedValue;
            }
        }
    }
}
