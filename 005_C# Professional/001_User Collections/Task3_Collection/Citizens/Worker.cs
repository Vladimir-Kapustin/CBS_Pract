using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Collection.Citizens
{
    class Worker : Citizen
    {
        public string Organization { get; set; }

        public Worker(string firstName, string lastName, int passpId, string organization)
            : base(firstName, lastName, passpId)
        {
            Organization = organization;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, работник, № паспорта {2}, организация: {3}", FirstName, LastName, PassportId, Organization);
        }
    }
}
