using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0412_2
{
     
    public partial class Form1 : Form
    {
        Random r = new Random();
        List<string> num = new List<string>();

        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = num.Count;


            Game g = new Game();
            g.rock = "바위";
            g.scissors = "가위";
            g.paper = "보";

           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
