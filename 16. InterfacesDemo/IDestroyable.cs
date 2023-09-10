using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    public  interface IDestroyable
    {
        // we declaired to things here which implementation r define in car or chair class 
        string DestroySounnd { get; set; }

        void Destroy();
    }
}
