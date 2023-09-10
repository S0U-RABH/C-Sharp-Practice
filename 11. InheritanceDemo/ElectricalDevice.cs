using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    // Parent Class OR Super Class 
    public class ElectricalDevice
    {

        // boolean to determine the state of the Electrical Device
        public bool IsOn { get; set; }

        // string for the brand name of the Electrical Device
        public string Brand { get; set; }

        public ElectricalDevice(bool isOn, string brand) 
        {
            this.IsOn = isOn;
            this.Brand = brand;
        }

        // switch on the Electrical Device
        public void SwitchOn()
        { IsOn = true; }
    
        // switch off the Electrical Device
        public void SwitchOff() 
        { IsOn = false; }

        //Method to Listen to the Radio
        public void ListenRadio()
        {
            if(IsOn)
            {
                Console.WriteLine("Listening to the Radio.");
            }
            else
            {
                Console.WriteLine("Radio is Switched off, switch it on First");
            }
        }
    }
}
