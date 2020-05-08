using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Employee
{
    class Employee
    {
        readonly string lastName, firstName;

        //Свойства (только для чтения) - Имя и Фамилия сотрудника
        public string FirstName
        {
            get { return firstName; }
        }

        public string LastName
        {
            get { return lastName; }
        }

        //Свойство для указания должности
        public string Position { get; set; }

        //Свойство для указания опыта
        public int Experience { get; set; }

        //К-ры - по умолчанию и пользовательский
        public Employee() { }

        public Employee(string lastName, string firstName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
        }

        //Метод, рассчитывающий оклад сотрудника и налоговый сбор
        public void CalculateSalaryAndTax()
        {
            int salary = 0;
            double tax = 0.17;
            
            //Расчёт зарплаты в зависимости от должности
            switch (Position.ToLower())
            {
                case "worker":
                    {
                        salary = 500;
                        break;
                    }
                case "manager":
                    {
                        salary = 1000;
                        break;
                    }
                case "director":
                    {
                        salary = 1500;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("No such position. Insert correct");
                        break;
                    }
            }
            
            //Расчёт зарплаты в зависимости от стажа
            if (Experience > 0 && Experience < 15)
            {
                salary += 250;
            }
            else if (Experience >= 15)
            {
                salary += 450;
            }

            //Вывод на экран зарплаты
            Console.WriteLine("Salary is: {0}", salary);    //--Хорошо было бы вынести это в отдельный метод - но тогда либо придётся в нём дважды запускать метод расчёта, либо в классе создавать дополнительные поля - для зарплаты и для налога, присваивать им значения в методе расчёта и обращаться к ним уже в этом методе вывода на экран.

            //Расчёт и вывод на экран налогового сбора
            Console.WriteLine("Tax is: {0}", salary * tax);
        }
    }
}
