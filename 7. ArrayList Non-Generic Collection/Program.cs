
using System.Collections;

namespace ArrayList_Non_Generic_Collection
{
    internal class Program
    {
        /*
          The generic collections are defined in the System.Collections.Generic namespace. Some commonly used generic collections include:

          List<T>: Represents a dynamic-sized list of elements of type T.
          Dictionary<TKey, TValue>: Represents a collection of key-value pairs, where each unique key is associated with a value of type TValue.
          HashSet<T>: Represents a set of unique elements of type T.
          Queue<T>: Represents a first-in, first-out (FIFO) collection of elements of type T.
          Stack<T>: Represents a last-in, first-out (LIFO) collection of elements of type T.
          By using generic collections, you can benefit from type safety, better performance, and improved code readability.
         */

        /*
         Non-generic collections are defined in the System.Collections namespace. Some commonly used non-generic collections include:

         ArrayList: Represents a dynamically sized collection of objects.
         Hashtable: Represents a collection of key-value pairs that are organized based on the hash code of the key.
         Queue: Represents a first-in, first-out (FIFO) collection of objects.
         Stack: Represents a last-in, first-out (LIFO) collection of objects.
         Non-generic collections are less type-safe compared to generic collections since they operate on System.Object. 
         Therefore, they can lead to runtime errors if the wrong type is cast during retrieval.
         */
        static void Main(string[] args)
        {
            // Non-Generic-Coleecction.
            // Declair an ArryLiast with undefine amount of objects.
            ArrayList myarryList = new ArrayList();

            //declair an ArryLiast with define amount of objects.
            ArrayList myarryList2 = new ArrayList(100);

            myarryList.Add(24);
            myarryList.Add("sourabh");
            myarryList.Add(123.34f);
            myarryList.Add(12390.22312d);
            myarryList.Add(13.2);
            foreach(var i in myarryList) 
            {
                Console.WriteLine(i);
            }
            // Delete  element with specific value from ArrayList
            myarryList.Remove(13.2);

            // Delete element at specific location
            myarryList.RemoveAt(0);

            //check the length of Arraylist use count 
            Console.WriteLine(myarryList.Count);

        }
    }
}