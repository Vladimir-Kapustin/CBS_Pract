using System;
using System.Collections.Generic;   //Целью задания является, как и в примерах урока, максимально скрыть работу объектов, которые являются составными частями основного объекта - Книги. Он становится объектом-фасадом, который скрывает в себе работу других объектов. Это инкапсуляция вариаций.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //New Solution:
            Book book = new Book("Pro C# 5 And .Net Framework 4.5 Platform", "Andrew Troelsen", "Eat some of these delicious French rolls!");
            
            //Old Solution (with Properties):
            //Book book = new Book("Pro C# 5 And .Net Framework 4.5 Platform");
            //book.Author = "Andrew Troelsen";
            //book.Content = "Eat some of these delicious French rolls!";

            //Вообще-то старое решение выглядит как-то приятнее, аккуратнее и лаконичнее, а верхний пример - более громоздко... Хоть я ВСЮ работу и перенёс в объект Book - для эксперимента - когда искал что поправить, проходясь второй раз по этому курсу.

            book.Show();
        }
    }
}
