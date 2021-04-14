using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace answer_Func
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int input); 
            MyMath1 m = new MyMath1();//인스턴스메소드는 이거 해줘야함
            MessageBox.Show(textBox1.Text+"의 제곱은" + m.Power(input));   //new mymath.power(input)해도됨
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int input);
            int.TryParse(textBox2.Text, out int count);


            MessageBox.Show(textBox1.Text + "의" +textBox2.Text+"곱은"+MyMath1.Power(input,count));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox3.Text, out int end);
            MessageBox.Show("0부터"+end +"까지의 합은"+MyMath1.SumAll(end));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox3.Text, out int start);
            int.TryParse(textBox4.Text, out int end);

            MessageBox.Show(start+"부터" + end + "까지의 합은" + MyMath1.SumAll(start, end));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MyMath1 m = new MyMath1(); //인스턴스 생성
            int.TryParse(textBox3.Text, out m.end);
            MessageBox.Show("0부터"+m.end+"까지의 합은"+m.SumAll());

            MyMath1 m2 = new MyMath1(); //인스턴스 생성
            int.TryParse(textBox4.Text, out m2.end);
            MessageBox.Show("0부터" + m2.end + "까지의 합은" + m2.SumAll());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MyMath1 a = new MyMath1();
            a.end = 0;
            // a.abc = 100; 안됨. abc가 private상태라서  mymath1밖에서는 사용할수없음. 그래서 end는 사용된것.
        }
    }
}
