using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Bird : Animal
    {
        public Bird(string name)
        {
            species = SPECIES.BIRD;
            canFly = true;
            base.name = name;
        }
        public override void IntroduceYourself()
        {
            Console.WriteLine("Tweet. I am a bird called " + name);
            base.IntroduceYourself();
        }
    }
}
