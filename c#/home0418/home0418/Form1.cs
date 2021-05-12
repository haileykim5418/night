using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home0418
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int mynum = 0;
        int rand =0;
      

        public Form1()
        {

            InitializeComponent();
            rand = r.Next(10) + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mynum = int.Parse(textBox1.Text);
           

            if (mynum == rand)
            {
                MessageBox.Show("정답");
                rand =r.Next(10)+1;
                return;
              
            }
            else if (mynum > rand)
            {
                MessageBox.Show("내가 입력한 숫자가 더 큼");
            }
            else
            {
                MessageBox.Show("내가 입력한 숫자가 더 작음");
            }
        }
    }
}
