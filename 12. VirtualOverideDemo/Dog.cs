using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverideDemo
{
    internal class Dog : Animals
    {

        public bool IsHappy { get; set; }

        // simple constructor where we pass the name and age to our base constructor 
        public Dog(string Name, int Age) : base(Name, Age) 
        {
            IsHappy= true;
        }

        //  simple override of the virtual method Eat()
        public override void Eat()
        {
            //to call the eat method from our base class we use the keyword "base"
            base.Eat();
        }

        public override void MakeSound() {
            // since every animal will make a tottaly different sound
            //each animal will implement their own version of MakeSound
            Console.WriteLine("Wuuf!..");
        }
        public override void Play()
        {
            //check if the dog is happy if yes call the Play method from the base
            //class
            if (IsHappy)
            {
                base.Play();
            }
        }

    }
}
