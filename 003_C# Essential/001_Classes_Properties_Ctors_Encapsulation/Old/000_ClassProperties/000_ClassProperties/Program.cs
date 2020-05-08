using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_ClassProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            
            address.Index = 61145;
            address.Country = "Ukraine";
            address.City = "Kharkov";
            address.Street = "Klochkovskaya";
            address.House = "154-a";
            address.Apartment = 156;

            Console.WriteLine(new string('-', 50));

            Console.WriteLine("\nMy Address:\n\nIndex - {0}\nCountry - {1}\nCity - {2}\nStreet - {3}\nHouse - {4}\nApartment - {5}\n", 
                address.Index, address.Country, address.City, address.Street, address.House, address.Apartment);
            
            Console.WriteLine(new string('-', 50));
        }
    }
}
