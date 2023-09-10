using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1_Type_of_Classes
{
    /*
         A nested class is a class defined within another class.
         It is useful when you want to group related classes together or encapsulate helper classes.
     */
    internal class NestedClass
    {
        public int OuterField;

        public class NestedClass1
        {
            public int NestedField;
        }
    }
}
