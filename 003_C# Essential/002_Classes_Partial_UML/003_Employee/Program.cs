using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Ivan", "Petrov");
            
            employee.Position = "director";
            employee.Experience = 0;

            Console.WriteLine(employee.FirstName + " " + employee.LastName + ", " + employee.Position);
            employee.CalculateSalaryAndTax();
        }
    }
}
