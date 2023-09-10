using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1_Type_of_Classes
{
    /*
        An abstract class cannot be instantiated and is meant to be derived from.
        It can contain abstract methods that must be implemented by derived classes.
        use abstract keyword before class to make it abstract class.
     */
    internal abstract class AbstractClass
    {
        //abstract Method
        public abstract void AbstractMethod();

        // Regular Method
        public void RegularMethod()
        {
            Console.WriteLine("Regular method from abstraction class");
        }

        // Virtual method its override on runtime.
        public virtual void Method1()
        {
            Console.WriteLine("This is the Virtual Method from abstraction class");
        }
    }


    // To access the Method of abstract class we have to create is derived class.
    internal class DerivedClass : AbstractClass
    {
        // Implementing the abstract method
        public override void AbstractMethod()
        {
            Console.WriteLine("Abstract method implementation by Derived class");
        }
        
        public sealed override void Method1()
        {
            // seal Method con not be further override in sub base class . 
            Console.WriteLine("This is the Sealed Method from Derived Class");
        }
    }
    // create sub derived class to learn the sealed method .
    internal class SubDeriedClass : DerivedClass
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("Abstract method implementation by SubDerivedClass");
        }

        // here you can show it give error 
        // that you can not inherit the sealed method. 
        // we can have access of selaed class but we cant to impleament it but we can call it form this class object.
        // public override void Method1() { }

    }
}
