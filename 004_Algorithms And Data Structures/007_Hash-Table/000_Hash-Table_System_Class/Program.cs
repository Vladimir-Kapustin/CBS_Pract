using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_Hash_Table_System_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();

            table.Add("Артём", "Виноградов");
            table.Add("Георгий", "Страшнюк");
            table.Add("Игорь", "Кунин");
            table.Add("Инна", "Старцева");
            table.Add("Елена", "Лигутина");
            table.Add("Андрей", "Безин");
            table.Add("Неля", "Иргизова");
            table.Add("Дмитрий", "Антонов");

            Console.WriteLine("Количество одноклассников (некоторые): {0}", table.Count);


            Console.WriteLine("Одноклассники:");
            foreach (DictionaryEntry de in table)
            {
                Console.WriteLine(de.Key + " " + de.Value);
            }

        }
    }
}
