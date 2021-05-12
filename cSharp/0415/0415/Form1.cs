using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0415
{
    public partial class Form1 : Form
    {
        Account a1;
        Account a2; //아직 인스턴스 선언은 안한상태

        public Form1()
        {
            InitializeComponent();
        }

     
        //계좌를 개설해주는 버튼. 고객1
        private void button7_Click(object sender, EventArgs e)
        {

            int.TryParse(textBox1.Text, out int money); //money라는변수에다가 텍스트박스 내용 넣어
            string name = textBox2.Text;

            a1 = new Account(money, name);

            string message = a1.name + "님," + "잔액은" + a1.myMoney + "입니다";

            foreach(var item in Controls)  //Controls=폼 창 안에있는 것들을 모아놓은 리스트. foreach = in 뒤에부분만큼 반복. 
            { // var=타입이 정해져있지않은 변수 
                if (item is Label) //폼에 라벨타입이 있나 확인
                {
                    if ((item as Label).Name == "temp") //라벨로 타입변환을 하고 name값이 temp인지 확인
                        Controls.Remove((item as Label)); //temp면 지워
                }
            }

            Label msg = new Label();
            msg.Name = "temp";
            msg.Text = message;
            msg.AutoSize = true;
            msg.Location = new Point(200, 200);
            Controls.Add(msg);  //폼 안에 위에걸 추가해줘

        }
        //계좌를 개설해주는 버튼. 고객2
        //클래스를 통해 만든 참조변수는 주소지가 따로있어서 내용을 바꾸려고해도 똑같은 주소지를 가르키기때문에 내용이 같아짐
        private void button8_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox3.Text, out int money); //money라는변수에다가 텍스트박스 내용 넣어
            string name = textBox4.Text;

            /* a2 = a1;
             a2.myMoney = int.Parse(textBox4.Text);
             a2.name = textBox3.Text;*/
           /* a2 = new Account(a1.myMoney, a1.name);
            a2.myMoney = int.Parse();
            string message = a2.name + "님," + "잔액은" + a2.myMoney + "입니다";*/

            for (int i = 0; i < 2; i++)
            {
                foreach (var item in Controls)
                {
                    if (item is Label)
                    {
                        if ((item as Label).Name == "temp1"
                            || (item as Label).Name == "temp2")
                        {
                            Controls.Remove((item as Label));
                        }
                            
                    }
                }
            }
      
            Label msg = new Label();
            msg.Name = "temp1";
            msg.Text = message;
            msg.AutoSize = true;
            msg.Location = new Point(200, 250);
            Controls.Add(msg);

            Label msg2 = new Label();
            msg2.Name = "temp2";
            msg2.Text = a2.name+a2.myMoney;
            msg2.AutoSize = true;
            msg2.Location = new Point(200, 250);
            Controls.Add(msg2);


        }
    }
}
