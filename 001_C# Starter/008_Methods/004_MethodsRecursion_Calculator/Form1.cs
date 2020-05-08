using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _004_MethodsRecursion_Calculator
{
    public partial class Form1 : Form
    {
        //Инициализация елементов управленя на форме
        public Form1()
        {
            InitializeComponent();
        }

        //Обработчик события нажатия по кнопке 1
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) // Remainder
            {
                textBox3.Text = (int.Parse(textBox1.Text) % int.Parse(textBox2.Text)).ToString();
            }
            else  if (radioButton2.Checked)  // Power Of
            {
                textBox3.Text = Involution(long.Parse(textBox1.Text), long.Parse(textBox2.Text)).ToString(); // Можно Math.Pow вместо Involution, а то ошибки может выдавать.
            }
            else if (radioButton3.Checked)  // Concatenation
            {
                textBox3.Text = textBox1.Text + textBox2.Text;
            }
            else if (radioButton4.Checked)  // Division
            {
                textBox3.Text = (double.Parse(textBox1.Text) / double.Parse(textBox2.Text)).ToString();
            }
            else
            {
                textBox3.Text = "Choose Operation!";
            }
        }
        static long Involution(long multiplier, long power)
        {
            power--;
            if (power==0)
            {
                return multiplier ;
            }
            return multiplier*Involution(multiplier, power);
        }
    }
}
