using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    public class Car : Vehicle , IDestroyable
    {
        public List<IDestroyable> DestroyablesNearby;

        public string DestroySounnd { get; set; }

        public Car(float speed, string color) : base (speed, color) 
        { 
            DestroyablesNearby = new List<IDestroyable>();
            DestroySounnd = "CarExplosionSound.mp3";
        }

        public void Destroy ()
        {
            Console.WriteLine("The {0} color car with the speed of {1} was crashed.",color,speed);
            Console.WriteLine("Playing destruction sound {0}", DestroySounnd);
            Console.WriteLine("Create Fire");

            foreach (IDestroyable destroyble in DestroyablesNearby)
            {
                destroyble.Destroy();
            }
        }


    }
}
