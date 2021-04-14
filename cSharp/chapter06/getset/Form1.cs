using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace getset
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rect rect = new Rect();
            int.TryParse(textBox1.Text, out rect.w);
            int.TryParse(textBox2.Text, out rect.h);
            MessageBox.Show("사각형의 넓이는" + rect.getArea());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rect rect = new Rect();
            int.TryParse(textBox1.Text, out int width);
            int.TryParse(textBox2.Text, out int height);

            rect.setWidth(width);
            rect.setHeight(height);

            if (rect.getWidth() == 0 || rect.getHeight() == 0)
            {
                MessageBox.Show("넓이나 높이에 대한 이상한 값이 들어갔음");
                return;
            }
            MessageBox.Show("사각형의넓이는" + rect.getArea_with_getset());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Circle c = new Circle();
            c.R = 100;  //set호출해서 value에100 넣음
           // MessageBox.Show(c.R+"입니다");

            int radi;
            int.TryParse(textBox3.Text, out radi);
            c.radi = radi;
            if (c.radi ==0)
            {
                MessageBox.Show("양수 써");
            }
            else
            {
                MessageBox.Show(c.R + "입니다");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Person p = new Person();
            Person p = new Person("이동준", 23); //이름 나이 둘다 알때
            MessageBox.Show(p.name+","+p.age);
            // p.name = textBox4.Text;

            Person p2 = new Person(textBox4.Text); //이름만 아는경우
            int.TryParse(textBox5.Text, out int age);
            p2.age = age;
            MessageBox.Show(p2.name+","+p2.age);

            Person p3 = new Person(); //아무것도 모르는경우
            p3.name = textBox4.Text;
            p3.age = int.Parse(textBox5.Text);
            MessageBox.Show(p3.name+","+p3.age);

            const int myAge = 33;
           // myAge = 23; 일반 변수는 선언 이후 값 바꿀수있는데 상수는 한번 선언되면 못바꿈
           int yourAge = 300;
            yourAge = 30;  //얘는 가능

            //readonly == 상수랑 같은애

           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //일반변수
            string name = "김가현";
            string name2 = name;
            name2 = "양화영";
            MessageBox.Show(name + "vs" + name2);

            //참조변수
            Person p = new Person("이동준", 100);
            Person p2 = p;
            p2.name = "김우진";
            p2.age = 500;
            MessageBox.Show(p.name + "vs" + p2.name);

        }
    }
}
