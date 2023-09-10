namespace Hello_world_.net5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Primative data type 
            int num1 =20; 
            int num2 =10;
            int num3 =num1+ num2;
            
            Console.WriteLine(num3);
            // concatination
            Console.WriteLine("Num1: "+ num1 +" num2: "+ num2 +" is "+ num3);

            // long integiner
            long x1 = 1236465321354613;
            Console.WriteLine(x1);

            //signed byte 
            sbyte x = (sbyte)x1;
            Console.WriteLine(x);

            // double
            double f1 = 22.22;
            double f2 = 11.11;
            double f3 = f1 / f2;  
            Console.WriteLine(f3);

            // float 
            float ff1 = 2.0f;
            float ff2 = 1.0f;
            float ff3 = ff1 / ff2;
            Console.WriteLine(ff3);

            // decimal
            decimal d1 = 10.2m;
            decimal d2 = 05.0m;
            decimal d3 = d1 / d2;
            Console.WriteLine(d3);

            //bool
            bool x2 = false;
            Console.WriteLine(x2);

            // char
            char z = 'A';
            Console.WriteLine(z);

            //string
            string s = "String";
            Console.WriteLine(s);

            string s1 = s.ToLower();
            Console.WriteLine(s1);

            // short
            short S = 16;
            Console.WriteLine(S);

            Console.ReadKey();
        }
    }
}