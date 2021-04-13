using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test01
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(result(textBox1.Text);
            result();
            //examInch();
            examKg();
            examBan();

        }
        private void result()
        {
            double inch = double.Parse(textBox1.Text);
            label1.Text = inch * 2.54 + "cm";

        }
        private void examInch()
        {
            double inch = double.Parse(textBox1.Text) * 2.54;
            MessageBox.Show(textBox1.Text + "cm => " + inch + "inch!");
        }

        private void examKg()
        {
            double pound = double.Parse(textBox1.Text) * 2.20462262;
            MessageBox.Show(textBox1.Text + "kg =>" + pound + "pound!");
        }

        private void examBan()
        {
            double r = double.Parse(textBox1.Text);
            const double PI = 3.14;
            MessageBox.Show("반지름이 " + textBox1.Text + "인 원의 둘레는 "
                            + (r * PI * 2) + "이고, 넓이는" + (r * PI * r) + "이다.");
        }
    }
}
