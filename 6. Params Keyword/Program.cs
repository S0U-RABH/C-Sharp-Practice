namespace Params_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Passisng arguements as much we can pass.
            ParamsMethod("Hi", "My", "Name", "is", "Sourabh");

            //declair object for params keyword
            int age = 20;
            string name = "Sourabh";
            float salary = 100000.2500f;
            paramsMethod1(salary, age, name); // passing aguements 

            // math Method min Max 
            int[] ary = { 14, 29, 67, 58, 34, 66, 69 ,2};
            paramsMethod2(ary);
        }

        //params keyword help as to take as many arguement as we can there is no limits.
        static void ParamsMethod(params string[] args)
        {
            foreach (string arg in args)
            {
                Console.Write(arg + " ");
            }
        }

        // we can pass objects as well with diffrent data type.
        static void paramsMethod1(params object[] args)
        {
            foreach (object arg in args)
            {
                Console.Write(arg + " ");
            }
        }

        static void paramsMethod2(params int[] args)
        {
            int min = args.Max();
            int max = args.Min();
            //foreach (int arg in args)
            //{
            //    if (arg < min)
            //    {
            //        min = arg;
            //    }
            //}

            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}