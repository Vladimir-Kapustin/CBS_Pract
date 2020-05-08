using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _000_MVP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window    // Это класс-издатель события сейчас.
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);                // создаём объект класса Presenter по слабой ссылке для реализации паттерна MVP
        }

        internal Presenter Presenter    // это автоматически сгенерировалось, когда строил диаграмму классов
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        EventHandler myEvent = null;

        public event EventHandler MyEvent       // (!) Создаём событие, на которое могут подписываться другие разработчики.
        {
            add { myEvent += value; }           // может использоваться для добавления условий проверки ПРЕЖДЕ чем ПОДПИСАТЬ
            remove { myEvent -= value; }        // может использоваться для добавления условий проверки ПРЕЖДЕ чем ОТПИСАТЬ
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            myEvent.Invoke(sender, e);          // Класс-издатель инициирует событие
        }
    }
}
// Полная версия комментариев - в примере кода к уроку.