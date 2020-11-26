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
            Animal.SetYear(2019);

            Animal yukio = new Cat("Yukio", 4);
            Animal kero = new Dog("Kero", 2);
            Animal joel = new Cat("Joel", 1);
            Animal low = new Bird("Low", 19);

            yukio.IntroduceYourself();
            kero.IntroduceYourself();
            joel.IntroduceYourself();
            low.IntroduceYourself();

            Animal.SetYear(2020);

            yukio.IntroduceYourself();
            kero.IntroduceYourself();
            joel.IntroduceYourself();
            low.IntroduceYourself();

            Console.ReadKey();

            /* Animal[] allAnimals;

             allAnimals = new Animal[4]; //an array with 4 possible spots to put things in
             *//*Cat c = new Cat();
             c.name = "Yukio";*//*
                             // the constructor Cat Dog and Bird creates intances to put into allAnimals
             allAnimals[0] = new Cat("Yukio"); // a cat with the name 'Yukio' is put on the first spot in the array - an object
             allAnimals[1] = new Dog("Kero"); // a dog named 'Kero' on the second spot - an object
             allAnimals[2] = new Cat("Joel"); // a cat named 'Joel' on the third spot - an object
             allAnimals[3] = new Bird("Low"); // a birb named 'Low' on the fourth and final spot - an object

             allAnimals[0].age = 4;
             allAnimals[1].age = 2;
             allAnimals[2].age = 1;
             allAnimals[3].age = 5;

             foreach (Animal a in allAnimals) // a loop that goes through all items in
                 // the array and prints them out with 'Here comes ' before the name
                 // and then an introduction from the anmials
             {
                 Console.WriteLine("Here comes " + a.name);
                 a.IntroduceYourself();
                 Console.WriteLine();
             }
             Console.ReadKey();*/
        }
    }
}
