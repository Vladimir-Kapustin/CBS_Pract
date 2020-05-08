using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Collection.Citizens
{
    class Pensioner : Citizen
    {
        public Pensioner(string firstName, string lastName, int passpId, int age)
            : base(firstName, lastName, passpId)
        {
            Age = age;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, пенсионер, {2} года, № паспорта {3}", FirstName, LastName, Age, PassportId);
        }
    }
}
