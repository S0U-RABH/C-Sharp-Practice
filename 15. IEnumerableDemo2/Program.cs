using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace IEnumerableDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating a generic IEnumerable variable that takes any collection of type int
            //we will use this variable to store the collections that will get returned by the Getcollection() method
            IEnumerable<int> values;
            values = GetCollection(0);
            Console.WriteLine("This Was List <int> ");
            // foreach number in the collection we got back from GetC011ection(0);
            foreach (int i in values)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(" ");

            // call GetC011ection() with option = 1 which will return a Queue<int>
            // but we will store it in the base type of generic collections
            values = GetCollection(1);
            Console.WriteLine("This Was Queue <int> ");
            foreach (int i in values)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(" ");

            values = GetCollection(4);
            Console.WriteLine("This Was Unknown <int> ");
            foreach (int i in values)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(" ");


            Console.WriteLine("--------------Passing IEnumerable Collection As An Arguement-------------------------------- ");
            // a list of type List<int> initialized with some number
            List<int> List2 = new List<int>() { 1,2,3,4,5};
            // an array of type int[] initialized with some numbers
            int[] numberArray = new int[] { 1, 7, 1, 3 };
            CollectionSum(List2);
            Console.WriteLine(" ");
            CollectionSum(numberArray);
            Console.WriteLine(" ");

            Console.ReadKey();

        }

        static IEnumerable<int> GetCollection(int option)
        {
            List<int> Numberlist = new List<int>() { 1,2,3,4,5,6,7};
            Queue<int> NumberQueue = new Queue<int>();
            NumberQueue.Enqueue(8);
            NumberQueue.Enqueue(9);
            NumberQueue.Enqueue(10);
            NumberQueue.Enqueue(11);
            NumberQueue.Enqueue(12);
            NumberQueue.Enqueue(13);

            if(option == 0)
            {
                return Numberlist;
            }else if(option == 1)
            {
                return NumberQueue;
            }
            else
            {
                return new int[] { 14,15,16,17,18,19,20 };
            }

        }
        static void CollectionSum(IEnumerable<int> anycollection)
        {
            // sum variable to store the sum of the numbers in anycollection
            int sum = 0;
            // for each number in the collection passed to this method
            foreach (int num in anycollection) {
                // add the num value to sum
                sum += num;
            }
               
            //print the sum
            Console.Write("Sum is {0}", sum);

        }
    }
}