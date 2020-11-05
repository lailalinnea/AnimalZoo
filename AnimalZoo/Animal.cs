using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Animal
    {
        public enum SPECIES { CAT, DOG, BIRD };

        public string name;
        public SPECIES species;
        public bool canFly;

        public virtual void IntroduceYourself()
        {
            if (canFly == true)
            {
                Console.WriteLine("I can fly!");
            }
            else
            {
                Console.WriteLine("I cannot fly.");
            }
            Console.WriteLine("My species is a : " + species);
        }
    }
}
