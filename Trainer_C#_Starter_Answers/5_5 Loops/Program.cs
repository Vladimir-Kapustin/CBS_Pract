using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//После объявления переменной inputString написать цикл с постусловием для вывода в консоль с новой строки приглашение «Введите слово длиной в 7 символов», пока введенная строка inputString действительно не будет иметь длину в 7 символов. Учтите, что каждый раз будет вводиться новая строка и ее не надо конкатенировать с предыдущим вводом.
namespace _5_5_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "";

            do
            {
                Console.WriteLine("Введите слово длиной в 7 символов");

                inputString = Console.ReadLine();

            } while (inputString.Length < 7);
        }
    }
}
