using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class developer : employee
    {
        public developer(int id, string name, string department, float salary) : base(id, name, department, salary)
        {
        }
    }
}
