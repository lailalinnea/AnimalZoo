using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] allAnimals;

            allAnimals = new Animal[4];
            /*Cat c = new Cat();
            c.name = "Yukio";*/
            allAnimals[0] = new Cat("Yukio");
            allAnimals[1] = new Dog("Kero");
            allAnimals[2] = new Cat("Joel");
            allAnimals[3] = new Bird("Low");

            foreach (Animal a in allAnimals)
            {
                Console.WriteLine("Here comes " + a.name);
                a.IntroduceYourself();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
