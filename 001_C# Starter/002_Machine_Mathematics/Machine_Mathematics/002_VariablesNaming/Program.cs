using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_VariablesNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            //int uberflu?;         // не может СОДЕРЖАТЬ "другие" символы;
            string myVar;
            string _Identifier;     // технически может начинаться со знака "нижнее подчёркивание" и с любого алфавитного символа;
            int \u006fIdentifier;   // Unicode - \u006f
            //double &myVar;        // не может начинаться с цифр и "других" символов;
            //decimal 3myVar;
            char myVariab1le;       // содержать цифры - может.
        }
    }
}
