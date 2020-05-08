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

namespace _004_MVP_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        #region События и поля для событий
        private EventHandler add;
        private EventHandler subtract;
        private EventHandler multiply;
        private EventHandler divide;

        public event EventHandler Add
        {
            add { add += value; }
            remove { add -= value; }
        }

        public event EventHandler Subtract
        {
            add { subtract += value; }
            remove { subtract -= value; }
        }

        public event EventHandler Multiply
        {
            add { multiply += value; }
            remove { multiply -= value; }
        }

        public event EventHandler Divide
        {
            add { divide += value; }
            remove { divide -= value; }
        }
        #endregion

      

        #region Обработчики нажатий и генерация событий
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            add.Invoke(sender, e);
        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            subtract.Invoke(sender, e);
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            multiply.Invoke(sender, e);
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            divide.Invoke(sender, e);
        } 
        #endregion
    }
}
