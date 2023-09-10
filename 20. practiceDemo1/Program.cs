using System.Collections;
using System.Runtime.CompilerServices;

namespace _20._practiceDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable EmployeeData = new Hashtable();

            IEmployee ep1 = new IEmployee("Sourabh", 444.44d, "IT");
            IEmployee ep2 = new IEmployee("Vipin", 444.44d, "IT");
            IEmployee ep3 = new IEmployee("Aman", 255.65d, "Digital Marketing");

            EmployeeData.Add(ep1.Id, ep1);
            EmployeeData.Add(ep2.Id, ep2);
            EmployeeData.Add(ep3.Id, ep3);

            Console.WriteLine("Employee DataBase --\n");

            // retrieve all values from a Hashtable

            foreach (DictionaryEntry entry in EmployeeData)
            {
                IEmployee temp = (IEmployee)entry.Value;
                Console.WriteLine($"Employee ID : {temp.Id}, Employee Name : {temp.Name}, Employee Salary : {temp.Salary}, Employee Department : {temp.Department}\n");
            }


        }
    }
}