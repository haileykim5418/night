using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace overloading
{
    //오버로딩: 똑같은 이름을 계속 쓸수있게함. 매개변수,타입이 달라야함
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            black();
        }

        private void black()
        {
            MessageBox.Show("가가가");
        }
        private void black(string name)
        {
            MessageBox.Show(name);

        }
        private void black(string name, string name2)
        {
            MessageBox.Show(name+name2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            black(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            black(button2.Text, button1.Text);
        }
    }
}
