using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    internal class Sphere : Shape
    {
        public double Radius { get; set; }

        public Sphere(double Radius) 
        {
            Name = "Sphere";
            this.Radius = Radius;
        }
        
        public override double Volume()
        {
            return Math.PI * (Math.Pow(Radius, 3) * 4 / 3);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("The Sphere hase the Radius of {0}", Radius);
        }
    }
}
