using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Animal
    {
        private string animalName;//only accessed in this calss only, this is a instance variable

        // seters or initialise method
        public void SetAnimalName(string name)//in this method parameters are provided as string //can be accessed outside of this class also
        {
            animalName = name;
        }
        // getter or call method
        public string GetAnimalName()
        {
            return animalName;
        }
    }
