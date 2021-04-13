using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chap06Answer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int param = int.Parse(textBox1.Text); //textbox1.text를 숫자로 변환해서 param에 값을 넣어
            double answer = readInch_writeCm(param); //answer라는 변수에 값을 넣고
            label1.Text = answer.ToString(); //answer값을 반환해서 label1에 텍스트로 넣어라
        }
        private double readInch_writeCm(int param)
        {
            return param * 2.54;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int param = int.Parse(textBox2.Text);
            double answer = readKg_writePound(param);
            label2.Text = answer.ToString();
        }

        private double readKg_writePound(int kg)
        {
            return kg * 2.20462262;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            label4.Text = "";
            int r = int.Parse(textBox3.Text);
            double doolle_answer = doolle(r);
            if (doolle_answer == -1)
                return; //-값이 나오면 그냥 공백으로 출력되도록 void를 return함
            double area_answer = area(r);
            if (doolle_answer == -1)
                return;
            label3.Text = doolle_answer.ToString();
            label4.Text = area_answer.ToString();
        }
        private double doolle(int r)
        {
            if (r < 0)
            {
                MessageBox.Show(r+"은 음수입니다");
                return -1;
            }
            else
            {
                return 2 * 3.14 * r;
            }
        }
        private double area(int r)
        {
            if (r < 0)
            {
                MessageBox.Show(r + "은 음수입니다");
                return -1;
            }
            else
            {
                return r * r * 3.14;
            }
        }
    }
}
