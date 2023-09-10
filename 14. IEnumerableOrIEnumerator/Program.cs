using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Intrinsics.X86;

namespace IEnumerableOrIEnumerator
{
    internal class Program
    {
        // 1.1Enumerab1e < T > for generic collections
        // 2.1Enumerab1e for non generic collections

        ///     < summary >
        ///     IEnumerab1e < T > contains a single method that you must implement when implementing this interface;
        ///     GetEnumerator(), which returns an IEnumerator<T> object.
        ///     The returned IEnuction
        ///     by exposing a Current property that points at the object we aremerator<T> provides the ability to iterate through the colle currently at in the collection.
        ///     </summary>
        ///     

        /*   when it is recommended to use the IEnumerab1e interface:
             Your collection represents a massive database table,
             you don't want to copy the entire thing into memory and cause performance issues in your application.
             When it is not recommended to use the IEnumerab1e interface:
             You need the results right away and are possibly mutating / editing the objects later on.
             In this case, it is better to use an Array or a List
        */

        static void Main(string[] args)
        {
            
            DogShelter shelter = new DogShelter();

            foreach (Dog Dogs in shelter)
            { 
                if(!Dogs.isNaughtyDog)
                {
                    Dogs.GiveTreat(2);
                }
                else
                {
                    Dogs.GiveTreat(1);
                }
            }
            Console.ReadLine();
        }

        class Dog
        {
            public string Name { get; set; }
            public  bool isNaughtyDog { get; set; }

            public Dog(string Name, bool isNaughtyDog) 
            {
            this.Name = Name;
            this.isNaughtyDog = isNaughtyDog;
            }

            public void GiveTreat(int numberofTreats)
            {
                // print a message containing the number of treats and the name of the dog
                Console.WriteLine("Dog: {0} said wuoff {1} times! .", Name, numberofTreats);
            }
        }

        class DogShelter : IEnumerable<Dog>
        {
            public List<Dog> Dogs;
            
            public DogShelter()
            {
                Dogs = new List<Dog>()
                {
                    new Dog( "Casper", false),
                    new Dog( "Sift" , true),
                    new Dog( "Oreo", false),
                    new Dog( "Pixel", false)
                };
            }

            IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
            {
                return Dogs.GetEnumerator();
            }
                  
            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }
    }
}