using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Bird : Animal
    {
        public Bird(string name, int age)
        {
            SetSpecies(SPECIES.BIRD);
            SetCanFly(true);
            SetName(name);
            SetAge(age);
        }
        public override void IntroduceYourself()
        {
            Console.WriteLine("Tweet. I am a bird called " + GetName() + ". "/* + " and I am " + age + " years old."*/);
            base.IntroduceYourself();
        }
    }
}
