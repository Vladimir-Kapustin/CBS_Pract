using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Content
    {
        private string text;

        public string Text      //Хотелось назвать Content, но Content уже занято классом.
        {
            private get { return text; }    //Это я уже во 2-й раз проходился по курсу и добавил private. Чтоб доступ для чтения к этому методу имел объект только этого класса. И чтоб увидеть значение св-ва можно было только через метод Show(), а не через свойство title.Content, например, в классе Book. Т.е. здесь сокрытие реализации, что некоторые относят к инкапсуляции - а зря.
            set { text = value; }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;      //ForegroundColor - цвет для шрифта!
            Console.BackgroundColor= ConsoleColor.Blue;         //BackgroundColor - для фона.
            Console.WriteLine(Text);
            Console.ForegroundColor = ConsoleColor.Gray;        //Возврат
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
