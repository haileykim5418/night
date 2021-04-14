using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DescriptFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  //이걸 클릭했을때 내용 실행해
        {
            int value = int.Parse(textBox1.Text);
            label1.Text = second_denmension(value) + ""; //텍스트박스1의 내용을 숫자로 바꿔서 메소드에 넣고 출력
        }

        private void button2_Click(object sender, EventArgs e) //button2_click도 함수라서 클릭할때 button2_click를 실행하는것.
        {
            introduce_myname(textBox1.Text);
        }
        private void button3_Click(object sender, EventArgs e) //이걸 호출한 나 자신 = sender, 이벤트 =EventArgs e
        {
            int number = random_one_to_ten();
            MessageBox.Show("오늘의 랜덤 숫자는" + number + "입니다");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Hello();
        }
        //매개변수가 있고 반환형이 있는 함수
        private int second_denmension(int x)
        {
            return (x * x) + (2 * x) + 1;
        }
        //매개변수만 있는 함수
        private void introduce_myname(string name)
        {
            MessageBox.Show("내이름은" + name + "이야");
        }
        //반환형만 있는 함수
        private int random_one_to_ten()
        {
            return new Random().Next(10) + 1;
        }
        //반환형과 매개변수가 없는 함수
        private void Hello()
        {
            MessageBox.Show("안녕");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //int.parse 대신 쓸수있는거 1번
            //사용자의 오류에의해 프로그램이 종료될 것을 생각 or 안정적이지 않은 구간에 사용
            try
            {
                int num = int.Parse(textBox1.Text);
                MessageBox.Show("내가 입력한 숫자는" + num);
            }
            catch (Exception ex)
            {
                MessageBox.Show("숫자적어");
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                printLog(ex.Message);
                printLog(ex.StackTrace);

                //throw; = 프로그램 끄는 기능
            }


        }
        private void printLog(string contents)
        {
            DirectoryInfo di = new DirectoryInfo("Trace"); //Trace라는 폴더 정보를 가지고 와
            if (di.Exists == false)  //Trace가 없으면 다른거 밑에거 생성해
            {
                di.Create();
            }
            using (StreamWriter writer = new StreamWriter("Trace" + "\\" + "Log.txt"))
            {
                writer.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}]{contents}{".txt"}");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //int.parse 대신 쓸수있는것2
            int number;
            bool result = int.TryParse(textBox1.Text, out number);  
            //tryparse = number라는 변수에 텍스트박스에 적힌 숫자를 넣을건데 그걸 '시도'해볼거야
            //숫자변환이 실패하면 result에 false를 넣고 number라는 변수에는0이 들어가
            if (result = false)
            {
                MessageBox.Show("숫자쓰삼");
            }
            else
            {
                MessageBox.Show("내가적은 숫자는" + textBox1.Text);
            }
        }

        //오버로딩 반환형만 있는 함수
        private int random_one_to_ten_except5()
        {
            int num = new Random().Next(10) + 1; //5가 나오면 다시 뽑고 아니면 그값 리턴해
            while (num ==5)
            {
                num = new Random().Next(10) + 1;
            }
            return num;
        }
        private int random_one_to_ten(int except) //오버로딩.매개변수 타입이나 갯수만 다르면 얼마든지 사용가능
        {
            int num = new Random().Next(10) + 1; //void 리턴값 필요x, int일때는 return값 필요
            while (num == except)
            {
                num = new Random().Next(10) + 1;
            }
            return num;
        }

       /*private int random_except_mynum()
        {
            int[] num = new int[10];
            int except = int.Parse(textBox2.Text);
            return 0;
        }*/

        private void button7_Click(object sender, EventArgs e)
        {
            int except = 5;
            int num = random_one_to_ten(except);
            MessageBox.Show("5를 제외한1~10사이의 수" + num);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox2.Text, out int except);
            label2.Text = "제외되는 숫자는" + except;
            label3.Text = except + "를 제외한 숫자는" + random_one_to_ten(except);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Circle c1 = new Circle(); //인스턴스=c1
            c1.r = 100;
            Circle c2 = new Circle(); //인스턴스=c2
            c2.r = 111;
            MessageBox.Show("원의PI값은"+Circle.PI+"입니다");  //공통값 = PI, 인스턴스에 따라 달라지는 변수 =r

            MessageBox.Show("c1의 둘레는"+c1.doolle()+"입니다");
            MessageBox.Show("c2의 둘레는" + c2.doolle() + "입니다");
            MessageBox.Show("c1의 넓이는" + c1.area() + "입니다");
            MessageBox.Show("c2의 넓이는" + c2.area() + "입니다");
            Circle.setPi(3.14);
            MessageBox.Show("원의PI값은"+ Circle.getPi() +"입니다");

            MessageBox.Show("c1의 둘레는" + c1.doolle() + "입니다");
            MessageBox.Show("c2의 둘레는" + c2.doolle() + "입니다");
            MessageBox.Show("c1의 넓이는" + c1.area() + "입니다");
            MessageBox.Show("c2의 넓이는" + c2.area() + "입니다");

            Circle.showPi();




            MyMath mm = new MyMath();
            mm.Power(input);

            MyMath.Power();
            
        }
    }

}
