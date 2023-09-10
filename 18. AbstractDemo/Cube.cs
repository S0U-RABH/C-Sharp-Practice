using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    internal class Cube : Shape
    {   
        public double Length { get; set; }

        public Cube(double Length) 
        {
            Name = "Cube";
            this.Length = Length;
        }

        // Defining Base class method Here 
        public override double Volume()
        {
            return Math.Pow(Length, 3);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("The Cube hase the Lenght of {0}", Length);
        }

    }
}
