using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Title
    {
        private string content;
        
        public string Content
        {
            private get { return content; } //Это я уже во 2-й раз проходился по курсу и добавил private. Чтоб доступ для чтения к этому методу имел объект только этого класса. И чтоб увидеть значение св-ва можно было только через метод Show(), а не через свойство title.Content, например, в классе Book. Т.е. здесь сокрытие реализации, что некоторые относят к инкапсуляции - а зря.
            set { content = value; }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
