using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Dog : Animal
    {

        public Dog(string name, int age)/* : base(age)*/
        {
            SetSpecies(SPECIES.DOG);
            SetCanFly(false);
            SetName(name);
            SetAge(age);
        }
        public override void IntroduceYourself()
        {
            Console.WriteLine("Woof. I am a dog thats called " + GetName() + ". " /*+ " and I am " + SetAge() + " years old."*/);
            base.IntroduceYourself();
        }
    }
}
