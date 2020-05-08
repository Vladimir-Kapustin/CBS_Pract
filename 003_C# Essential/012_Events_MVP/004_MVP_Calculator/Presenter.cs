using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_MVP_Calculator
{
    class Presenter
    {
        Model model;
        MainWindow view;

        public Presenter(MainWindow win)
        {
            this.model = new Model();
            this.view = win;
            
            this.view.Add += view_Add;
            this.view.Subtract += view_Subtract;
            this.view.Multiply += view_Multiply;
            this.view.Divide += view_Divide;
        }

        void view_Divide(object sender, EventArgs e)
        {
            view.TextBox3.Text = model.Divide(double.Parse(view.TextBox1.Text), double.Parse(view.TextBox2.Text));
        }

        void view_Multiply(object sender, EventArgs e)
        {
            view.TextBox3.Text = model.Multiply(double.Parse(view.TextBox1.Text), double.Parse(view.TextBox2.Text));
        }

        void view_Subtract(object sender, EventArgs e)
        {
            view.TextBox3.Text = model.Subtract(double.Parse(view.TextBox1.Text), double.Parse(view.TextBox2.Text));
        }

        void view_Add(object sender, EventArgs e)
        {
            view.TextBox3.Text = model.Add(double.Parse(view.TextBox1.Text), double.Parse(view.TextBox2.Text));
        }
    }
}
