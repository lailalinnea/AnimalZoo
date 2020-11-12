using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo 
{
    class Animal // parent class
    {
        public enum SPECIES { CAT, DOG, BIRD }; // a special class representing a group of constants
        // values that dont change

        public string name; // a string with names
        public SPECIES species; // 
        public bool canFly; // can fly? true false

        public virtual void IntroduceYourself() // every one is affected by this  (cat dog bird)
        {
            if (canFly == true)
            {
                Console.WriteLine("I can fly!"); // if canFly is true this is added to the introduction
            }
            else
            {
                Console.WriteLine("I cannot fly."); // if canFly is false this is added to the intro
            }
            Console.WriteLine("My species is a : " + species); // this is added to everyones intro with their 
            // respective species 
        }
    }
}
