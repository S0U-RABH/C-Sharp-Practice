namespace _4._1_Type_of_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // we create diffrent type of class then here we create object from it.

            Console.WriteLine("\n------------------------1. Regular class------------------------");
            //Regular class 
            Regular_Class Test1 = new Regular_Class();
            Test1.Numbers = 15;
            Test1.Display();

            Console.WriteLine("\n------------------------2. Abstract class------------------------");
            // Abstract class 
            // we can not create object for abstract class.
            // So we create derived class from abstract class to acssess the abstract method from abstract class through derived class.
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.AbstractMethod();
            derivedClass.RegularMethod();
            derivedClass.Method1();

            // learn selaed method.
            Console.WriteLine("\n------------------------ Sealed Method------------------------");
            SubDeriedClass subDeriedClass = new SubDeriedClass();
            subDeriedClass.AbstractMethod();
            subDeriedClass.RegularMethod();
            subDeriedClass.Method1();

            Console.WriteLine("\n------------------------3. Sealed class------------------------");
            // we can create object from sealed class but we cant inherit it.
            SealedClass variable = new SealedClass();
            variable.Method();

            Console.WriteLine("\n------------------------4. Static class------------------------");
            // we can not create object for Static class.
            // static class work like containers you use them directly without object.
            StaticClass.ConstantValue = 15;
            Console.WriteLine("The value is " + StaticClass.ConstantValue);
            StaticClass.StaticMethod();

            Console.WriteLine("\n------------------------5. Partial Class------------------------");
            PartialClass partialClass = new PartialClass();
            partialClass.Method1();
            partialClass.Method2();

            Console.WriteLine("\n------------------------6. Generic Class <DataType> ------------------------");
            GenericClass<int> genericClass = new GenericClass<int>(25);
            genericClass.DisplayValue();
            GenericClass<string> genericClass1 = new GenericClass<string>("Sourabh");
            genericClass1.DisplayValue();


            Console.WriteLine("\n------------------------7. Nested Classes------------------------");
            NestedClass outer = new NestedClass();
            outer.OuterField = 10;
            NestedClass.NestedClass1 inner = new NestedClass.NestedClass1();
            inner.NestedField = 20;
            Console.WriteLine("OuterField value is {0}", outer.OuterField);
            Console.WriteLine("InnerFiels value is {0}", inner.NestedField);

            Console.ReadKey();
        }
    }
}