namespace Function_Method
{
    internal class Program
    {
        //To call a static method (function), we don't need to instantiate or create an object of that class or method.
        static void Main(string[] args)
        {
            Console.WriteLine("-------------FUNCTION OR METHODS------------------------");
            Myfuction();
            string s1 = "This is my fuction with arguments";
            Myfuction(s1); // fuction||method  with argument 

            int Argument1 = 12;
            int Argument2 = 13;
            int Sum = Myfuction(Argument1,Argument2);
            Console.WriteLine($"Sum of argument1 and argument2 is {Sum}.");
            Console.WriteLine(Myfuction(Myfuction(1, 2), Myfuction(2, 3)));

            // try catch 
            TryCatch();

            // Operator
            Operators();

            Console.Read();
        }





        // access modifier (static) return type method name (parameterl, parameter2)
        public static void Myfuction()
        {
            Console.WriteLine("This is my void fuction");
        }

        // Fuction||Method with parameters 
        public static void Myfuction(string s1)
        {
            Console.WriteLine(s1);
        }

        //Fuction || Method With return type
        public static int Myfuction(int Parameter1,int Parameter2)
        {
            int result = Parameter1 + Parameter2;
            return result;
        }

        public static void TryCatch() 
        {
            Console.WriteLine("----------TRY_CATCH METHOD------------------");

            Console.WriteLine("Please Enter the number ");
            string userInput = Console.ReadLine();
            // if user enter other value expect number. like abdf so it give fomate exception 
            // for that exception we uses try catch method get rid of that eception.

            try
            {
                int userInputasint = Int32.Parse(userInput);
            }
            catch (FormatException)
            {

                Console.WriteLine("Format exception, please enter the correct type next time. ");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Overflow Eception. The value was too large or short");
            }
            catch(ArgumentNullException) 
            {
                Console.WriteLine("Argument Eception. T he value ws Empty(null).");
            }
            finally
            { Console.WriteLine("This is called Anyway!"); }
        }

        public static void Operators()
        {
            Console.WriteLine("-----------------OPERATORS--------------");
            int num1 = 5;
            int num2 = 3;
            int num3;

            // unary operators
            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3);

            bool isSunny = true;
            Console.WriteLine("is it sunny? {0}", !isSunny);

            // increment operators
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num++);
            // pre increment
            Console.WriteLine("num is {0}", ++num);

            // decrement opertor
            num--;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num--);
            // pre decrement
            Console.WriteLine("num is {0}", --num);

            int result;

            result = num1 + num2;
            Console.WriteLine("result of num1 + num2 is {0}", result);
            result = num1 - num2;
            Console.WriteLine("result of num1 - num2 is {0}", result);
            result = num1 / num2;
            Console.WriteLine("result of num1 / num2 is {0}", result);
            result = num1 * num2;
            Console.WriteLine("result of num1 * num2 is {0}", result);
            result = num1 % num2;
            Console.WriteLine("result of num1 % num2 is {0}", result);

            // relational and type operators
            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine("result of num1 < num2 is {0}", isLower);

            // equality operator
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine("result of num1 == num2 is {0}", isEqual);

            isEqual = num1 != num2;
            Console.WriteLine("result of num1 != num2 is {0}", isEqual);

            // conditional operators
            bool isLowerAndSunny;
            // condition1 AND condition2
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("result of isLower && isSunny is {0}", isLowerAndSunny);

            // condition1 OR condition2
            isLowerAndSunny = isLower || isSunny;
            Console.WriteLine("result of isLower || isSunny is {0}", isLowerAndSunny);
            Console.ReadKey();
        }
    }
}