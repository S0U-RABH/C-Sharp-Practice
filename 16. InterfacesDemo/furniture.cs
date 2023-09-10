using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    public class furniture
    {
        public string color { get; set; }
        public string Material { get; set; }

        public furniture() 
        {
            color= "red";
            Material = "Wood";
        }
        public furniture(string color, string Material)
        {
            this.color = color;
            this.Material = Material;
        }
    }
}
