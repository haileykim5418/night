using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Struct
{
    public partial class Form1 : Form   //얕은복사 깊은복사 (참조변수) 알아둘것.
    {

        Account a1;
        Account a2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a1 = new Account(100, textBox1.Text);
            MessageBox.Show(a1.name + a1.myMoney);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a2 = a1;
            a2.name = textBox2.Text;
            a2.myMoney = 1234;
            MessageBox.Show(a1.name + a1.myMoney);
            MessageBox.Show(a2.name + a2.myMoney);

        }

        private void Form1_Load(object sender, EventArgs e)   //readonly -true enable-false = 입력못함
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox3.Text, out int a);
            int.TryParse(textBox4.Text, out int b);
            swapFunction(a, b);
            textBox5.Text = a.ToString();
            textBox6.Text = a.ToString();
            MessageBox.Show("변경이 안됐나");

            swapFunction(ref a, ref b);
            MessageBox.Show("변경 완료");
            textBox5.Text = a.ToString();
            textBox6.Text = a.ToString();
            MessageBox.Show("변경 완료!");

            int tempA = a;
            int tempB = b;

            /*swapFunction(tempB, tempA, out a, out b);
            textBox5.Text = a.ToString();
            textBox6.Text = a.ToString();
            MessageBox.Show("다시 변경 완료!");*/

        }
        private void swapFunction(int a, int b)  //이 안에서만 유효한 a,b
        {
            int temp = a;
            a = b;
            b = temp;
        }
        private void swapFunction(ref int a, ref int b)  //주소지가 가리키는 값을 바꿈 ref=주소지 
        {
            int temp = a;
            a = b;
            b = temp;
        }
        //out키워드  
        //이함수는 반환형은 없지만 2개의 변수값을 바꾼다
        private void NextPosition(int x, int y, int vx, int vy, out int rx, out int ry)
        {
            //다음위치=현재위치+현재속도
            rx = x + vx;
            ry = y + vy;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox7.Text, out int x);
            int.TryParse(textBox8.Text, out int y);
            int.TryParse(textBox9.Text, out int vx);
            int.TryParse(textBox10.Text, out int vy);
            MessageBox.Show($"x={x},y={y}");
            NextPosition(x, y, vx, vy, out x, out y);  //out은 함수한개로 여러개값을 바꿀수있음 return이랑 비슷함
            MessageBox.Show($"x={x},y={y}");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // outExample(out int abc, out int def, out int hij);  //변수 선언과 동시에 할당 여러개
            int abc;
            int def;
            int hij;
            //이까지는 값 지정을 안해줬기때문에 0이 들어가는데 밑에거 호출되면 바로 값3개가 할당됨
            outExample(out abc, out def, out hij);
            MessageBox.Show(abc + def + hij + "");

            foreach (var item in Controls)
            {
                /* if (item is TextBox)
                 {
                     (item as Textbox).Text = "안녕";
                 }*/
                var temp = item as TextBox;  //as를 이용해서 텍스트박스 내용 형변환 후 temp에 넣고 
                if (temp != null)   //temp가 null이 아닐경우 아래 내용 다 넣어
                    temp.Text = "하하하";  //모든텍스트박스내용 이거 들어감
               
            }
        }
        private void outExample (out int a, out int b, out int c) 
        {
            a = 100;
            b = 200;
            c = 300;
        }
    }
}
