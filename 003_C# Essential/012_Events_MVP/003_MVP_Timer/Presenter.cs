using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_MVP_Timer
{
    class Presenter
    {
        Model model = null;
        Form1 view = null;

        public Presenter (Form1 form)
        {
            this.model = new Model();
            this.view = form;

            this.view.Start += view_Start;
            this.view.Stop += view_Stop;
            this.view.Reset += view_Reset;
            this.view.timer1.Tick += timer1_Tick; // событие timer1.Tick - его не надо прописывать в Form1. Его не надо так описывать как клик по кнопке. - Оно и так само происходит каждую секунду. 
            
            // запуск таймера
            view.timer1.Interval = 1000;  // а это то, что автор ДЗ зафигачил в Form1.Designer.cs :)))
            view.timer1.Start();
            view.timer1.Enabled = false;
        }

       

        void view_Reset(object sender, EventArgs e)
        {
            view.timer1.Stop();
            view.textBox1.Clear();
            model.Reset();
        }

        void view_Stop(object sender, EventArgs e)
        {
            view.timer1.Enabled = false;
        }

        void view_Start(object sender, EventArgs e)
        {
            view.timer1.Enabled = true;
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            view.textBox1.Text = model.Tick();
        }
    }
}
