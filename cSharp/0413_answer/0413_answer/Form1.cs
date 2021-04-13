using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0413_answer
{
    public partial class Form1 : Form
    {
        int time = 0;
        int answer = 0;  //정답
        public Form1()
        {
            InitializeComponent();
            Random r = new Random();
            answer = r.Next(10) + 1; //엔써라는 변수에 0이상10미만의 랜덤값을 넣음, 1부터 시작하고10까지 들어가야하니까 +1
           // answer = new Random().Next(10); 위에거랑 같음
            Console.WriteLine("정답:"+answer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(textBox1.Text); 내가 텍스트박스에 적은걸 메세지박스에 띄움
            int myChoice = int.Parse(textBox1.Text); //mychoice라는 변수안에 텍스트박스1에 적는 내용을 숫자로 변환해서 넣어라
            if(myChoice == answer) //answer랑 mychoice값이 같다면 정답을 띄우고
            {
                MessageBox.Show("정답!");
                answer = new Random().Next(10) + 1; //새로운 숫자 입력받음
                //return; //종료시키겠다는 뜻(리턴 없으면 계속 나옴)
                Console.WriteLine("정답:" + answer);
                return;  //값이 같으면 밑의 내용은 더이상 비교하지않겠다. 탈출
            }
            if (myChoice < answer)
            {
                MessageBox.Show("정답보다 내 답이 작다");
            }
            if (myChoice > answer)
            {
                MessageBox.Show("정답보다 내 답이 크다");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if (time == 10)
            {
                MessageBox.Show("시작한지"+60+"초입니다");
             
            }
            InitializeComponent();
        }
    }
}
