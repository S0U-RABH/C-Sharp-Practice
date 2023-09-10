namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio myRadio = new Radio(false, "Sony");
            myRadio.SwitchOn();
            myRadio.ListenRadio();


            TV MyTv = new TV(false, "sumsung");
            MyTv.SwitchOn();
            MyTv.ListenRadio();
            MyTv.SwitchOff();
            MyTv.ListenRadio();
            
            Console.ReadKey();
        }
    }
}