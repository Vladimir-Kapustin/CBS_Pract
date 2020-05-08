using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3_Collection.Citizens;

namespace Task3_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection people = new Collection()                // Для использования такого блока инициализации коллекция
            {                                                   // обязательно должна реализовывать IEnumerble 
                new Student ("Alexey","Petrov",123,"KNU"),      
                new Student ("Ivan","Ivanov",456,"KPI"),
                new Pensioner ("Evstafiy","Nikiforov", 789, 89),
                new Pensioner ("Nikolay", "Sidorov", 321, 81),
                new Worker("Sergey", "Plotnikov", 654, "Avtozavod"),
                new Worker("Petr","Semyonov", 978, "Trubniy Zavod"),
            };

            foreach (Citizen human in people)
            {
                Console.WriteLine(human.ToString());
            }

            Console.WriteLine(new string('-', 50));
            people.Add(new Student("Alexey", "Petrov", 123, "KNU"));    // Добавления не произойдет, т.к. уже есть элемент с таким номером паспорта
            people.Add(new Worker("Maxim", "Gavrilov", 159, "GorTrans"));
            people.Add(new Pensioner("Arkadiy", "Maksimov", 753, 85));

            Console.WriteLine(new string('-', 50));
            people.Remove();                                            // Удаление с начала

            foreach (Citizen human in people)
            {
                Console.WriteLine(human.ToString());
            }

            Console.WriteLine(new string('-', 50));
            people.Remove(new Pensioner("Arkadiy", "Maksimov", 753, 85)); // Удаление конкретного гражданина

            foreach (Citizen human in people)
            {
                Console.WriteLine(human.ToString());
            }

            Console.WriteLine(new string('-', 50));                     // Проверка на наличие
            int index = -1;     // создание индекса для возвращаемого значения из метода Contains
            Console.WriteLine(people.Contains(ref index, new Worker("Sergey", "Plotnikov", 654, "Avtozavod")));

            Console.WriteLine(new string('-', 50));                     // Возвращение последнего
            int anotherIndex = -1;
            Console.WriteLine("Последний гражданин в коллекции: {0}, его номер в очереди - {1}", 
                people.ReturnLast(ref anotherIndex).ToString(), anotherIndex);

            Console.WriteLine(new string('-', 50));
            people.Clear();
        }
    }
}
