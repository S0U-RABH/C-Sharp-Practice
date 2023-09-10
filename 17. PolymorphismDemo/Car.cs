using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    public  class Car
    {
        public int  HP { get; set; }
        public string Color { get; set; } 
        // Has a Relationship
        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarIdInfo(int IDnum, string owner)
        {
            carIDInfo.IDNum = IDnum;
            carIDInfo.Owner = owner;
        }
        public void GetCarIDInfo()
        {
            Console.WriteLine("The car has a ID of {0} and is owner is {1} ",carIDInfo.IDNum,carIDInfo.Owner);
        }



        public Car (int HP , string Color) {
            this.HP = HP;
            this.Color = Color;
        }

        public void ShowDetails()
        {
            Console.WriteLine("HP: {0} Color :{1}" ,HP,Color);
        }

        // overide on runtime
        public virtual void Repaired()
        {
            Console.WriteLine("Car Was Repaired!");
        }
    }
}
