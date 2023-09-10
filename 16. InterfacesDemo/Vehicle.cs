using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    public class Vehicle
    {
        public float speed { get; set; }
        public string color { get; set; }

        public Vehicle() 
        {
         speed = 125.25f;
         color= "red";
        }

        public Vehicle (float speed, string color)
        {
            this.speed = speed;
            this.color = color;
        }
    }
}
