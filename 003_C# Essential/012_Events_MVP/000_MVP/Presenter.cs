using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_MVP
{
    class Presenter     // Это элемент "Presenter" из MVP. Он действует над Моделью и Видом. (над данными из них). Извлекает данные из хранилища (модели) и форматирует их для отображения в Виде (view).
    {                   // Здесь Presenter - класс-подписчик события.
        Model model = null;                 // Model
        MainWindow mainWindow = null;       //View

        public Presenter(MainWindow mainWindow)                                 // К-р инициализирует в Презентере Модель и Вид
        {
            this.model = new Model();
            this.mainWindow = mainWindow;
            this.mainWindow.MyEvent += new EventHandler(mainWindow_myEvent);    //Подписка на событие
        }

        void mainWindow_myEvent(object sender, System.EventArgs e)              // Метод - обработчик
        {
            string variable = model.Logic(this.mainWindow.textBox1.Text);

            this.mainWindow.textBox1.Text = variable;
        }
    }
}
// В Презентере - "пришиваются" вместе Вид и Модель
