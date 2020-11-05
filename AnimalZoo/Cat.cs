using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Cat : Animal
    {
        public Cat(string name)
        {
            species = SPECIES.CAT;
            canFly = false;
            base.name = name;
        }
        public override void IntroduceYourself()
        {
            Console.WriteLine("Meow. I am a cat that is called " + name);
            base.IntroduceYourself();
        }
    }
}
