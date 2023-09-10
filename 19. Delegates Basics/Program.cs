

namespace _19._Delegates_Basics
{
    internal class Program
    {
        // defining a delegate type called FilterDe1egate that takes a
        // person object and returns a bool
        public delegate bool FilterDelegate(Person P);

        internal class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        static void Main(string[] args)
        {
            List<string> Name = new List<string>() { "Dennis", "Robert", "Mike", "John" };
            Console.WriteLine("----Before----");
            foreach (string s in Name) Console.WriteLine(s);

            // calling RemoveA11 and passing a method Filter we created.
            // Passing method refrence as parameter  this is called Delegates

            Name.RemoveAll(Filter); // RemoveAll is Delegate

            Console.WriteLine("----After----");
            foreach (string s in Name) Console.WriteLine(s);

            Console.WriteLine("--------Create our own Delegate --------");
            // Create 4 Person Object
            Person s1 = new Person() { Name = "Robert", Age = 19 };
            Person s2 = new Person() { Name = "John", Age = 29 };
            Person s3 = new Person() { Name = "Jonny", Age = 25 };
            Person s4 = new Person() { Name = "Ben", Age = 15 };

            //Add Object to the list
            List<Person> People = new List<Person>() { s1, s2, s3, s4 };

            DisplayPeople("Minor", People, IsMinor);
            Console.WriteLine("--------Anonymous Method Delegate --------");
            // Anonymous Method.
            // here we created a new variable called filter of type FilterDe1egate.
            // then we assigned an anonymous method to it instead of an already defined method
            FilterDelegate filter1 = delegate (Person person)
            {
                return person.Age > 18;
            };
            //Calling anonymous method
            DisplayPeople("Adult", People, filter1);
            // Other way
            DisplayPeople("\nAll People", People, delegate (Person person) { return true; });

            //Lambda Expression
            Console.WriteLine("--------lambda Expression --------");
            string searchKey = "o";
            // Lambda Exprestion with Statement.
            DisplayPeople($"Age > 20 with search Keyword {searchKey}", People, (p) =>
                 {
                     if (p.Name.Contains(searchKey) && p.Age > 20)
                     {
                         return true;
                     }
                     else
                     {
                         return false;
                     }
                 });
            // Lambda Expresstion with single line code exprestion.
            DisplayPeople("exactly age 25", People, p => p.Age == 25);
            Console.ReadKey();

        }


        // a method called Filter that takes a string
        static bool Filter(string s)
        {
            // return whether the string s contains the letter 'i'
            // the Contains method will return a bool which we will return as well
            return s.Contains("i");
        }

        // a method to display the list of people that passes the filter condition
        // (returns true)
        // this method will take a title to be displayed, the list of people,
        // and a filter delegate
        static void DisplayPeople(string title, List<Person> People, FilterDelegate filter)
        {
            Console.WriteLine(title);
            foreach (Person p in People)
            {
                //check if this person passes the filter
                if (filter(p))
                {
                    Console.WriteLine("{0},{1} years old.", p.Name, p.Age);
                }
            }
        }

        // -------------filters-------------------
        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }


    }
}