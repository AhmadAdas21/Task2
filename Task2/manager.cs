using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class manager : employee
    {
        public manager(int id, string name, string department, float salary) : base(id, name, department, salary)
        {
        }
    }
}
