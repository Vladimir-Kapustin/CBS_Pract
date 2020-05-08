using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Task3
{
    class Book
    {
        // 1. Способ 1.
        
        //public class Notes
        //{
        //    string note;
        //    public Notes (string str)
        //    {
        //        Console.WriteLine("Making note: " + str);
        //        note = str;
        //    }
        //    public Notes() { }
        //    public void PrintNote ()
        //    {
        //        Console.WriteLine(note);
        //    }
        //}

        // 2. Способ 2.
        // или так
        public class Notes
        {
            string note = "";
            public string MakeNote
            {
                set
                {
                    if (note != "")
                        note += "\n";
                    note += value;
                }
                get 
                {
                    return note;
                }
            }
        }
        

        public string FindNext(string str)
        {
            Console.WriteLine("Поиск строки : " + str);
            return "Found Some Text with ";
        }
    }
}
