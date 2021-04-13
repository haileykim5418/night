using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("함수결과" + f(int.Parse(textBox1.Text)));
        }
        private int f(int x)
        {
            return x * x + 2 * x + 1; //이 값을 반환해서 메세지박스에 출력
        }

        private void button2_Click(object sender, EventArgs e) //void = 비어있는
        {
            //함수 사용하지 않고 해보기
            label1.Text = (int.Parse(textBox2.Text) * int.Parse(textBox2.Text)).ToString();  //결과값을 텍스트로 바꿔서 라벨1에 넣기

            //함수 사용해서 해보기
            MessageBox.Show(power(textBox2.Text));

            example(100, 5, 60);
        }
                 
            private string power(string inputNumber)
        {
            return ""+ int.Parse(inputNumber) * int.Parse(inputNumber);
        }

        private void example(int a, int b, int c)
        {
            int d = a + b + c;
            d = d - a + c * b;
            MessageBox.Show("d값은"+d+"입니다");
        }

        private void bb()  //받는 값, 반환할 값 없음
        {
            MessageBox.Show("he is not good");
        }
    }
}
