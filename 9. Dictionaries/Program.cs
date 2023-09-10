namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Key - Value Pair
            // StudentID - Student

            // Declairation of Dictionaries 
            Dictionary<int, string> MyDictionary = new Dictionary<int, string>()
            {
                {1,"first"},
                {2,"Second"},
                {3,"Third"}

            };

            // declair array of employee
            Employee[] employee = new Employee[]{
                new Employee("CEO", "Gwyn", 95, 200) ,
                new Employee("Manager", "Joe", 35, 25) ,
                new Employee("HR", " Lora", 32, 21),
                new Employee("Secretary", "Petra", 28, 18),
                new Employee("Lead Developer", "Artorias", 55, 35),
                new Employee("Intern", " Ernest", 22, 8),
            };

            Dictionary<string, Employee> employeeDictionaries = new Dictionary<string, Employee>();
            // Store Employee[] Data in Dictionatires. 
            foreach (Employee  emp in employee)
            {
                employeeDictionaries.Add(emp.Role, emp);
            }

            // access individual data with Role  using ContainsKey()
            string key = "CEO";
            if (employeeDictionaries.ContainsKey(key))
            {
                Employee emp1 = employeeDictionaries[key];
                Console.WriteLine($"Employee name {emp1.Name}, Role : {emp1.Role}, Age : {emp1.Age}, Salary : {emp1.Salary}");
            }else
            {
                Console.WriteLine("No Employee Found With This Key {0}",key); 
            }

            Employee result = null;
            //using TryGetVa1ue() it returns returns true if the operation was successful and false otherwise
            if (employeeDictionaries.TryGetValue("Intern", out result))
            {
                Console.WriteLine(result.Name);
            }
            else {
                Console.WriteLine("The Key Does not Exit"); 
            }
              

            // access entire data from dictionarie
            foreach (Employee item in employeeDictionaries.Values)
            {
                Console.WriteLine($"{item.Role}, {item.Name}, {item.Age}, {item.Rate}");
            }
            //Updating or Deleting element in dictionary 
            //Update
            string KeyToUpdate = "HR";
            if(employeeDictionaries.ContainsKey(KeyToUpdate))
            {
                employeeDictionaries[KeyToUpdate] = new Employee("HR", "Ereka", 26, 18);
                Console.WriteLine("The Key {0} Is Updated ", KeyToUpdate);
            }
            else
            {
                Console.WriteLine("No Employee Found with this Kye {0}", KeyToUpdate);
            }
            //Delete
            string KeyToRemove = "Intern";
            if (employeeDictionaries.Remove(KeyToRemove))
            {
                Console.WriteLine("Employee with role/key {0} is remove", KeyToRemove);
            }
            else
            {
                Console.WriteLine("No Employe found with this key");
            }
        }
    } 
}