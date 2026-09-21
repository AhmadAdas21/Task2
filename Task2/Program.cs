using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            bool ok = true;
            int c;
            employee_service service = new employee_service();
            while (ok)
            {
                Console.WriteLine("************************");
                Console.WriteLine("Employee Management System");
                Console.WriteLine("Choose one of the features below:");
                Console.WriteLine("1 add employee");
                Console.WriteLine("2 view all employees");
                Console.WriteLine("3 search an employee");
                Console.WriteLine("4 delet an employee");
                Console.WriteLine("5 filter employees by department");
                Console.WriteLine("6 sort employees by salary");
                Console.WriteLine("7 exit");
                if (!int.TryParse(Console.ReadLine(), out c))
                {
                    Console.WriteLine(" enter a number between 1 and 7.");
                    continue;


                }
                switch (c)
                { 
                    case 1:
                        service.add_employee();break;
                    case 2: service.view_all(); break;
                    case 3: service.search_employee(); break;
                    case 4: service.delete_employee(); break;
                    case 5: service.ffilter(); break;
                    case 6: service.sort(); break;
                    case 7: Console.WriteLine("Thank you for using our system"); ok = false; break;

                }

            }
        }
       
    }
}