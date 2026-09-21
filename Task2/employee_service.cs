using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{

    internal class employee_service
    {
        List<employee> employees = new List<employee>();

        public void add_employee()
        {
            int id;

            Console.WriteLine("Enter employee id:");

            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Please enter a valid integer for employee id.");
                    continue;
                }
                else
                {
                    Console.WriteLine("the id number saved");
                    break;
                }
            }
            Console.WriteLine("enter employee name:");
            string s= Console.ReadLine();
            Console.WriteLine("enter employee department:");
            string department= Console.ReadLine();
            Console.WriteLine("enter employee salary:");
            int salary;
            while(true)
            {
                if (!int.TryParse(Console.ReadLine(), out salary))
                {
                    Console.WriteLine("Please enter a valid integer for employee salary.");
                    continue;
                }
                else
                {
                    Console.WriteLine("the salary number saved");
                    break;
                }
            }
            employee emp = new employee(id, s, department, salary); 



        }
        public void view_all()
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"ID: {employee.id}, Name: {employee.name}, Department: {employee.department}, Salary: {employee.salary}");
            }
        }
        public void search_employee()
        {
            Console.WriteLine("Enter employee id to search:");
            int id;
            while(true)
            {
                if (!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine(" enter a valid integer for employee id.");
                    continue;
                }
                else
                {
                    break;
                }
            }
            foreach(var employee in employees)
            {
                if (employee.id == id)
                {
                    Console.WriteLine($"ID: {employee.id}, Name: {employee.name}, Department: {employee.department}, Salary: {employee.salary}");
                    return;
                }
            }

        }
        public void delete_employee()
        {
            Console.WriteLine("enter the id number for the employee");
            int idd;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out idd))
                {
                    Console.WriteLine(" enter a valid integer for employee id.");
                    continue;
                }
                else
                {
                    break;
                }
            }
            foreach(var employee in employees)
            {
                if (employee.id == idd)
                {
                    employees.Remove(employee);
                    Console.WriteLine("employee deleted");
                    return;
                }
            }
            
            return;

        }
        public void ffilter()
        {
            Console.WriteLine("enter the department name ");
            string departmentt= Console.ReadLine();
            foreach(var e in employees)
            {
                if (e.department == departmentt)
                {
                    Console.WriteLine($" Name: {e.name}, Department: {e.department}");
                }
            }
            
            return;

        }
        public void sort()
        {
            employees.Sort();
            foreach (var e in employees)
            {
                Console.WriteLine($" Name: {e.name}, Salary: {e.salary}");
            }
            Console.WriteLine("employees sorted by salary");

        }

    }
}
