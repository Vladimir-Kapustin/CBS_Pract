using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_ClassProperties
{
    class Address
    {
        private int index, apartment;
        private string country, city, street, house;
        
        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        
        public string House
        {
            get { return house; }
            set { house = value; }
        }
        
        public int Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }
    }
}
