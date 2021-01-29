using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cal
{
    void ButtonOperator(object sender)
    {
        if (textBox1.Text.Length > 0)
        {
            Button btn = (Button)sender;
            if (btn.Text.Equals("+"))
            {
                // textBox1.Text += btn.Text;

                // textBox1.Text값의 마지막 문자열을 가져온다.
                String s1 = textBox1.Text.Substring(textBox1.Text.Length - 1, 1);
                if (s1 == "+")
                {
                    // textBox1.Text += btn.Text; // 이 코드가 살아있으면 +를 누를 때마다 출력됨
                }
                else
                {
                    textBox1.Text += btn.Text;
                }



            }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("button_Click value : 1");
            textBox1.Text += "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
        }
        private void 영_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        
         void ButtonsClick(object sender) // sender 함수
            {
              // n개 출력 방법은 동적인 방법 두가지
              //textBox1.Text = textBox1.Text + button11.Text; // 첫번째 방법
              Button btn = (Button)sender; // 두번째 방법
              textBox1.Text = textBox1.Text + btn.Text;

              // 더하기
              String[] str1 = textBox1.Text.Split("+".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
              if (str1.Length == 2)
              {
                  int a1 = Convert.ToInt32(str1[0]);
                  int a2 = Convert.ToInt32(str1[1]);
                  int result = a1 + a2;
                  // 출력하는 두가지 방법
                  textBox1.Text = "" + result; // 첫번째 방법
                                                 // textBox1.Text = string.Format("%d", result); // 두번째 방법
               }
         }

        private void button11_Click_1(object sender, EventArgs e)
        {
            ButtonsClick(sender);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ButtonsClick(sender);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ButtonsClick(sender);
        }

        private void textBox1(object sender, EventArgs e)
        {

        }
    }


    

        }
    






