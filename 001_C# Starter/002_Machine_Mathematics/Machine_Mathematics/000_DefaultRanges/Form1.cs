using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _000_DefaultRanges
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("from 0 to 255");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("from -128 to +127");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("from 0 to 65535");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("from -32768 to +32767");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("from 0 to 4294967295");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("from -2147483648 to +2147483647");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("from 0 to 18446744073709551615");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("from -9223372036854775808 to +9223372036854775807");
        }
    }
}
