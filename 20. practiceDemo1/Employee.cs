using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._practiceDemo1
{
    internal abstract class Employee
    {
        // fields or member function.
        private int id;
        private string name;
        private double salary;
        private string department;

        // properties.
        public int Id { get { return id; } set { this.id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public double Salary { get { return salary; } set { salary = value; } }
        public string Department { get { return department; } set { department = value; } }

    }

    internal class IEmployee : Employee
    {
        //field
        private static int IDCount = 1;

        public IEmployee(string name, double salary, string department) : base()
        {
            int IDNO = IDcount();
            Id = IDNO;
            Name = name;
            Salary = salary;
            Department = department;
        }

        public int IDcount()
        {
            return IDCount++;
        }



    }
}
