namespace PolymorphismDemo
{
    internal class Program
    {
        // Create a base class Car with two poperties HP and Color
        // Create a Constructor setting those two properties
        // Create a Method called ShowDetai1s() which shows the HP and Color of the car on the console
        // Create a Repair Method which writes "Car was repaired! " onto the console
        // Create two deriving classes, BMW and Audi, which have their own constructor and have an aditional property
        // called Model. Also a private member called brand. Brand should be different in each of the two classes.
        // Create the two methods ShowDetai1s() and Repair in them as well. Adjust those methods accordingly.

        static void Main(string[] args)
        {
            /*
             * COMPILE TIME POLYMORPHISM    ||   METHOD OERLOADING POLYMORPHISM :- 
             
                // a car can be a BMW, an Audi, a Porsche etc.
                // Polymorphism at work #1: an Audi. Porsche
                // can all be used whereever a Car js expected. No cast is
                // required because an implicit conversion exists from a derived
                // class to its base class.

             */
            // we create Car object type list and store it in variable cars after that me create object which is of type Car
            var cars = new List<Car>()
            {
                new Audi(280, "Blue", "A4"),
                new BMW(250 ,"Orange","M3")
            };

            /*
             * RUNTIME POLYMORPHISM     ||    METHOD OVERRIDING POLUMORPHISM:- 

                // Polymorphism at work #2: the virtual method Repair is
                // invoked on each of the derived classes, not the base class.
             
             */
            foreach (var car in cars)
            {
                // we define Repaired Method in class class so the decide which method to be called on runtime.
                // its called method overriding or runtime polimorphism
                car.Repaired();
            }


            Console.WriteLine("-----------New Keyword----------");
            //create object of type car.
            // if you create object using base class type so it use base class Methods.
            Car BmwM5 = new BMW(250, "Red", "M5");
            Car audiA5 = new Audi(280, "Silver", "A5");
            BmwM5.ShowDetails();
            audiA5.ShowDetails();

            // create object of type sub class
            // if you create object using sub class so they use sub class method.
            BMW bmwM7 = new BMW(300, "Royal", "M7");
            bmwM7.ShowDetails();


            Console.WriteLine("-----------Has A Relationship----------");
            BmwM5.SetCarIdInfo(1234, "Denis Punjuta");
            audiA5.SetCarIdInfo(1254, "Sourbah");
            BmwM5.GetCarIDInfo();
            audiA5.GetCarIDInfo();
            Console.ReadKey();
            // Sealed Keyword it seal the override method so that no one the acess it only that class have acess on it.
            // example - public sealed override void repaired(){}  
            // we can also make sealed class by using seald keyword befor class name 
        }

    }
}