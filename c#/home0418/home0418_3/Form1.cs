using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home0418_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //tryparse
        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;
            bool result = int.TryParse(textBox1.Text, out num);

            if (result ==false)
            {
                MessageBox.Show("숫자입력");
            }
            else
            {
                MessageBox.Show("입력한숫자:"+num);
            }


           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //try catch


            try
            {
                int number = int.Parse(textBox2.Text);
                MessageBox.Show("입력한숫자:" + number);
            }
            catch (Exception ee)

            {

                MessageBox.Show("숫자입력하삼");
            }
        }
    }
}
