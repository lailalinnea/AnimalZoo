using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo 
{
    class Animal // parent class
    {
        public enum SPECIES { CAT, DOG, BIRD }; // a special type representing a group of constants
        // values that dont change

        //instansce variable
        public string name; // a string with names
        public SPECIES species; // 
        public bool canFly; // can fly? true false

        private int birthYear;

        //class variable
        private static int currentYear = 2020;

        public void SetAge(int age)
        {
            birthYear = currentYear - age;
        }

        public int GetAge ()
        {
            int age = currentYear - birthYear;
            return age;
        }

        public static void SetYear(int year)
        {
            currentYear = year;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public SPECIES GetSpecies()
        {
            return species;
        }

        public void SetSpecies(SPECIES species)
        {
            this.species = species;
        }

        public bool GetCanFly()
        {
            return canFly;
        }

        public void SetCanFly(bool canFly)
        {
            this.canFly = canFly;
        }

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

            Console.WriteLine("I am  " + GetAge() + " years old.");
            Console.WriteLine(" ");
        }
    }
}
