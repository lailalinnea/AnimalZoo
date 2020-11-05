using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Dog : Animal
    {
        public Dog(string name)
        {
            species = SPECIES.DOG;
            canFly = false;
            base.name = name;
        }
        public override void IntroduceYourself()
        {
            Console.WriteLine("Woof. I am a dog thats called " + name);
            base.IntroduceYourself();
        }
    }
}
