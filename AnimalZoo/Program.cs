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

            allAnimals = new Animal[4]; //an array with 4 possible spots to put things in
            /*Cat c = new Cat();
            c.name = "Yukio";*/
            allAnimals[0] = new Cat("Yukio"); // a cat with the name 'Yukio' is put on the first spot in the array
            allAnimals[1] = new Dog("Kero"); // a dog named 'Kero' on the second spot
            allAnimals[2] = new Cat("Joel"); // a cat named 'Joel' on the third spot
            allAnimals[3] = new Bird("Low"); // a birb named 'Low' on the fourth and final spot

            foreach (Animal a in allAnimals) // a loop that goes through all items in
                // the array and prints them out with 'Here comes ' before the name
                // and then an introduction from the anmials
            {
                Console.WriteLine("Here comes " + a.name);
                a.IntroduceYourself();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
