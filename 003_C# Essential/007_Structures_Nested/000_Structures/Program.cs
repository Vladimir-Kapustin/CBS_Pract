using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            NoteBook note = new NoteBook("Wolkswagen", "WW, GmbH", 50000);
            note.Print();

            Console.WriteLine(note.Manufacturer);

            Console.ReadKey();
        }
    }
}
