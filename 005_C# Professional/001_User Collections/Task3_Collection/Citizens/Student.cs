using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Collection.Citizens
{
    class Student : Citizen
    {
        public string University { get; set; }

        public Student(string firstName, string lastName, int passpId, string university)
            : base(firstName, lastName, passpId)
        {
            University = university;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, студент, № паспорта {2}, ВУЗ: {3}", FirstName, LastName, PassportId, University);
        }
    }
}
