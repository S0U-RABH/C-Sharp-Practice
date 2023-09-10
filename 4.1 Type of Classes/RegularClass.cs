namespace _4._1_Type_of_Classes
{
    /*
     Regular Class:
        A regular class is a basic class that can have fields, properties, methods, and events.
        It can be instantiated, and objects can be created from it.
     */
    internal class Regular_Class
    {
        // Fielda
        private int Number;

        //properties
        public int Numbers
        {
            get { return Number; }
            set { Number = value; }
        }

        // Method
        public void Display()
        {
            Console.WriteLine("The Number is {0}.", Number);
        }
    }
}
