using System;                               //--Другой вариант решения. Не скопированный, но после просмотра ДЗ.
using System.Collections.Generic;           //--Отличается тем, что классы решил вынести в отдельные файлы - т.к. код много места занимает,
using System.Linq;                          //--Все вспомогательные методы не должны в таком количестве присутствовать в классе Program,
using System.Text;                          //--для них создаю отдельный статический класс. Из видео позаимствовал - заполнение массива
using System.Threading.Tasks;               //--пару операций с DateTime, тернарный оператор.

namespace Task7_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Train[] trains = new Train[8];

            ProcedureClass.Add(trains);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Вы ввели такие маршруты:");

            ProcedureClass.ShowAll(trains);
            Console.WriteLine(new string('-', 30));

            ProcedureClass.Sort(trains);

            Console.WriteLine("После сортировки:");
            ProcedureClass.ShowAll(trains);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Введите номер поезда");
            int search = Convert.ToInt32(Console.ReadLine());

            ProcedureClass.Search(trains, search);
        }
    }
}
