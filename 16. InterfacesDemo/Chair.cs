using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    public class Chair : furniture, IDestroyable
    {
        public string DestroySounnd { get; set; }
      
        public Chair(string color, string Material) : base(color, Material)  
        {
            DestroySounnd = "ChairDestructionSound.mp3";
        }

        public void Destroy() {
            Console.WriteLine($"The {color} chair was destroyed. ");
            Console.WriteLine("Playing Destruction Sound.", DestroySounnd);
            Console.WriteLine("Spawning chair parts");
        }
    }
}
