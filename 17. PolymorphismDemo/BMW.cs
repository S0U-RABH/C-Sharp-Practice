using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    //Relationship :-
    // BMW is a car 
    public class BMW : Car
    {
        // field
        private string brand = "BMW";

        public string Model { get; set; }

        public BMW(int HP, string Color, string model) : base(HP, Color)
        {
            Model = model;
        }


        // Here new keyword priotize this method over define in car class  method.
        public new  void ShowDetails()
        {
            Console.WriteLine("Brand :{0} HP:{1} Color :{2}",brand, HP, Color);
        }

        // it overide the virtual methode on runtime
        public override void  Repaired()
        {
            Console.WriteLine("The BMW {0} Was Repaired!", Model);
        }
    }
}
