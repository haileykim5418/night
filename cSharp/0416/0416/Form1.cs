using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0416
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("안녕");
            MessageBox.Show("Test"); //modal이 기본
            Console.WriteLine("하쇼");//창 띄우고 멈춰있음 "안녕"다음 아무것도 안나옴(f5 누르고 출력창 확인)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("안녕");
            Form2 f = new Form2();
            f.Show(); //modeless 다른창 선택됨
            Console.WriteLine("하쇼"); //창 띄우고 다 출력해줌(f5 누르고 출력창 확인) "안녕" "하쇼"한꺼번에 다 보여줌
            //중복해서 선택하게하고싶은경우 ex. 남녀/ 123 여기서 하나씩 총 두 옵션을 선택하고싶은 경우 그룹박스로 묶으면됨
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog(); //modal 창 새로 뜨면 다른 창 선택이 안됨

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cat c = new Cat();
            c.Eat(); //따로 입력해줬음
            c.sleep();

            Dog d = new Dog();
            d.Eat(); //따로 입력해줬음
            d.sleep();

            Animal a = new Dog();
            Animal b = new Cat();
            a.Eat(); //a에는 dog의 eat을 호출
            b.Eat(); //b에는 cat의 eat을 호출
        }
    }
}
