using System.Collections;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Learn HashTables
           // Its has Key - Value Pairs 
           // Auto - car

            // Declair HashTable.
            Hashtable StudentTable = new Hashtable();

            // Create object for students After that we store it in HashTable
            Student stud1 = new Student(1,"Sourabh" ,77.1f);
            Student stud2 = new Student(2, "Sourabh", 78.1f);
            Student stud3 = new Student(3, "Sourabh", 79.1f);
            Student stud4 = new Student(4, "Sourabh", 80.1f);

            // Adding student Detail in HashTable
            StudentTable.Add(stud1.Id, stud1);
            StudentTable.Add(stud2.Id, stud2);
            StudentTable.Add(stud3.Id, stud3);
            StudentTable.Add(stud4.Id, stud4);

            // this is the way to access the store object in HashTable.
            // retrieve individual item with known ID.
            Student StoredStudent = (Student)StudentTable[stud1.Id];

            Console.WriteLine($"Student ID : {StoredStudent.Id}, Student Name : {StoredStudent.Name}, Student SGPA : {StoredStudent.SGPA}");

            // retrieve all values from a Hashtable
            foreach (DictionaryEntry entry in StudentTable)
            {
                Student temp = (Student)entry.Value; 
                Console.WriteLine($"Student ID : {temp.Id}, Student Name : {temp.Name}, Student SGPA : {temp.SGPA}");
            }

            // Other way using foreach loop. you can access directly using class 
            foreach (Student value in StudentTable.Values)
            {
                Console.WriteLine($"Student ID : {value.Id}, Student Name : {value.Name}, Student SGPA : {value.SGPA}");
            }
            Console.ReadKey();

        }
    }
}