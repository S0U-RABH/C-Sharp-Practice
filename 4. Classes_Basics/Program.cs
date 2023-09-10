namespace Classes_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create an object of my class
            // an intences of human class
            Human Denis= new Human();

            //access public variable from outside, and even change it.
            Denis.FirstName = "Sourabh";
            Denis.LastName = "Shakya";

            // call the method of class.
            Denis.IntroduceMyself();

            //create one new object
            Human Aman = new Human();
            Aman.FirstName = "Aman";
            Aman.LastName = "Verma";
            Aman.IntroduceMyself();

            Console.WriteLine("----------Learn Constructor------------------------------------");

            // create object wtih method
            Human Rahul = new Human("Rahul","Sherma","Brown",24);
            // calling constructor
            Rahul.IntroduceMyself();

            Human vipin = new Human("Vipin","Verma","Black");
            vipin.IntroduceMyself();

            Human golu = new Human("golu", "Gujjar");
            golu.IntroduceMyself();

            Human Don = new Human("Don");
            Don.IntroduceMyself();

            Console.WriteLine("----------Learn Properties-------Setter And Getter-----------------------------");
            // defination of object is define in Box Class.cs
            Box box = new Box(2, 3, 4);
            //box.Length = 10;          // we can acces this code if member variable is public.if it is private we cant access it from Box class.
            box.SetLenght(10);          // we can access this code if member variable is private in Box class
            box.Hieght = 10;            // use same Name that define during defining Height.
            box.Width = 10;
            box.DisplayInfo();

            //for the Help of Getter we can access private Lenght value here. like this.
            Console.WriteLine("The Box Lenght is " + box.GetLenght());
            Console.WriteLine("The Box Height is " + box.Hieght);
            Console.WriteLine("The Box Width is " + box.Width);
            Console.WriteLine("The Box volume is " + box.GetVolume());

            Console.ReadKey();
        }
    }
}