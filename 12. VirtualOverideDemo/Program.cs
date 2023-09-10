namespace VirtualOverideDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Bella", 15);
            Console.WriteLine($"{dog.Name} is {dog.Age} year old.");

            dog.Play();
            dog.Eat(); 
            dog.MakeSound();

            Console.ReadLine();
        }
    }
}