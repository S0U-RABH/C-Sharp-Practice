using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1_Type_of_Classes
{
    /*
        A static class is a class that cannot be instantiated.
        It can only contain static members (fields, properties, methods).
        It serves as a container for utility methods or constants.  
     */
    internal static class StaticClass
    {
        public static int ConstantValue = 10;

        public static void StaticMethod()
        {
            Console.WriteLine("Static method");
        }

    }
}
