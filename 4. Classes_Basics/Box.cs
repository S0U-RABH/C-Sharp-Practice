using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Basics
{
    internal class Box
    {
        // We will Understand Properties in 3 different ways. you can use any one of them in your project.

        // (1) First way Define member Variable and then Make getter  and setter for example like - Lenght
        // Member Variable || fields
        private int Length;
        private int Height;
        //private int Width;
        private int Volume;

        // (3) Third way you can define properties without having member variable for example like - Width 
        public int Width { get; set; }

        // this code exectly same like above (3)
        /*public int Width
        {
            get { return this.Width; }
            set { this.Width = value; }
        }*/


        /// <summary>
        /// This is the Defination of ENCAPSULATION. we restric the accesibility of variable by making Setters and Getters 
        /// </summary>
        /// <param name="SetLenght"></param>

        // Setter to set the value in private menber variable
        public void SetLenght(int length) 
        {
            // So this is the reason we need setters and getters. So we can control the accesibility of variable.
            // if we dont use it Any value is store in Private variable like -4, other values as well.  
            if (length < 0)
            {
                throw new Exception("The Lenght should be greater then Zero ");
            }
            Length = length;
        }

        // Getter to Get the value for private mumber variable 
        public int GetLenght ()
        {
            return Length; 
        }


        // (2) Second way define the properties of Mumber variable for example like - Height
        // you can use condition statement on it as well if needed.
        public int Hieght {
            get { return this.Height; }
            set { this.Height = value; }
        }

        public int GetVolume()
        {
            return Volume = Length * Hieght * Width;
        }

        // Constructor
        public Box(int lenght, int height, int width)
        {
            this.Length = lenght;
            Hieght = height;
            Width = width;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Lenght is {Length} and height is {Height} and width is {Width}. So the volume is {Volume = Length * Height * Width}");
        }
    }
}
