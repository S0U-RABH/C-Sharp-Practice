 namespace AbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // we can to instantiate object to abstract class 
            // like this -> public Shape shape = new Shape();
            // But we can use its member variable and methods using variable of shape type.
             
            // here shape is the array of Shape type. its is not a object here.
            Shape[] shape = {new Sphere(4), new Cube(5)};

            foreach (Shape item in shape)
            {
                item.GetInfo();
                Console.WriteLine($"{item.Name} has a volume of {item.Volume()}");

                // Learn as keyword which means convert one type to other type. just like typecasting 
                Cube iceCube = item as Cube;
                if(iceCube == null)
                {
                    Console.WriteLine("This shape is not a Cube. \n");
                }

                // Learn is keyword which means Check one type to other type. just like comparision. 
                if (item is Cube) {
                    Console.WriteLine("This is a Cube. \n");
                }

                // typecasting of objects.
                object cube1 = new Cube(7);
                Cube cube2 = (Cube)cube1;
                Console.WriteLine($"{cube2.Name} Has a volume of {cube2.Volume()} \n");

                Console.ReadKey();
            }
        }
    }
}