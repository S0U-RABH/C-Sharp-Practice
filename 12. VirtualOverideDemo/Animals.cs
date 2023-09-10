using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverideDemo
{
    internal class Animals
    {
        public string Name { get; set; }

        public int Age { get; set; }
        
        public bool IsHungry { get; set; }
    
    public Animals(string Name , int Age) 
        {
            this.Name = Name;
            this.Age = Age;
            // by default take all animals r hungry
            IsHungry = true;
        }

        //an empty virtual method MakeSound for other classes to override
        public virtual void MakeSound()
        {

        }

        // a virtual method called Eat which sub classes can override
        public virtual void Eat()
        {
            if(IsHungry)
            {
                Console.WriteLine($"{Name} is Eating..");
            }
            else
            {
                Console.WriteLine($"{Name} is not Hungry");
            }
        }
        

        //Virtual Method Play
        public virtual void Play()
        {
            Console.WriteLine($"{Name} Is Playing");
        }
    }
}
