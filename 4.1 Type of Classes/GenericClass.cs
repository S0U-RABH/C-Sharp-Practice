using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1_Type_of_Classes
{
    /*
        A generic class is a class that can be parameterized with one or more type parameters.
        It allows you to create a class that can work with different data types.
     */
    internal class GenericClass<T>
    {
        private T value;

        // we can find out type of T using typefo(T) or GetType(T).
        private Type type = typeof(T);

        public GenericClass(T value)
        {
            this.value = value;
        }

        public T GetValue()
        {
            return value;
        }

        public void DisplayValue()
        {
            Console.WriteLine("Class Data type is {0}", type);
            Console.WriteLine("The value is {0}", value);
        }
    }
}
