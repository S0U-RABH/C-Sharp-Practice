using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This class is the blue print of DataType
namespace Classes_Basics
{
    internal class Human
    {
        // Use access specifer like public , private , protected,..... for member variable by default its protected
        // Member Variable 
        public string FirstName;
        public string LastName;
        private string Eyecolor;
        private int Age = 0;

        // Menber function or Method
        public void IntroduceMyself() 
        {
            
            if (FirstName != null && LastName != null && Eyecolor != null && Age != 0)
            {
                Console.WriteLine($"Hi, My name is {FirstName} {LastName}! I am {Age} year old and I have {Eyecolor} eye color.");
            }else if (FirstName != null && LastName != null && Eyecolor != null)
            {
                Console.WriteLine($"Hi, My name is {FirstName} {LastName}! I have {Eyecolor} eye color.");
            }else if (FirstName != null && LastName != null)
            {
                Console.WriteLine($"Hi, My name is {FirstName} {LastName}!");
            }else if (FirstName != null)
            {
                Console.WriteLine($"Hi, My name is {FirstName}!");
            }
        }

        // LEARN CONSTRUCTOR-----------------------------------------------------

        //default constructer
        public Human()
        {
            //Console.WriteLine("Constructor called object is created");
        }

        // Constructor with parameters
        public Human(string FirstName)
        {
            this.FirstName = FirstName;
        }

        public Human(string FirstName, string lastName)
        {
            this.FirstName = FirstName;
            this.LastName = lastName;
        }

        public Human(string FirstName, string lastName, string Eyecolor)
        {
            this.FirstName = FirstName;
            this.LastName = lastName;
            this.Eyecolor = Eyecolor;
        }

        public Human( string FirstName, string lastName,string Eyecolor,int Age ) 
        {
           // FirstName = FirstName;
           // it is bad way of assign becouse complier get confuse which variable is what.
           // so we use this. keywork which means this.FirstName is the variable of object and it get value form local variable of parameter of constructer.
           // and assign to this.FirstName
            this.FirstName = FirstName;
            this.LastName = lastName;
            this.Eyecolor = Eyecolor;
            this.Age = Age;
        }
    }
}
