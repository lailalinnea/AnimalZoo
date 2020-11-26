using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Cat : Animal// the class cat inherits from the class animal
    {
        public Cat(string name, int age)
        {
            SetSpecies(SPECIES.CAT);
            SetCanFly(false);
            SetName(name);
            SetAge(age);
        }
        public override void IntroduceYourself() // the class cat overwrites the introduction in the animal class
        {
            Console.WriteLine("Meow. I am a cat that is called " + GetName() + ". "/* + " and I am " + age + " years old."*/);
            base.IntroduceYourself();
        }
    }
}
