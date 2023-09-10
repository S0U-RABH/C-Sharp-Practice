using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    //Relationship :-
    // BMW is a car 
    public class Audi : Car
    {
        // field
        private string brand = "Audi";

        public string Model { get; set; }

        public Audi(int HP, string Color, string model) : base(HP, Color)
        {
            Model = model;
        }

        // Here new keyword priotize this method over define in car class  method.
        public new void ShowDetails()
        {
            Console.WriteLine("Brand :{0} HP:{1} Color :{2}", brand, HP, Color);
        }

        // it overide the virtual methode on runtime
        public override void Repaired()
        {
            Console.WriteLine("The Audi {0} Was Repaired!", Model);
        }
    }
}
