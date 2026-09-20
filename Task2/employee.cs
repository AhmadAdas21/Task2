using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class employee
    {
       
        public int id { get; set; }
        public string name { get; set; }
        public string department { get; set; }
        public float salary { get; set; }

        public employee(int id, string name, string department, float salary)
        {
            this.id = id;
            this.name = name;
            this.department = department;
            this.salary = salary;
        }

    }
}
