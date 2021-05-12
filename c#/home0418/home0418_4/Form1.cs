using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home0418_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;
            int.TryParse(textBox1.Text, out num);
            double ans = mynum(num);

            if (num >0)
            {
                MessageBox.Show(ans.ToString()); 
            }
            else if(num<0)
            {
                MessageBox.Show("양수입력");
            }
            else
            {
                MessageBox.Show("숫자입력");
            }

           
        }
        private double mynum(int number)
        {
            return number * 3.14;
        }
    }
}
