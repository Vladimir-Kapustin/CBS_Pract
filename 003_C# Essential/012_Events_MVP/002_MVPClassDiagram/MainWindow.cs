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

namespace _002_MVPClassDiagram
{
    public class MainWindow
    {
        private EventHandler myEvent;

        public event EventHandler MyEvent;
    
        public MainWindow()
        {
            //InitializeComponent();
            new Presenter(this);
        }

        public Presenter Presenter
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void button1_Click(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
