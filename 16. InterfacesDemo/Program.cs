namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chair OfficeChair = new Chair("white", "wood");
            Chair GameChair = new Chair("Red", "Plastic");

            Car demagedCar = new Car(80.25f, "black");

            demagedCar.DestroyablesNearby.Add(GameChair);
            demagedCar.DestroyablesNearby.Add(OfficeChair);

            demagedCar.Destroy();
            Console.ReadKey();
        }
    }
}