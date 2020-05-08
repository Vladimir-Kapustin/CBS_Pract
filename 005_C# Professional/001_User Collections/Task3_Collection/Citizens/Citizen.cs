using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Collection
{
    abstract class Citizen
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PassportId { get; set; }
        public int Age { get; set; }

        // Конструкторы

        public Citizen(string firstName, string lastName, int passpId)
        {
            FirstName = firstName;
            LastName = lastName;
            PassportId = passpId;
        }

        public Citizen() { }

        // Переопределение операторов равенства - неравенства
        public static bool operator ==(Citizen c1, Citizen c2)
        {
            return c1.Equals(c2);
        }

        public static bool operator !=(Citizen c1, Citizen c2)
        {
            return !(c1 == c2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Citizen)
            {
                Citizen human = (Citizen)obj;
                return this.PassportId == human.PassportId;
            }
            else
            {
                Console.WriteLine("Типы объектов не сравнимы");
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
