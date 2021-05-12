using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home0414
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int a = int.Parse(textBox1.Text);
            label1.Text = cal(a)+"";
          
        }


        private int cal(int x)
        {
            return (x * x) + (x * 2);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myname(textBox2.Text);
        }

        private void myname(string name)
        {
            MessageBox.Show("내이름은"+name);
        }
    }
}
