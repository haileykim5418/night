using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateLamda
{
    public partial class Form1 : Form
    {
        delegate void TestDelegate();
        public Form1()
        {
            InitializeComponent();
            Button button2 = new Button();
            button2.Text = "코드로만든 버튼";
            button2.AutoSize = true;
            button2.Location = new Point(100, 100);
            button2.Click += Button2_Click; 
            button2.Click += Button2_Click_222;
            button2.Click += delegate (object sender, EventArgs e)
            {
                MessageBox.Show("test delegate");
            };
            button2.Click += (object sender, EventArgs e) => { MessageBox.Show("lamda"); };
            Controls.Add(button2);

        }

        private void Button2_Click_222(object sender, EventArgs e)
        {
            MessageBox.Show("test22222");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test1");
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            TestDelegate a = Hello; //a라는 변수에 hello라는 함수가 들어감. Delegate:함수의변수화
            TestDelegate b = delegate() //무명함수
            {
                MessageBox.Show("안녕");
            };
            TestDelegate c = () => { MessageBox.Show("안녕"); }; //=>쓰는게 람다. 위에거랑 같은데 방법이 다른것
            a();
            b();
            c();
            exCallBack(a); //CallBack:함수를 매개변수로 가져와서 함수를 함수로 돌리는것
        }
        
        private void Hello()
        {
            MessageBox.Show("안녕");
        }
        private void exCallBack(TestDelegate t)
        {
            for (int i = 0; i < 3; i++)
            {
                t();
            }
        }
    }
}
