using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _003_MVP_Timer
{
    public partial class Form1 : Form       // Класс - издатель события.
    {
        public Form1()
        {
            InitializeComponent();
            new Presenter(this);        //Связка с Presenter
        }

        private EventHandler start;
        private EventHandler stop;
        private EventHandler reset;

        public event EventHandler Start     // формируем события, которые будет "генерировать" класс-издатель
        {
            add { start += value; }
            remove { start -= value; }
        }

        public event EventHandler Stop
        {
            add { stop += value; }
            remove { stop -= value; }
        }

        public event EventHandler Reset
        {
            add { reset += value; }
            remove { reset -= value; }
        }



        private void Start_Click(object sender, EventArgs e)    
        {
            start.Invoke(sender, e);                            // "генерация" событий
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            stop.Invoke(sender, e);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            reset.Invoke(sender, e);
        }
    }
}
