using System;
using System.Collections.Generic;
using System.Text;

namespace animal
{
    class Animal
    {
        public string name;
        public  string shound;
        public string idnum;
        public static int numOfAnimals = 0;

        public Animal()
        {
        }

        public Animal(string name,string shound, string idnum)
        {
            this.name = name;
            this.shound = shound;
            this.idnum = idnum;
           
        }
        public int numofAnimals()
        {
            return numOfAnimals++;
        }
        public string MakeSound() {

            return name + shound;
        }

    }
}
