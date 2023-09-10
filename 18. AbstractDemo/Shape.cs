using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    // Abstract class 
    abstract class Shape
    {
        public string Name { get; set; } = " ";

        public virtual void GetInfo()
        {
            Console.WriteLine("This is the {0}.", Name);
        }

        // abstract Method it will define in sub class and override on runtime.
        public abstract double Volume();    
    }
}
