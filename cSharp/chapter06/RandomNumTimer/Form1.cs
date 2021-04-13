using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumTimer
{
    public partial class Form1 : Form
    {
        int number = 0;
        public Form1()
        {
            InitializeComponent();
            number = new Random().Next(10) + 1;
            Console.WriteLine(number);
        }
        int time = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 10)
            {
                label1.Text = "timeover";  //10초가 넘었을때 라벨에 이 내용을 띄우기
                time = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int choiceNumber = int.Parse(textBox1.Text);
                if (choiceNumber == number)
                {
                    time = 0; //타이머 리셋
                    MessageBox.Show("정답");
                    number = new Random().Next(10) + 1;
                    Console.WriteLine(number);  //정답 다시 출력
                    label1.Text = "끝";
                }
                else
                {
                    if (choiceNumber > number)
                    {
                        MessageBox.Show("입력값이 더 큽니다");
                    }
                    else
                    {
                        MessageBox.Show("입력값이 더 작습니다");
                    }
                }
            }
            catch (Exception ee)  //원래는 숫자 말고 다른거 입력하면 오류나는데 트라이캐치 쓰면 다른거 써도 오류나지않음
            {
                MessageBox.Show("숫자를 입력하세요");
                Console.WriteLine(ee.Message); //에러메세지
                Console.WriteLine(ee.StackTrace); //어디서 에러났는지 출력
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // int choiceNumber = int.Parse(textBox1.Text);
            int choiceNumber;
            bool result = int.TryParse(textBox1.Text, out choiceNumber); 
            if (result == false)//textbox1에입력된 값을 choicenum~에 넣어주는데 그게 false일 경우 리턴값을 반환
            {
                MessageBox.Show("숫자입력!");
                return;
            }
                if (choiceNumber == number)
                {
                    time = 0; //타이머 리셋
                    MessageBox.Show("정답");
                    number = new Random().Next(10) + 1;
                    Console.WriteLine(number);  //정답 다시 출력
                    label1.Text = "끝";
                }
                else
                {
                    if (choiceNumber > number)
                    {
                        MessageBox.Show("입력값이 더 큽니다");
                    }
                    else
                    {
                        MessageBox.Show("입력값이 더 작습니다");
                    }
                }
            }
            
        }
    }
    
