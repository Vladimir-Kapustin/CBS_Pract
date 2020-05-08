using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_Readonly
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Admin", "Vladimir", "Kapustin", 37);
            
            user.Show();
        }
    }
}
