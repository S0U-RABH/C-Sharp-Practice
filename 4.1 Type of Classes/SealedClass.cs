using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1_Type_of_Classes
{
    /*
        A sealed class is a class that cannot be inherited by other classes.
        It is used to prevent further derivation.
        use sealed keyword before class to make it sealed class.
        we can create object for sealed class.
     */
    internal sealed class SealedClass
    {

        // regual method 
        public void Method()
        {
            Console.WriteLine("Sealed class method");
        }

        // we learn selad medhod in  abstract class becouse in seald class we can not  purform inheritance  

    }
}
