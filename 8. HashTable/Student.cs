using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float SGPA { get; set; }

        public Student(int Id, string Name, float SGPA) 
        {
            this.Id = Id;
            this.Name = Name;
            this.SGPA = SGPA;
        }
    }
}
