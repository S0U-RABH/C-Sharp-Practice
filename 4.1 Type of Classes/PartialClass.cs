using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1_Type_of_Classes
{
    /*
          A partial class is a class that is split into multiple files, allowing the definition of the class to be in multiple places.
          This is useful for separating different aspects of a class into different files.
     */
    internal partial class PartialClass
    {
        public void Method1()
        {
            Console.WriteLine("Partial Class Method 1");
        }
    }

    internal partial class PartialClass
    {
        public void Method2()
        {
            Console.WriteLine("Partial Class Method 2");
        }
    }
}
