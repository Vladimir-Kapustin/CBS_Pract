using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Способ 1.
            //Book.Notes note1 = new Book.Notes("My New Note 1");
            //note1.PrintNote();

            //Book.Notes note2 = new Book.Notes("My new note 2");
            //note2.PrintNote();

            // 2. Способ 2.

            Book.Notes note = new Book.Notes();
            note.MakeNote = "first note";
            note.MakeNote = "second note";

            Console.WriteLine(note.MakeNote);


            Console.ReadKey();
        }
    }
}
